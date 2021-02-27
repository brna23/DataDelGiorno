using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bernabe.mattia._4j.dataDelGiorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Data t1= new Data();
            Data t2= new Data(2,3,1960);

            t1.formato = "GMA"; //Selezione formato stampa GMA->ITALIA / MGA->USA / AMG ->CINA
            Console.WriteLine("data: {0}", t1.ToString());

            t1.aggiungiGiorni(50);

            Console.WriteLine("data con giorni aggiunti: {0}", t1.ToString());
            Console.WriteLine("");

            t2.formato = "AMG"; //Selezione formato stampa GMA->ITALIA / MGA->USA / AMG ->CINA
            Console.WriteLine("data: {0}", t2.ToString());

            t2.aggiungiGiorni(50);

            Console.WriteLine("data con giorni aggiunti: {0}", t2.ToString());
            Console.WriteLine("");

            Console.WriteLine("Confronto: {0}", t1 == t2);

            Console.ReadLine();
        }
    }
    class Data
    {
        public int _giorno { get; set; }
        public int _mese { get; set; }
        public int _anno { get; set; }
        public string formato;

        int x=0;
        int y=0;
        public Data()
        {
            _giorno = 1;
            _mese = 1;
            _anno = 1900;
        }
        public Data(int gg, int mm, int aa)
        {
            _giorno = gg;
            _mese = mm;
            _anno = aa;
        }
        public void aggiungiGiorni(int plus)
        {
            if(x == 0 && _mese == 1 || _mese == 3 || _mese == 5 || _mese == 7 || _mese == 8 || _mese == 10 || _mese == 12)
            {
                if(plus > (31 - _giorno))
                {
                    plus = plus - (31 - _giorno);
                    if(_mese == 12)
                    {
                        _anno++;
                        _mese = 0;
                    }
                    _mese++;
                    _giorno = 0;
                    aggiungiGiorni(plus);
                }else
                    _giorno += plus;

                x = 1;
            }
            if (x == 0 && _mese == 4 || _mese == 6 || _mese == 9 || _mese == 11)
            {
                if (plus > (30 - _giorno))
                {
                    plus = plus - (30 - _giorno);
                    _mese++;
                    _giorno = 0;
                    aggiungiGiorni(plus);
                }else
                    _giorno += plus;

                x = 1;
            }
            if (x == 0 && _mese == 2)
            {
                if (plus > (28 - _giorno))
                {
                    plus = plus - (28 - _giorno);
                    _mese++;
                    _giorno = 0;
                    aggiungiGiorni(plus);
                }else
                    _giorno += plus;

                x = 1;
            }
        }

        public override string ToString()
        {
            string ris = "";
            if (formato == "GMA")
            {
                ris = $""+_giorno+"/"+_mese+"/"+_anno+"";
            }
            if (formato == "MGA")
            {
                ris = $"" + _mese + "/" + _giorno + "/" + _anno + "";
            }
            if (formato == "AMG")
            {
                ris = $"" + _anno + "/" + _mese + "/" + _giorno + "";
            }
            return ris;
        }
        public static string operator ==(Data t1, Data t2)
        {
            if (t1._giorno == t2._giorno && t1._mese == t2._mese && t1._anno == t2._anno)
                return "Le date sono uguali";
            else
                return "Le date non sono uguali";
        }
        public static string operator !=(Data t1, Data t2)
        {
            if (t1._giorno != t2._giorno && t1._mese != t2._mese && t1._anno != t2._anno)
                return "Le date sono diversi";
            else
                return "Le date sono uguali";
        }
        //public static string operator >(Data t1, Data t2)
        //{
        //    if(t1._anno>t2._anno)

        //}
        //public static string operator <(Data t1, Data t2)
        //{

        //}

        //public void togliGiorni(int minus)
        //{
        //    if (y == 0 && _mese == 1 || _mese == 3 || _mese == 5 || _mese == 7 || _mese == 8 || _mese == 10 || _mese == 12)
        //    {
        //        if()

        //        y = 1;
        //    }
        //    if (y == 0 && _mese == 4 || _mese == 6 || _mese == 9 || _mese == 11)
        //    {
        //        if (plus > (30 - _giorno))
        //        {
        //            plus = plus - (30 - _giorno);
        //            _mese++;
        //            _giorno = 0;
        //            togliGiorni(plus);
        //        }
        //        else
        //            _giorno += plus;

        //        y = 1;
        //    }
        //    if (y == 0 && _mese == 2)
        //    {
        //        if (plus > (28 - _giorno))
        //        {
        //            plus = plus - (28 - _giorno);
        //            _mese++;
        //            _giorno = 0;
        //            togliGiorni(plus);
        //        }
        //        else
        //            _giorno += plus;

        //        y = 1;
        //    }
        //}
    }

}
