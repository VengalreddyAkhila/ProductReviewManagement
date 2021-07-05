﻿using System;
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

    }
}
