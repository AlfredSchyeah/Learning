const fileSystem = require('fs');
const { json } = require('stream/consumers');

const phone = {
    "id": 232413,
    "brand": "samsung",
    "model": "galaxy",
    "number": "s26",
    "features": {
        "processor": "Exynos",
        "ram": "8 GB",
        "storage": "128 GB",
        "battery": "4000 mAh"
    }
}

let jsonString = JSON.stringify(phone)
/*
fileSystem.writeFile('phone.json', jsonString, 'utf8', (err) => {
    if (err) {
        console.log("Ошибка данных", err);
        return
    }
    console.log("Файл создан успешно");
}*/

fileSystem.readFile('phone.json', 'utf8', (err, data) => {
    if (err) {
        console.log("Ошибка данных");
        return
    }
    const filePhone = JSON.parse(data);
    console.log("телефон:", filePhone);
})