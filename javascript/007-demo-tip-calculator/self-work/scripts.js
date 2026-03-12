let persons = prompt("Сколько человек?");
let check = prompt("Счет")
let tips = prompt("Сколько процентов от заказа оставить на чай?")
let sum = (parseInt(check) + (check * (tips / 100))) / persons
alert(`C человека ${sum}`)

