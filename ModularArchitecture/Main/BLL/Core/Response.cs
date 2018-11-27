using Main.BLL.Core.Enums;
using Newtonsoft.Json.Linq;

namespace Main.BLL.Core
{
    public class Response
    {
        public RequestType type = RequestType.None;
        public ReturnCode code = ReturnCode.None;
        public JObject data = new JObject();
    }
}