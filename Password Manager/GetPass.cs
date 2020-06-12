using Microsoft.Win32;

namespace Password_Manager
{
    class GetPass
    {

        public static string GetPassword(string num)
        {
            string passWRD;
            RegistryKey hcu = Registry.CurrentUser;
            RegistryKey MyPasswords = hcu.OpenSubKey("Software\\PasswordManager\\MyPasswords");
            try
            {
                string p1 = (string)MyPasswords.GetValue(num);
                passWRD = p1;
            }
            catch
            {
                passWRD = "Пароль не установлен";
            }

            return passWRD;
        }

    }
}
