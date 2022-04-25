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
    public partial class Orbitals_Menu : Form
    {
        public Orbitals_Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Orbitals_Menu_Load(object sender, EventArgs e)
        {

        }

        private void sldOrbital_1_X_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_1_Y_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_2_X_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_2_Y_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_2_X_Velocity_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_2_Y_Velocity_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_3_X_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_3_Y_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sldOrbital_3_X_Velocity_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_3_Y_Velocity_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_4_X_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_4_Y_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_4_X_Velocity_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_4_Y_Velocity_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_5_X_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_5_Y_Location_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_5_X_Velocity_Scroll(object sender, EventArgs e)
        {

        }

        private void sldOrbital_5_Y_Velocity_Scroll(object sender, EventArgs e)
        {

        }

        private void btnSave_Values_Click(object sender, EventArgs e)
        {
            File_Loader.createmainmenufile();
            File_Loader.ammendmainmenufile(sldOrbital_1_X_Location.Value, sldOrbital_1_Y_Location.Value, sldOrbital_1_X_Velocity.Value, sldOrbital_1_Y_Velocity.Value);
            File_Loader.ammendmainmenufile(sldOrbital_2_X_Location.Value, sldOrbital_2_Y_Location.Value, sldOrbital_2_X_Velocity.Value, sldOrbital_2_Y_Velocity.Value);
            File_Loader.ammendmainmenufile(sldOrbital_3_X_Location.Value, sldOrbital_3_Y_Location.Value, sldOrbital_3_X_Velocity.Value, sldOrbital_3_Y_Velocity.Value);
            File_Loader.ammendmainmenufile(sldOrbital_4_X_Location.Value, sldOrbital_4_Y_Location.Value, sldOrbital_4_X_Velocity.Value, sldOrbital_4_Y_Velocity.Value);
        }
    }

    public class File_Loader
    {
        public static void createmainmenufile()
        {
            string firstfilename = @"OrbitalsText.txt";

            if (File.Exists(firstfilename))
            {
                File.Delete(firstfilename);
            }


            using (StreamWriter filestr = File.CreateText(firstfilename))
            {
                filestr.WriteLine("Values of Orbitals");
            }
        }
        public static void ammendmainmenufile(int X_Location, int Y_Location, int X_Velocity, int Y_Velocity)
        {
           string firstfilename = @"OrbitalsText.txt";


            using (StreamWriter filestr = File.CreateText(firstfilename))
            {
                filestr.WriteLine("", X_Location, Y_Location, X_Velocity, Y_Velocity);
            }

        }
    }
}
