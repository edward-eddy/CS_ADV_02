using System.Collections;

namespace Demo
{
    internal class Program
    {

        public static void PrintArrayList(ArrayList arrayList)
        {
            Console.WriteLine();
            foreach (int item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region What are The Collections?
            // Collections : Built-in DS in C#
            // Array: Container

            // Collections in C#
            // Lists
            // Hashtables:

            // Generic - Non-Generic
            // Lists:
            // Non-Generic Lists: ArrayList - Stack - Queue
            // Generic Lists    : List, LinkedList, Stack , Queue

            // Hashtables:
            // Non-Generic HashTables  : HashTable
            // Generic HashTables      : Dictionary - SortedDictionary 
            #endregion

            #region Non-Generic Lists : ArrayList
            // Lists
            // Non-Generic Lists : ArrayList
            // ArrayList Like Array
            // Array Based
            // Index
            // Array Indexed Collection : Fixed Size
            // ArrayList Indexed Collection : Dynamic Size
            // Index : 0 1 2 3 4 5
            // items : 4 5 6 7 8 1
            // Size  : 6

            // Arr[1] --- > 5
            //int[] Numbers = { 9, 8, 7, 6, 1, 2, 3, 4, 5 };

            //Console.WriteLine (Numbers [1]);
            //Numbers[1] =12;
            //Console.WriteLine(Numbers[1]);

            //ArrayList list = new ArrayList(6);

            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //ArrayList list = new ArrayList();

            //list.Add(1);
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
            //list.Add(5);
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);
            //list.Add(9);
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list[1]);

            //list[1] = 12;
            //Console.WriteLine(list[1]);

            //list.AddRange(new[] { 11, 12, 13 });

            //PrintArrayList(list);
            //int Index = list.BinarySearch(2);
            //int Index = list.BinarySearch(2,);

            //Console.WriteLine(Index);

            //Employee E01 = new Employee() { Id = 1, Name = "Edward", Salary = 12000, Age = 28 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ahmed", Salary = 11000, Age = 29 };
            //Employee E03 = new Employee() { Id = 3, Name = "Yassmen", Salary = 9000, Age = 20 };
            //Employee E04 = new Employee() { Id = 4, Name = "Alaa", Salary = 10000, Age = 23 };

            //ArrayList list = new ArrayList();
            //list.AddRange(new Employee[] { E01, E02, E03, E04 });

            //list.Sort(new EmployeeCompareName());


            ////int Index = list.BinarySearch(E02);
            //int Index = list.BinarySearch(new Employee() { Name = "Alaa" }, new EmployeeCompareName());
            //Console.WriteLine($"Index: {Index}");

            ////int Index = list.BinarySearch(0, 2, new Employee() { Name = "Alaa" }, new EmployeeCompareName());
            ////Console.WriteLine($"Index: {Index}");


            //Console.WriteLine("===========");
            //foreach (Employee item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(9);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);

            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
            //list.Clear();
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            // Clone
            //ArrayList listClone = (ArrayList)list.Clone();
            //list.Add(9);
            //list[2] = 10;
            //PrintArrayList(list);
            //PrintArrayList(listClone);

            //bool Flag = list.Contains(1);
            //Console.WriteLine(Flag);

            //int[] Arr = new int[7];
            //list.CopyTo(Arr, 2);        // 0 0 1 2 3 4 5
            //list.CopyTo(1, Arr, 2, 3);  // 0 0 2 3 4 0 0 


            //foreach (int item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList = list.GetRange(2, 2);
            //PrintArrayList(list);



            //int i = list.IndexOf(5, 4, 5);
            //Console.WriteLine(i);

            //list.Insert(0, 100);
            //PrintArrayList(list);


            //list.InsertRange(0, new int[] { 10, 20, 30, 40 });
            //PrintArrayList(list);

            //int i = list.LastIndexOf(5);
            //Console.WriteLine(i);

            //list.Remove(5);
            //list.RemoveAt(0);
            //list.RemoveRange(1, 2);
            //list.InsertRange(0, new int[] { 10, 20, 30 });
            ////list.SetRange(3, new int[] { 10, 20, 30 });
            //list.Sort();

            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
            //list.TrimToSize();
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
            //PrintArrayList(list); 
            #endregion





        }
    }
}
