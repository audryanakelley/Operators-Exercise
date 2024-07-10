namespace OperatorExercise
{
    public class Program
    {
         
        public static void Main(string[] args)
        {
          int a = 17;
          int b = 4;
          int sum = a + b; 
          int quotient = a / b;
          int remainder = a % b;


          Console.WriteLine(a);
          Console.WriteLine(b);

          Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
          
          Console.Write("Enter the radius of the circle: ");
          double radius = double.Parse(Console.ReadLine());
          double area = AreaOfCircle(radius);
          Console.WriteLine($"The area of the circle with radius {radius} is {area}");
        }
        
        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
        
    }   
}
