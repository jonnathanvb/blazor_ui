using System.Text.Json.Serialization;

namespace app.Services.Dto.Chart
{
    public class Graph
    {

        public Chart chart { get; set; }
        public PlotOptions PlotOptions { get; set; }
        public List<Series> series { get; set; }
    }

    public class Chart
    {
        public string type { get; set; }
    }

    public class PlotOptions
    {
        public Bar Bar { get; set; }
    }

    public class Bar
    {
        public bool Horizontal { get; set; }
    }

    public class Series
    {
        public List<Data> Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("x")]
        public string Name { get; set; }
        [JsonPropertyName("y")]
        public decimal Valor { get; set; }
    }

}
