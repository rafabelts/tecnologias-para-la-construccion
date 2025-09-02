import { Animal } from "./animal";
import { Fly } from "../interfaces/fly.ts";

export class Dove extends Animal implements Fly {
  constructor(name: string) {
    super(name);
  }

  makeSound(): void {
    console.log("Prr Prr");
  }

  fly(): void {
    console.log("Fly fly");
  }
}
