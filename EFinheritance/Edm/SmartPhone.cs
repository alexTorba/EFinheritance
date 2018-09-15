using System.ComponentModel.DataAnnotations.Schema;

namespace EFinheritance
{
    [Table("SmartPhones")]
    public class SmartPhone : Phone
    {
        public string OS { get; set; }
    }
}