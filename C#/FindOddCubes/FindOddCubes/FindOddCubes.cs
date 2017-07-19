using System.Linq;

namespace FindOddCubesKata
{
    public class FindOddCubes
    {
        public int OddCubeSum(int[] numbers)
        {
            return numbers.Where(n => n % 2 != 0)
                          .Select(n => n * n * n)
                          .Sum(); 
        }
    }
}
