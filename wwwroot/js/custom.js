function showImagePopup(imageUrl, imageTitle, imageDetails, imageCheckpointURL) {
  var popup = document.getElementById("imagePopup");
  var popupImage = document.getElementById("popupImage");
  var popupDetails = document.getElementById("imageDetails");
  var popupTitle = document.getElementById("imageTitle");
  ;
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
}

function closeImagePopup() {
  var popup = document.getElementById("imagePopup");
  var overlay = document.getElementById("overlay");
  overlay.style.display = "none";
  popup.style.display = "none";
}

function addStamp(id) {
  var mainImage = document.querySelectorAll('.card-img-top')[id - 1];
  var mainDiv = mainImage.parentElement;

  mainImage.classList.add('grayscale-checkpoint');

  const stampImage = mainDiv.querySelector('div.card-img-overlay .stamp-img');
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


function showModal(title, message) {
  var modal = document.createElement('div');
  modal.classList.add('modal', 'fade');
  modal.innerHTML = `
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">${title}</h5>
          <button type="button" class="btn-close close" aria-label="Close"></button>
        </div>
        <div class="modal-body">
          <p>${message}</p>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-primary modalOkButton" >OK</button>
        </div>
      </div>
    </div>
  `;

  document.body.appendChild(modal);

  $('.modalOkButton').on('click', function () {
    $(modal).modal('hide');
  });

  $('.close').on('click', function () {
    $(modal).modal('hide');
  });
  $(modal).modal('show');
}

function darkBlurBackground() {
  var overlay = document.getElementById("overlay");
  overlay.style.display = "block";
}
function clearBackground() {
  var overlay = document.getElementById("overlay");
  overlay.style.display = "none";
}

function disableButton() {
  var usedBtn = document.getElementById("usedBtn");
  usedBtn.innerHTML = "引換済み";
  usedBtn.disabled = true;
  usedBtn.classList.remove("btn-success");
  usedBtn.classList.add("btn-secondary");
}

