using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

/*
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|||||||||||||||||||||| Maciej Stępień       ||||||||||||||||||||||
|||||||||||||||||||||| UWM, ISI 3           ||||||||||||||||||||||
|||||||||||||||||||||| 2018r                ||||||||||||||||||||||
|||||||||||||||||||||| Sztuczna Inteligencja||||||||||||||||||||||
||||||||||||||||||||||"Algorytmy wyliczania ||||||||||||||||||||||
||||||||||||||||||||||   reguł decyzyjnych" ||||||||||||||||||||||
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    Kod jest nieco chaotyczny ze względu na pisanie go z ręki bez projektu.
*/

namespace DaneZPlikuOkienko
{
    public partial class DaneZPliku : Form
    {
        /*
         1. lsita ktore rozwazamy
         * .pokolei wiersze -> w p
         
         */
        //Potzrbne do wszystkich funkcji
        private string[][] systemDecyzyjny; 
        

        //Liczba kolumn i wierszy
        int Rows = 0;
        int Columns = 0;
        
        
        //Covering
        private string[][] NiewykorzystaneCovering;

        //Przechowuje informacje o regulach I rzedu do wyswietlenia
        List<RegulyIRzedu> RegI = new List<RegulyIRzedu>();
        List<RegulyIIRzedu> RegII = new List<RegulyIIRzedu>();

           public struct RegulyIRzedu
        {
            public int nKolumny;
            public int ilosc;      
            public string desc;
            public string decyzja;
            public RegulyIRzedu(int a, string b, string c)
            {

                this.ilosc = 1;
                this.nKolumny = a;
                this.desc = b;
                this.decyzja = c;
            }
        }
           public struct RegulyIIRzedu
           {
               public int nK1;
               public int nk2;

               public int ilosc; //1 default
               

               public string desc1;
               public string desc2;
                   
               public string decyzja;
               public int wiersz;
               public RegulyIIRzedu(int a1, int a2, string s1, string s2, int w , string s4)
               {

                   this.ilosc = 1;

                   this.nK1 = a1;
                   this.nk2 = a2;
                                      
                   this.desc1 = s1;
                   this.desc2 = s2;

                   this.wiersz = w;
                   this.decyzja = s4;
               }
           }
        public DaneZPliku()
        {
            InitializeComponent();
        }

        private void btnWybierzPlik_Click(object sender, EventArgs e)
        {
            DialogResult wynikWyboruPliku = ofd.ShowDialog(); // wybieramy plik
            if (wynikWyboruPliku != DialogResult.OK)
                return;

            tbSciezkaDoSystemuDecyzyjnego.Text = ofd.FileName;
            string trescPliku = System.IO.File.ReadAllText(ofd.FileName); // wczytujemy treść pliku do zmiennej
            string[] wiersze = trescPliku.Trim().Split(new char[] { '\n' }); // treść pliku dzielimy wg znaku końca linii, dzięki czemu otrzymamy każdy wiersz w oddzielnej komórce tablicy
            systemDecyzyjny = new string[wiersze.Length][];   // Tworzymy zmienną, która będzie przechowywała wczytane dane. Tablica będzie miała tyle wierszy ile wierszy było z wczytanego poliku
            Rows = wiersze.GetLength(0);

            for (int i = 0; i < wiersze.Length; i++)
            {
                string wiersz = wiersze[i].Trim();     // przypisuję i-ty element tablicy do zmiennej wiersz
                string[] cyfry = wiersz.Split(new char[] { ' ' });   // dzielimy wiersz po znaku spacji, dzięki czemu otrzymamy tablicę cyfry, w której każda oddzielna komórka to czyfra z wiersza
                systemDecyzyjny[i] = new string[cyfry.Length];    // Do tablicy w której będą dane finalne dokładamy wiersz w postaci tablicy integerów tak długą jak długa jest tablica cyfry, czyli tyle ile było cyfr w jednym wierszu
                Columns = cyfry.GetLength(0);
                for (int j = 0; j < cyfry.Length; j++)
                {
                    string cyfra = cyfry[j].Trim(); // przypisuję j-tą cyfrę do zmiennej cyfra
                    systemDecyzyjny[i][j] = cyfra;  
                }
            }

            tbSystemDecyzyjny.Text = TablicaDoString(systemDecyzyjny);


            
        }

