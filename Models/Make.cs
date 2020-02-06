using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace angular_dotnet_core.Models
{
    public class Make
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}