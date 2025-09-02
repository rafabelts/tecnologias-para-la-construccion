import { Animal } from "./animal";
import { Fly } from "../interfaces/fly";
import { Swim } from "../interfaces/swim";

export class Duck extends Animal implements Fly, Swim {
  constructor(name: string) {
    super(name);
  }

  makeSound(): void {
    console.log("Sonido de pato");
  }

  sleep(): void {
    console.log("El pato duerme");
  }

  fly(): void {
    console.log("Fly fly fly");
  }

  swim(): void {
    console.log("blub blub");
  }
}
