namespace Zachary_Renyhart_Assignment_10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, -1, 3, -3, 10, -200, 14 };
            //This is the condition to where only the positive numbers will be selected
            var numQuery = from num in numbers where (num) > 0 select num;
            //This condition is where num is > (GREATER) than 0. Select the numbers!!

            foreach (int num in numQuery )
            {
                Console.WriteLine(num);
            }


        }

       
            
          
        
    }
}
