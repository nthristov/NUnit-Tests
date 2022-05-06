
namespace Summator
{
    public class Summator
    {
       public long Sum(int[] arr)
        {

            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;

        }

        public static int Average(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum/arr.Length;
        }
    }
}
