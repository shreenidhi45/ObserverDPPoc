using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODPPoc.Model
{
    internal class Investor:IInvestor
    {
        private string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {name} of {stock.GetSymbol()}'s change to {stock.GetPrice()}");
        }
    }
}
