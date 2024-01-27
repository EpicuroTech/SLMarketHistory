using SplinterlandsMarketTrack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplinterlandsMarketTrack
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //inicia a aplicacao
            dataLayer.Iniciar();

            //Abre o nosso formulario inicial

            Application.Run(new Form1());
        }
    }
}
