using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_P_Flip_coin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            string resultToBox = "";
            int a;
            int headCounts = 0;
            int tailCounts = 0;
            try
            {
                a = int.Parse((string)flipCounts.SelectedItem);
            }
            catch (ArgumentNullException)
            {
                flipCounts.SelectedItem = "1";
                a = 1;
            }
            string[] finalResult = GiveResults(a);
            for(int j = 0; j < finalResult.Length; j++)
            {
                resultToBox += finalResult[j];
                resultToBox += "\r\n";
                if(finalResult[j] == "Heads")
                {
                    headCounts++;
                }
                else
                {
                    tailCounts++;
                }
            }
            resultBox.Text = resultToBox;
            label1.Text = $"H = {headCounts}\r\nT = {tailCounts}";
        }

        private string[] GiveResults(int count)
        {
            string[] results; // can reference any array of strings

            results = new string[count]; // allocating memory for count strings in array
            for (int i = 0; i < count; i++)
            {
                results[i] = RandomFlip();
            }
            return results;
        }

        private string RandomFlip()
        {
            var randomNumber = (new Random()).Next(1, 1000);
            if (randomNumber >= 500)
            {
                return "Heads";
            }
            else
            {
                return "Tails";
            }
        }
    }
}
