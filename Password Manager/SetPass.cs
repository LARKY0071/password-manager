using System;
using Microsoft.Win32;

namespace Password_Manager
{
    class SetPass
    {
        public static void SetPassword(string num, string pass)
        {
            RegistryKey hcu = Registry.CurrentUser;
            RegistryKey MyPasswords = hcu.CreateSubKey("Software\\PasswordManager\\MyPasswords");
            MyPasswords.SetValue(num , pass);
            MyPasswords.Close();
            hcu.Close();
        }
    }
}
