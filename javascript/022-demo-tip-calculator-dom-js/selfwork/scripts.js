let sum = document.getElementById("sum");
let tips = document.getElementById("tips");
let persons = document.getElementById("persons");
let sumTips = document.getElementById("sumTips");
let totalTips = document.getElementById("totalTips");
let sumPerPerson = document.getElementById("sumPerPerson");

let btn = document.getElementById("btn");

btn.addEventListener("click", function () {
    const sumValue = parseFloat(sum.value) || 0;
    const tipsValue = parseFloat(tips.value) || 0;
    const personsValue = parseInt(persons.value) || 1;

    if (sumValue <= 0 || tipsValue <= 0 || personsValue <= 1) {
        alert("введите корректные данные")
        return
    }

    const totalTipsValue = sumValue * tipsValue / 100;
    const sumTipsValue = totalTipsValue + sumValue;
    const sumPerPersonValue = sumTipsValue / personsValue;

    sumTips.textContent = sumTipsValue.toFixed(2);
    totalTips.textContent = totalTipsValue.toFixed(2);
    sumPerPerson.textContent = sumPerPersonValue.toFixed(2);
})

