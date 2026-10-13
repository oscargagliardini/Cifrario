using System.Reflection.Metadata;

namespace Cifrario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arraydecifrate = new string[8];
            int i = 0;
            string nfile = "parole.txt";
            string alfabeto =  "abcdefghijkmnopqrstuvwxyz" ;
            if (File.Exists(nfile))
            {
                
                using (StreamReader sr = new StreamReader(nfile))
                {
                    string[] leggere = new string[nfile.Length];
                    while (sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        leggere[i] = line;
                        i++;
                    }
                    int q = 1;
                    for (int j = 0; j < leggere.Length; j++)
                    {
                        if (q % 2 == 0)
                        {
                            string cifrata = "";
                            string  f1= leggere[j];
                            for (int k = 0; k < f1.Length; k++)
                            {
                                for (int l = 0;l<alfabeto.Length; l++)
                                {
                                    if (f1[k] == alfabeto[l])
                                    {
                                       
                                        cifrata = cifrata+ alfabeto[l - 3];
                                        arraydecifrate[j] = cifrata;
                                    }
                                }
                            }
                        }
                        q++;
                    }
                }
                
            }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
