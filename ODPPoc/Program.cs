using ODPPoc.Model;

namespace ODPPoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock relStock = new Stock("RIL", 102);

            Investor Shree = new Investor("Shree");
            Investor Nidhi = new Investor("Nidhi");

            NewsAgency bloomberg = new NewsAgency("bloomberg");
            NewsAgency ETNow = new NewsAgency("ETNow");

            relStock.Attach(Shree);
            relStock.Attach(Nidhi);

            relStock.Attach(bloomberg);
            relStock.Attach(ETNow);

            relStock.SetPrice(110);

            //relStock.Detach(Nidhi);
            //relStock.SetPrice(111);
        }
    }
}