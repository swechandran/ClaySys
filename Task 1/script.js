// Function display error messege
function showError(input, message) {
  input.style.borderColor = "red";
  let errorElement = input.parentElement.querySelector(".error"); //small
  errorElement.style.color = "red";
  errorElement.innerText = message;
}
//clear the error and reset the input field
function clearError(input) {
  input.style.borderColor = ""; // Remove the red border
  let errorElement = input.parentElement.querySelector(".error"); // Clear
  errorElement.innerText = "";
}
//validate a text field
function isValidFirstname() {
  const input = document.getElementById("firstName");
  const pattern = /[0-9_]/;
  if (input.value.trim() === "") {
    showError(input, "Name is not valid");
    return false;
  } else if (pattern.test(input.value.trim())) {
    showError(input, "number cannot be included");
    return false;
  } else {
    return true;
    clearError(input);
  }
}
function validateTextField(input) {
  if (input.value.trim() === "") {
    showError(input, "field required");
  } else {
    clearError(input);
  }
}
//validate a phone number
function validatePhoneNumber(input) {
  let phonePattern = /^\(\d{3}\) \d{3}-\d{4}$/;
  if (input.value.trim() === "") {
    showError(input, "Phone number cannot be empty");
  } else if (!phonePattern.test(input.value.trim())) {
    showError(input, "Phone number format should be (201) 555-0123");
  } else {
    clearError(input);
  }
}
//validate an email
function validateEmail() {
  const input = document.getElementById("emailId");
  // console.log("hello");
  let emailPattern = /^[^ ]+@[^ ]+\.[a-z]{2,3}$/;
  if (input.value.trim() === "") {
    showError(input, "Email cannot be empty");
    return false;
  } else if (!emailPattern.test(input.value.trim())) {
    showError(input, "Invalid email format");
    return false;
  } else {
    clearError(input);
    return true;
  }
}
// Function to validate a dropdown
function validateregionSelect() {
  console.log("hello");
  const input = document.getElementById("regionSelect");
  console.log(input.value);
  if (input.value === "none") {
    showError(input, "Please select region");
    return false;
  } else {
    clearError(input);
    return true;
  }
}
// when the button is clicked
function validateForm() {
  // Get inputs
  let firstName = document.getElementById("firstName");
  let lastName = document.getElementById("lastName");
  let companyName = document.getElementById("companyName");
  let phoneNumber = document.getElementById("phoneNumber");
  let emailId = document.getElementById("emailId");
  let addressLine1 = document.getElementById("addressline1");
  let city = document.getElementById("city");
  let regionSelect = document.getElementById("regionSelect");
  let pincode = document.getElementById("pincode");
  let countrySelect = document.getElementById("countrySelect");
}
function submitButton() {
  console.log(validateEmail());
  validateregionSelect();
  allInputFieldValid();
  if (isValidFirstname() && validateEmail() && validateregionSelect()) {
    alert("formsubmit successfully");
  }
}
// if yes then copy text
document.addEventListener("DOMContentLoaded", function () {
  const radioYes = document.getElementById("radioYes");
  radioYes.addEventListener("change", function () {
    if (this.checked) {
      // Copying info
      [
        "firstName",
        "lastName",
        "companyName",
        "phoneNumber",
        "emailId",
        "addressline1",
        "addressline2",
        "city",
        "Region",
        "pincode",
        "countrySelect",
      ].forEach((field) => {
        document.getElementById(`shipping${field}`).value =
          document.getElementById(`${field}`).value;
      });
    }
  });
});
function allInputFieldValid() {
  const inputs = document.getElementsByTagName("input");
  for (let input of inputs) {
    if (input.value == "") {
      input.style.borderColor = "red";
    }
  }
}
function InputFieldValid() {
  const inputs = document.getElementsByTagName("input");
  for (let input of inputs) {
    input.addEventListener("focusout", () => {
      if (input.value == "") {
        input.style.borderColor = "red";
      } else {
        input.style.borderColor = "green";
      }
    });
  }
}
InputFieldValid();
