using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Singular.CorePlatform.Pay.Emoney.Models.Requests
{
    public class InitPaymentRequest
    {
        [Required]
        [JsonProperty(PropertyName = "user_id")]
        public uint UserId { get; set; }

        [Required]
        [JsonProperty(PropertyName = "account")]
        public string EmoneyUser { get; set; }

        [Required]
        [Range(0.1, uint.MaxValue)]
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
    }
}
