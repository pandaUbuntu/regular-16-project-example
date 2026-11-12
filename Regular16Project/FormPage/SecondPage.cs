using Regular16Project.Entities.Characters;
using System.Windows.Forms;

namespace Regular16Project.FormPage
{
    public partial class SecondPage : Form
    {
        Form mainForm;
        public SecondPage(Player player, Form mainForm) : base()
        {
            InitializeComponent();
           

            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.mainForm.Show();
            this.Hide();
        }

    }
}
