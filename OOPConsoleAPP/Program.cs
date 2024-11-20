namespace OOPConsoleAPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Object
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2021;
            myCar.Drive();


            //encapsulation

            BankAccount myAccount = new BankAccount();

            myAccount.deposit(20);
            
            Console.WriteLine($"Your balance is: " + myAccount.getBalance());


            //inheritance

            Dogs myDog = new Dogs();

            myDog.Bark();
            myDog.eat();

            //Polymorphishm

            Cats myCat = new Cats();

            myCat.eat();

            //abstraction

            //All together 
            Person student = new Student();
            Person teacher = new Teacher();


            student.Work();
            teacher.Work();
            

            




        }
    }
}
