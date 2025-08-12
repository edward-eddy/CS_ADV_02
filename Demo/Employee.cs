using System.Collections;

namespace Demo
{
    class EmployeeCompareName : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            return X.Name.CompareTo(Y.Name);
        }
    }
    internal class Employee : IComparable<Employee>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            return Age.CompareTo(other.Age);
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
    }
}
