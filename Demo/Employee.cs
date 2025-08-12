using System.Collections;

namespace Demo
{
    class EmployeeCompareName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            //Employee X = (Employee)x;
            //Employee Y = (Employee)y;
            return x.Name.CompareTo(y.Name);
        }
    }
    internal class Employee : IComparable<Employee>, IEnumerable<Employee>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            return Age.CompareTo(other.Age);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //public int CompareTo(object? obj)
        //{
        //    Employee other = (Employee)obj;
        //    return Age.CompareTo(other.Age);
        //}

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, Age: {Age}";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
