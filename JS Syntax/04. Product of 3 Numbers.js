function productOfThreeNumbers(arr) {
    let x = parseInt(arr[0]);
    let y = parseInt(arr[1]);
    let z = parseInt(arr[2]);

    if (x == 0 || y == 0 || z == 0) {
        console.log("Positive");
        return;
    }

    let negativeNumber = 0;
    if (x < 0) {
        negativeNumber++;
    }
    if (y < 0) {
        negativeNumber++;
    }
    if (z < 0) {
        negativeNumber++;
    }

    if (negativeNumber % 2 == 0) {
        console.log("Positive");
    } else {
        console.log("Negative");
    }
}

let numbers = [5, -4, 3];
console.log(productOfThreeNumbers(numbers));