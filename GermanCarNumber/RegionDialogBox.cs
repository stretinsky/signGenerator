using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GermanCarNumber
{
    public partial class RegionDialogBox : Form
    {
        private List<string> regions = new List<string>();
        public RegionDialogBox()
        {
            InitializeComponent();
            InitComboBox();
        }
        private void InitComboBox()
        {
            comboBox1.Items.Add("Случайный");
            string[] lines = Properties.Resources.regions.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                int index = lines[i].IndexOf(':');
                regions.Add(lines[i].Substring(index + 1));
                comboBox1.Items.Add(regions[i]);
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        public void Close(object sender, EventArgs e)
        {
            Close();
        }
        private void ConfirmChanges(object sender, EventArgs e)
        {
            Form1 form = Owner as Form1;
            if (form != null)
            {
                form.region = comboBox1.SelectedItem.ToString();
            }
            Close();
        }
    }
}
