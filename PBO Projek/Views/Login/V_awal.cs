using PBO_Projek.Controller;
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
    public partial class V_awal : UserControl
    {
        C_MainFrame Controller;
        public V_awal(C_MainFrame controller)
        {
            InitializeComponent();
            Controller = controller;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Controller.v_LoginPemilik = new V_LoginPemilik(Controller);
            Controller.SwitchView(Controller.v_LoginPemilik);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Controller.v_LoginOwner = new V_LoginOwner(Controller);
            Controller.SwitchView(Controller.v_LoginOwner);
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void V_awal_Load(object sender, EventArgs e)
        {

        }
    }
}
