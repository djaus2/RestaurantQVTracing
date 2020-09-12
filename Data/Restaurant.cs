using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TableTracewithQRCode.Data
{
    public class Restaurant
    {

        [Key]
        [Column("Id")]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        [JsonPropertyName("Name")]
        public string Name { get; set; }
		
		[Column("PhoneNumber")]
        [Required]
        [JsonPropertyName("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("ImagePath")]
        [JsonPropertyName("ImagePath")]
        public string ImagePath { get; set; }

        [Column("Image")]
        [JsonPropertyName("Image")]
        public string Image { get; set; }

        [Column("TablesCSV")]
        [JsonPropertyName("TablesCSV")]
        public string TablesCSV { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<int> Tables { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<QRTable> QRTables { get; set; } = null;

        [Column("bitly")]
        [JsonPropertyName("bitly")]
        public string bitly { get; set; }

        [Column("ContactName")]
        [JsonPropertyName("ContactName")]
        public string ContactName { get; set; }

        [Column("Street")]
        [JsonPropertyName("Street")]
        public string Street { get; set; }

        [Column("Suburb")]
        [JsonPropertyName("Suburb")]
        public string Suburb { get; set; }

        [Column("PostCode")]
        [JsonPropertyName("PostCode")]
        public string PostCode { get; set; }

        [Column("State")]
        [JsonPropertyName("State")]
        public string State { get; set; } = "VIC";

        [Column("Country")]
        [JsonPropertyName("Country")]
        public string Country { get; set; } = "Australia";

        [Column("Web")]
        [JsonPropertyName("Web")]
        public string Web { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool Begin { get { return true; } }

        [NotMapped]
        [JsonIgnore]
        public bool End { get { return true; } }
    }

    public class QRTable
    {
        public string Name { get; set; }
        public int Table { get; set; }
        public string InputText { get; set; }
        public string QRCode { get; set; }
        public string BitLy { get; set; }
        public bool Begin { get { return true; } }
        public bool End { get { return true; } }
    }
}
