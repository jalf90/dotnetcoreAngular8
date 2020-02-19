using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace angular_dotnet_core.Controllers.Resources
{
    public class MakeResource
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }
        public MakeResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}