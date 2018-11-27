using Main.BLL.Core.Enums;

namespace Main.BLL.Core
{
    public static class Processor
    {
        public static Response process(Request request) {
            
            return new Response() {
                type = request.type,
                code = ReturnCode.BadRequest
            };
        }
    }
}