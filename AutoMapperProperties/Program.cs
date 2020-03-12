using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.CategoryId = 1;
            product.Id = 2;
            product.Name = "Product Name";
            var productViewModel   = new ProductViewModel();

            //map all data from model to viewmodel where they have the same Name and DataType
            productViewModel = AutoMapper<ProductViewModel, Product>.Map(productViewModel,product);
            Console.WriteLine(productViewModel.Id);
            Console.WriteLine(productViewModel.Name);
            Console.WriteLine(productViewModel.NameCateogry);


            Console.ReadLine();
        }
    }
}
