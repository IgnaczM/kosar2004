using System;
using System.IO;
using System.Collections.Generic;

namespace kosar2004
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> hazai = new List<string>();
            List<string> idegen = new List<string>();
            List<int> hazai_pont = new List<int>();
            List<int> idegen_pont = new List<int>();
            List<string> helyszin = new List<string>();
            List<string> időpont = new List<string>();

            StreamReader olvas = new StreamReader("eredmenyek.csv");

            olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                string[] vag = olvas.ReadLine().Split(";");
                hazai.Add(vag[0]);
                idegen.Add(vag[1]);
                hazai_pont.Add(Convert.ToInt32(vag[2]));
                idegen_pont.Add(Convert.ToInt32(vag[3]));
                helyszin.Add(vag[4]);
                időpont.Add(vag[5]);          
            }
            olvas.Close();


            int hazaimecss = 0;
            int idegenmeccs = 0;
            for (int i = 0; i < hazai.Count; i++)
            {
                if (hazai[i]=="Real Madrid")
                {
                    hazaimecss++;
                }
            }
            for (int i = 0; i < idegen.Count; i++)
            {
                if (idegen[i] == "Real Madrid")
                {
                    idegenmeccs++;
                }
            }
            Console.WriteLine("3.feladat:Real Madrid: Hazai: {0}, Idegen: {1}",hazaimecss,idegenmeccs);

            bool dontetlenVolt = false;

            for (int i = 0; i < hazai_pont.Count; i++)
            {
                if (hazai_pont[i]==idegen_pont[i])
                {
                    dontetlenVolt = true;
                    break;
                }
            }
            Console.Write("4.feladat: Volt döntetlen? ");
            if (dontetlenVolt)
            {
                Console.WriteLine("Igen");

            }
            else
            {
                Console.WriteLine("Nem");
            }

            for (int i = 0; i < hazai.Count; i++)
            {
                if (hazai[i].Contains("Barcelona"))
                {
                    Console.WriteLine("5.feladat: barcelonai csapat neve: {0}",hazai[i]);
                    break;
                }
            }
            Console.WriteLine("6.feladat");
            for (int i = 0; i < hazai.Count; i++)
            {
                if (időpont[i]=="2004-11-21")
                {
                    Console.WriteLine($"\t{hazai[i]} {idegen[i]} ({hazai_pont[i]}:{idegen_pont[i]})");
                }
            }


            List<string> staidon = new List<string>();
            List<int> merkozesSzam = new List<int>();

            for (int i = 0; i < helyszin.Count; i++)
            {
                if (!staidon.Contains( helyszin[i]))
                {
                    staidon.Add(helyszin[i]);
                }
                
            }
            
            for (int i = 0; i < staidon.Count; i++)
            {
                int db = 0;
                for (int k = 0; k < helyszin.Count; k++)
                {
                    if (staidon[i]==helyszin[k])
                    {
                        db++;
                    }
                }
                merkozesSzam.Add(db);
            }

            Console.WriteLine("7.feladat");
            for (int i = 0; i < merkozesSzam.Count; i++)
            {
                if (merkozesSzam[i]>20)
                {
                    Console.WriteLine("\t{0} {1}",staidon[i],merkozesSzam[i]);
                }
            }





        }
    }
}
