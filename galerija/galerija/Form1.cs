using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galerija
{
    public partial class Form1 : Form
    {
        Album prviAlbum = new Album();
        int trenutnaSlika = 0;
        public Form1()
        {
            InitializeComponent();
        }
       //promjenljiva prvialbum koja je tipa album-to znaaaci da moze drzati samo album
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.BackColor = prviAlbum.pozadina;
            pictureBox1.ImageLocation = prviAlbum.slike[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trenutnaSlika++;
            if(trenutnaSlika > prviAlbum.slike.Count - 1)
            {
                trenutnaSlika = 0;
            }
                
            pictureBox1.ImageLocation = prviAlbum.slike[trenutnaSlika];
            //prviAlbum.slike.Count - ukupno slika
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfTea = new OpenFileDialog();
            opfTea.ShowDialog();
            prviAlbum.slike.Add(opfTea.FileName);

        }
    }
}
