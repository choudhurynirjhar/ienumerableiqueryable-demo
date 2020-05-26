using System.Collections;
using System.Collections.Generic;

namespace IEnumerableIQueryable.Demo
{
    public class EmployeeEnumerator : IEnumerator<Employee>
    {
        private bool disposed = false;
        private int currentIndex;
        private EmployeeEnumerable employees;

        public EmployeeEnumerator(EmployeeEnumerable employees)
        {
            this.employees = employees;
            currentIndex = -1;
            Current = default;
        }

        public Employee Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose of managed resources.
                }
            }

            disposed = true;
        }

        public bool MoveNext()
        {
            if (++currentIndex >= employees.Count)
            {
                return false;
            }
            else
            {
                Current = employees[currentIndex];
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}