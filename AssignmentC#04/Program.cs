namespace AssignmentC_04
{
    internal class Program
    {

        #region Q3

        //public static (int ,int) SumSub(int x ,int y, ref  int sum, ref  int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //    return (sum, sub);

        //}

        #endregion


        #region Q4

        static int SumDigits(int num)
        {
            int result = 0;
            while (num > 0)    // 543
            {
                result += num % 10;
                num /= 10;
            }
            return result;

        }

        #endregion

        #region Q5

        static bool isPrime(int n)
        {
            if (n <= 1) return false;


            for (int i = 2; i * i <= n; i++)  //n = 7         14
            {
                if (n % i == 0) return false;
            }
            return true;

        }

        #endregion

        #region Q6

        static int[] MinMax(int[] arr)
        {

            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int[] result = { min, max };
            return result;

        }

        #endregion

        #region Q7

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return (result);
        }

        #endregion


        #region Q8

        static string ChangeChar(string str, int pos, char newChar)
        {
            if (pos < 0 || pos > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(pos), "position is out of range");
            }

            char[] chars = str.ToCharArray();
            chars[pos] = newChar;
            return new string(chars);
        }


        #endregion




        static void Main(string[] args)
        {
            //int x, y, sum =0, sub = 0;
            //x = int.Parse(Console.ReadLine());
            //y = int.Parse(Console.ReadLine());

            //(int ,int) result = SumSub(x, y,ref sum,ref sub);

            //Console.WriteLine(sum);
            //Console.WriteLine(sub);           

            //Console.WriteLine("Enter a number");

            int num= int.Parse(Console.ReadLine());



            bool prime = isPrime(num);
            if (prime)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

            //int[] arr = { 10, 2, 5, 7, 4, 7, -5 };
            //int[] arrResult = MinMax(arr);
            //Console.WriteLine(arrResult[0]);
            //Console.WriteLine(arrResult[1]);

            //factorial problem
            //Console.WriteLine(Factorial(7));

            Console.WriteLine(ChangeChar("ahmed",7,'h') );
            

        }
    }
}
