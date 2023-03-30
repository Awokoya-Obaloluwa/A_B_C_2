namespace A_B_C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a first number");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a second number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a third number");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Correctness(A, B, C));
        }

        public static int Correctness(int A, int B, int C)
        {
            if (C == 0)
            {
                int a = A;
                int b = B;
                Console.WriteLine(a >= 14);
                Console.WriteLine(b >= 14);

            }
            else if (C > 0)
            {
                int a2 = A;
                int b2 = B;
                Console.WriteLine(a2 > 2 * (C + 1));
                Console.WriteLine(b2 > 2 * (C + 1));

            }
            return C;
        }
    }
}