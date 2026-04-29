public class SUV extends Vehichle
{
    // SUV-specific fields
    private int seatingCapacity;
    private boolean hasThirdRow;

    // Default constructor
    public SUV()
    {
        super();
        seatingCapacity = 0;
        hasThirdRow = false;
    }

    // Parameterized constructor
    public SUV(String make, String model, int year, double price, int seatingCapacity, boolean hasThirdRow)
    {
        super(make, model, year, price);
        this.seatingCapacity = seatingCapacity;
        this.hasThirdRow = hasThirdRow;
    }

    // Getters
    public int getSeatingCapacity()
    {
        return seatingCapacity;
    }

    public boolean getHasThirdRow()
    {
        return hasThirdRow;
    }

    // Setters
    public void setSeatingCapacity(int seatingCapacity)
    {
        this.seatingCapacity = seatingCapacity;
    }

    public void setHasThirdRow(boolean hasThirdRow)
    {
        this.hasThirdRow = hasThirdRow;
    }

    // Override displayInfo method
    @Override
    public void displayInfo()
    {
        super.displayInfo();
        System.out.println("Seating Capacity: " + seatingCapacity);
        System.out.println("Third Row: " + hasThirdRow);
    }

    @Override
    public String toString()
    {
        return super.toString() +
               ", Seating Capacity: " + seatingCapacity +
               ", Third Row: " + hasThirdRow;
    }
}