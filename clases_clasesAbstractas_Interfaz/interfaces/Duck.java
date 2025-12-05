package interfaces;

public class Duck extends Animal implements Fly {
    private String color;

    public Duck(int age, String color) {
        super(age);
        this.color = color;
    }
    
    @Override
    public void makeNoise() {
        System.out.println("Quack Quack");
    }

    @Override
    public void fly() {
        System.out.println("El pato esta volando con " + amountOfWings + " alas.");
    }

}
