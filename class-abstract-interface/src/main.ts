import { Cat } from "./classes/cat";
import { Dove } from "./classes/dove";
import { Duck } from "./classes/duck";

const cat = new Cat("Larry");
const dove = new Dove("Prince");
const duck = new Duck("Donald");

console.log("Cat shit");
cat.getName();
cat.makeSound();
cat.sleep();

console.log("\n");

console.log("Dove shit");
dove.fly();
dove.getName();
dove.makeSound();
dove.sleep();

console.log("\n");

console.log("Duck shit");
duck.fly();
duck.getName();
duck.makeSound();
duck.sleep();
duck.swim();
