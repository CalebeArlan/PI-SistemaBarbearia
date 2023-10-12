using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Funcoes
    {
        public string teste = "teste";

        public static bool VerivicaVazio(Form formulario)
        {
            bool passou = false;
            foreach (Control c in formulario.Controls)
            {

                if (c is TextBox)
                {
                    TextBox textBox = (TextBox)c;
                    if (Convert.ToBoolean(string.IsNullOrWhiteSpace(textBox.Text)) && (passou == false))
                    {
                        MessageBox.Show("Deve-se preencher todos os campos vazios.");
                        passou = true;
                       
                    };
                }
                if (c is ComboBox)
                {
                    ComboBox combobox = (ComboBox)c;
                    if ((combobox.SelectedIndex == -1) && (passou == false))
                    {
                        MessageBox.Show("Deve-se preencher todos os campos vazios.");
                        passou = true;
  
                    }
                }
                
            }
            if(passou == true)
            {
                return true;
            }
            else { return false; }
        }

    }
}
