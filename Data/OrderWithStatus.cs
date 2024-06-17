using System;
using System.Collections.Generic;

namespace blazor_erp.Data
{
    public class OrderWithStatus
    {
        public readonly static TimeSpan PreparationDuration = TimeSpan.FromSeconds(10);

        public readonly static TimeSpan DeliveryDuration = TimeSpan.FromMinutes(1); // Unrealistic, but more interesting to watch

        public Order? Order { get; set; }

        public string? StatusText { get; set; }

        public bool IsDelivered => StatusText == "Delivered";

        public static OrderWithStatus FromOrder(Order order)
        {
            // To simulate a real backend process, we fake status updates based on the amount
            // of time since the order was placed
            string statusText;
            //if (order.CreatedTime.HasValue)
            {

            var dispatchTime = order.CreatedTime.Add(PreparationDuration);
            //var dispatchTime = order.CreatedTime.Value.Add(PreparationDuration);
            //var dispatchTime = order.CreatedTime.Value.AddMinutes(PreparationDuration);

            if (DateTime.Now < dispatchTime)
            {
                statusText = "Preparing";
            }
            else if (DateTime.Now < dispatchTime + DeliveryDuration)
            {
                statusText = "Out for delivery";
            }
            else
            {
                statusText = "Delivered";
            }
}
/*else
{
statusText = "";
}*/
            return new OrderWithStatus
            {
                Order = order,
                StatusText = statusText
            };
        }


    }
}
