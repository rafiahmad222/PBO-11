using PBO_Projek.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Projek.Views
{
    public partial class FormDataKasir : Form
    {
        C_ManagementKasir Controller;
        private bool isEditing;
        String title = "Mekanik Hunter";
        bool cek = false;

        public FormDataKasir(C_ManagementKasir controller, bool isEditing = false)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Controller = controller;
            this.isEditing = isEditing;
            SetButtonStatus();
        }

        private void SetButtonStatus()
        {
            if (isEditing)
            {
                btnSave.Enabled = false; btnUpdate.Enabled = true;
            }
            else
            {
                btnSave.Enabled = true; btnUpdate.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idkasir;
            string namakasir = txtNamaKas.Text;
            string username = txtUserKas.Text;
            string password = txtPassKas.Text;
            try
            {
                if (int.TryParse(lblEid.Text, out idkasir))
                {
                    cekkosong();
                    if (cek)
                    {
                        if (MessageBox.Show("Apakah anda yakin ingin mengedit?", "Edit Kasir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Controller.EditKasir(idkasir, namakasir, username, password);
                            MessageBox.Show("Data Kasir Berhasil Diedit", title);
                            Clear();
                            this.Dispose();

                        }

                    }
                }
                else
                {
                    MessageBox.Show("ID Kasir tidak valid.", title);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string namakasir = txtNamaKas.Text;
            string username = txtUserKas.Text;
            string password = txtPassKas.Text;
            try
            {
                cekkosong();
                if (cek)
                {
                    if (MessageBox.Show("Apakah anda yakin ingin menambah?", "Tambah Kasir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Controller.AddKasir(namakasir, username, password);
                        MessageBox.Show("Data Kasir Berhasil Ditambah", title);
                        Clear();
                        cek = false;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

        public void Clear()
        {
            txtNamaKas.Clear();
            txtPassKas.Clear();
            txtUserKas.Clear();
        }
        public void cekkosong()
        {
            if (txtNamaKas.Text == "" || txtPassKas.Text == "" || txtUserKas.Text == "")
            {
                MessageBox.Show("Isilah Nama Jangan Kosong", "Warning");
                return;
            }
            cek = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormDataKasir_Load(object sender, EventArgs e)
        {

        }
    }
}
