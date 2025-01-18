namespace Session_OOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {





        }













            #region   Assignment 04 OOP


            #region Part01

           #region Q1 - Calculator Class with Overloaded Add Methods
public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }
        #endregion

        #region Q2 - Rectangle Class with Multiple Constructors
        public class Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle()
            {
                Width = 0;
                Height = 0;
            }

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public Rectangle(int size)
            {
                Width = size;
                Height = size;
            }
        }
        #endregion

        #region Q3 - ComplexNumber Class with Operator Overloading
        public class ComplexNumber
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }

            public ComplexNumber(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
            }

            public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
            }
        }
        #endregion

        #region Q4 - Employee and Manager Classes
        public class Employee
        {
            public virtual void Work()
            {
                Console.WriteLine("Employee is working");
            }
        }

        public class Manager : Employee
        {
            public override void Work()
            {
                base.Work();
                Console.WriteLine("Manager is managing");
            }
        }
        #endregion

        #region Q5 - BaseClass and Derived Classes with DisplayMessage
        public class BaseClass
        {
            public virtual void DisplayMessage()
            {
                Console.WriteLine("Message from BaseClass");
            }
        }

        public class DerivedClass1 : BaseClass
        {
            public override void DisplayMessage()
            {
                Console.WriteLine("Message from DerivedClass1");
            }
        }

        public class DerivedClass2 : BaseClass
        {
            public new void DisplayMessage()
            {
                Console.WriteLine("Message from DerivedClass2");
            }
        }
        #endregion

        #endregion

        #region Part02

        #region Duration Class with Required Features
        public class Duration
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            public Duration(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }

            public Duration(int totalSeconds)
            {
                Hours = totalSeconds / 3600;
                Minutes = (totalSeconds % 3600) / 60;
                Seconds = totalSeconds % 60;
            }

            public override string ToString()
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Duration other)
                {
                    return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Hours, Minutes, Seconds);
            }

            public static Duration operator +(Duration d1, Duration d2)
            {
                return new Duration(d1.ToSeconds() + d2.ToSeconds());
            }

            public static Duration operator +(Duration d, int seconds)
            {
                return new Duration(d.ToSeconds() + seconds);
            }

            public static Duration operator ++(Duration d)
            {
                return new Duration(d.ToSeconds() + 60);
            }

            public static Duration operator --(Duration d)
            {
                return new Duration(d.ToSeconds() - 60);
            }

            public static bool operator >(Duration d1, Duration d2) => d1.ToSeconds() > d2.ToSeconds();
            public static bool operator <(Duration d1, Duration d2) => d1.ToSeconds() < d2.ToSeconds();
            public static implicit operator DateTime(Duration d) => DateTime.Now.AddSeconds(d.ToSeconds());

            private int ToSeconds()
            {
                return Hours * 3600 + Minutes * 60 + Seconds;
            }
        }
        #endregion

        #endregion

        #endregion

    }
}

