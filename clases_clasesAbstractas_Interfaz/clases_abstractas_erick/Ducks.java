package clases_abstractas_erick;

public class Ducks extends Animals implements Flying, Swimming {

    public Ducks(String name) {
        this.name = name;
    }
    
    @Override
    public void makeNoise() {
        System.out.println("El pato " + this.name + " hace quack quack");
    }

    @Override
    public void fly() {
        System.out.println("El pato " + this.name + " esta volando");
    }

    @Override
    public void swim() {
        System.out.println("El pato " + this.name + " esta nadando");
    }
}