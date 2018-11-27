using Main.BLL.Modules.Hash;
using Main.DAL.Models;

namespace Main.BLL.Modules.Auth
{
    public static class UAuth
    {
        public static bool CheckUserPassword(User user, string password) {
            return UHash.Encrypt(password) == user.password;
        }
        
        public static User UpdateUserPassword(User user, string password) {
            user.password = password;
            user.Save();
            return user.Refresh();
        }
    }
}