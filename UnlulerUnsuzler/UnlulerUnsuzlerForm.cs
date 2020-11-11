using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnlulerUnsuzler.Classes;

namespace UnlulerUnsuzler
{
    public partial class UnlulerUnsuzlerForm : Form
    {
        
        public UnlulerUnsuzlerForm()
        {
            InitializeComponent();
        }

        private void bHesapla_Click(object sender, EventArgs e)
        {
            string kelime = tbKelime.Text.ToLower();
            Unluler sesli = new Unluler();
            tbSesli.Text = sesli.Unler(kelime);
            tbSessiz.Text = sesli.Unsuzler(kelime);

        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbKelime.Clear();
            tbSesli.Clear();
            tbSessiz.Clear();
        }
    }
}
