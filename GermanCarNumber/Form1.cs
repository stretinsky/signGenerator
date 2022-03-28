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
        public Form1()
        {
            InitializeComponent();
            InitCustomLabelFont();
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

        private void GenerateAndShowNumber(object sender, EventArgs e)
        {
            string[] labelText = sequenceGenerator.CreateRandomNumber().Split(' ');
            label1.Text = labelText[0];
            label2.Text = labelText[1];
            label3.Text = labelText[2];
        }
    }
}
