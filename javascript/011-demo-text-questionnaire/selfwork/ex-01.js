let first_question = prompt("Сколько цветов в радуге? Варианты ответа: 5, 6, 7, 8");
let second_question = prompt("Какой язык программирования самый популярный? Варианты ответа: Python, JavaScript, Java, C++");
let third_question = prompt("Самая высокая гора в мире? Варианты ответа: Эверест, Арарат, Килиманджаро");

let score = 0;

if (first_question === "7") {
    score += 10;
}

if (second_question.toLowerCase() === "python") {
    score += 10;
}

if (third_question.toLowerCase() === "эверест") {
    score += 10;
}

alert("Ваш результат: " + score + " из 30");
