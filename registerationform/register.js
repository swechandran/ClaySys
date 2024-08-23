$(document).ready(function () {
  // Personal Information
  $("#firstName").on("blur", function () {
    var firstName = $(this).val();
    var regex = /^[a-zA-Z]{2,30}$/; 
    if (!regex.test(firstName)) {
      $("#firstNameError").text(
        "firstname cannot be empty. Please enter a valid name."
      );
      $(this).addClass("error");
    } else {
      $("#firstNameError").text("");
      $(this).removeClass("error");
    }
  });
  $("#lastName").on("blur", function () {
    var lastName = $(this).val();
    var regex = /^[a-zA-Z]{2,30}$/; 
    if (!regex.test(lastName)) {
      $("#lastNameError").text("lastname cannot be empty . Please enter a valid name.");
      $(this).addClass("error");
    } else {
      $("#lastNameError").text("");
      $(this).removeClass("error");
    }
  });
  $("#dob").on("blur", function () {
    var dob = $(this).val();
    if (!dob) {
      $("#dobError").text("Please select your date of birth.");
      $(this).addClass("error");
    } else {
      $("#dobError").text("");
      $(this).removeClass("error");
    }
  });
  $('input[name="gender"]').on("change", function () {
    var gender = $(this).val();
    if (!gender) {
      $("#genderError").text("Please select your gender.");
    } else {
      $("#genderError").text("");
    }
  });
  // Contact Information
  $("#phone").on("blur", function () {
    var phone = $(this).val();
    var regex = /^[0-9]{10}$/; // allow only 10 digits
    if (!regex.test(phone)) {
      $("#phoneError").text(
        "Invalid phone number. Please enter a valid 10-digit number."
      );
      $(this).addClass("error");
    } else {
      $("#phoneError").text("");
      $(this).removeClass("error");
    }
  });
  $("#email").on("blur", function () {
    var email = $(this).val();
    var regex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/; // allow only valid email format
    if (!regex.test(email)) {
      $("#emailError").text(
        "Invalid email address. Please enter a valid email address."
      );
      $(this).addClass("error");
    } else {
      $("#emailError").text("");
      $(this).removeClass("error");
    }
  });
  // Address
  $("#address").on("blur", function () {
    var address = $(this).val();
    if (!address) {
      $("#addressError").text("Please enter your address.");
      $(this).addClass("error");
    } else {
      $("#addressError").text("");
      $(this).removeClass("error");
    }
  });
  $("#state").on("change", function () {
    var state = $(this).val();
    if (!state) {
      $("#stateError").text("Please select your state.");
    } else {
      $("#stateError").text("");
    }
  });
  $("#city").on("change", function () {
    var city = $(this).val();
    if (!city) {
      $("#cityError").text("Please select your city.");
    } else {
      $("#cityError").text("");
    }
  });
  // Account Information
  $("#username").on("blur", function () {
    var username = $(this).val();
    var regex = /^[a-zA-Z0-9_]{4,20}$/; 
    if (!regex.test(username)) {
      $("#usernameError").text(
        "Invalid username. Please enter a valid username."
      );
      $(this).addClass("error");
    } else {
      $("#usernameError").text("");
      $(this).removeClass("error");
    }
  });
  $("#password").on("blur", function () {
    var password = $(this).val();
    var regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%?&])[A-Za-z\d@$!%?&]{8,}$/;
    if (!regex.test(password)) {
      $("#passwordError").text("Invalid password. Password must be at least 8 characters long, with at least one uppercase letter, one number, and one special character.");
      $(this).addClass("error");
    } else {
      $("#passwordError").text("");
      $(this).removeClass("error");
    }
  });
});
$(document).ready(function() {
  $("#loginButton").on("click", function() {
    var firstName = $("#firstName").val();
    var lastName = $("#lastName").val();
    var dob = $("#dob").val();
    var gender = $('input[name="gender"]:checked').val();
    var phone = $("#phone").val();
    var email = $("#email").val();
    var address = $("#address").val();
    var state = $("#state").val();
    var city = $("#city").val();
    if (firstName === "" || lastName === "" || dob === "" || gender === undefined || phone === "" || email === "" || address === "" || state === "" || city === "") {
      alert("Please fill in all the fields.");
    } else {
      alert("Sign up successful!");
    }
  });
});

