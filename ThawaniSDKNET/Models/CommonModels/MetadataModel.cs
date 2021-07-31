using System.ComponentModel.DataAnnotations;

namespace ThawaniSDKNET.Models.CommonModels
{
    public class MetadataModel
    {
        [Required]
        public string customer_name { get; set; }
        [Required]
        [EmailAddress]
        public string customer_email { get; set; }
        [Required]
        [Phone]
        public string customer_phone { get; set; }
        public string customer_id { get; set; } = "";
        public string order_id { get; set; } = "";
    }
}
