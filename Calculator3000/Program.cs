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

            double dblNoteMa = 0;
            double dblNoteSaisieMa;
            double dblMoyenneMa;

            double dblNotePhy = 0;
            double dblNoteSaisiePhy;
            double dblMoyennePhy;

            double dblNoteAng = 0;
            double dblNoteSaisieAng;
            double dblMoyenneAng;

            double dblNoteHis = 0;
            double dblNoteSaisieHis;
            double dblMoyenneHis;

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

            Console.Write("Combien de notes de math voulez-vous insérer? : ");
            string strnbNoteMa = Console.ReadLine();
            int iNbNoteMa = Convert.ToInt32(strnbNoteMa);
            int iNoteResMa = iNbNoteMa;


            do
            {
                Console.Write("Entrez votre note : ");
                string strSaisieMa = Console.ReadLine();
                dblNoteSaisieMa = Convert.ToDouble(strSaisieMa);

                dblNoteMa += dblNoteSaisieMa;

                iNoteResMa -= 1;

            }
            while (iNoteResMa != 0);

            dblMoyenneMa = dblNoteMa / iNbNoteMa;

            Console.WriteLine("Votre moyenne de math est de {0}", dblMoyenneMa);
            Console.ReadLine();

            Console.Write("Combien de notes de physique voulez-vous insérer? : ");
            string strnbNotePhy = Console.ReadLine();
            int iNbNotePhy = Convert.ToInt32(strnbNotePhy);
            int iNoteResPhy = iNbNotePhy;


            do
            {
                Console.Write("Entrez votre note : ");
                string strSaisiePhy = Console.ReadLine();
                dblNoteSaisiePhy = Convert.ToDouble(strSaisiePhy);

                dblNotePhy += dblNoteSaisiePhy;

                iNoteResPhy -= 1;

            }
            while (iNoteResPhy != 0);

            dblMoyennePhy = dblNotePhy / iNbNotePhy;

            Console.WriteLine("Votre moyenne est de {0}", dblMoyennePhy);
            Console.ReadLine();

            Console.Write("Combien de notes d'anglais voulez-vous insérer? : ");
            string strnbNoteAng = Console.ReadLine();
            int iNbNoteAng = Convert.ToInt32(strnbNoteAng);
            int iNoteResAng = iNbNoteAng;

            do
            {
                Console.Write("Entrez votre note : ");
                string strSaisieAng = Console.ReadLine();
                dblNoteSaisieAng = Convert.ToDouble(strSaisieAng);

                dblNoteAng += dblNoteSaisieAng;

                iNoteResAng -= 1;

            }
            while (iNoteResAng != 0);

            dblMoyenneAng = dblNoteAng / iNbNoteAng;


            Console.WriteLine("Votre moyenne est de {0}", dblMoyenneAng);
            Console.ReadLine();

            Console.Write("Combien de notes d'histoire voulez-vous insérer? : ");
            string strnbNoteHis = Console.ReadLine();
            int iNbNoteHis = Convert.ToInt32(strnbNoteHis);
            int iNoteResHis = iNbNoteHis;

            do
            {
                Console.Write("Entrez votre note : ");
                string strSaisieHis = Console.ReadLine();
                dblNoteSaisieHis = Convert.ToDouble(strSaisieHis);

                dblNoteHis += dblNoteSaisieHis;

                iNoteResHis -= 1;

            }
            while (iNoteResHis != 0);

            dblMoyenneHis = dblNoteHis / iNbNoteHis;


            Console.WriteLine("Votre moyenne est de {0}", dblMoyenneHis);
            Console.ReadLine();
        }
    }
}
