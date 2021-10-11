using System;

namespace lab1
{

    public class Employee
    {

        /*
         * getter and setter short notation for:
              private int _Id;
              public int GetId() { return _Id;}
              public void SetId(int Id) { _Id = Id;}
        */

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool IsActive()
        {
            return EndDate < DateTime.UtcNow;
        }

        /**
         * virtual method allows the inheriting sub-classes to overwrite the method
         * this means that when:  
         * Employee e1 = new Manager();
         * e1.Salutation() -> the actual method called is Manager.Salution(), not from base class, Employee.Salution()
         */
        public virtual string Salutation() {
            return $"Hello, employee of name {GetFullName()}!";
        } 
    }

    public class Architect : Employee
    {
        public override string Salutation()
        {
            return $"Hello, architect of name {GetFullName()}!";
        }
    }

    public class Manager : Employee
    {
        public override string Salutation()
        {
            return $"Hello, manager of name {GetFullName()}!";
        }
    }

    public class Exercise1
    {
        private static void MakeEmployeeSalute(Employee employee)
        {
            System.Console.WriteLine($"{employee.GetFullName()}: \"{employee.Salutation()}\"");
        }
        public static void Execute()
        {
            Employee architect = new Architect
            {
                FirstName = "George",
                LastName = "Columbus",
                StartDate = DateTime.UtcNow.AddDays(-1000),
                EndDate = DateTime.UtcNow.AddDays(1000),
                Salary = 680d
            };

            Employee manager = new Manager
            {
                FirstName = "Luis",
                LastName = "Waters",
                StartDate = DateTime.UtcNow.AddDays(-2000),
                EndDate = DateTime.UtcNow.AddDays(2000),
                Salary = 680d
            };

            
            MakeEmployeeSalute(architect); 
            MakeEmployeeSalute(manager); //because Salution() method is virtual and implemented in derived class Manager -> this will print "Hello, manager of name ..", not "Hello, employee of name .."
        }
    }

    public class Exercise2
    {
        public static void Execute()
        {
            var listOfWords = "Lorem ipsum dolor sit amet, consectetur adipiscing".GetWordsFromSentence().ToString();
            
            System.Console.WriteLine(listOfWords);
            System.Console.WriteLine(listOfWords.Length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise1.Execute();
            Exercise2.Execute();
        }
    }
}
