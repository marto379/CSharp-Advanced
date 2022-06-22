using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        List<Stock> portfolio;
        string fullName;
        string emailAdress;
        decimal moneyToInvest;
        string brokerName;

        public string FullName { get => fullName; set => fullName = value; }
        public string EmailAdress { get => emailAdress; set => emailAdress = value; }
        public decimal MoneyToInvest { get => moneyToInvest; set => moneyToInvest = value; }
        public string BrokerName { get => brokerName; set => brokerName = value; }

        public List<Stock> Portfolio { get => portfolio; set => portfolio = value; }

        public Investor(string fullName, string emailAdress, decimal moneyToInvest, string brokerName)
        {
            Portfolio = new List<Stock>();
            FullName = fullName;
            EmailAdress = emailAdress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;

        }

        public int Count()
        {
            return this.portfolio.Count;
        }
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && moneyToInvest >= stock.PricePerShare)
            {
                portfolio.Add(stock);   
                MoneyToInvest -= stock.PricePerShare;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            foreach (Stock stock in Portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    if (sellPrice < stock.PricePerShare)
                    {
                        return $"Cannot sell {companyName}";
                    }
                    else
                    {
                        portfolio.Remove(stock);
                        MoneyToInvest += sellPrice;
                        return companyName + " was sold";
                    }
                }
                
            }
            return companyName + " does not exist.";
        }
        public  Stock FindBiggestCompany()
        {

            if (portfolio.Count == 0)
            {
                return null;
            }
            return portfolio.OrderBy(stock => stock.MarketCapitalization).Last();

          
            
        }

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
           foreach (var stock in portfolio)
           {
                sb.Append(stock.ToString());
           }
            return sb.ToString();
        }

    }
}
