package clases_abstractas;

public abstract class Car {
    private String brand;
    private int wheels;
    private String color;

    public Car(String brand, int wheels, String color) {
        this.brand = brand;
        this.wheels = wheels;
        this.color = color;

    }

    public void prender(){
        System.out.println("El carro esta prendido");
    }

    public abstract void acelerar();
}