﻿
namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu_UC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu_UC));
            this.Menu_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demostraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascaráToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valídaCPF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valídaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarAbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.IML_Imagens = new System.Windows.Forms.ImageList(this.components);
            this.Menu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Principal
            // 
            this.Menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.Menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal.Name = "Menu_Principal";
            this.Menu_Principal.Size = new System.Drawing.Size(529, 24);
            this.Menu_Principal.TabIndex = 0;
            this.Menu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.apagarAbaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demostraçãoKeyToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.mascaráToolStripMenuItem,
            this.valídaCPF1ToolStripMenuItem,
            this.valídaCPF2ToolStripMenuItem,
            this.validaSenhaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // demostraçãoKeyToolStripMenuItem
            // 
            this.demostraçãoKeyToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_DemonstracaoKey;
            this.demostraçãoKeyToolStripMenuItem.Name = "demostraçãoKeyToolStripMenuItem";
            this.demostraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.demostraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.demostraçãoKeyToolStripMenuItem.Text = "Demostração &Key";
            this.demostraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demostraçãoKeyToolStripMenuItem_Click);
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_HelloWorld;
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.helloWorldToolStripMenuItem.Text = "Hello &World";
            this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
            // 
            // mascaráToolStripMenuItem
            // 
            this.mascaráToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_Mascara;
            this.mascaráToolStripMenuItem.Name = "mascaráToolStripMenuItem";
            this.mascaráToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.mascaráToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.mascaráToolStripMenuItem.Text = "&Máscara";
            this.mascaráToolStripMenuItem.Click += new System.EventHandler(this.mascaráToolStripMenuItem_Click);
            // 
            // valídaCPF1ToolStripMenuItem
            // 
            this.valídaCPF1ToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF;
            this.valídaCPF1ToolStripMenuItem.Name = "valídaCPF1ToolStripMenuItem";
            this.valídaCPF1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.valídaCPF1ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.valídaCPF1ToolStripMenuItem.Text = "Válida &CPF1";
            this.valídaCPF1ToolStripMenuItem.Click += new System.EventHandler(this.valídaCPF1ToolStripMenuItem_Click);
            // 
            // valídaCPF2ToolStripMenuItem
            // 
            this.valídaCPF2ToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF2;
            this.valídaCPF2ToolStripMenuItem.Name = "valídaCPF2ToolStripMenuItem";
            this.valídaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.valídaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.valídaCPF2ToolStripMenuItem.Text = "Válida C&PF2";
            this.valídaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.valídaCPF2ToolStripMenuItem_Click);
            // 
            // validaSenhaToolStripMenuItem
            // 
            this.validaSenhaToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaSenha;
            this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            this.validaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.validaSenhaToolStripMenuItem.Text = "Válida &Senha";
            this.validaSenhaToolStripMenuItem.Click += new System.EventHandler(this.validaSenhaToolStripMenuItem_Click);
            // 
            // apagarAbaToolStripMenuItem
            // 
            this.apagarAbaToolStripMenuItem.Name = "apagarAbaToolStripMenuItem";
            this.apagarAbaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.apagarAbaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.apagarAbaToolStripMenuItem.Text = "Apagar Aba";
            this.apagarAbaToolStripMenuItem.Click += new System.EventHandler(this.apagarAbaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Aplicacoes.ImageList = this.IML_Imagens;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 24);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(529, 298);
            this.Tbc_Aplicacoes.TabIndex = 1;
            // 
            // IML_Imagens
            // 
            this.IML_Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IML_Imagens.ImageStream")));
            this.IML_Imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.IML_Imagens.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            this.IML_Imagens.Images.SetKeyName(1, "Frm_HelloWorld.png");
            this.IML_Imagens.Images.SetKeyName(2, "Frm_Mascara.png");
            this.IML_Imagens.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            this.IML_Imagens.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            this.IML_Imagens.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            // 
            // Frm_Principal_Menu_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 322);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.Menu_Principal);
            this.MainMenuStrip = this.Menu_Principal;
            this.Name = "Frm_Principal_Menu_UC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formuláro Principal";
            this.Menu_Principal.ResumeLayout(false);
            this.Menu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demostraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascaráToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valídaCPF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valídaCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.ImageList IML_Imagens;
        private System.Windows.Forms.ToolStripMenuItem apagarAbaToolStripMenuItem;
    }
}