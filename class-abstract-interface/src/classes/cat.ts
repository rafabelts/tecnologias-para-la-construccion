import { Animal } from "./animal";

export class Cat extends Animal {
  constructor(name: string) {
    super(name);
  }

  makeSound(): void {
    console.log("Miau");
  }
}
