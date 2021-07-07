using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class LinqQueries
    {
        public readonly DataTable dataTable = new DataTable();
        /// <summary>
        /// UC1-Print the product review class with 25default values in list
        /// UC2-Top 3 records whos rating is high
        /// </summary>
        /// <param name="listproductReviews"></param>
        public void Toprecords(List<ProductReview> listproductReviews)
        {
            var recordData = (from ProductReviews in listproductReviews
                              orderby ProductReviews.Rating descending
                              select ProductReviews).Take(3);
            foreach (var list in recordData)
            {
                Console.WriteLine(" productid :" + list.productID + " userid :" + list.UserID + " rating :" + list.Rating
                    + " review :" + list.Review + " like :" + list.Like);
            }
        }
        /// <summary>
        /// UC3-Rating greater than 3 and product id is 1, 4 and 9 in list
        /// </summary>
        /// <param name="listproductReviews"></param>
        public void SelectedRecords(List<ProductReview> listproductReviews)
        {
            var recordedData = from ProductReviews in listproductReviews
                               where (ProductReviews.productID == 1 && ProductReviews.Rating > 3) ||
                               (ProductReviews.productID == 4 && ProductReviews.Rating > 3) ||
                               (ProductReviews.productID == 9 && ProductReviews.Rating > 3)
                               select ProductReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine(" productid :" + list.productID + " userid :" + list.UserID + " rating :" + list.Rating
                    + " review :" + list.Review + " like :" + list.Like);
            }

        }
        /// <summary>
        /// UC4-Retriew count of review for each product id
        /// </summary>
        /// <param name="listproductReviews"></param>
        public void RetriewCountToData(List<ProductReview> listproductReviews)
        {
            var recordedData = listproductReviews.GroupBy(x => x.productID).Select(x => new { productID = x.Key, count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.productID + "-----" + list.count);
            }
        }
        /// <summary>
        /// UC5-Retrive Only ProductId
        /// </summary>
        /// <param name="listproductReviews"></param>
        public void RetriveProductData(List<ProductReview> listproductReviews)
        {
            var recordedData = listproductReviews.GroupBy(x => x.productID).Select(x => new { productID = x.Key });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.productID);
            }
        }
        /// <summary>
        /// UC6-Skip top 5 records in product review management
        /// </summary>
        /// <param name="listproductReviews"></param>
        public void SkipRecords(List<ProductReview> listproductReviews)
        {
            var recordData = (from ProductReviews in listproductReviews
                              orderby ProductReviews.Rating 
                              select ProductReviews).Skip(5);
            foreach (var list in recordData)
            {
                Console.WriteLine(" productid :" + list.productID + " userid :" + list.UserID + " rating :" + list.Rating
                    + " review :" + list.Review + " like :" + list.Like);
            }
        }
        /// <summary>
        /// UC7-Retrive Only ProductId and review
        /// </summary>
        /// <param name="listproductReviews"></param>
        public void RetriveIdAndReviewData(List<ProductReview> listproductReviews)
        {
            var recordedData = from ProductReview  in listproductReviews  select new { ProductReview.productID,ProductReview.Review };
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.productID+""+list.Review);                
            }
        }
        /// <summary>
        /// UC-8 Create a datatablr for product review management
        /// </summary>
        /// <param name="dataTable"></param>
        public void PrintTable(DataTable dataTable)
        {
            var Products = from products in dataTable.AsEnumerable()
                           select (products.Field<int>("ProductID"), products.Field<int>("UserID"), products.Field<int>("Rating"),
                                products.Field<string>("Review"), products.Field<bool>("Like"));
            PrintDataTable(Products);
        }
        /// <summary>
        /// printing datatable
        /// </summary>
        /// <param name="products"></param>
        private void PrintDataTable(EnumerableRowCollection<(int, int, int, string, bool)> products)
        {
            Console.WriteLine("ProductID   UserID   Rating   Review       Like");
            foreach (var list in products)
            {
                Console.WriteLine("productID:"+list.Item1 +" UserID:"+list.Item2+" Rating:"+list.Item3+" Review:"+list.Item4+" Like:"+list.Item5);
            }
        }

    }
}
