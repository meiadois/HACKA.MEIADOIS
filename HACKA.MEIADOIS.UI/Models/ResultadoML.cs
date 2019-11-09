using Newtonsoft.Json;
using System;
using System.Collections.Generic;


public class Paging
{

    [JsonProperty("total")]
    public int total { get; set; }

    [JsonProperty("offset")]
    public int offset { get; set; }

    [JsonProperty("limit")]
    public int limit { get; set; }

    [JsonProperty("primary_results")]
    public int primary_results { get; set; }
}

public class Seller
{

    [JsonProperty("id")]
    public int id { get; set; }

    [JsonProperty("power_seller_status")]
    public string power_seller_status { get; set; }

    [JsonProperty("car_dealer")]
    public bool car_dealer { get; set; }

    [JsonProperty("real_estate_agency")]
    public bool real_estate_agency { get; set; }

    [JsonProperty("tags")]
    public IList<object> tags { get; set; }
}

public class Installments
{

    [JsonProperty("quantity")]
    public int quantity { get; set; }

    [JsonProperty("amount")]
    public double amount { get; set; }

    [JsonProperty("rate")]
    public double rate { get; set; }

    [JsonProperty("currency_id")]
    public string currency_id { get; set; }
}

public class Address
{

    [JsonProperty("state_id")]
    public string state_id { get; set; }

    [JsonProperty("state_name")]
    public string state_name { get; set; }

    [JsonProperty("city_id")]
    public string city_id { get; set; }

    [JsonProperty("city_name")]
    public string city_name { get; set; }
}

public class Shipping
{

    [JsonProperty("free_shipping")]
    public bool free_shipping { get; set; }

    [JsonProperty("mode")]
    public string mode { get; set; }

    [JsonProperty("tags")]
    public IList<string> tags { get; set; }

    [JsonProperty("logistic_type")]
    public string logistic_type { get; set; }

    [JsonProperty("store_pick_up")]
    public bool store_pick_up { get; set; }
}

public class Country
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }
}

public class State
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }
}

public class City
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }
}

public class SellerAddress
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("comment")]
    public string comment { get; set; }

    [JsonProperty("address_line")]
    public string address_line { get; set; }

    [JsonProperty("zip_code")]
    public string zip_code { get; set; }

    [JsonProperty("country")]
    public Country country { get; set; }

    [JsonProperty("state")]
    public State state { get; set; }

    [JsonProperty("city")]
    public City city { get; set; }

    [JsonProperty("latitude")]
    public string latitude { get; set; }

    [JsonProperty("longitude")]
    public string longitude { get; set; }
}

public class Value
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("struct")]
    public object estrutura { get; set; }

    [JsonProperty("source")]
    public object source { get; set; }
}

public class Attribute
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("value_id")]
    public string value_id { get; set; }

    [JsonProperty("value_name")]
    public string value_name { get; set; }

    [JsonProperty("value_struct")]
    public object value_struct { get; set; }

    [JsonProperty("attribute_group_id")]
    public string attribute_group_id { get; set; }

    [JsonProperty("attribute_group_name")]
    public string attribute_group_name { get; set; }

    [JsonProperty("values")]
    public IList<Value> values { get; set; }

    [JsonProperty("source")]
    public object source { get; set; }
}

public class DifferentialPricing
{

    [JsonProperty("id")]
    public int id { get; set; }
}

public class Result
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("site_id")]
    public string site_id { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("seller")]
    public Seller seller { get; set; }

    [JsonProperty("price")]
    public double price { get; set; }

    [JsonProperty("currency_id")]
    public string currency_id { get; set; }

    [JsonProperty("available_quantity")]
    public int available_quantity { get; set; }

    [JsonProperty("sold_quantity")]
    public int sold_quantity { get; set; }

    [JsonProperty("buying_mode")]
    public string buying_mode { get; set; }

    [JsonProperty("listing_type_id")]
    public string listing_type_id { get; set; }

    [JsonProperty("stop_time")]
    public DateTime stop_time { get; set; }

    [JsonProperty("condition")]
    public string condition { get; set; }

    [JsonProperty("permalink")]
    public string permalink { get; set; }

    [JsonProperty("thumbnail")]
    public string thumbnail { get; set; }

    [JsonProperty("accepts_mercadopago")]
    public bool accepts_mercadopago { get; set; }

    [JsonProperty("installments")]
    public Installments installments { get; set; }

    [JsonProperty("address")]
    public Address address { get; set; }

    [JsonProperty("shipping")]
    public Shipping shipping { get; set; }

    [JsonProperty("seller_address")]
    public SellerAddress seller_address { get; set; }

    [JsonProperty("attributes")]
    public IList<Attribute> attributes { get; set; }

    [JsonProperty("original_price")]
    public int? original_price { get; set; }

    [JsonProperty("category_id")]
    public string category_id { get; set; }

    [JsonProperty("official_store_id")]
    public int? official_store_id { get; set; }

    [JsonProperty("catalog_product_id")]
    public string catalog_product_id { get; set; }

    [JsonProperty("tags")]
    public IList<string> tags { get; set; }

    [JsonProperty("catalog_listing")]
    public bool catalog_listing { get; set; }

    [JsonProperty("differential_pricing")]
    public DifferentialPricing differential_pricing { get; set; }
}

public class Sort
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }
}

public class AvailableSort
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }
}

public class PathFromRoot
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }
}
public class Value1
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("path_from_root")]
    public IList<PathFromRoot> path_from_root { get; set; }
}

public class Filter
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("values")]
    public IList<Value> values { get; set; }
}

public class Value2
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("results")]
    public int results { get; set; }
}

public class AvailableFilter
{

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("values")]
    public IList<Value> values { get; set; }
}

public class Resultados
{

    [JsonProperty("site_id")]
    public string site_id { get; set; }

    [JsonProperty("query")]
    public string query { get; set; }

    [JsonProperty("paging")]
    public Paging paging { get; set; }

    [JsonProperty("results")]
    public IList<Result> results { get; set; }

    [JsonProperty("secondary_results")]
    public IList<object> secondary_results { get; set; }

    [JsonProperty("related_results")]
    public IList<object> related_results { get; set; }

    [JsonProperty("sort")]
    public Sort sort { get; set; }

    [JsonProperty("available_sorts")]
    public IList<AvailableSort> available_sorts { get; set; }

    [JsonProperty("filters")]
    public IList<Filter> filters { get; set; }

    [JsonProperty("available_filters")]
    public IList<AvailableFilter> available_filters { get; set; }
}

