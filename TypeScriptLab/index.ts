import { Inventory } from "./InventoryItems";
import { Mountain } from "./Moutains";
import { Product } from "./Products";

//create array

let Mountains:Mountain[] = [
    {name: "Kilimanjaro", height: 19341},
    {name: "Everest", height: 29029},
    {name:"Denali", height: 20310},
];
//declare function

function findNameOfTallestMountain(Mountains:Mountain[]) : string{ 
        let MaxHeight = 0;
        let tallestMountain = ""
    for(let Mountain of Mountains)
    {
        if (MaxHeight < Mountain.height)
            {
            MaxHeight = Mountain.height;
            tallestMountain = Mountain.name;
        }
    }
    return tallestMountain;
}

console.log(findNameOfTallestMountain(Mountains));
//create array

let Products:Product[] = 
    [
        {name: "Whole Milk-1 gallon", price: 3.99 },
        {name: "Organic Eggs-24 count", price: 7.99 },
        {name: "Bread-1 loaf", price: 1.99 },
        {name: "Organic Black Beans-15 oz can", price: 1.29 },
        {name: "Ibuprofen-100 tablets", price: 4.88 }
    ];

    //declare function
function calcAverageProductPrice(Products:Product[]) : number {
    if (Products.length === 0) return 0;
    let totalPrice = 0;
    for (let Product of Products) {
        totalPrice += Product.price;
    }
    return totalPrice / Products.length;
}

console.log(calcAverageProductPrice(Products));
    //create array

  let InventoryItems: Inventory[] = [
   { products: {name:"motor", price:10.00}, quantity: 10},
   { products: {name:"sensor", price:12.50}, quantity: 4},
   { products: {name:"LED", price:1.00}, quantity: 20},
  ];

  //declare function
  function calcInventoryValue(InventoryItems:Inventory[]) : number {
    let totalValue = 0;
    for(let Inventory of InventoryItems){
        totalValue += Inventory.products.price * Inventory.quantity;
    }
    return totalValue;
  }
  console.log(calcInventoryValue(InventoryItems));