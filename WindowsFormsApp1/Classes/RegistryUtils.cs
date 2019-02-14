using Microsoft.Win32;
using System;


namespace STS_Berlin_Privacy.Classes
{

    public class RegistryDeleter
    {

        private RegistryKey Key { get => Key; set => Key = value; }  
        private string Keyvalue { get => Keyvalue; set => Keyvalue = value; }
        private string KeyPath { get => KeyPath; set => KeyPath = value; }

        public RegistryDeleter()
        {
            KeyPath = @"Software\Microsoft\Windows\blablabla"; //default

        }

        private void removeRegistryKeyValue() {

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(KeyPath, true))
            {
                if (key == null)
                {
                    Console.WriteLine("Error with registry key:" + key);
                }
                else
                {
                    key.DeleteValue(Keyvalue);
                }
            }
        }
        private void removeRegistryKey()
        {

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(KeyPath, true))
            {
                if (key == null)
                {
                    Console.WriteLine("Error with registry key:" + key);
                }
                else
                {
                    key.DeleteSubKey(KeyPath);
                }
            }
        }
        private void removeRegistryKeyTree()
        {

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(KeyPath, true))
            {
                if (key == null)
                {
                    Console.WriteLine("Error with registry key:" + key);
                }
                else
                {
                    key.DeleteSubKeyTree(KeyPath);
                }
            }
        }
    }
}
