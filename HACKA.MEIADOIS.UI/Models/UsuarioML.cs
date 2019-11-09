using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    public class Address
    {

        [JsonProperty("city")]
        public string city { get; set; }

        [JsonProperty("state")]
        public string state { get; set; }
    }

    public class Ratings
    {

        [JsonProperty("negative")]
        public double negative { get; set; }

        [JsonProperty("neutral")]
        public double neutral { get; set; }

        [JsonProperty("positive")]
        public double positive { get; set; }
    }

    public class Transactions
    {

        [JsonProperty("canceled")]
        public int canceled { get; set; }

        [JsonProperty("completed")]
        public int completed { get; set; }

        [JsonProperty("period")]
        public string period { get; set; }

        [JsonProperty("ratings")]
        public Ratings ratings { get; set; }

        [JsonProperty("total")]
        public int total { get; set; }
    }

    public class SellerReputation
    {

        [JsonProperty("level_id")]
        public string level_id { get; set; }

        [JsonProperty("power_seller_status")]
        public string power_seller_status { get; set; }

        [JsonProperty("transactions")]
        public Transactions transactions { get; set; }
    }

    public class BuyerReputation
    {

        [JsonProperty("tags")]
        public IList<object> tags { get; set; }
    }

    public class Status
    {

        [JsonProperty("site_status")]
        public string site_status { get; set; }
    }

    public class UserML
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("nickname")]
        public string nickname { get; set; }

        [JsonProperty("registration_date")]
        public DateTime registration_date { get; set; }

        [JsonProperty("country_id")]
        public string country_id { get; set; }

        [JsonProperty("address")]
        public Address address { get; set; }

        [JsonProperty("user_type")]
        public string user_type { get; set; }

        [JsonProperty("tags")]
        public IList<string> tags { get; set; }

        [JsonProperty("logo")]
        public object logo { get; set; }

        [JsonProperty("points")]
        public int points { get; set; }

        [JsonProperty("site_id")]
        public string site_id { get; set; }

        [JsonProperty("permalink")]
        public string permalink { get; set; }

        [JsonProperty("seller_reputation")]
        public SellerReputation seller_reputation { get; set; }

        [JsonProperty("buyer_reputation")]
        public BuyerReputation buyer_reputation { get; set; }

        [JsonProperty("status")]
        public Status status { get; set; }
    }


}