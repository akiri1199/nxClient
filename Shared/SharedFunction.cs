using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public class SharedFunctions
{
    private readonly HttpClient _httpClient;
    private readonly NavigationManager _navigationManager;
    private readonly IJSRuntime _jsRuntime;
    private UserData? myData { get; set; } = new UserData();
    private isFriend isFriend = new isFriend();
    private ProfileModel MyProfile { get; set; } = new ProfileModel();
    public MemberModel Member = new MemberModel();
    private UserProfile userProfile = new UserProfile();

    public SharedFunctions(HttpClient httpClient, NavigationManager navigationManager, IJSRuntime jsRuntime)
    {
        _httpClient = httpClient;
        _navigationManager = navigationManager;
        _jsRuntime = jsRuntime;
    }

    public async Task OnAfterRenderAsync(string? endpoint, string? liffId, string? lineID)
    {
        await _jsRuntime.InvokeVoidAsync("liff.init", new { liffId = liffId });
        var isLoggedIn = await _jsRuntime.InvokeAsync<bool>("liff.isLoggedIn");//liffでアクセス

        if (isLoggedIn)
        {
            isFriend = await _jsRuntime.InvokeAsync<isFriend>("liff.getFriendship");
            try
            {
                var profile_str = await _httpClient.GetStringAsync(endpoint + "lineaccounts/" + lineID);//apiで基本情報を取得(api)
                profile_str = Regex.Replace(profile_str, @",\s*\r?\n\s*]", "]");
                profile_str = Regex.Replace(profile_str, "\"true\"", "true");
                profile_str = Regex.Replace(profile_str, "\"false\"", "false");
                StringBuilder modifiedString = new StringBuilder(profile_str);
                string json = modifiedString.ToString();
                myData = JsonSerializer.Deserialize<UserData>(json);

                if (isFriend != null && isFriend.friendFlag)
                {
                    userProfile = await _jsRuntime.InvokeAsync<UserProfile>("liff.getProfile");
                    if (userProfile != null && userProfile.userId != null)
                    {
                        var isMember = await _httpClient.GetStringAsync(endpoint + "Members/search?lineId=" + userProfile.userId);
                        //memberの参照(api)
                        JsonDocument memberDocument = JsonDocument.Parse(isMember);
                        JsonElement members = memberDocument.RootElement;
                        if (members.GetArrayLength() == 0)//member未登録
                        {
                            if (myData != null && myData.isProfile)//基本情報.プロフィール画面の表示有無の判定
                            {
                                _navigationManager.NavigateTo("/profile");
                            }
                            else
                            {
                                Member.member_lineid = userProfile.userId;
                                Member.member_firstname = userProfile.displayName;
                                Member.member_profileicon = userProfile.pictureUrl;
                                await _httpClient.PostAsJsonAsync(endpoint + "Members", Member);//line.userId、ニックネーム、アイコン以外はブランクの状態でメンバー作成apiのpost
                                _navigationManager.NavigateTo("/rally");
                            }
                        }
                        else
                        {
                            await _jsRuntime.InvokeVoidAsync("liff.closeWindow"); //liffの関数操作                        
                        }
                    }
                }
                else
                {
                    await _jsRuntime.InvokeVoidAsync("alert", "友達設定になっていません。");
                }
            }
            catch (HttpRequestException ex)
            {
                await _jsRuntime.InvokeVoidAsync("alert", "LINEIDが正しくありません。");
                Console.WriteLine("HTTP request failed. Status code: " + ex.StatusCode);
            }


        }
        else
        {
            await _jsRuntime.InvokeVoidAsync("liff.login");
        }
    }

}