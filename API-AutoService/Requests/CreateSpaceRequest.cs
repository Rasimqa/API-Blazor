namespace API_BlazorForSome.Requests
{
    public class CreateSpaceRequest
    {
        public int id { get; set; }
        public string NameSpace { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Square { get; set; }
    }
}
