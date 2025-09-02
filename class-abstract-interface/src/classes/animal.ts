export abstract class Animal {
  private name: string;

  constructor(name: string) {
    this.name = name;
  }

  sleep(): void {
    console.log("zzzz");
  }

  abstract makeSound(): void;

  getName(): string {
    return this.name;
  }
}
