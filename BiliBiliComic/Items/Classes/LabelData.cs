using Newtonsoft.Json;

namespace BiliBiliComic.Item.Class;
 
public class LabelData
{
    [JsonProperty("styles")]
    public List<Style> Styles { get; set; }

    [JsonProperty("areas")]
    public List<Area> Areas { get; set; }

    [JsonProperty("status")]
    public List<Status> Status { get; set; }

    [JsonProperty("orders")]
    public List<Order> Orders { get; set; }

    [JsonProperty("prices")]
    public List<Price> Prices { get; set; }

    [JsonProperty("special")]
    public List<object> Special { get; set; }
}

public class Style
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public class Area
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public class Status
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public class Order
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public class Price
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}
