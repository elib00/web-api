using System.ComponentModel.DataAnnotations;

namespace web_api.Models
{
    public class User
    {
        [Key] //can be ommitted, for readability
        public int Id { get; set; }
        public string Name { get; set; }
        public string SensitiveInfo { get; set; }
    }
}
