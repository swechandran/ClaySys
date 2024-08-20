function printNumbers() {
    const numberList = document.getElementById('numberList');
    let numbers = '';
    for (let i = 1; i <= 100; i++) {
        numbers += i + '\n'; 
    }
    numberList.textContent = numbers; 
}