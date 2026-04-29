
public class Vehichle 
{
	// Base class fields
    private String make;
    private String model;
    private int year;
    private double price;

    // Def const
    public Vehichle()
    {
        make = "";
        model = "";
        year = 0;
        price = 0.0;
    }

    // Parameterized const
    public Vehichle(String make, String model, int year, double price)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.price = price;
    }

    // Gets
    public String getMake()
    {
        return make;
    }

    public String getModel()
    {
        return model;
    }

    public int getYear()
    {
        return year;
    }

    public double getPrice()
    {
        return price;
    }

    // Sets
    public void setMake(String make)
    {
        this.make = make;
    }

    public void setModel(String model)
    {
        this.model = model;
    }

    public void setYear(int year)
    {
        this.year = year;
    }

    public void setPrice(double price)
    {
        this.price = price;
    }

    // Method to display vehicle info
    public void displayInfo()
    {
        System.out.println("Make: " + make);
        System.out.println("Model: " + model);
        System.out.println("Year: " + year);
        System.out.println("Price: $" + price);
    }

    // toString method
    public String toString()
    {
        return "Make: " + make +
               ", Model: " + model +
               ", Year: " + year +
               ", Price: $" + price;
    }
	
	
}
