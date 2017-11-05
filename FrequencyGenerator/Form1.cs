using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrequencyGenerator
{
    public partial class Form1 : Form
    {
        int Freq1,Freq2;
        int TimeinMillis1, TimeinMillis2;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender,EventArgs e)
        {
            Freq1 = Convert.ToInt32(this.textBox1.Text);
            TimeinMillis1 = Convert.ToInt32(this.textBox3.Text);

            BeepSoundGen beep = new BeepSoundGen();
            beep.BeepGen(Freq1,TimeinMillis1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Freq2 = Convert.ToInt32(this.textBox1.Text);
            TimeinMillis2 = Convert.ToInt32(this.textBox3.Text);

            BeepSoundGen beep = new BeepSoundGen();
            beep.BeepGen(Freq2, TimeinMillis2);
        }
    }
}
