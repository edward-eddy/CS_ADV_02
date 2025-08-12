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

        public static int SumArrayList(ArrayList list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is int)
                        Sum += (int)list[i]; // Unboxing [ReferenceType] To [ValueType] - Unsafe
                }
            }
            return Sum;
        }

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
        }

        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += list[i];
                }
            }
            return Sum;
        }

        public static void PrintLinkedList(LinkedList<int> linkedList)
        {
            Console.Write("null");
            foreach (int item in linkedList)
            {
                Console.Write($" <- {item} -> ");
            }
            Console.WriteLine("null");
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

            #region Problems With Non-Generic Lists [ArrayList]
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            ////list.Add("Hello, World!"); // Exception
            ////list.Add(new Employee()); // Exception
            ////list.Add(2.3); // Exception

            ////int Sum = SumArrayList(list);
            ////Console.WriteLine(Sum); 
            #endregion

            #region Generic Lists : List
            // Generic Lists : List
            // List : Version Generic Of ArrayList
            // List Like ArrayList Like Array : Generic - Dynamic Size

            //List<int> list = new List<int>(new int[] { 1,2,3,4});
            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(4);
            //list.Add("Hello World"); // Complier

            //PrintList(list);

            //int Sum = SumList(list);

            //Console.WriteLine(Sum);

            //list.AddRange(new List<int>() {10, 20, 30, 40, 50 });

            //list.AsReadOnLy();
            //int i= list.BinarySearch(20);

            //PrintList(i);

            //Console.WriteLine(i);


            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 29 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 30 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 15000, Age = 35 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 14000, Age = 32 };

            //List<Employee> employees = new List<Employee> { E01, E02, E03, E04 };

            //int i = employees.BinarySearch(E01, new EmployeeCompareName());
            //Console.WriteLine(i);

            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //list.EnsureCapacity(capacity: 10);

            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");


            //List<int> result=list.GetRange(0, 2);

            //PrintList(result);

            //list.Sort();
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //list.TrimExcess();
            //list.TrueForAll();
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}"); 
            #endregion

            #region Generic Lists : LinkedList
            // Generic Lists : LinkedList

            // LinkedList<>

            // LinkedList

            //LinkedList<int> linkedList = new LinkedList<int>();

            //linkedList.AddFirst(1);
            //linkedList.AddFirst(2);
            ////LinkedList.AddLast(1);
            ////LinkedList.AddLast(2);

            //LinkedListNode<int> node = new LinkedListNode<int>(3);
            //linkedList.AddLast(node);

            //linkedList.AddAfter(node, 4);

            //LinkedListNode<int> result = linkedList.Find(1);

            //linkedList.AddBefore(result, 4);


            //Console.WriteLine(linkedList.First.Value);
            //Console.WriteLine(linkedList.Last.Value);

            //linkedList.Clear();

            //Console.WriteLine(linkedList.First.Next.Value);

            //linkedList.Remove(linkedList.First);
            //linkedList.Remove(2);
            //linkedList.RemoveLast();
            //linkedList.Remove(linkedList.Last);

            //PrintLinkedList(linkedList); 
            #endregion








        }
    }
}
