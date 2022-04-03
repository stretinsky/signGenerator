using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GermanCarNumber
{
    public partial class Form1 : Form
    {
        //Create your private font collection object.
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private SequenceGenerator sequenceGenerator = new SequenceGenerator();
        private Dictionary<string, string> regions = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            InitCustomLabelFont();
            InitComboBox();
        }
        public void InitCustomLabelFont()
        {
            //Select your font from the resources.
            //My font here is "FE_FONT.ttf"
            int fontLength = Properties.Resources.FE_FONT.Length;
            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.FE_FONT;
            // create an unsafe memory block for the font data
            System.IntPtr data = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontLength);
            // copy the bytes to the unsafe memory block
            System.Runtime.InteropServices.Marshal.Copy(fontdata, 0, data, fontLength);
            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            label1.Font = new Font(pfc.Families[0], 57);
            label2.Font = new Font(pfc.Families[0], 57);
            label3.Font = new Font(pfc.Families[0], 57);
        }
        public void InitComboBox()
        {
            comboBox1.Items.Add("None");
            string[] lines = Properties.Resources.regions.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                int index = lines[i].IndexOf(':');
                regions[lines[i].Substring(index + 1)] = lines[i].Substring(0, index);
                comboBox1.Items.Add(lines[i].Substring(index + 1));
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void GenerateRandomNumber(object sender, EventArgs e)
        {
            string[] labelText = comboBox1.SelectedItem.Equals("None") ?
                sequenceGenerator.CreateRandomNumber().Split(' ') : 
                sequenceGenerator.CreateRandomNumber(regions[(string)comboBox1.SelectedItem]).Split(' ');
            label1.Text = labelText[0];
            label2.Text = labelText[1];
            label3.Text = labelText[2];
        }

        private void GenerateNextNumber(object sender, EventArgs e)
        {
            string number = comboBox1.SelectedItem.Equals("None") ? sequenceGenerator.CreateNextNumber() :
                sequenceGenerator.CreateNextNumber(regions[(string)comboBox1.SelectedItem]);
            if (number == null)
            {
                MessageBox.Show("Номер является крайним");
            }
            else
            {
                string[] labelText = number.Split(' ');
                label1.Text = labelText[0];
                label2.Text = labelText[1];
                label3.Text = labelText[2];
            }
        }

        private void GeneratePreviousNumber(object sender, EventArgs e)
        {
            string number = comboBox1.SelectedItem.Equals("None") ? sequenceGenerator.CreatePreviousNumber() :
                sequenceGenerator.CreatePreviousNumber(regions[(string)comboBox1.SelectedItem]);
            if (number == null)
            {
                MessageBox.Show("Номер является крайним");
            }
            else
            {
                string[] labelText = number.Split(' ');
                label1.Text = labelText[0];
                label2.Text = labelText[1];
                label3.Text = labelText[2];
            }
        }
    }
}
