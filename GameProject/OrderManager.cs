using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class OrderManager

    {
        public void Add(Order order)
        {
            Console.WriteLine("Satışınız oluşturuldu.");
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Satışınız iptal edildi.");
        }

        public void Update(Order order)
        {
            Console.WriteLine("Satışınız güncellendi.");
        }
    }
}
