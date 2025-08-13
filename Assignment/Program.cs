namespace Assignment
{
    internal class Program
    {
        #region Q01
        public static int NumbersOfGreater(int[] Arr, int Comparer)
        {
            int result = 0;
            foreach (int i in Arr)
            {
                if (i > Comparer)
                    result++;
            }
            return result;
        }
        #endregion

        #region Q03
        public static void reverseQueueUsingStack<T>(Queue<T> queue)
        {
            Stack<T> Temp = new Stack<T>(queue);
            queue.Clear();
            foreach (T t in Temp)
            {
                queue.Enqueue(t);
            }
        }
        #endregion

        #region Q04
        public static bool IsBalanced(string text)
        {
            Stack<Char> stack = new Stack<Char>();
            Char Check;
            foreach (Char s in text)
            {
                // Stacking the parentheses 
                if (s == '(' || s == '{' || s == '[')
                    stack.Push(s);

                if (s == ')' || s == '}' || s == ']')
                {
                    // Check If The Parentheses Stack Is Empty
                    // All Open Parentheses Have Been Closed
                    if (!stack.TryPeek(out Check))
                        return false;

                    // Matches Parentheses
                    switch (s)
                    {
                        case ')':
                            if (Check == '(')
                                stack.Pop();
                            break;
                        case '}':
                            if (Check == '{')
                                stack.Pop();
                            break;
                        case ']':
                            if (Check == '[')
                                stack.Pop();
                            break;
                    }
                }
            }
            return !stack.TryPeek(out Check);
        }
        #endregion

        #region Q05
        public static void RemoveDuplicate<T>(ref T[] values)
        {
            HashSet<T> set = new HashSet<T>(values);
            values = new T[set.Count];
            values = set.ToArray();
        }
        #endregion

        #region Q06
        public static void RemoveOdd(ref List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (i % 2 != 0)
                    values.Remove(i);
            }
        }
        #endregion

        #region Q08
        public static void InsertIntegersAndSearch(int[] ints, int target)
        {
            Stack<int> stack = new Stack<int>(ints);
            int Checks = 0;
            foreach (int i in stack)
            {
                if (i == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {Checks}");
                    return;
                }
                Checks++;
            }
            if (Checks == stack.Count)
                Console.WriteLine("Target was not found");
        }
        #endregion

        #region Q09
        public static int[] CreateUserDefinedIntArray(int Size)
        {
            int[] IntArr = new int[Size];
            bool flag = true;
            do
            {
                try
                {
                    Console.Write($"Enter The Array Elements Space-Separeted (1 2 3 ...): ");
                    string[] StringArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    IntArr = Array.ConvertAll(StringArray, int.Parse);

                    if (IntArr.Length != Size)
                        throw new Exception("");
                    flag = false;
                }
                catch
                {
                    Console.WriteLine($"\nNote: Enter Numbers Only with Size {Size}\n");
                }
            } while (flag);
            return IntArr;
        }

        public static void FindIntersection<T>(T[] Array01, T[] Array02)
        {
            List<T> list01 = new List<T>(Array01);
            List<T> list02 = new List<T>(Array02);
            for (int i = 0; i < list01.Count; i++)
            {
                for (int j = 0; j < list02.Count; j++)
                {
                    if (list01[i].Equals(list02[j]))
                    {
                        Console.Write($"{list01[i]} ");
                        list01.Remove(list01[i]);
                        list02.Remove(list02[j]);
                        i = j = 0;
                    }

                }
            }
        }
        #endregion

        #region Q11
        public static void ReverceKElements<T>(ref Queue<T> queue, int K)
        {
            T[] temp = queue.ToArray();

            Array.Reverse(temp, 0, K);

            queue = new Queue<T>(temp);
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q01
            /*
              1. Given an array  consists of  numbers with size N and number of queries, 
              in each query you will be given an integer X, and you should print how many 
              numbers in array that is greater than  X.
             */

            //int Size, Queries;
            //// Getting Array Size
            //do
            //{
            //    Console.Write("Enter Size of array: ");
            //} while (!int.TryParse(Console.ReadLine(), out Size));

            //// Getting Queries Count
            //do
            //{
            //    Console.Write("Enter number of Queries: ");
            //} while (!int.TryParse(Console.ReadLine(), out Queries));

            //// =======================================


            //int[] IntArr = new int[Size];

            //// Assigning The Array
            //for (int i = 0; i < Size; i++)
            //{
            //    do
            //    {
            //        Console.Write($"\nEnter Element No.{i + 1} of The List: ");
            //    } while (!int.TryParse(Console.ReadLine(), out IntArr[i]));
            //}

            //// Query And Results
            //for (int i = 0; i < Queries; i++)
            //{
            //    int temp;
            //    do
            //    {
            //        Console.Write($"\nQuery No.{i + 1}: ");
            //    } while (!int.TryParse(Console.ReadLine(), out temp));

            //    Console.WriteLine($"{NumbersOfGreater(IntArr, temp)} Greater Numbers"); ;
            //} 
            #endregion

            #region Q02
            // 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //// Getting Array Size
            //int Size;
            //do
            //{
            //    Console.Write("Enter Size of array: ");
            //} while (!int.TryParse(Console.ReadLine(), out Size));


            //// Assign The Array
            //int[] IntArr = new int[Size];
            //bool flag = true;
            //do
            //{
            //    try
            //    {
            //        Console.Write($"Enter The Array Elements Space-Separeted (1 2 3 ...): ");
            //        string[] StringArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //        IntArr = Array.ConvertAll(StringArray, int.Parse);

            //        if (IntArr.Length != Size)
            //            throw new Exception("");
            //        flag = false;
            //    }
            //    catch
            //    {
            //        Console.WriteLine($"\nNote: Enter Numbers Only with Size {Size}\n");
            //    }
            //} while (flag);

            //// Check If The Array Is Palindrome Or Not
            //bool IsPalindrome = true;
            //for (int i = 0; i < Size / 2; i++)
            //{
            //    if (IntArr[i] != IntArr[Size - i - 1])
            //        IsPalindrome = false;
            //}
            //Console.WriteLine("\n" + (IsPalindrome ? "YES" : "No!")); 
            #endregion

            #region Q03
            //3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (int i in queue)
            //{
            //    Console.Write($"{i} ");
            //}
            //reverseQueueUsingStack(queue);
            //Console.WriteLine();
            //foreach (int i in queue)
            //{
            //    Console.Write($"{i} ");
            //} 
            #endregion

            #region Q04
            //4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //Console.WriteLine("Enter The Text: ");
            //string Text = Console.ReadLine();
            //Console.WriteLine(IsBalanced(Text) ? "Balanced" : "Not Balanced!");
            #endregion

            #region Q05
            //5. Given an array, implement a function to remove duplicate elements from an array.

            //int[] array = { 4, 3, 2, 6, 4, 7, 4, 2, 3, 9, 8, 0 };

            //foreach (int i in array)
            //{
            //    Console.Write($"{i} ");
            //}

            //RemoveDuplicate<int>(ref array);
            //Console.WriteLine();

            //foreach (int i in array)
            //{
            //    Console.Write($"{i} ");
            //} 
            #endregion

            #region Q06
            //6. Given an array list , implement a function to remove all odd numbers from it

            //List<int> Arr = [1, 2, 3, 4, 5, 6, 7, 8];

            //foreach (int i in Arr)
            //    Console.Write($"{i} ");

            //RemoveOdd(ref Arr);
            //Console.WriteLine();

            //foreach (int i in Arr)
            //    Console.Write($"{i} "); 
            #endregion

            #region Q07
            // 7. Implement a queue that can hold different data types. 

            //Queue<Object> queue = new Queue<Object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28); 
            #endregion

            #region Q08
            /*
                 8. Create a function that pushes a series of integers onto a stack. Then, search for 
                a target integer in the stack. If the target is found, print a message indicating that 
                the target was found how many elements were checked before finding the target 
                (“Target was found successfully and the count = 5”). If the target is not found, print 
                a message indicating that the target was not found(“Target was not found”).
                 */


            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int target;
            //do
            //{
            //    Console.Write("Enter The Target: ");
            //} while (!int.TryParse(Console.ReadLine(), out target));

            //InsertIntegersAndSearch(Arr, target);
            #endregion

            #region Q09
            //int Size;
            //// Getting first Array Size
            //do
            //{
            //    Console.Write("Enter Size of the first array: ");
            //} while (!int.TryParse(Console.ReadLine(), out Size));

            //// Assign The first Array
            //int[] Array01 = CreateUserDefinedIntArray(Size);


            //// Getting Second Array Size
            //do
            //{
            //    Console.Write("Enter Size of the second array: ");
            //} while (!int.TryParse(Console.ReadLine(), out Size));

            //// Assign The Second Array
            //int[] Array02 = CreateUserDefinedIntArray(Size);

            //FindIntersection(Array01, Array02); 
            #endregion

            #region Q10
            /*
             10. Given an ArrayList of integers and a target sum, find if there is a contiguous 
            sub list that sums up to the target.
             */

            //int target, check = 0;
            //ArrayList result = new ArrayList();

            //ArrayList arrayList = new ArrayList(CreateUserDefinedIntArray(5));

            //do
            //{
            //    Console.Write("Enter The Target: ");
            //} while (!int.TryParse(Console.ReadLine(), out target));

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    for (int j = i; j < arrayList.Count; j++)
            //    {
            //        check += (int)arrayList[j];
            //        if (check > target)
            //        {
            //            check = 0;
            //            break;
            //        }
            //        if (check == target)
            //        {
            //            //result = new int[j - i + 1];
            //            result = arrayList.GetRange(i, j - i + 1);
            //            break;
            //        }
            //    }
            //    if (result.Count > 0)
            //        break;
            //}
            //if (result.Count > 0)
            //{
            //    Console.Write("[ ");
            //    foreach (int i in result)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    Console.Write("]");

            //} 
            #endregion

            #region Q11
            /*
                 11. Given a queue reverse first K elements of a queue, keeping the remaining elements 
                in the same order 
                 */

            //int K;

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //// Assign K
            //do
            //{
            //    Console.Write("Enter K: ");
            //} while (!int.TryParse(Console.ReadLine(), out K));

            //foreach (int i in queue)
            //{
            //    Console.Write($"{i} ");
            //}

            //ReverceKElements(ref queue, K);
            //Console.WriteLine();

            //foreach (int i in queue)
            //{
            //    Console.Write($"{i} ");
            //} 
            #endregion

        }
    }
}
