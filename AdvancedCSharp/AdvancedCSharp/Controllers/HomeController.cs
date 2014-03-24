using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdvancedCSharp.Models;

namespace AdvancedCSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() 
        {
            return View();
        }
        //
        // GET: /Home/

        public string  Vista()
        {
            
            return "View";

        }

        public ViewResult AutoProperty()
        {
            //Crear un nuevo Objeto
            //De la clase producto
            //Establece sus propiedades
            Product myProduct = new Product
            {
            ProductId = 12,
            Name = "Kayak",
            Description = "Kiosteca Blue",
            Category = "SPORTS",
            Price = 12.5f            
           };

            string salida=
                String.Format("{0}-{1}-{2}-{3}-{4:C0}",
                myProduct.ProductId,
                myProduct.Name,
                myProduct.Description,
                myProduct.Category,
                myProduct.Price);

            //Genera la vista
            return View("Results",
                (object)salida);

              
        }
        public ViewResult CreateCollection()
        { 
            //Arreglos de String
            string[] stringArray = { "manzana", "naranja", "lima" };

            //Lista
            List<int> intList = new List<int> { 10, 20, 30, 40 };

            //diccionario
            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"Manzana", 10},
                {"Naranja", 20},
                {"Lima",30}
            };
            return View("Results", (object)myDict["Lima"].ToString());
                 
        }

        public ViewResult useExtension()
        {
            //Creacion e inicialización de 
            //Shopping cart (carrito de compras)
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product{Name = "Kayak", Price = 3250.0f},
                    new Product{Name = "Lentes", Price = 1500.0f},
                    new Product{Name ="Balon Football", Price = 50.0f},
                    new Product{Name ="Disco Volador", Price = 130.0f},

                }
            };

            //Obteniendo el total de la compra
            double total = cart.TotalPrices();

            //Rendereando la Vista
            return View("Results",
            (object)String.Format("Total:{0:c}", total));

        }

    }
}
