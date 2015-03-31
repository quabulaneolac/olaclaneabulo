using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using quabulaneolac.Musique;

namespace RechecherConcert
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<int> id = LastfmAPI.getIdLieubyName("OTO");
            //List<Event> lesEvents = LastfmAPI.getIdLieubyName("OTO");
            foreach (int unEvent in id)
            {
                Console.WriteLine(unEvent);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmRechercheConcert());
        }
    }
}
