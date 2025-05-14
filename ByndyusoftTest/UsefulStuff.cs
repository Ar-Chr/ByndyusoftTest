namespace ByndyusoftTest
{
    public static class UsefulStuff
    {
        public static long GetMinTwoNumbersSum(int[] numbers)
        {
            long sum = 0;
            LinkedList<int> minNumbers = GetMinNumbers(numbers, 2);
            foreach (int number in minNumbers)
            {
                sum += number;
            }
            return sum;
        }

        public static LinkedList<int> GetMinNumbers(int[] numbers, int minCount)
        {
            if (numbers.Length < minCount)
            {
                throw new ArgumentException("Input array length less than requested output length");
            }

            if (minCount < 0)
            {
                throw new ArgumentException("Requested output length is negative");
            }

            var minNumbers = new LinkedList<int>();
            for (int i = 0; i < minCount; i++)
            {
                minNumbers.AddLast(int.MaxValue);
            }

            int currentNumber;
            LinkedListNode<int>? currentNode;
            for (uint i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                currentNode = minNumbers.First;
                while (currentNode != null)
                {
                    if (currentNode.Value > currentNumber)
                    {
                        minNumbers.AddBefore(currentNode, currentNumber);
                        minNumbers.RemoveLast();
                        break;
                    }
                    currentNode = currentNode.Next;
                }
            }
            return minNumbers;
        }
    }
}
