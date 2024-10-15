using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_15._10
{
    internal class Product
    {


        public string Id;
        public string BrandName;
        public string Model;
        public decimal Price;
        public decimal Cost;
        public decimal Income;
        public int Count;

        public Product(string brandName, string model, decimal price, decimal cost, int count)
        {
            Id = brandName.Substring(0, 2) + model.Substring(0, 2);
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Income = 0;
            if (count < 0)
            {
                count = 0;
            }
            else
            {
                Count = count;
            }
        }

            public void GetInfo()
            {
                Console.WriteLine($"Id: {Id}, BrandName: {BrandName}, Model: {Model}, Price: {Price}, Cost: {Cost}, Income: {Income}, Count: {Count}");
            
        }

            public void Sale(int quantity)
            {
                if (quantity > Count)
                {
                    Console.WriteLine("Kifayət qədər məhsul yoxdur.");

                }
                else
                {
                    decimal revenue = (Price - Cost) * quantity;
                    Income += revenue;
                    Count -= quantity;
                }
            }
        }


    } 

