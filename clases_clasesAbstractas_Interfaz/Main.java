import interfaces.Duck;
import clases_abstractas.Bus;
import clases_abstractas_erick.Cat;
import clases_abstractas_erick.Pigeon;
import clases_abstractas_erick.Ducks;

public class Main {
    public static void main(String[] args) {
        
        Bus bus = new Bus("Volvo", 6, "Amarillo", 3);
        bus.prender();
        bus.acelerar();

        Duck paco = new Duck(2, "Amarillo");
        paco.makeNoise();
        paco.fly();
        
        Cat garfield = new Cat("Garfield");
        garfield.makeNoise();
        garfield.dormir();

        Pigeon pidgeoto = new Pigeon("Pidgeoto");
        pidgeoto.makeNoise();
        pidgeoto.fly();

        Ducks lucas = new Ducks("Lucas");
        lucas.makeNoise();
        lucas.fly();
        lucas.swim();

    }
}