using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3000
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblNoteAt = 0;
            double dblNoteSaisieAt;
            double dblMoyenneAt;

            double dblNoteFr = 0;
            double dblNoteSaisieFr;
            double dblMoyenneFr;

            Console.Write("Combien de notes d'atelier voulez-vous insérer? : ");
            string strnbNoteAt = Console.ReadLine();
            int iNbNoteAt = Convert.ToInt32(strnbNoteAt);
            int iNoteResAt = iNbNoteAt;

            do
            {
                Console.Write("Entrez votre note : ");
                string strSaisieAt = Console.ReadLine();
                dblNoteSaisieAt = Convert.ToDouble(strSaisieAt);

                dblNoteAt += dblNoteSaisieAt;

                iNoteResAt -= 1;

            }
            while (iNoteResAt != 0);

            dblMoyenneAt = dblNoteAt / iNbNoteAt;


            Console.WriteLine("Votre moyenne est de {0}", dblMoyenneAt);
            Console.ReadLine();

            Console.Write("Combien de notes de français voulez-vous insérer? : ");
            string strnbNoteFr = Console.ReadLine();
            int iNbNoteFr = Convert.ToInt32(strnbNoteFr);
            int iNoteResFr = iNbNoteFr;

            do
            {
                Console.Write("Entrez votre note : ");
                string strSaisieFr = Console.ReadLine();
                dblNoteSaisieFr = Convert.ToDouble(strSaisieFr);

                dblNoteFr += dblNoteSaisieFr;

                iNoteResFr -= 1;

            }
            while (iNoteResFr != 0);

            dblMoyenneFr = dblNoteFr / iNbNoteFr;

            Console.WriteLine("Votre moyenne est de {0}", dblMoyenneFr);
            Console.ReadLine();
        }
    }
}
