﻿namespace ImUENP.UI
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinzaNTSCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinzaNTSCPtrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinzaNTSCMarshallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinzaNTSC1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizacaoTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiLimiarizacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroMedianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aforgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.melanomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 543);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources._174226679;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.aforgeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cinzaNTSCToolStripMenuItem,
            this.cinzaNTSCPtrToolStripMenuItem,
            this.cinzaNTSCMarshallToolStripMenuItem,
            this.cinzaNTSC1ToolStripMenuItem,
            this.binarizacaoToolStripMenuItem,
            this.binarizacaoTotalToolStripMenuItem,
            this.multiLimiarizacaoToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.filtroMediaToolStripMenuItem,
            this.filtroMedianaToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // cinzaNTSCToolStripMenuItem
            // 
            this.cinzaNTSCToolStripMenuItem.Name = "cinzaNTSCToolStripMenuItem";
            this.cinzaNTSCToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cinzaNTSCToolStripMenuItem.Text = "Cinza NTSC";
            this.cinzaNTSCToolStripMenuItem.Click += new System.EventHandler(this.cinzaNTSCToolStripMenuItem_Click);
            // 
            // cinzaNTSCPtrToolStripMenuItem
            // 
            this.cinzaNTSCPtrToolStripMenuItem.Name = "cinzaNTSCPtrToolStripMenuItem";
            this.cinzaNTSCPtrToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cinzaNTSCPtrToolStripMenuItem.Text = "Cinza NTSC ptr";
            this.cinzaNTSCPtrToolStripMenuItem.Click += new System.EventHandler(this.cinzaNTSCPtrToolStripMenuItem_Click);
            // 
            // cinzaNTSCMarshallToolStripMenuItem
            // 
            this.cinzaNTSCMarshallToolStripMenuItem.Name = "cinzaNTSCMarshallToolStripMenuItem";
            this.cinzaNTSCMarshallToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cinzaNTSCMarshallToolStripMenuItem.Text = "Cinza NTSC marshall";
            this.cinzaNTSCMarshallToolStripMenuItem.Click += new System.EventHandler(this.cinzaNTSCMarshallToolStripMenuItem_Click);
            // 
            // cinzaNTSC1ToolStripMenuItem
            // 
            this.cinzaNTSC1ToolStripMenuItem.Name = "cinzaNTSC1ToolStripMenuItem";
            this.cinzaNTSC1ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cinzaNTSC1ToolStripMenuItem.Text = "Cinza NTSC 1";
            this.cinzaNTSC1ToolStripMenuItem.Click += new System.EventHandler(this.cinzaNTSC1ToolStripMenuItem_Click);
            // 
            // binarizacaoToolStripMenuItem
            // 
            this.binarizacaoToolStripMenuItem.Name = "binarizacaoToolStripMenuItem";
            this.binarizacaoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.binarizacaoToolStripMenuItem.Text = "Binarizacao";
            this.binarizacaoToolStripMenuItem.Click += new System.EventHandler(this.binarizacaoToolStripMenuItem_Click);
            // 
            // binarizacaoTotalToolStripMenuItem
            // 
            this.binarizacaoTotalToolStripMenuItem.Name = "binarizacaoTotalToolStripMenuItem";
            this.binarizacaoTotalToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.binarizacaoTotalToolStripMenuItem.Text = "Binarizacao Total";
            this.binarizacaoTotalToolStripMenuItem.Click += new System.EventHandler(this.binarizacaoTotalToolStripMenuItem_Click);
            // 
            // multiLimiarizacaoToolStripMenuItem
            // 
            this.multiLimiarizacaoToolStripMenuItem.Name = "multiLimiarizacaoToolStripMenuItem";
            this.multiLimiarizacaoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.multiLimiarizacaoToolStripMenuItem.Text = "Multi Limiarização";
            this.multiLimiarizacaoToolStripMenuItem.Click += new System.EventHandler(this.multiLimiarizacaoToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // filtroMediaToolStripMenuItem
            // 
            this.filtroMediaToolStripMenuItem.Name = "filtroMediaToolStripMenuItem";
            this.filtroMediaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.filtroMediaToolStripMenuItem.Text = "Filtro Media";
            this.filtroMediaToolStripMenuItem.Click += new System.EventHandler(this.filtroMediaToolStripMenuItem_Click);
            // 
            // filtroMedianaToolStripMenuItem
            // 
            this.filtroMedianaToolStripMenuItem.Name = "filtroMedianaToolStripMenuItem";
            this.filtroMedianaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.filtroMedianaToolStripMenuItem.Text = "Filtro Mediana";
            this.filtroMedianaToolStripMenuItem.Click += new System.EventHandler(this.filtroMedianaToolStripMenuItem_Click);
            // 
            // aforgeToolStripMenuItem
            // 
            this.aforgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.melanomaToolStripMenuItem});
            this.aforgeToolStripMenuItem.Name = "aforgeToolStripMenuItem";
            this.aforgeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.aforgeToolStripMenuItem.Text = "Aforge";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Arquivos de Imagem|*.*";
            this.openFileDialog.Title = "Abrir Imagem";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "jpg";
            this.saveFileDialog.Title = "Salvar imagem";
            // 
            // melanomaToolStripMenuItem
            // 
            this.melanomaToolStripMenuItem.Name = "melanomaToolStripMenuItem";
            this.melanomaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.melanomaToolStripMenuItem.Text = "melanoma";
            this.melanomaToolStripMenuItem.Click += new System.EventHandler(this.melanomaToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageProcessing UENP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinzaNTSCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinzaNTSCPtrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinzaNTSCMarshallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinzaNTSC1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizacaoTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiLimiarizacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroMedianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aforgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem melanomaToolStripMenuItem;
    }
}

