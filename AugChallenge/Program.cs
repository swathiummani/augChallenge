namespace AugChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public string CheckSumOfElements(int[] numbers)
        {
            if (numbers.Length <= 2)
            {
                return "Test Failed";
            }

            var index = 1;
            var rightSideSum = numbers[0];
            var leftSideSum = 0;

            for (var j = index + 1; j < numbers.Length; j++)
            {
                leftSideSum = leftSideSum + numbers[j];
            }
            if (rightSideSum == leftSideSum)
            {
                return "TEST PASSED";
            }

            for (var k = index; k < numbers.Length - 1; k++)
            {
                index++;
                rightSideSum = rightSideSum + numbers[k];
                leftSideSum = leftSideSum - numbers[k + 1];

                if (rightSideSum == leftSideSum)
                {
                    return "TEST PASSED";
                }
                
            }

            return "Test Failed";
        }
    }
}
