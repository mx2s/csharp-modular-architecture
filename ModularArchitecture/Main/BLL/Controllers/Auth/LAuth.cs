using Main.BLL.Core;
using Main.BLL.Core.Enums;
using Main.DAL.Models;
using Newtonsoft.Json.Linq;

namespace Main.BLL.Controllers.Auth
{
    public static class LAuth
    {
        public static Response Register(string login, string password, string email) {
            const RequestType requestType = RequestType.Register;

            if (User.FindByLogin(login) != null) {
                return new Response() {
                    type = requestType,
                    code = ReturnCode.Conflict,
                    data = new JObject() {
                        ["message"] = "User with same login already exists"
                    }
                };
            }
            
            // TODO: validate email
            
            if (User.FindByEmail(login) != null) {
                return new Response() {
                    type = requestType,
                    code = ReturnCode.Conflict,
                    data = new JObject() {
                        ["message"] = "User with same email already exists"
                    }
                };
            }

            return new Response() {
                type = requestType,
                code = ReturnCode.Success
            };
        }
    }
}