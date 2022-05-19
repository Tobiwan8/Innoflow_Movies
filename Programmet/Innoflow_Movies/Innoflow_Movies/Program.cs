using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Innoflow_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = File.ReadAllLines(@"C:\Users\toblar\Desktop\MovieData\MovieData\Users.txt");
            string[] products = File.ReadAllLines(@"C:\Users\toblar\Desktop\MovieData\MovieData\Products.txt");
            string[] currentUser = File.ReadAllLines(@"C:\Users\toblar\Desktop\MovieData\MovieData\CurrentUserSession.txt");

            double rating = 0;

            List<ProductDto> productsList = new List<ProductDto>();
            //Populære film

            double HighstRating = 0;
            string informationForHighestRatingTitle = string.Empty;
            string informationForHighestRatingTitle2 = string.Empty;
            foreach (string product in products)
            {
                string[] productItems = product.Split(',');

                var currentRating = Convert.ToDouble(productItems[8].Replace('.',','));

                if (currentRating > HighstRating)
                {
                    HighstRating = currentRating;
                    informationForHighestRatingTitle2 = informationForHighestRatingTitle;
                    informationForHighestRatingTitle = product;
                }


                //var template = new ProductDto()
                //{
                //    Year = 2022
                //};
                //template.Id = Convert.ToInt32(productItems[0]);
                //template.Title = productItems[1];
                //template.Year = Convert.ToInt32(productItems[2]);

                //productsList.Add(template);

                //decimal rating = Convert.ToDouble(productItems[8], CultureInfo.InvariantCulture);
                int price = Convert.ToInt32(productItems[9]);

                //Console.WriteLine(rating);
                Console.WriteLine(product);
                //Console.WriteLine("best rated: " + rating);
                }

            var maxRating = productsList.Max(x => x.Rating);

            var maxRatingProduct = productsList.Max(x => x.Rating);
            //Anbefalede film

            Console.ReadKey();
        }

        public class ProductDto
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }
            public int Rating { get; set; }
        }
    }
}
