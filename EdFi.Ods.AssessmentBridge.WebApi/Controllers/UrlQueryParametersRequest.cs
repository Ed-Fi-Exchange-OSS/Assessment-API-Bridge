namespace EdFi.Ods.Api.Services.Queries
{
    public class UrlQueryParametersRequest 
    {
        public int? Offset { get; set; }
        public int? Limit { get; set; }
        public string Q { get; set; }
    }
}
