using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Main.PL.Transformers.User
{
    public static class TUser
    {
        public static JObject Transform(DAL.Models.User item) {
            return new JObject {
                ["id"] = item.id,
                ["login"] = item.login,
                ["email"] = item.email,
                ["registerDate"] = item.register_date
            };
        }

        public static JArray TransformList(IEnumerable<DAL.Models.User> items) {
            JArray result = new JArray();

            foreach (var item in items) {
                result.Add(Transform(item));
            }

            return result;
        }
    }
}