using Main.BLL.Core;
using Main.BLL.Core.Enums;

namespace Main.BLL.Controllers.Auth
{
    /// <summary>
    /// Core controller
    /// </summary>
    public static class CAuth
    {
        public static Response process(Request request) {

            switch (request.type) {
                case RequestType.Register:
                    return LAuth.Register(
                        request.data.Value<string>("login"),
                        request.data.Value<string>("password"),
                        request.data.Value<string>("email")
                    );
            }

            return new Response() {
                type = request.type,
                code = ReturnCode.BadRequest
            };
        }
    }
}