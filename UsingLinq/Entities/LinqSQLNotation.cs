using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLinq.Entities
{
    public class LinqSQLNotation
    {
        public static void Execution()
        {
            try
            {
                List<Product> products = new List<Product>();
                products = Model.InstanceObjetcs();

                var result01 =
                    from p in products
                    where p.Category.Tier == 1 && p.Price < 900.00
                    select p;
                Model.PrintResult(".Where(Tier = 1 and Price < 900.00)", result01);

                var result02 =
                    from p in products
                    where p.Category.Name == "Tools"
                    select p.Name;
                Model.PrintResult(".Where(CategoryName = Tools).Select(Product Name)", result02);

                var result03 = 
                    from p in products
                    where p.Name[0] == 'C'
                    select new { p.Name, p.Price, CategoryName = p.Category.Name };
                Model.PrintResult(".Where(Name starts with C).Select(Product Name), Price, Categoty Name", result03);

                var result04 =
                    from p in products
                    where p.Category.Tier == 1
                    orderby p.Price
                    select p;
                Model.PrintResult(".Where(Tier = 1).Orderby(Product Price, Name)", result04);

                var result05 = 
                    (from p in result04
                     select p)
                     .Skip(2)
                     .Take(4);
                Model.PrintResult(".Skip(2).Take(4)", result05);

                var result06 =
                    from p in products
                    group p by p.Category;
                foreach (IGrouping<Category, Product> group in result06)
                {
                    Console.WriteLine($"Category {group.Key.Name}:");
                    foreach (Product p in group)
                        Console.WriteLine(p);
                }
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }      
        }
    }
}
