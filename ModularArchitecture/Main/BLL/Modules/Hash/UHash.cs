using System;

namespace Main.BLL.Modules.Hash
{
    public static class UHash
    {
        public static string GenGuid() {
            return Guid.NewGuid().ToString();
        }
    }
}