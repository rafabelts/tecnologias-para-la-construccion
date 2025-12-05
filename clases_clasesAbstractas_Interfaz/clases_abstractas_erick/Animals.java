package clases_abstractas_erick;

public abstract class Animals {
    protected String name;


    public abstract void makeNoise();

    public void dormir(){
        System.out.println(this.name +  " esta durmiendo");
    }

    public String getName() {
        return this.name;
    }
}
