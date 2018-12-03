using Newtonsoft.Json;

namespace Troopers
{
    public class Trooper
    {        
        public int Id { get; set; }
     
        [JsonProperty("first_name")]        
        public string Name { get; set; }

        public int Accuracy { get; set; }
    }
}
