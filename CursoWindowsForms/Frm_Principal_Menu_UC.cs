using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemostracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF1 = 0;
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }

        private void demostraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemostracaoKey += 1;
            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            TabPage Tb = new TabPage();
            Tb.Name = "Demostração Key " + ControleDemostracaoKey;
            Tb.Text = "Demostração Key " + ControleDemostracaoKey;
            Tb.ImageIndex = 0;
            Tb.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            TabPage Tb = new TabPage();
            Tb.Name = "Hello World " + ControleHelloWorld;
            Tb.Text = "Hello World " + ControleHelloWorld;
            Tb.ImageIndex = 1;
            Tb.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }


        private void mascaráToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
            Frm_Mascara_UC U = new Frm_Mascara_UC();
            TabPage Tb = new TabPage();
            Tb.Name = "Máscara " + ControleMascara;
            Tb.Text = "Máscara " + ControleMascara;
            Tb.ImageIndex = 2;
            Tb.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void valídaCPF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF1 += 1;
            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            TabPage Tb = new TabPage();
            Tb.Name = "Válida CPF " + ControleValidaCPF1;
            Tb.Text = "Válida CPF " + ControleValidaCPF1;
            Tb.ImageIndex = 3;
            Tb.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;
            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            TabPage Tb = new TabPage();
            Tb.Name = "Válida CPF(2.0) " + ControleValidaCPF2;
            Tb.Text = "Válida CPF(2.0) " + ControleValidaCPF2;
            Tb.ImageIndex = 4;
            Tb.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;
            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            TabPage Tb = new TabPage();
            Tb.Name = "Válida Senha " + ControleValidaSenha;
            Tb.Text = "Válida Senha " + ControleValidaSenha;
            Tb.ImageIndex = 5;
            Tb.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(Tb);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( !(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
                //ControleHelloWorld -= 1;
            }


        }
    }
}
