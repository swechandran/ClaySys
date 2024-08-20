function checkEvenOrOdd() {
    const number = document.getElementById('numberInput').value;
    const result = document.getElementById('result');
    const num = Number(number);
    if (!isNaN(num)) {
        result.textContent = (num % 2 === 0) ?  "is even" : "is odd";
    } else {
        result.textContent = 'Please enter a valid number.';
    }
}