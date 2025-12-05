package clases_abstractas_erick;

public class Pigeon extends Animals implements Flying {
    
    public Pigeon(String name) {
        this.name = name;
    }

    @Override
    public void makeNoise() {
        System.out.println("La paloma " + this.name + " hace brrrbrrr");
    } 

    @Override
    public void fly() {
        System.out.println("La paloma " + this.name + " esta volando");
    }
}
