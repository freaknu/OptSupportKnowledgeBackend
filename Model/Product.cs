namespace optsupport.Model
{
    public class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; } = string.Empty;
        public string product_description { get; set; } = string.Empty;
        public string short_description { get; set; } = string.Empty;
        public string logo { get; set; } = string.Empty;
        public string path { get; set; } = string.Empty;
        public string product_image { get; set; } = string.Empty;
        public string moto { get; set; } = string.Empty;
        public string log { get; set; } = string.Empty;
        public bool isactive { get; set; } = true;
        public DateTime create_date { get; set; } = DateTime.Now;
        public int create_by { get; set; }
        public int modify_by { get; set; }
        public DateTime modify_date { get; set; }
        public string ip_address { get; set; } = string.Empty;
        public string unq_code { get; set; } = string.Empty;
    }
}