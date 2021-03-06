using Newtonsoft.Json;
using Stripe.Client.Sdk.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stripe.Client.Sdk.Models.Arguments
{
    public class OrderPayArguments
    {
        [JsonIgnore]
        [Required]
        public string OrderId { get; set; }

        public string Customer { get; set; }

        [JsonIgnore]
        public string CardToken { get; set; }

        [JsonIgnore]
        public CardCreateArguments CardCreateArguments { get; set; }

        [ChildModel]
        public object Source => !string.IsNullOrWhiteSpace(CardToken) ? (object)CardToken : CardCreateArguments;

        public int? ApplicationFee { get; set; }

        public string Email { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}