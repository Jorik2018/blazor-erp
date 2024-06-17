using System.Collections.Generic;
using System.Linq;

namespace blazor_erp.Data
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class Pizza
    {
        public const int DefaultSize = 12;

        public const int MinimumSize = 9;
        
        public const int MaximumSize = 17;

        public int? Id { get; set; }

        public int? OrderId { get; set; }

        public PizzaSpecial? Special { get; set; }

        public int? SpecialId { get; set; }

        public int? Size { get; set; }

        public List<PizzaTopping>? Toppings { get; set; }

        public decimal GetBasePrice()
        {
            // Ensure Size and Special are not null before performing calculations
            if (Size.HasValue && Special != null && Special.BasePrice.HasValue)
            {
                return ((decimal)Size.Value / DefaultSize) * Special.BasePrice.Value;
            }
            else
            {
                // Return 0 or some default value if Size or Special is null
                return 0;
            }
        }

        public decimal GetTotalPrice()
        {
            return GetBasePrice();
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}
