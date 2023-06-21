using Business.Concrete;
using ConsoleUI;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProducDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }


        }
    }
}

