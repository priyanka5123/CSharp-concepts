using System.Drawing;
using System.Xml.Schema;
using Pastel;
using Newtonsoft.Json;

public class Program
{
    public static int DivideNumbers(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        int result = (numerator/denominator);
        return result;
    }
    public static void Main()
    {
        int result = DivideNumbers(10, 0);
        Console.WriteLine("The result is: " + result);
        Console.WriteLine("Hello, World!".Pastel(ConsoleColor.Green));
        int[] numbers = {};
        double average = MathUtils.CalculateAverage(numbers);
        Console.WriteLine("The average is:" + average);
        double finalPrice = MathUtils.ApplyDiscount(1000,15);
        Console.WriteLine("The final price is :" + finalPrice);
        int[] myNumbers = { -5, -10, -3,-8, -2};
        int maxNumber = MathUtils.FindMax(myNumbers);
        Console.WriteLine("The maximum number is: " + maxNumber);
        int res = Calculator.Add();
        Console.WriteLine("The sum is: " + res);
        NumberDisplay.DispalyNumbers();
        UserInput.GreetUser();
        bool running = true;

        while (running)
        {
            Console.WriteLine("what would you like to do?");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Mark a task as complete");
            Console.WriteLine("4. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    TodoList.AddTask();
                    break;
                case "2":
                    TodoList.ViewTasks();
                    break;
                case "3":
                    TodoList.CompleteTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        // Deserialize JSON to Person object
        string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        // Serialize Person object to JSON
        Person newPerson = new Person { Name = "Ping Jeong", Age = 25 };
        string newJson = JsonConvert.SerializeObject(newPerson);
        Console.WriteLine($"Serialized JSON: {newJson}");

        // Create Pool object
        Pool p = new Pool(5, 100);
        p.PoolInfo();

        // Create Spa object (inherits from Pool)
        Spa s = new Spa(3, 80, 40);
        s.SpaInfo();

        // You can also access inherited method
        s.PoolInfo();

        //interface
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog());
        animals.Add(new Cat());

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
        }

        //Singleton
        Database db1 = Database.GetInstance();
        Database db2 = Database.GetInstance();
        db1.Connect();
        Console.WriteLine(object.ReferenceEquals(db1, db2));  //Output : True

        //Adapter
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);
        target.Request();

        //Factory
        Animals dog = AnimalFactory.CreateAnimal("Dog");
        dog.Speak();

        Animals cat = AnimalFactory.CreateAnimal("Cat");
        cat.Speak();

        //NotificationFactory
        NotificationFactory factory = new NotificationFactory();
        INotification note = factory.CreateNotification("email");
        note.Send("Welcome user");

        //WeatherStation
        WeatherStation station = new WeatherStation();
        PhoneDisplay phone = new PhoneDisplay();
        DesktopDisplay desktop = new DesktopDisplay();

        station.RegisterObserver(phone);
        station.RegisterObserver(desktop);

        station.SetTemperature(18);
        station.RemoveObserver(phone);
        station.SetTemperature(25);

        //Observer
        Subject subject = new Subject();
        IObservers observer1 = new ConcreteObserver("Observer 1");
        IObservers observer2 = new ConcreteObserver("Observer 2");

        subject.Attatch(observer1);
        subject.Attatch(observer2);

        subject.Notify("Hello, Observers!");

        //NewPerson
        NewPerson friend = new NewPerson();
        friend.Name = "Jane Smith";
        friend.Age = 35;
        friend.Greet();
        NewPerson colleague = new NewPerson();
        colleague.Name = "John Doe";
        colleague.Age = 30;
        colleague.Greet();
        
    }

}