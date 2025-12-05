package clases_abstractas_erick;

public class Cat extends Animals {
    

    public Cat(String name) {
        this.name = name;
    }

    @Override
    public void makeNoise() {
        System.out.println("El gato " + this.name + " hace miau miau");
    }
}
