public class Car extends Vehichle
{
    // Car specific fields
    private int numDoors;
    private boolean isConvertible;

    // Def const
    public Car()
    {
        super();
        numDoors = 0;
        isConvertible = false;
    }

    // Param const
    public Car(String make, String model, int year, double price, int numDoors, boolean isConvertible)
    {
        super(make, model, year, price);
        this.numDoors = numDoors;
        this.isConvertible = isConvertible;
    }

    // Gets
    public int getNumDoors()
    {
        return numDoors;
    }

    public boolean getIsConvertible()
    {
        return isConvertible;
    }

    // Sets
    public void setNumDoors(int numDoors)
    {
        this.numDoors = numDoors;
    }

    public void setIsConvertible(boolean isConvertible)
    {
        this.isConvertible = isConvertible;
    }

    // Overrides displayInfo method
    @Override
    public void displayInfo()
    {
        super.displayInfo();
        System.out.println("Number of Doors: " + numDoors);
        System.out.println("Convertible: " + isConvertible);
    }

    @Override
    public String toString()
    {
        return super.toString() +
               ", Number of Doors: " + numDoors +
               ", Convertible: " + isConvertible;
    }
}