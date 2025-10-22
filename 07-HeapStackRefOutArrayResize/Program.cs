namespace _07HeapStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3};
            int[] number = { 4,5,6 };
            StackHeap(ref arr, number);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void StackHeap(ref int[] arr, int[] number)
        {
            int[] newArr = new int[arr.Length + number.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            
            for (int i = 0; i < number.Length; i++)
            {
                newArr[arr.Length +i] = number[i];
                
            }

            arr = newArr;



        }
    }
}
