using DogStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogStore
{
    public partial class DogStore : Form
    {
        public DogStore()
        {
            InitializeComponent();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dog Store v1.0 Created by Andrew Brown 2015", "About");
        }
    }
}