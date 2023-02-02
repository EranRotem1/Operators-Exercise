namespace OperatorExercise
{
    public class MathMethods
    {
        public static string Div_Remainder()
        {
            Console.WriteLine("Please provide dividend (x) for x/y: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide divisor (y) for x/y: ");
            int y = int.Parse(Console.ReadLine());
            int div = x / y;
            int rem = x % y;
            return $"{x}/{y} is {div}, remainder {rem}";
        }
        
        public static int Add(params int[] x)
        {
            var total = 0;
            foreach (int i in x) { total += i; }
            return total;
        }

        public static int Sub(params int[] x) 
        {
            var total = x[0];
            for (int i = 1; i < x.Length; i++) 
            {
                total -= x[i];
            }
            return total;
        }

        public static int Mult(params int[] x)
        {
            var total = x[0];
            for (int i = 1; i < x.Length; i++) { total *= x[i]; }
            return total;
        }

        public static double AreaOfCircle()
        {
            Console.WriteLine("What's the radius of this circle? : ");
            var r = int.Parse(Console.ReadLine());
            return Math.PI * Math.Pow(r, 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4));
            Console.WriteLine(Sub(1, 2, 3, 4));
            Console.WriteLine(Mult(1, 2, 3, 4));
            Console.WriteLine(AreaOfCircle());
            Console.WriteLine(Div_Remainder());
        }
    }
}
