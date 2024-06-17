namespace blazor_erp.Data
{
    public class Topping
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public decimal? Price { get; set; }

        //public string GetFormattedPrice() => Price.ToString("0.00");

        public string GetFormattedPrice()
        {
            if (Price.HasValue)
            {
                return Price.Value.ToString("0.00");
            }
            else
            {
                return "0.00";
            }
        }
        
    }
}
