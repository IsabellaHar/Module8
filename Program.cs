using System.Reflection.Metadata.Ecma335;

namespace Module8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            BankAccount account = new BankAccount();
            //view the balance
            Console.WriteLine(account.Balance);
            //deposit 20
            account.Deposit(20);
            //view balance after deposit
            Console.WriteLine(account.Balance);
            account.Withdrawal(5);
            Console.WriteLine(account.Balance);
            */

            //Example of overloading
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1,2,3));

            //Example of overriding
            Shape shape = new Shape();
            Circle circle = new Circle();

            shape.Draw();
            circle.Draw();

            var shapes = new List<Shape>
                {
                    new Rectangle(),
                    new Triangle(),
                    new Circle()
                };

            foreach (var item in shapes)
            {
                item.Draw();
            }

            DerivedClass B = new DerivedClass();
            Console.WriteLine(B.myVariable);

            BaseClass A = (BaseClass)B;
            Console.WriteLine(A.myVariable);


        } //end Main
    } //end program class

    public class BankAccount
    {
        //private field to store the balance
        private decimal balance;

            // public property to access the balance

        public decimal Balance
        {
            get { return balance; }  //read-only
            
        }

         public void Deposit(decimal amount)   //write-only
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Amount must be positive", nameof(amount));
            }

            balance += amount;
        }

        public void Withdrawal(decimal amount)   //write-only
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive", nameof(amount));
            }

            if (amount > balance)
            {
                throw new ArgumentException("Insufficent funds", nameof(amount));
            }

            balance -= amount;
        }
    }


    //Method overloading - two methods with the same name

    class Calculator
    {
        public int Add(int num1, int num2)  //add two numbers
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2, int num3)  //adds three numbers
        {
            return num1 + num2 + num3;
        }
    }

    //Method override

    //Activity 2 for Module 8

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    } //end class shape

   
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    } //end class rectangle

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    } //end class circle

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    } //end class triangle


    class BaseClass
    {
        public string myVariable = "This is the base class";
    }

    class DerivedClass : BaseClass
    {
        public new string myVariable = "This is the derived class";
    }

    /*
     * 

Create two classes, BaseClass and DerivedClass, then hide base class members with new members. Hidden base class members may be accessed from client code by casting the instance of the derived class to an instance of the base class.
Type and run the C# program to illustrate polymorphism.
     */





} //end namespace