using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBiblioteca.controle
{
    static class Registro
    {
        public static String lerRegistro(String caminho, String chave)
        {
            string path = @caminho;
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(path);
            if (registryKey != null && registryKey.GetValue(chave) != null)
                return registryKey.GetValue(chave).ToString();
            else return "";
        }

        public static void criaRegistro(String caminho, String chave, String valor)
        {
            Microsoft.Win32.RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@caminho);
            registryKey.SetValue(chave, valor);
            registryKey.Close();
        }
    }
}
