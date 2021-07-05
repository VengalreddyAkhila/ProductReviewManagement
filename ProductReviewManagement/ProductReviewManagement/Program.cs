using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){productID=1,UserID= 1,Review = "Good",Rating = 8,Like=true},
                new ProductReview(){productID=2,UserID= 1,Review = "Better",Rating = 5,Like=false},
                new ProductReview(){productID=3,UserID= 3,Review = "Average",Rating = 4,Like=true},
                new ProductReview(){productID=4,UserID= 4,Review = "Nice",Rating = 6,Like=true},
                new ProductReview(){productID=5,UserID= 6,Review = "Bad",Rating = 3,Like=false},
                new ProductReview(){productID=6,UserID= 8,Review = "Good",Rating = 9,Like=true},
                new ProductReview(){productID=7,UserID= 10,Review = "Good",Rating = 7,Like=true},
                new ProductReview(){productID=8,UserID= 12,Review = "Nice",Rating = 5,Like=false},
                new ProductReview(){productID=9,UserID= 14,Review = "Worst",Rating = 0,Like=true},
                new ProductReview(){productID=10,UserID= 19,Review = "Excellent",Rating = 10,Like=true},
                new ProductReview(){productID=11,UserID= 17,Review = "Nice",Rating = 6,Like=false},
                new ProductReview(){productID=12,UserID= 27,Review = "Nice",Rating = 6,Like=false},
                new ProductReview(){productID=13,UserID= 13,Review = "Nice",Rating = 6,Like=true},
                new ProductReview(){productID=14,UserID= 15,Review = "Nice",Rating = 6,Like=false},
                new ProductReview(){productID=15,UserID= 22,Review = "excellent",Rating = 10,Like=false},
                new ProductReview(){productID=16,UserID= 37,Review = "Nice",Rating = 6,Like=false},
                new ProductReview(){productID=17,UserID= 26,Review = "Nice",Rating = 6,Like=false},
                new ProductReview(){productID=18,UserID= 21,Review = "good",Rating = 5,Like=true},
                new ProductReview(){productID=19,UserID= 23,Review = "Nice",Rating = 6,Like=false},
                new ProductReview(){productID=20,UserID= 33,Review = "worst",Rating = 2,Like=false},
                new ProductReview(){productID=21,UserID= 34,Review = "Nice",Rating = 6,Like=true},
                new ProductReview(){productID=22,UserID= 32,Review = "bad",Rating = 1,Like=false},
                new ProductReview(){productID=23,UserID= 45,Review = "Nice",Rating = 6,Like=false},
                new ProductReview(){productID=24,UserID= 11,Review = "average",Rating = 4,Like=true},
                new ProductReview(){productID=25,UserID= 29,Review = "better",Rating = 3,Like=true},
            };
            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("productid :" + list.productID + "userid :" + list.UserID + "rating :" + list.Rating
            //        + "review :" + list.Review + "like :" + list.Like);
            //}

            /// <summary>
            /// UC2-Get top 3 reviews in list
            /// </summary>
            //LinqQueries linqQueries = new LinqQueries();
            //linqQueries.Toprecords(productReviewList);

            //UC3-Get whos Rating is greater 3 product id is 1 , 4 and 9 in list
            //LinqQueries linqQueries = new LinqQueries();
            //linqQueries.SelectedRecords(productReviewList);

            //UC4-count for review for each product id
            //LinqQueries linqQueries = new LinqQueries();
            //linqQueries.RetriewCountToData(productReviewList);

            //UC5-Only product Id from list of all record
            LinqQueries linqQueries = new LinqQueries();
            linqQueries.RetriveProductData(productReviewList);
        }
    }
}
