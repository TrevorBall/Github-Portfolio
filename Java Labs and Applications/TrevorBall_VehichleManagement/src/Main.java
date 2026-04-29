import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);

        // Array of base class
        Vehichle[] vehicles = new Vehichle[100];
        int count = 0;

        int choice;

        do
        {
            System.out.println("\n===== Vehicle Management System =====");
            System.out.println("1. Add Car");
            System.out.println("2. Add Truck");
            System.out.println("3. Add SUV");
            System.out.println("4. View All Vehicles");
            System.out.println("5. Exit");
            System.out.print("Enter your choice: ");
            choice = input.nextInt();
            input.nextLine();

            switch (choice)
            {
                case 1:
                    if (count < vehicles.length)
                    {
                        vehicles[count] = createCar(input);
                        count++;
                        System.out.println("Car added successfully.");
                    }
                    else
                    {
                        System.out.println("Vehicle array is full.");
                    }
                    break;

                case 2:
                    if (count < vehicles.length)
                    {
                        vehicles[count] = createTruck(input);
                        count++;
                        System.out.println("Truck added successfully.");
                    }
                    else
                    {
                        System.out.println("Vehicle array is full.");
                    }
                    break;

                case 3:
                    if (count < vehicles.length)
                    {
                        vehicles[count] = createSUV(input);
                        count++;
                        System.out.println("SUV added successfully.");
                    }
                    else
                    {
                        System.out.println("Vehicle array is full.");
                    }
                    break;

                case 4:
                    displayVehicles(vehicles, count);
                    break;

                case 5:
                    System.out.println("Exiting program...");
                    break;

                default:
                    System.out.println("Invalid choice. Try again.");
            }

        } while (choice != 5);

        input.close();
    }

    // Method to create a Car object
    public static Car createCar(Scanner input)
    {
        System.out.print("Enter make: ");
        String make = input.nextLine();

        System.out.print("Enter model: ");
        String model = input.nextLine();

        System.out.print("Enter year: ");
        int year = input.nextInt();

        System.out.print("Enter price: ");
        double price = input.nextDouble();

        System.out.print("Enter number of doors: ");
        int numDoors = input.nextInt();

        System.out.print("Is it convertible? (true/false): ");
        boolean isConvertible = input.nextBoolean();
        input.nextLine(); // clear newline

        return new Car(make, model, year, price, numDoors, isConvertible);
    }

    // Method to create a Truck object
    public static Truck createTruck(Scanner input)
    {
        System.out.print("Enter make: ");
        String make = input.nextLine();

        System.out.print("Enter model: ");
        String model = input.nextLine();

        System.out.print("Enter year: ");
        int year = input.nextInt();

        System.out.print("Enter price: ");
        double price = input.nextDouble();

        System.out.print("Enter bed length: ");
        double bedLength = input.nextDouble();

        System.out.print("Enter towing capacity: ");
        double towingCapacity = input.nextDouble();
        input.nextLine(); // clear newline

        return new Truck(make, model, year, price, bedLength, towingCapacity);
    }

    // Method to create an SUV object
    public static SUV createSUV(Scanner input)
    {
        System.out.print("Enter make: ");
        String make = input.nextLine();

        System.out.print("Enter model: ");
        String model = input.nextLine();

        System.out.print("Enter year: ");
        int year = input.nextInt();

        System.out.print("Enter price: ");
        double price = input.nextDouble();

        System.out.print("Enter seating capacity: ");
        int seatingCapacity = input.nextInt();

        System.out.print("Has third row? (true/false): ");
        boolean hasThirdRow = input.nextBoolean();
        input.nextLine(); // clear newline

        return new SUV(make, model, year, price, seatingCapacity, hasThirdRow);
    }

    // Method to display all vehicles
    public static void displayVehicles(Vehichle[] vehicles, int count)
    {
        if (count == 0)
        {
            System.out.println("No vehicles have been added yet.");
            return;
        }

        System.out.println("\n===== Vehicle List =====");
        for (int i = 0; i < count; i++)
        {
            System.out.println("\nVehicle #" + (i + 1));
            vehicles[i].displayInfo(); // polymorphism happens here
        }
    }
}