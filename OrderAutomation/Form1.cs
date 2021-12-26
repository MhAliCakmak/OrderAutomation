using OrderAutomation.Business.Abstract;
using OrderAutomation.Business.Concrete;
using OrderAutomation.DataAccsessLayer.Concrete.EntityFrameWork;
using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _logInServices = new LogInManager(new EfLogInDal());
        }
        private ILogInServices _logInServices;

        public Form1(ILogInServices logInServices)
        {
            _logInServices = logInServices;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\user\Girişİkonu.png");
            //tooltip1 özellikleri
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.ToolTipTitle = "Uyarı!";
            toolTip1.AutomaticDelay = 75;
            toolTip1.AutoPopDelay = 3000;
            toolTip1.IsBalloon = true;

            toolTip1.SetToolTip(this.tbxEposta, "Kullanıcı E-Postası Girilmesi Zorunludur.");
            toolTip1.SetToolTip(this.tbxPassword, "Kullanıcı Sifre Girilmesi Zorunludur.");
            tbxPassword.PasswordChar = '*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            LogIn logIn = _logInServices.GetLogInbyEPostaPassword(tbxEposta.Text, tbxPassword.Text);

            if (logIn==null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış Tekrar deneyiniz.");
            }
            else if (logIn.Rol == "Administrator")
            {
                MessageBox.Show(logIn.Rol);
                AdminControlUI adminControlUI = new AdminControlUI();
                adminControlUI.Show();
            }
            else if (logIn.Rol == "Customer")
            {
                MessageBox.Show(logIn.Rol);
                CustomerUI customerUI = new CustomerUI();
                customerUI.Show();
            }
        }
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Kaydol kaydol = new Kaydol();
            kaydol.Show();
        }
    }
}
