$(document).ready(function () {
  $("#loginButton").click(function (event) {
    event.preventDefault();
    var email = $("#floatingInputEmail").val().trim();
    var password = $("#floatingInputpassword").val().trim(); //getting input
    //regex for validation
    var emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    var passwordPattern =
      /^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;
    // Clear error messages
    $(".error-message").text("");
    var isValid = true;
    // Email validation
    if (!emailPattern.test(email)) {
      $("#emailError").text("Please enter a valid email address.");
      isValid = false;
      
    }
    // Password validation
    if (!passwordPattern.test(password)) {
      $("#passwordError").text(
        "Password must be at least 8 characters long, with at least one uppercase letter, one number, and one special character."
      );
      isValid = false;
    }
    if (isValid) {
      alert("Form is valid and ready for submission!");
    }
  });
});
