using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODPPoc.Model
{
    internal class NewsAgency:INewsAgency
    {
        private string newsAgencyName;

        public NewsAgency(string name)
        {
            this.newsAgencyName = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine($"{newsAgencyName} received update on {stock.GetSymbol()} - Price: {stock.GetPrice()}");
        }
    }
}
