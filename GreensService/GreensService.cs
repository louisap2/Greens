using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GreensService
{
    public class GreensService : IGreensService
    {
        public GreensPrice ConvertDataToGreensPrice(string name, int price)
        {
            if(!String.IsNullOrEmpty(name) && price > 0)
            {
                GreensPrice greensPrice = new GreensPrice();
                greensPrice.Name = name;
                greensPrice.Price = price;

                return greensPrice;
            }
            else
            {
                return null;
            }
        }
    }
}
