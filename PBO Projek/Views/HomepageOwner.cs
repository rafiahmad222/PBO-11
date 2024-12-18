using PBO_Projek.Controller;
using PBO_Projek.Views.Homepage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Projek.Views
{
    public partial class HomepageOwner : Form
    {
        C_Homepage Controller;
        public HomepageOwner()
        {
            InitializeComponent();
            Controller = new C_Homepage(this);
        }

        private void HomepageOwner_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSlide.Height = button2.Height;
            panelSlide.Top = button2.Top;
            Controller.V_sukuCadang = new V_Produk(Controller);
            Controller.SwitchView(Controller.V_sukuCadang);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSlide.Height = button1.Height;
            panelSlide.Top = button1.Top;
            Controller.V_ManagementTeknisi = new V_ManagementKasir(Controller);
            Controller.SwitchView(Controller.V_ManagementTeknisi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelSlide.Height = button3.Height;
            panelSlide.Top = button3.Top;
            Controller.V_riwayatTransaksi = new V_RiwayatTransaksi(Controller);
            Controller.SwitchView(Controller.V_riwayatTransaksi);
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelSlide.Height = button4.Height;
            panelSlide.Top = button4.Top;
            Controller.V_Tambahlayanan = new V_AlatPertanian(Controller);
            Controller.SwitchView(Controller.V_Tambahlayanan);
        }
    }
}
