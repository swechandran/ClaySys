function findLargest(numbers) 
{
    let largest = numbers[0]; 
    for (let i = 1; i < numbers.length; i++) 
        {
        if (numbers[i] > largest) {
            largest = numbers[i]; 
        }
    }

    return largest; 
}
const array = [3, 5, 7, 2, 8, 4];
const largestNumber = findLargest(array);
document.write('<p>The largest number is: ' + largestNumber + '</p>');