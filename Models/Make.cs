using System.Collections.ObjectModel;
using System.Collections.Generic;
namespace angular_dotnet_core.Models
{
    public class Make
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}