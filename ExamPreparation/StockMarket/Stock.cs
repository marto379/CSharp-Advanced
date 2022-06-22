using System.Text;

namespace StockMarket
{
    public class Stock
    {
        string companyName;
        string Director;
        decimal pricePerShare;
        int totalNumShares;
        decimal marketCapitalization;

        public string CompanyName { get => companyName; set => companyName = value; }
        public string Director1 { get => Director; set => Director = value; }
        public decimal PricePerShare { get => pricePerShare; set => pricePerShare = value; }
        public int TotalNumShares { get => totalNumShares; set => totalNumShares = value; }
        public decimal MarketCapitalization { get => pricePerShare * totalNumShares; set => marketCapitalization = value; }

        public Stock(string companyName, string director, decimal pricePerShare, int totalNumShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumShares = totalNumShares;
            MarketCapitalization = pricePerShare * totalNumShares;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {CompanyName}");
            sb.AppendLine($"Director: {Director}");
            sb.AppendLine($"Price per share: ${PricePerShare}");
            sb.AppendLine($"Market capitalization: ${MarketCapitalization}");

            return sb.ToString();

        }
    }
}
