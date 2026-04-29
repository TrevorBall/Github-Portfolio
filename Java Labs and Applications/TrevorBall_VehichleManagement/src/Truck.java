public class Truck extends Vehichle
{
    // Truck-specific fields
    private double bedLength;
    private double towingCapacity;

    // Default constructor
    public Truck()
    {
        super();
        bedLength = 0.0;
        towingCapacity = 0.0;
    }

    // Parameterized constructor
    public Truck(String make, String model, int year, double price, double bedLength, double towingCapacity)
    {
        super(make, model, year, price);
        this.bedLength = bedLength;
        this.towingCapacity = towingCapacity;
    }

    // Getters
    public double getBedLength()
    {
        return bedLength;
    }

    public double getTowingCapacity()
    {
        return towingCapacity;
    }

    // Setters
    public void setBedLength(double bedLength)
    {
        this.bedLength = bedLength;
    }

    public void setTowingCapacity(double towingCapacity)
    {
        this.towingCapacity = towingCapacity;
    }

    // Override displayInfo method
    @Override
    public void displayInfo()
    {
        super.displayInfo();
        System.out.println("Bed Length: " + bedLength + " ft");
        System.out.println("Towing Capacity: " + towingCapacity + " lbs");
    }

    @Override
    public String toString()
    {
        return super.toString() +
               ", Bed Length: " + bedLength +
               " ft, Towing Capacity: " + towingCapacity + " lbs";
    }
}