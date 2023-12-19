


var car1 = {
    brand:"mercedes",
    model:"E200",
    year: 2010,
    price: 23000,
    color:"white"
}

var car2 = {
    brand:"mercedes",
    model:"S500",
    year: 2008,
    price: 18000,
    color:"grey"
}

console.log(car2.year)

var std1 = {
    fullname:"Hikmet Abbasov",
    birthYear: 1993,
    groupNo:"P123"
}

var cars = [car1,car2,{brand:"bmw",model:"m5",year:2009,price: 350,color:"white"}]

var total=0;
for(var i=0;i<cars.length;i++){
    total+=cars[i].price;
    console.log(cars[i].brand,cars[i].model,cars[i].price)
}

var result = total/cars.length;
console.log(result)

var count=0;
for(var i=0;i<cars.length;i++){
    if(cars[i].color == "white"){
        count++;
    }
}

console.log(count)


