const person = {
    name: "Jhon",
    age: "67",
};

for (let key in person) {
    console.log(key + ": " + person[key]);
}

person.greet = () => {
    console.log("Hello, my name is " + person.name);
};

const car = new Object();
car.mark = 'Ford';
car.model = 'F-150';
car.production_date = '20.01.2019';

const child = {
    name: 'Jeff',
    age: 7,
    greet: function () {
        console.log('Hello, my name is ' + this.name + '. I am ' + this.age + ' y.o.')
    }
}

child.greet();

child.greet = () => { console.log("Hello, my name is " + child.name); };

child.greet();
