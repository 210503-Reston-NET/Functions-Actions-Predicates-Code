using System;
using System.Collections.Generic;
using RRModels;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an Action Demo");
            RunActionDemo();
        }

        static void RunActionDemo(){
            //get some dummy data from Restaurant Review
            List<Restaurant> Restaurants = new List<Restaurant>() 
            {
                new Restaurant("sushi land", "Seattle", "WA"),
                new Restaurant("Homegrown", "Bellevue", "WA")
            };

            Restaurants[0].Reviews = new List<Review>
            {
                new Review{
                    Rating = 5,
                    Description = "best sushi"
                },
                new Review{
                    Rating = 4,
                    Description = "good sushi"
                }
            };

            //Leverage Action to create a print method as a parameter which used to 
            // pass in to List<T>.ForEach method that will print each item on console
            Action<Object> print = obj => Console.WriteLine(obj.ToString());

            //print a list of retuarants
            Restaurants.ForEach(print);
            //print a list of reviews of Sushi Land
            Restaurants[0].Reviews.ForEach(print);
        }
    }
}
