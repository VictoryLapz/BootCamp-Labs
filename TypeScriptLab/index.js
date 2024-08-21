"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
//create array
var Mountains = [
    { name: "Kilimanjaro", height: 19341 },
    { name: "Everest", height: 29029 },
    { name: "Denali", height: 20310 },
];
//declare function
function findNameOfTallestMountain(Mountains) {
    var MaxHeight = 0;
    var tallestMountain = "";
    for (var _i = 0, Mountains_1 = Mountains; _i < Mountains_1.length; _i++) {
        var Mountain = Mountains_1[_i];
        if (MaxHeight < Mountain.height) {
            MaxHeight = Mountain.height;
            tallestMountain = Mountain.name;
        }
    }
    return tallestMountain;
}
console.log(findNameOfTallestMountain(Mountains));
//create array
var Products = [
    { name: "Whole Milk-1 gallon", price: 3.99 },
    { name: "Organic Eggs-24 count", price: 7.99 },
    { name: "Bread-1 loaf", price: 1.99 },
    { name: "Organic Black Beans-15 oz can", price: 1.29 },
    { name: "Ibuprofen-100 tablets", price: 4.88 }
];
//declare function
function calcAverageProductPrice(Products) {
    if (Products.length === 0)
        return 0;
    var totalPrice = 0;
    for (var _i = 0, Products_1 = Products; _i < Products_1.length; _i++) {
        var Product = Products_1[_i];
        totalPrice += Product.price;
    }
    return totalPrice / Products.length;
}
console.log(calcAverageProductPrice(Products));
//create array
var InventoryItems = [
    { products: { name: "motor", price: 10.00 }, quantity: 10 },
    { products: { name: "sensor", price: 12.50 }, quantity: 4 },
    { products: { name: "LED", price: 1.00 }, quantity: 20 },
];
//declare function
function calcInventoryValue(InventoryItems) {
    var totalValue = 0;
    for (var _i = 0, InventoryItems_1 = InventoryItems; _i < InventoryItems_1.length; _i++) {
        var Inventory = InventoryItems_1[_i];
        totalValue += Inventory.products.price * Inventory.quantity;
    }
    return totalValue;
}
console.log(calcInventoryValue(InventoryItems));
