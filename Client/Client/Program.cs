/// Autores:    Rui Duarte 15831 | Carlos Silva 17028 | Daniel Silva  17637
/// Cadeira:    Integra��o de Sistemas de Informa��o
/// Curso:      LESI
/// Professor:  Lu�s Ferreira
/// Ano L�tivo: 2020/2021
/// Cliente da API TP2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            
        }
    }
}
