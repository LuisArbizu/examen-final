using System;
using System.Windows.Forms;

namespace AppUCA.UI
{
    public partial class Form1 : Form
    {
        public bool IsLogged { get; set; }

        public Form1()
        {
            InitializeComponent();
            IsLogged = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Login logic
            IsLogged = true;
            Close();
        }
    }
}
