﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImUENP.UI.Filters;
using WindowsFormsApp.Filters;

namespace ImUENP.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = openFileDialog.ShowDialog();
            if (res != DialogResult.OK)
            {
                return;
            }
            var fn = openFileDialog.FileName;            
            var img = Image.FromFile(fn);
            pictureBox1.Image = img;
            pictureBox1.Refresh();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = saveFileDialog.ShowDialog();
            if (res != DialogResult.OK)
            {
                return;
            }
            var fn = saveFileDialog.FileName;
            //if (File.Exists(fn))
            var img = pictureBox1.Image;
            img.Save(fn);
        }

        private void cinzaNTSCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;            
            var gray = new Grayscale0().Process(img);
            pictureBox1.Image = gray;
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs+"ms");
        }

        private void cinzaNTSCPtrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;
            var gray = new Grayscale3().Process(img);
            pictureBox1.Image = gray;
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs + "ms");
        }

        private void cinzaNTSCMarshallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;
            var gray = new Grayscale2().Process(img);
            pictureBox1.Image = gray;
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs + "ms");
        }

        private void cinzaNTSC1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var img = (Bitmap)pictureBox1.Image;
            var gray = new Grayscale1().Process(RGBImage.FromImage(img));
            pictureBox1.Image = gray.ToImage();
            pictureBox1.Refresh();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            MessageBox.Show(elapsedMs + "ms");
        }

        private void binarizacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bpm = pictureBox1.Image;
            var img = RGBImage.FromImage((Bitmap)bpm);
            var bin = new ThreeShold().Process(img);
            pictureBox1.Image = bin.ToImage();
            pictureBox1.Refresh();
        }

        private void binarizacaoTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bpm = pictureBox1.Image;
            var img = RGBImage.FromImage((Bitmap)bpm);
            var bin = new ThreeShold().Process2(img);
            pictureBox1.Image = bin.ToImage();
            pictureBox1.Refresh();
        }

        private void multiLimiarizacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bpm = pictureBox1.Image;
            var img = RGBImage.FromImage((Bitmap)bpm);
            var multi = new ThreeShold().ProcessMulti(img);
            pictureBox1.Image = multi.ToImage();
            pictureBox1.Refresh();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void filtroMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bpm = pictureBox1.Image;
            var img = RGBImage.FromImage((Bitmap)bpm);
            var media = new MediaMediana(4).media(img);
            pictureBox1.Image = media.ToImage();
            pictureBox1.Refresh();
        }

        private void filtroMedianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bpm = pictureBox1.Image;
            var img = RGBImage.FromImage((Bitmap)bpm);
            var mediana = new MediaMediana(4).mediana(img);
            pictureBox1.Image = mediana.ToImage();
            pictureBox1.Refresh();
        }

        private void melanomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bpm = (Bitmap)pictureBox1.Image;
            var melanoma = new Melanoma().ProcessMelanoma(bpm);
            pictureBox1.Image = melanoma;
            pictureBox1.Refresh();
        }
    }
}
