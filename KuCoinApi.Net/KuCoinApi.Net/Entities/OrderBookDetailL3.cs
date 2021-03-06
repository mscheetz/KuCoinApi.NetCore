﻿// -----------------------------------------------------------------------------
// <copyright file="OrderBookDetailL3" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="1/19/2019 9:07:27 PM" />
// -----------------------------------------------------------------------------

namespace KuCoinApi.Net.Entities
{
    #region Usings

    using KuCoinApi.Net.Core;
    using Newtonsoft.Json;

    #endregion Usings

    [JsonConverter(typeof(Converter.ObjectToArrayConverter<OrderBookDetailL3>))]
    public class OrderBookDetailL3
    {
        [JsonProperty(Order = 1)]
        public string OrderId { get; set; }

        [JsonProperty(Order = 2)]
        public decimal Price { get; set; }

        [JsonProperty(Order = 3)]
        public decimal Size { get; set; }
    }
}
