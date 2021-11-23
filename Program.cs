using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace TD_7_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] test = new int[5] {1, 2, 3, 4, 5};
            Stack<int> stack1 = new Stack<int>(test);

            Stack<int> stack2 = new Stack<int>(test);
            PrintValues(stack1);
            
            PrintValues(Melanger(stack1, stack2));

            List<string> numberList = new List<string>();
            numberList.Add("91234765234");
            numberList.Add("dkpqdoqhduigzd");
            numberList.Add("91234765234qsdqs");
            numberList.Add("912347652dddddd4");
            numberList.Add("0146477865");
            numberList.Add("!ÉDJO'è!ù%");
            
            
            CleanNumberList(numberList);
            
            PrintValues(numberList);

            var addressBook = new AddressBook();
            addressBook.Add(0132324523, "Jean Pierre");
            addressBook.Add(819732341, "Jean Pierre");
            Console.WriteLine(addressBook.ToString());
        }

        public static void CleanNumberList(List<string> numberList)
        {
            var regex = new Regex("^[0-9]+$");
            for (var index = 0; index < numberList.Count; index++)
            {
                string number = numberList[index];
                if (!regex.IsMatch(number) || number.Length > 10)
                {
                    numberList.Remove(number);
                    --index;
                }
            }
        }

        public static Stack<T> Melanger<T>(Stack<T> stackA, Stack<T> stackB)
        {
            Random random = new Random();
            Stack<T> newStack = new Stack<T>();
            
            while (stackA.Count > 0 || stackB.Count > 0)
            {
                var choice = random.Next(0, 2);
                if (choice == 0) newStack.Push(stackA.Count > 0 ? stackA.Pop() : stackB.Pop());
                else newStack.Push(stackB.Count > 0 ? stackB.Pop() : stackA.Pop());
            }
            return newStack;

        }
        
        public static void PrintValues( IEnumerable myCollection )  {
            foreach ( Object obj in myCollection )
                Console.Write( "    {0}", obj );
            Console.WriteLine();
        }
    }
}