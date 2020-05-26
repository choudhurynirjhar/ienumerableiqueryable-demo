using System.Collections;
using System.Collections.Generic;

namespace IEnumerableIQueryable.Demo
{
    public class EmployeeEnumerable : IEnumerable<Employee>
    {
        List<Employee> employees = new List<Employee>();

        public Employee this[int index]
        {
            get { return employees[index]; }
            set { employees.Insert(index, value); }
        }

        public int Count => employees.Count;

        public IEnumerator<Employee> GetEnumerator()
        {
            return new EmployeeEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}