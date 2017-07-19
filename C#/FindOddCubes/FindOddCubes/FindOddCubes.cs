namespace FindOddCubesKata
{
    public class FindOddCubes
    {
        public int OddCubeSum(int[] numbers)
        {

            var sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number * number * number;
                }
            }
            return sum; 
        }
    }
}
