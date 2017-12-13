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

            double dblNoteM100 = 0;
            double dblNoteSaisieM100;
            double dblMoyenneM100;

            double dblNoteM101 = 0;
            double dblNoteSaisieM101;
            double dblMoyenneM101;

            double dblNoteM304 = 0;
            double dblNoteSaisieM304;
            double dblMoyenneM304;

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


            Console.Write("Combien de notes de module 100 voulez-vous insérer? : ");
            string strnbNoteM100 = Console.ReadLine();
            int iNbNoteM100 = Convert.ToInt32(strnbNoteM100);
            int iNoteResM100 = iNbNoteM100;

            do
            {
                Console.Write("Entrez votre note : ");
                string strSaisieM100 = Console.ReadLine();
                dblNoteSaisieM100 = Convert.ToDouble(strSaisieM100);

                dblNoteM100 += dblNoteSaisieM100;

                iNoteResM100 -= 1;

            }
            while (iNoteResM100 != 0);

            dblMoyenneM100 = dblNoteM100 / iNbNoteM100;


            Console.WriteLine("Votre moyenne est de {0}", dblMoyenneM100);


            Console.Write("Combien de notes de module 101 voulez-vous insérer? : ");
            string strnbNoteM101 = Console.ReadLine();
            int iNbNoteM101 = Convert.ToInt32(strnbNoteM101);
            int iNoteResM101 = iNbNoteM101;

            do
            {
                Console.Write("Entrez votre note : ");
                string strSaisieM101 = Console.ReadLine();
                dblNoteSaisieM101 = Convert.ToDouble(strSaisieM101);

                dblNoteM101 += dblNoteSaisieM101;

                iNoteResM101 -= 1;

            }
            while (iNoteResM101 != 0);

            dblMoyenneM101 = dblNoteM101 / iNbNoteM101;


            Console.WriteLine("Votre moyenne est de {0}", dblMoyenneM101);


            Console.Write("Combien de notes de module 304 voulez-vous insérer? : ");
            string strnbNoteM304 = Console.ReadLine();
            int iNbNoteM304 = Convert.ToInt32(strnbNoteM304);
            int iNoteResM304 = iNbNoteM304;

            do
            {
                Console.Write("Entrez votre note : ");
                string strSaisieM304 = Console.ReadLine();
                dblNoteSaisieM304 = Convert.ToDouble(strSaisieM304);

                dblNoteM304 += dblNoteSaisieM304;

                iNoteResM304 -= 1;

            }
            while (iNoteResM304 != 0);

            dblMoyenneM304 = dblNoteM304 / iNbNoteM304;


            Console.WriteLine("Votre moyenne est de {0}", dblMoyenneM304);


            Console.WriteLine("Atelier : {0}", dblMoyenneAt);
            Console.WriteLine("Français : {0}", dblMoyenneFr);
            Console.WriteLine("Math : {0}", dblMoyenneMa);
            Console.WriteLine("Physique : {0}", dblMoyennePhy);
            Console.WriteLine("Anglais : {0}", dblMoyenneAng);
            Console.WriteLine("Histoire : {0}", dblMoyenneHis);
            Console.WriteLine("Module 100 : {0}", dblMoyenneM100);
            Console.WriteLine("Module 101 : {0}", dblMoyenneM101);
            Console.WriteLine("Module 304 : {0}", dblMoyenneM304);
            Console.ReadLine();

            if (EstPromu(dblMoyenneAt, dblMoyenneFr,dblMoyenneMa,dblMoyennePhy,dblMoyenneAng,dblMoyenneHis))
            {
                Console.WriteLine("Vous êtes promu");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Vous êtes non-promu");
                Console.ReadLine();
            }
        }

        static bool EstPromu(double dblMoyenneAt, double dblMoyenneFr, double dblMoyenneMa, double dblMoyennePhy, double dblMoyenneAng, double dblMoyenneHis)
        {
            if (dblMoyenneAt < 4)
            {
                return false;
            }

            int iMoyennesInsuffisantes = 0;
            if (dblMoyenneFr < 4)
            {
                iMoyennesInsuffisantes++;
            }
            if (dblMoyenneMa < 4)
            {
                iMoyennesInsuffisantes++;
            }
            if (dblMoyennePhy < 4)
            {
                iMoyennesInsuffisantes++;
            }
            if (dblMoyenneAng < 4)
            {
                iMoyennesInsuffisantes++;
            }
            if (dblMoyenneHis < 4)
            {
                iMoyennesInsuffisantes++;
            }
            
            if (iMoyennesInsuffisantes > 2)
            {
                return false;
            }

            return true;
        }
    }
}
