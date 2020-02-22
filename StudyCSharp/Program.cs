using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dataTable = Library.TestData.GetDatatable();
            dataTable.Rows.AsQueryable();
        }
    }
}