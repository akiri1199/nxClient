using System.ComponentModel.DataAnnotations;
public class UserData
{
    public int? lineaccountId { get; set; }
    public string? lineaccountCode { get; set; }
    public string? lineaccountShortcode { get; set; }
    public string? lineaccountName { get; set; }
    public string? lineaccountEmail { get; set; }
    public bool istalk;
    public string? talkMessage { get; set; }
    public bool isProfile { get; set; }
    public string? profileSetting { get; set; }
    public List<ProfileField>? profileSettings { get; set; }
    public int? entryPoint { get; set; }
    public int? startRank { get; set; }
    public int? pointExpire { get; set; }
    public string? membersCardColor { get; set; }
    public string? membersCardDesignUrl { get; set; }
    public bool? membersCardIsUseCamera { get; set; }
    public string? membersCardLiffId { get; set; }
    public string? lineChannelId { get; set; }
    public string? lineChannelSecret { get; set; }
    public string? lineChannelAccessToken { get; set; }
    public bool? isSmaregi { get; set; }
    public string? smaregiContractId { get; set; }
    public string? lineaccountLogoUrl { get; set; }
    public string? lineaccountCreated { get; set; }
    public string? lineaccountUpdated { get; set; }
    public string? lineaccountDeleted { get; set; }

}
public class MyFormData
{
    public string? name { get; set; }

    public string? kana { get; set; }

    public string? text { get; set; }

    public string? gender { get; set; } = "no";

    public string? radio { get; set; }

    public DateOnly birthday { get; set; }

    public DateOnly? date { get; set; }

    public string? email { get; set; }

    public string? tel { get; set; }

    public string? select { get; set; }

    public string address { get; set; } = "no";

    public string? textarea { get; set; }
    public string? check { get; set; }

    public List<string> SelectedValues { get; set; } = new List<string>();
    public bool IsChecked(string option)
    {
        return SelectedValues.Contains(option);
    }
    public bool IsSelected(string option)
    {
        return option == radio;
    }
}

public class ProfileModel
{
    public string? lineaccountId { get; set; }
    public string? lineaccountCode { get; set; }
    public string? lineaccountShortcode { get; set; }
    public string? lineaccountName { get; set; }
    public string? lineaccountEmail { get; set; }
    public bool? istalk { get; set; }
    public string? talkMessage { get; set; }
    public bool? isProfile { get; set; }
    public string? profileSetting { get; set; }
    public MyFormData FormData { get; set; } = new MyFormData();
}

public class ProfileField
{
    public int data_no { get; set; }
    public string? data_type { get; set; }
    public string? label { get; set; }
    public string? value { get; set; }
    public bool required { get; set; }
    public bool visibility { get; set; }
    public string? placeholder { get; set; }
    public string? hint { get; set; }
    public string? select_item { get; set; }
    public int? ordinal { get; set; }
}

public class BirthdayModel
{
    public int year { get; set; }
    public int month { get; set; }
    public int day { get; set; }
}

public class isFriend
{
    public bool friendFlag { get; set; }
}

public class UserProfile
{
    public string? userId { get; set; }
    public string? displayName { get; set; }
    public string? pictureUrl { get; set; }
    public string? statusMessage { get; set; }

}

public class MemberModel
{
    public int member_id { get; set; }
    public int member_pos_id { get; set; }
    public string? member_code { get; set; }
    public int member_shop_id { get; set; }
    public string? member_lastname { get; set; }
    public string? member_firstname { get; set; }
    public string? member_profileicon { get; set; }
    public string? member_lastname_kana { get; set; }
    public string? member_firstname_kana { get; set; }
    public string? member_zipcode { get; set; }
    public string? member_pref { get; set; }
    public string? member_address { get; set; }
    public string? member_tel { get; set; }
    public string? member_fax { get; set; }
    public string? member_mobile { get; set; }
    public string? member_email { get; set; }
    public int member_gender { get; set; }
    public DateOnly member_birthday { get; set; }
    public int member_hold_point { get; set; }
    public DateOnly member_point_limit_date { get; set; }
    public DateOnly member_last_pointget_date { get; set; }
    public int member_last_pointget_point { get; set; }
    public DateOnly member_last_visit_date { get; set; }
    public DateOnly member_join_date { get; set; }
    public DateOnly member_drop_date { get; set; }
    public int member_allow_email { get; set; }
    public string? member_rank { get; set; }
    public string? member_note { get; set; }
    public int member_status { get; set; }
    public int member_ordinal { get; set; }
    public bool member_visibility { get; set; }
    public string? member_tag { get; set; }
    public string? member_nonce { get; set; }
    public string? member_lineid { get; set; }
    public string? member_stripeId { get; set; }
    public string? member_password_hash { get; set; }
    public string? member_password_salt { get; set; }
    public string? member_email_verify_token { get; set; }
    public DateTime member_email_verify_expired_at { get; set; }
    public string? member_password_reset_token { get; set; }
    public DateTime member_password_reset_verify_expired_at { get; set; }

    public bool member_is_password_reset_verified { get; set; }
    public string? member_pending_email { get; set; }
    public string? member_pending_email_verify_token { get; set; }
    public bool member_is_signup_verified { get; set; }

    public string? member_signup_verify_token { get; set; }
    public string? member_searchtext { get; set; }
    public DateTime member_createat { get; set; }
    public DateTime member_updateat { get; set; }
    public DateTime member_deleteat { get; set; }

}

