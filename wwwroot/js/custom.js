function showImagePopup(imageUrl, imageTitle, imageDetails, stamp, imageCheckpointURL) {
    var popup = document.getElementById("imagePopup");
    var popupImage = document.getElementById("popupImage");
    var popupDetails = document.getElementById("imageDetails");
    var popupTitle = document.getElementById("imageTitle");
    var popupStamp = document.getElementById("popupStamp");
    var checkpointURL = document.getElementById("checkpointURL");
    popupImage.src = imageUrl;

    popupDetails.innerText = imageDetails;
    popupTitle.innerText = imageTitle;
    imageCheckpointURL = imageCheckpointURL.replace(/\\\//g, '/');
    checkpointURL.innerText = imageCheckpointURL;
    checkpointURL.href = imageCheckpointURL;

    var overlay = document.getElementById("overlay");

    overlay.style.display = "block";
    popup.style.display = "block";
    if (stamp) {
        popupStamp.style.display = "block";
    } else {
        popupStamp.style.display = "none";
    }
}

function closeImagePopup() {
    var popup = document.getElementById("imagePopup");
    var overlay = document.getElementById("overlay");

    overlay.style.display = "none";
    popup.style.display = "none";
}

function addStamp() {
    const stampImage = document.querySelector('.stamp-img');
    stampImage.classList.add('animate');

}
function removeStamp() {
    const stampImage = document.querySelector('.stamp-img');
    stampImage.classList.remove('animate');
    stampImage.classList.add('remove');

}

window.showNotification = function (message, type) {
    $.notify(message, type);
};