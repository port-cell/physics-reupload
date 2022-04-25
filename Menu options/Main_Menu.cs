using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Menu_options
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        public class Num_Orbitals
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public Num_Orbitals SelectedNum_Orbitals
        {
            get
            {
                return (Num_Orbitals)cboNum_Orbitals.SelectedItem;
            }
        }

        public class Num_Celestial_Bodies
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public Num_Celestial_Bodies SelectedNum_Celestial_Bodies
        {
            get
            {
                return (Num_Celestial_Bodies)cboNum_Celestial_Bodies.SelectedItem;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Particals_Menu_Load(object sender, EventArgs e)
        {
            List<Num_Orbitals> Number_Orbitals = new List<Num_Orbitals>();

            Number_Orbitals.Add(new Num_Orbitals() { ID = 1, Name = "1" });
            Number_Orbitals.Add(new Num_Orbitals() { ID = 2, Name = "2" });
            Number_Orbitals.Add(new Num_Orbitals() { ID = 3, Name = "3" });
            Number_Orbitals.Add(new Num_Orbitals() { ID = 4, Name = "4" });
            Number_Orbitals.Add(new Num_Orbitals() { ID = 5, Name = "5" });
            cboNum_Orbitals.DataSource = Number_Orbitals;
            cboNum_Orbitals.DisplayMember = "Name";
            cboNum_Orbitals.ValueMember = "ID";

            List<Num_Celestial_Bodies> Number_Celestial_Bodies = new List<Num_Celestial_Bodies>();

            Number_Celestial_Bodies.Add(new Num_Celestial_Bodies() { ID = 1, Name = "1" });
            Number_Celestial_Bodies.Add(new Num_Celestial_Bodies() { ID = 2, Name = "2" });
            Number_Celestial_Bodies.Add(new Num_Celestial_Bodies() { ID = 3, Name = "3" });
            cboNum_Celestial_Bodies.DataSource = Number_Celestial_Bodies;
            cboNum_Celestial_Bodies.DisplayMember = "Name";
            cboNum_Celestial_Bodies.ValueMember = "ID";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboNum_Orbitals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNum_Celestial_Bodies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Orbitals_Value_Menu_Click(object sender, EventArgs e)
        {
            Orbitals_Menu orbitals_Menu = new Orbitals_Menu();
            orbitals_Menu.ShowDialog();
        }

        private void btn_Celestial_Bodies_Values_Menu_Click(object sender, EventArgs e)
        {
            Celestial_Bodies_Menu celestial_Bodies_Menu = new Celestial_Bodies_Menu();
            celestial_Bodies_Menu.ShowDialog();
        }
    }

    class File_Loader
    {
        static void createmainmenufile(string[] args)
        {
            string firstfilename = @"MainMenuText.txt";

            if (File.Exists(firstfilename))
            {
                File.Delete(firstfilename);
            }


            using (StreamWriter filestr = File.CreateText(firstfilename))
            {
                filestr.WriteLine("Number of Orbitals and Celestial Bodies ");
            }
        }
        static void ammendmainmenufile(int Number_Of_Particals)
        {
            string firstfilename = @"MainMenuText.txt";

            using (StreamWriter filestr = File.CreateText(firstfilename))
            {
                filestr.WriteLine(Number_Of_Particals);
            }

        }
    }
}
