using System.Diagnostics;

namespace Core
{
    public class MyDataAccess
    {
        public void Test()
        {
            try
            {
                using var context = new NorthwindContext();
                var employeeCount = context.Employees.Count();

                Debug.WriteLine($"Employee count: {employeeCount}");
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Failed: {ex.Message}");
            }
        }
    }
}
