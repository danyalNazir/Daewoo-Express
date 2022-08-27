
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


function submitSignUpForm() {

    var formData = $("#signUpForm").serialize();
    console.log(data);
    alert(data);
    $.ajax({
        type: 'POST',
        url: '/Home/CreateStudent',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: formData,
        success: function (result) {
            alert('Successfully received Data ');
            console.log(result);
        },
        error: function () {
            alert('Failed to receive the Data');
            console.log('Failed ');
        }
    })
}