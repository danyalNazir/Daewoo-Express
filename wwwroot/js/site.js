
function Password_Toggle(id) {
    var element = document.getElementById(id);
    var togglePassword = document.getElementById('togglePassword');
    var toggleConfirmPassword = document.getElementById('toggleConfirmPassword');

    if (element == document.getElementById("Password")) {
        if (element.type === "password") {
            element.type = "text";
            togglePassword.classList.remove("bi-eye-slash");
            togglePassword.classList.add("bi-eye");
        }
        else {
            element.type = "password";
            togglePassword.classList.remove("bi-eye");
            togglePassword.classList.add("bi-eye-slash");
        }
    }
    else if (element == document.getElementById("ConfirmPassword")) {
        if (element.type === "password") {
            element.type = "text";
            toggleConfirmPassword.classList.remove("bi-eye-slash");
            toggleConfirmPassword.classList.add("bi-eye");
        }
        else {
            element.type = "password";
            toggleConfirmPassword.classList.remove("bi-eye");
            toggleConfirmPassword.classList.add("bi-eye-slash");
        }
    }
}

var count = 0;
var quantity = 0;
function tdClick(id) {
    var seatview = document.getElementById(id);
    var seats = document.getElementById("Seats");
    alert(seatview.value);
    seatview.addEventListener("click", e => {
        alert(seatview.value);
    })
      //if (count == 0) {
    //    seatview.style.backgroundImage = "url(https://www.daewoo.com.pk/Theme/Images/male_seat.png)";
    //    count += 1;
    //    seats.value = `${seatview.innerText}M,`;
    //}
    //else if (count == 1) {
    //    seatview.style.backgroundImage = "url(https://www.daewoo.com.pk/Theme/Images/female_seat.png)";
    //    count += 1;
    //    seats.value = `${seatview.innerText}F,`;
    //}
    //else if (count == 2) {
    //    seatview.style.backgroundImage = "url(https://www.daewoo.com.pk/Theme/Images/empty_seat.png)";
    //    count = 0;
    //}
    //if (count > 1) {
    //    quantity += 1;
    //}
    //document.getElementById("Quantity").value = quantity;
}
