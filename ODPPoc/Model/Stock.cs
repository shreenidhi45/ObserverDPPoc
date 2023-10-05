using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODPPoc.Model
{
    internal class Stock
    {
        private string symbol;
        private decimal price;
        private List<IInvestor> investors = new List<IInvestor>();
        private List<INewsAgency> newsAgencies = new List<INewsAgency>();

        public Stock(string symbol, decimal price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void Attach(INewsAgency agency)
        {
            newsAgencies.Add(agency);
        }

        public void Detach(INewsAgency agency)
        {
            newsAgencies.Remove(agency);
        }

        public void SetPrice(decimal price)
        {
            this.price = price;
            NotifyInvestors();
            NotifyNewsAgencies();
        }

        private void NotifyInvestors()
        {
            foreach (var investor in investors)
            {
                investor.Update(this);
            }
        }

        private void NotifyNewsAgencies()
        {
            foreach (var agency in newsAgencies)
            {
                agency.Update(this);
            }
        }

        public decimal GetPrice()
        {
            return price;
        }

        public string GetSymbol()
        {
            return symbol;
        }
    }
}

    

