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
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
            _logInServices = new LogInManager(new EfLogInDal());
        }
        private ILogInServices _logInServices;
        public Kaydol(ILogInServices logInServices)
        {
            _logInServices = logInServices;
        }
        private void Kaydol_Load(object sender, EventArgs e)
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

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            _logInServices.Add(new LogIn
            {
                EPosta=tbxEposta.Text,
                Password=tbxPassword.Text,
                Rol="Customer"
            });
            MessageBox.Show("Kayıt Başarıyla Oluşturulmuştur.");
        }
    }
}
