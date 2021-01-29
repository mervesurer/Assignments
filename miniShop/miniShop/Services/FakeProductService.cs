using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class FakeProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{ Id=1, Name="Kolye", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty50/product/media/images/20210111/11/50823886/115845882/1/1_org.jpg",
                            Description="Kar Tanesi Kolyesi", Price=86.47M, Discount=0.38, Rating= 4.7},
                new Product{ Id=2, Name="Kolye X", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty50/product/media/images/20210111/11/50823886/115845882/1/1_org.jpg",
                            Description="Kar Kolyesi", Price=86.47M, Discount=0.38, Rating= 4.7},
                new Product{ Id=3, Name="Kolye Y", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty50/product/media/images/20210111/11/50823886/115845882/1/1_org.jpg",
                            Description="Kolyesi", Price=86.47M, Discount=0.38, Rating= 4.7},
                new Product{ Id=4, Name="Saat", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty50/product/media/images/20210111/11/50823886/115845882/1/1_org.jpg",
                            Description="Kar ", Price=86.47M, Discount=0.38, Rating= 4.7},
                new Product{ Id=5, Name="Çanta", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty50/product/media/images/20210111/11/50823886/115845882/1/1_org.jpg",
                            Description="Tanesi Kolyesi", Price=86.47M, Discount=0.38, Rating= 4.7},
                new Product{ Id=6, Name="Pantolon", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty50/product/media/images/20210111/11/50823886/115845882/1/1_org.jpg",
                            Description="Kar Kolyesi", Price=86.47M, Discount=0.38, Rating= 4.7},
            };
        }
    }
}
