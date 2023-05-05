using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Tier
{
    /// <summary>
    /// Home page of application. Containing buttons which redirects user to 
    /// the specified page
    /// </summary>
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnCars_Click(object sender, EventArgs e)
        {
            var carPage = new CarsPage();
            carPage.Show();
            this.Hide();

        }

        private void BtnOwners_Click(object sender, EventArgs e)
        {
            var ownerPage = new OwnerPage();
            ownerPage.Show();
            this.Hide();
        }

        private void BtnCameras_Click(object sender, EventArgs e)
        {
            var cameraPage = new CamerasPage();
            cameraPage.Show();
            this.Hide();
        }
    }
}
