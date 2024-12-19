﻿using PBO_Projek.Controller;
using PBO_Projek.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_Projek.Views
{
    public partial class TambahAlat : Form
    {
        String title = "KopMart";
        private bool IsEditing;
        bool cek = false;
        C_Alat Controller;
        public TambahAlat(C_Alat controller, bool isEditing)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Controller = controller;
            this.IsEditing = isEditing;
            SetButtonStatus();
        }

        private void SetButtonStatus()
        {
            if (IsEditing)
            {
                button2.Enabled = false; button3.Enabled = true;
            }
            else
            {
                button2.Enabled = true; button3.Enabled = false;
            }
        }
        private void TambahAlat_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string namaAlat = txtAlat.Text;
            decimal hargaAlat;

            if (cekkosong())
                return;

            if (!decimal.TryParse(txtHargaAlat.Text, out hargaAlat))
            {
                MessageBox.Show("Harga harus berupa angka!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHargaAlat.Focus();
                return;
            }

            try
            {
                if (MessageBox.Show("Apakah anda yakin ingin menambah?", "Tambah Alat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Controller.addAlat(namaAlat, hargaAlat);
                    MessageBox.Show("Data Alat Berhasil Ditambah", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            txtAlat.Clear();
            txtHargaAlat.Clear();
        }

        private bool cekkosong()
        {
            if (string.IsNullOrWhiteSpace(txtAlat.Text) || string.IsNullOrWhiteSpace(txtHargaAlat.Text))
            {
                MessageBox.Show("Isilah semua data, jangan ada yang kosong!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cek = false;
                return true;
            }
            cek = true;
            return false;
        }

        private void txtHargaAlat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdAlat;
            string namaAlat = txtAlat.Text;
            decimal hargaAlat;

            if (int.TryParse(lblid.Text, out IdAlat))
            {
                if (decimal.TryParse(txtHargaAlat.Text, out hargaAlat))
                {
                    if (cekkosong())
                        return;

                    if (MessageBox.Show("Apakah anda yakin ingin mengedit?", "Edit Alat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Controller.editAlat(IdAlat, namaAlat, hargaAlat);
                            MessageBox.Show("Data Alat Berhasil Diedit", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            this.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Harga harus berupa angka!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHargaAlat.Focus();
                }
            }
            else
            {
                MessageBox.Show("ID Alat tidak valid!", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