        public string TablicaDoString<T>(T[][] tab)
        {
            string wynik = "";
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    wynik += tab[i][j].ToString() + " ";
                }
                wynik = wynik.Trim() + Environment.NewLine;
            }

            return wynik;
        }


        public double StringToDouble(string liczba)
        {
            double wynik; liczba = liczba.Trim();
            if (!double.TryParse(liczba.Replace(',', '.'), out wynik) && !double.TryParse(liczba.Replace('.', ','), out wynik))
                throw new Exception("Nie udało się skonwertować liczby do double");

            return wynik;
        }


        public int StringToInt(string liczba)
        {
            int wynik;
            if (!int.TryParse(liczba.Trim(), out wynik))
                throw new Exception("Nie udało się skonwertować liczby do int");

            return wynik;
        }


        


        private void btnStart_Click(object sender, EventArgs e)
        {
            
            // Przykład konwersji string to double 
            //string sLiczbaDouble = "1.5";
            //double dsLiczbaDouble = StringToDouble(sLiczbaDouble);

            // Przykład konwersji string to int 
            //string sLiczbaInt = "1";
            //int iLiczbaInt = StringToInt(sLiczbaInt);

            /******************  *********************************/


                


                //Czyszczenie
                tbCoverI.Text = "";
                tbCoverRegulyII.Text = "";
                tbCoverRegulyI.Text = "";
                tbCoverRegulyII.Text = "";

                NiewykorzystaneCovering = systemDecyzyjny; // Kopia systemu
                RegI = new List<RegulyIRzedu>();
                RegII = new List<RegulyIIRzedu>();
                tbCoverI.Text = "";
                 tbCoverRegulyI.Text = "";
                 tbCoverRegulyII.Text = "";
            
                //Covering sequence
                Covering();
                ShowCoveringI();
                ShowCoveringII();
                //
                //Exhaust();
                //LEM2();


                


            
        }
        ///systemDecyzyjny[wiersz][kolumna]
        //systed[][6] = 1 albo 0


        //Covering 
        void Covering()
        {
            IRzad();
            IIRzad();
        }

        void IRzad()
        {
            string deskrybtor;
            //string odpowiedzi;
            //Pokolei kolumnami 

            for (int i = 0; i < Columns -1; i++)
            {

                for (int j = 0; j < Rows; j++)
                {

                    //Zapisuje aktualny deskrybtor
                    deskrybtor = systemDecyzyjny[j][i];
                    
                    //Sprawdza czy wystepuje taki w tej kolumnie
                    f1(deskrybtor, j, i);

                }





            }
            
           
            
        }

        void f1(string desk, int wiersz, int kolumna)
        {
            int w; //tymczasowa
            bool deleteAll = false;
            
            for ( w = wiersz ; w< Rows; w++)
            {
                

                if (NiewykorzystaneCovering[w][kolumna] == desk)
                {
                    if (NiewykorzystaneCovering[w][Columns - 1] != NiewykorzystaneCovering[wiersz][Columns - 1])
                        deleteAll = true;

                    


                }

            }
            //Zapisuje ile razy sie nie zgadzalo ??
            
            //jezeli znajdzie nie zgodne usuwa tez deksyptor
            if(deleteAll)
            for (w = wiersz; w < Rows; w++)
            {


                if (NiewykorzystaneCovering[w][kolumna] == desk)
                {
                    NiewykorzystaneCovering[w][kolumna] = "X";
                    
                }

            }

        }


        //Wyswietla dane //zmienic trzeba nazwe na jakas norlamna
        
        void ShowCoveringI()
        {
            
            //Wyswietl tablice
            for (int i = 0; i < Rows; i++)
            {

                for (int j = 0; j < Columns ; j++)
                {
                    
                    tbCoverI.Text += NiewykorzystaneCovering[i][j] + " ";
                    if(j < Columns -1)
                    if(NiewykorzystaneCovering[i][j] != "X" )
                    {
                        //Sprawdza czy istanija jakie kolwiek zapisane juz 
                        if (RegI.Exists(x => x.nKolumny == j && x.desc == NiewykorzystaneCovering[i][j]))
                        {
                            RegulyIRzedu result = RegI.Find(x => x.nKolumny == j && x.desc == NiewykorzystaneCovering[i][j]);
                            RegI.RemoveAt(RegI.FindIndex(x => x.nKolumny == j && x.desc == NiewykorzystaneCovering[i][j]));
                            result.ilosc += 1;
                            RegI.Add(result);
                            
                        }
                            
                        else
                            RegI.Add(new RegulyIRzedu(j, NiewykorzystaneCovering[i][j], NiewykorzystaneCovering[i][Columns - 1]));
                    }

                }

                tbCoverI.Text += Environment.NewLine;
                
            }


            //Wyswietl zgodne reguły

            tbCoverRegulyI.Text += "Jest " + RegI.Count +" reguł I rzędu..." + Environment.NewLine;


            //Test
            RegI.Sort((x, y) => x.nKolumny.CompareTo(y.nKolumny));
            foreach (var k in RegI)
            {
                tbCoverRegulyI.Text += "(a" + k.nKolumny + " = " + k.desc + ") => (d = "+ k.decyzja +") [" + k.ilosc + "]" + Environment.NewLine;
            }
            
        }
        void IIRzad()
        {
            

            //sprawdza czy 2 kolejne deskrybtory daja decyzje 1
            
            //string odpowiedzi;
            //Pokolei kolumnami 

            for (int i = 0; i < Rows; i++)
            {   
                bool deskI = false;
                bool deskII = false;
                string deskrybtorI = "";
                string deskrybtorII = "";
                int desk1Index = 0;
                int desk2Index = 0;

                

                for (int j = 0; j < Columns - 1; j++)
                {
                    

                    



                    //Sprawdza czy wystepuje taki w tej kolumnie
                    if (NiewykorzystaneCovering[i][j] != "X")
                    {
                        if (deskI)
                        {
                            deskrybtorII = NiewykorzystaneCovering[i][j];
                            deskII = true;
                            desk2Index = j;
                        }
                        else
                        {
                            deskI = true;
                            deskrybtorI = NiewykorzystaneCovering[i][j];
                            desk1Index = j;

                        }
                       
                            
                    }


                    //Wersja z ?
                    /*if (deskII)
                    {
                        //sprawdza czy zostal juz dodany do listyz tego wiersza regula

                        if (RegII.Exists(x => x.nK1 == desk1Index && x.nk2 == desk2Index ))
                        {
                            tbCoverII.Text += "chuj" + desk1Index + desk2Index;
                        }
                        else
                        {
                            RegII.Add(new RegulyIIRzedu(desk1Index, desk2Index, deskrybtorI, deskrybtorII,i, NiewykorzystaneCovering[i][Columns - 1]));
                        }

                        deskI = false;
                        deskII = false;
                        break;
                    }*/



                    //Wersja bez, jak znajduje wpisuje
                    if (deskII)
                    {
                        //sprawdza czy zostal juz dodany do listyz tego wiersza regula

                        
                        RegII.Add(new RegulyIIRzedu(desk1Index, desk2Index, deskrybtorI, deskrybtorII, i, NiewykorzystaneCovering[i][Columns - 1]));
                        

                        deskI = false;
                        deskII = false;
                        break;
                    }
                }





            }



            //Wyswietl znalezione

            





        }

        void ShowCoveringII()
        {
            tbCoverRegulyII.Text += "Jest " + RegII.Count + " reguł II rzędu..." + Environment.NewLine;
            foreach (var k in RegII)
            {
                tbCoverRegulyII.Text += "o" + k.wiersz + " (a" + k.nK1 + " = " + k.desc1 + ") ^ (a" + k.nk2 + " = " + k.desc2 +") => (d = "+ k.decyzja + ") ["+k.ilosc +"]"+ Environment.NewLine;
                //tbCoverRegulyI.Text += "(a" + k.nKolumny + " = " + k.desc + ") => (d = "+ k.decyzja +") [" + k.ilosc + "]" + Environment.NewLine;
            }
        }
        void Exhaust()
        {

        }

        void LEM2()
        {


        }

        
    }
}
