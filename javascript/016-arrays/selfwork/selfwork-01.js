const array = [];
let sum = 0;

for (let index = 0; index < 5; index++) {
    let element = Math.round(Math.random() * 10);
    array.push(element);
    console.log(array[index]);
    sum += element;
}

console.log(array);
console.log(sum);

let str = '';

for (let i = 0; i < array.length; i++) {
    const el = array[i];
    console.log(`[${el}]`);
    str += `[${el}]`;
}
console.log(str);
