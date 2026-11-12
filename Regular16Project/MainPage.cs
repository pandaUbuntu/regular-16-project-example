using Regular16Project.Entities.Characters;
using Regular16Project.FormPage;
using System;
using System.Windows.Forms;

namespace Regular16Project
{
    public partial class MainPage : Form
    {
        Player player = null;
        SecondPage secondPage = null;
        public MainPage()
        {
            InitializeComponent();
            player = new Player("Alex777");
            secondPage = new SecondPage(player, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
