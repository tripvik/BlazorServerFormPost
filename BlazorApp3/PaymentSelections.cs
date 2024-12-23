using System.ComponentModel.DataAnnotations;

namespace BlazorApp3
{
    public class PaymentSelections
    {
        public string? AccountNumber { get; set; } = "0000000";

        public string SessionGuid { get; set; } = Guid.NewGuid().ToString();
    }
}


