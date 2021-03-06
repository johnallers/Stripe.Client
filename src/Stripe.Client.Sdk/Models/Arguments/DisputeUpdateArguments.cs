﻿using Newtonsoft.Json;
using Stripe.Client.Sdk.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stripe.Client.Sdk.Models.Arguments
{
    public class DisputeUpdateArguments
    {
        [JsonIgnore]
        [Required]
        public string DisputeId { get; set; }

        [ChildModel]
        public Evidence Evidence { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}