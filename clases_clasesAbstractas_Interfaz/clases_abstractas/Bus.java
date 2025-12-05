package clases_abstractas;

public class Bus extends Car {
    private int ejes;

    public Bus(String brand, int wheels, String color, int ejes) {
        super(brand, wheels, color);
        this.ejes = ejes;
    }

    @Override
    public void acelerar() {
        System.out.println("El bus esta acelerando");
    }
}
