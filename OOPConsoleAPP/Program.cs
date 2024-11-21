namespace OOPConsoleAPP
{
    public class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Jerome", 27);
            Student student1 = new Student("Yana", 24, "Sheffield University");
            Teacher teacher1 = new Teacher("Colin", 45, "Computer Science");

            Console.WriteLine(person1.Work());
            Console.WriteLine(student1.Work());
            Console.WriteLine(teacher1.Work());


            person1.Age = 28;
            student1.Age = 25;
            teacher1.Age = 46;

            person1.Name = "Jerome Obnial";
            student1.Name = "Alliana";

            Console.WriteLine("--------------------------------------");
            Console.WriteLine(person1.Work());
            Console.WriteLine(student1.Work());
            Console.WriteLine(teacher1.Work());


            // teacher1.Subject = "Geography";  this is to test the exception

            Console.WriteLine("--------------------------------------");

            List<Person> people = new List<Person> { };


            people.Add(person1);
            people.Add(student1);
            people.Add(teacher1);



            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Work());
            }


























            //-------------------------------------------------------------------------------------------------------------------------
            ////Object
            //Car myCar = new Car();
            //myCar.Make = "Toyota";
            //myCar.Model = "Camry";
            //myCar.Year = 2021;
            //myCar.Drive();


            ////encapsulation

            //BankAccount myAccount = new BankAccount();

            //myAccount.deposit(20);

            //Console.WriteLine($"Your balance is: " + myAccount.getBalance());


            ////inheritance

            //Dogs myDog = new Dogs();

            //myDog.Bark();
            //myDog.eat();

            ////Polymorphishm

            //Cats myCat = new Cats();

            //myCat.eat();

            ////abstraction

            ////All together 
            //Person student = new Student();
            //Person teacher = new Teacher();


            //student.Work();
            //teacher.Work();
            //-------------------------------------------------------------------------------------------------------------------------








        }
    }
}
