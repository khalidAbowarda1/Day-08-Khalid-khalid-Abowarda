using System;
using System.Collections.Generic;

namespace Day08
{
    // Define IWalkable interface
    public interface IWalkable
    {
        void StartEngine();
        void StopEngine();
    }

    // Implement Car class
    public class Car : IWalkable
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }

    // Implement Bike class
    public class Bike : IWalkable
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }

    // Define Shape abstract class
    public abstract class Shape
    {
        public abstract void Display();
    }

    // Implement Rectangle class
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle: width = {width}, height = {height}");
        }
    }

    // Implement Circle class
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Circle: radius = {radius}");
        }
    }

    // Define Product class with IComparable
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(Product other)
        {
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Name}: ${Price}";
        }
    }

    // Define Student class with copy constructor
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public Student(Student other)
        {
            Id = other.Id;
            Name = other.Name;
            Grade = other.Grade;
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Grade = {Grade}";
        }
    }

    // Define Account class with encapsulation
    public class Account
    {
        private int id;
        private string name;
        private decimal balance;

        public Account(int id, string name, decimal balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Test IWalkable interface
            Console.WriteLine("Testing IWalkable Interface:");
            IWalkable car = new Car();
            IWalkable bike = new Bike();

            car.StartEngine();
            car.StopEngine();
            bike.StartEngine();
            bike.StopEngine();
            Console.WriteLine();

            // Test Shape abstract class
            Console.WriteLine("Testing Shape Abstract Class:");
            Shape rectangle = new Rectangle(5, 3);
            Shape circle = new Circle(2);

            Console.WriteLine("Rectangle:");
            rectangle.Display();
            Console.WriteLine("Circle:");
            circle.Display();
            Console.WriteLine();

            // Test Product with IComparable
            Console.WriteLine("Testing Product Comparison:");
            var products = new List<Product>
            {
                new Product("Laptop", 999.99m),
                new Product("Phone", 599.99m),
                new Product("Tablet", 399.99m)
            };

            products.Sort();
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();

            // Test Student with copy constructor
            Console.WriteLine("Testing Student Copy Constructor:");
            var student1 = new Student(1, "John Doe", 85.5);
            var student2 = new Student(student1); // Deep copy
            student2.Name = "Jane Doe";

            Console.WriteLine("Original: " + student1);
            Console.WriteLine("Copy (modified): " + student2);
            Console.WriteLine();

            // Test Account encapsulation
            Console.WriteLine("Testing Account Encapsulation:");
            var account = new Account(1001, "Alice Smith", 1000m);
            Console.WriteLine($"Initial balance: ${account.Balance}");

            account.Deposit(500m);
            Console.WriteLine($"After deposit: ${account.Balance}");

            account.Withdraw(200m);
            Console.WriteLine($"After withdrawal: ${account.Balance}");


            
        
        }
    }
}
