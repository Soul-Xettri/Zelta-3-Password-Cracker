using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brute_force
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brute_Click(object sender, EventArgs e)
        {

            {
                String password = Console.ReadLine();
                string attempt = "";
                int first = 0;
                int second = 0;
                int third = 0;
                int fourth = 0;
                int cracks = 0;
                string[] array = new string[27];
                array[0] = "";//first empty
                array[1] = "a";
                array[2] = "b";
                array[3] = "c";
                array[4] = "d";
                array[5] = "e";
                array[6] = "f";
                array[7] = "g";
                array[8] = "h";
                array[9] = "i";
                array[10] = "j";
                array[11] = "k";
                array[12] = "l";
                array[13] = "m";
                array[14] = "n";
                array[15] = "o";
                array[16] = "p";
                array[17] = "q";
                array[18] = "r";
                array[19] = "s";
                array[20] = "t";
                array[21] = "u";
                array[22] = "v";
                array[23] = "w";
                array[24] = "x";
                array[25] = "y";
                array[26] = "z";
                while (!attempt.Equals(password))
                {
                    if (first == array.Length)
                    {
                        second = second + 1;
                        first = 0;
                    }
                    if (second == array.Length)
                    {
                        third++;
                        second = 0;
                    }
                    if (third == array.Length)
                    {
                        fourth++;
                        third = 0;
                    }
                    if (fourth == array.Length)
                    {
                        break; //finished
                    }
                    attempt = array[fourth] + array[third] + array[second] + array[first];
                    list1.Items.Add(attempt);
                    first++;
                    cracks++;
                }
                Console.WriteLine(">Attempt to cracks " + cracks);
                Console.ReadLine();//just to showcase the result
            }
        }
    }
}


