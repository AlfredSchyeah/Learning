function maxvalue(num1, num2, num3) {
    let tempmax = 0;
    if (num1 >= num2 && num1 >= num3) {
        tempmax = num1;
    } else {
        if (num2 >= num3) {
            tempmax = num2;
        } else {
            tempmax = num3;
        }
    }
    return tempmax;
}

let a1 = Math.round(Math.random() * 100);
let a2 = Math.round(Math.random() * 100);
let a3 = Math.round(Math.random() * 100);
let a4 = Math.round(Math.random() * 100);
let a5 = Math.round(Math.random() * 100);
let a6 = Math.round(Math.random() * 100);
let a7 = Math.round(Math.random() * 100);
let a8 = Math.round(Math.random() * 100);
let a9 = Math.round(Math.random() * 100);



let max1 = maxvalue(a1, a2, a3);
console.log(max1);

let max2 = maxvalue(a4, a5, a6);
console.log(max2);

let max3 = maxvalue(a7, a8, a9);
console.log(max3);


let max = maxvalue(max1, max2, max3);

console.log(max)