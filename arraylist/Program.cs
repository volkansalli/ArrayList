using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste=new ArrayList();
            List<int> sayilar=new List<int>();

            List<string> renkler=new List<string>();
            renkler.Add("kırmızı");          
            renkler.Add("yeşil");          
            renkler.Add("mavi");          
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            string[] hayvanlar={"aslan","kaplan","fil"};
            
            List<string> şehirler=new List<string>(){"istanbul","ankara","adana","izmir"};
            liste.AddRange(hayvanlar);
            liste.AddRange(şehirler);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            ArrayList voli=new ArrayList();
            voli.AddRange(sayilar);
            foreach (var x in voli)
            {
                Console.WriteLine(x);
            }
            voli.Reverse();
            foreach (var x in voli)
            {
                Console.WriteLine(x);
            }
            voli.Sort();
            foreach (var x in voli)
            {
                Console.WriteLine(x);
            }



        }
    }
}
