using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace GermanCarNumber
{
    public partial class Form1 : Form
    {
        //Create your private font collection object.
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private SequenceGenerator sequenceGenerator = new SequenceGenerator();
        private Dictionary<string, string> regions = new Dictionary<string, string>();
        public string region = "Случайный";
        public Form1()
        {
            InitializeComponent();
            InitCustomLabelFont();
            string[] lines = Properties.Resources.regions.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                int index = lines[i].IndexOf(':');
                regions[lines[i].Substring(index + 1)] = lines[i].Substring(0, index).Replace("Ü", "ü").Replace("Ö", "ö");
            }
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

            regionLabel.Font = new Font(pfc.Families[0], 57);
            lettersLabel.Font = new Font(pfc.Families[0], 57);
            numbersLabel.Font = new Font(pfc.Families[0], 57);
        }

        private void GenerateRandomNumber(object sender, EventArgs e)
        {
            string[] labelText = region.Equals("Случайный") ?
                sequenceGenerator.CreateRandomNumber().Split(' ') :
                sequenceGenerator.CreateRandomNumber(regions[region]).Split(' ');
            regionLabel.Text = labelText[0];
            lettersLabel.Text = labelText[1];
            numbersLabel.Text = labelText[2];
            AddToDB();
        }
        private void CheckNumberInDB()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = generator.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand($"EXISTS(SELECT id FROM carNumbers WHERE name='{regionLabel.Text + lettersLabel.Text + numbersLabel.Text}')"))
                {
                    if (false)
                        MessageBox.Show("номер существует");
                }
            }
        }
        private void AddToDB()
        {
            CheckNumberInDB();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = generator.db;Version=3;"))
            {

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand($"INSERT OR IGNORE INTO carNumbers (carNumber) VALUES ('{regionLabel.Text + lettersLabel.Text + numbersLabel.Text}');", connection))
                {
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }

        private void GenerateNextNumber(object sender, EventArgs e)
        {
            string number = region.Equals("Случайный") ? sequenceGenerator.CreateNextNumber() :
                sequenceGenerator.CreateNextNumber(regions[region]);
            if (number == null)
            {
                MessageBox.Show("Номер является крайним");
            }
            else
            {
                string[] labelText = number.Split(' ');
                regionLabel.Text = labelText[0];
                lettersLabel.Text = labelText[1];
                numbersLabel.Text = labelText[2];
            }
            AddToDB();
        }

        private void GeneratePreviousNumber(object sender, EventArgs e)
        {
            string number = region.Equals("Случайный") ? sequenceGenerator.CreatePreviousNumber() :
                sequenceGenerator.CreatePreviousNumber(regions[region]);
            if (number == null)
            {
                MessageBox.Show("Номер является крайним");
            }
            else
            {
                string[] labelText = number.Split(' ');
                regionLabel.Text = labelText[0];
                lettersLabel.Text = labelText[1];
                numbersLabel.Text = labelText[2];
                AddToDB();
            }
        }

        private void OpenDialogBox(object sender, EventArgs e)
        {
            RegionDialogBox f2 = new RegionDialogBox();
            f2.ShowDialog(this);
        }
    }
}
