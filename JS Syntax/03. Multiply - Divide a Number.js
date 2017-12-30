function multiplyOrDivideNumbers(number1, number2) {
    if(number2 >= number1){
        return parseInt(number1) * parseInt(number2);
    }
    else {
        return parseInt(number1) / parseInt(number2);
    }
}

let numbers = ['2', '3', '13', '13', '3', '2', '144', '12'];

console.log(multiplyOrDivideNumbers(numbers[0], numbers[1]));
console.log(multiplyOrDivideNumbers(numbers[2], numbers[3]));
console.log(multiplyOrDivideNumbers(numbers[4], numbers[5]));
console.log(multiplyOrDivideNumbers(numbers[6], numbers[7]));