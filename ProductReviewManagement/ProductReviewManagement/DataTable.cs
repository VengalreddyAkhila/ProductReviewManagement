using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewTable
    {

        public void CreateDataTable()
        {
            // Create a new DataTable.     
            DataTable datatable = new DataTable();
            // Create Address column.    
            datatable.Columns.Add("ProductId",typeof(int));
            datatable.Columns.Add("UserId",typeof(int));
            datatable.Columns.Add("Rating",typeof(int));
            datatable.Columns.Add("Review",typeof(string));
            datatable.Columns.Add("Like",typeof(bool));
            datatable.Rows.Add(1, 1, 6, "Good", true);
            datatable.Rows.Add(2, 1, 2, "Worst", true);
            datatable.Rows.Add(3, 1, 19, "Excellent", true);
            datatable.Rows.Add(4, 1, 6, "Good", false);
            datatable.Rows.Add(5, 1, 2, "nice", true);
            datatable.Rows.Add(6, 1, 4, "Better", true);
            datatable.Rows.Add(7, 1, 1, "Good", false);
            datatable.Rows.Add(8, 1, 9, "nice", true);
            datatable.Rows.Add(9, 1, 8, "nice", true);
            datatable.Rows.Add(10, 1, 10, "Excellent", true);
            datatable.Rows.Add(11, 1, 7, "nice", false);
            datatable.Rows.Add(12, 1, 8, "nice", false);
            datatable.Rows.Add(13, 1, 7, "nice", false);
            datatable.Rows.Add(14, 1, 10, "Excellent",true);
            datatable.Rows.Add(15, 1, 2, "nice", false);
            datatable.Rows.Add(16, 1, 6, "Worst", false);
            datatable.Rows.Add(17, 1, 4, "better", false);
            datatable.Rows.Add(18, 1, 9, "nice", false);
            datatable.Rows.Add(19, 1, 1, "Bad", false);
            datatable.Rows.Add(20, 1, 7, "nice", false);
            Console.WriteLine("DataTable is Created");
           
        }
    }
    
}
