using Main.BLL.Core.Enums;
using Newtonsoft.Json.Linq;

namespace Main.BLL.Core
{
    public class Request
    {
        public RequestType type = RequestType.None;
        public string token = "";
        public ushort serviceId = 0;
        public uint userId = 0;
        public JObject data = new JObject();
    }
}