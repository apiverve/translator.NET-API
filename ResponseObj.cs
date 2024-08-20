using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("sourceLang")]
    public string sourceLang { get; set; }

    [JsonProperty("targetLang")]
    public string targetLang { get; set; }

    [JsonProperty("translatedText")]
    public string translatedText { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
