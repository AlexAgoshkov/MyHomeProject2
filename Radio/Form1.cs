using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using WMPLib;

namespace myradio
{
    public partial class Radio : Form
    {

        public Radio()
        {
            InitializeComponent();

            list.Add("http://relay.181.fm:8030/;?.mp3");
            list.Add("http://64.150.176.87:8287/;?.mp3");
            list.Add("http://relay.181.fm:8132");
            list.Add("http://ep256.hostingradio.ru:8052/europaplus256.mp3");
            list.Add("http://air2.radiorecord.ru:805/rr_320");
            list.Add("http://air2.radiorecord.ru:805/deep_320");
         
        }

        private string[] nameChannel = new string[] {"The Eagle", "Wild Rock", "Classic Rock Hits"
                                                    ,"Europa Plus", "Radio Record", "Record Deep"};

        WindowsMediaPlayer wmPlayer = new WindowsMediaPlayer();


        private void bt_Click(object sender, EventArgs e)
        {

            PlayURL(list[count]);
            CountChannel();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count <= 0)
            {
                count = list.Count;
            }
            count--;
            PlayURL(list.ElementAt(count));
            CountChannel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count > list.Count - 1)
            {
                count = 0;
            }
            PlayURL(list.ElementAt(count));
            CountChannel();
        }

        private void PlayURL(string URL)
        {
            wmPlayer.URL = URL;
            wmPlayer.controls.play();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            wmPlayer.controls.stop();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (!mut)
            {
                wmPlayer.settings.mute = true;
                mut = true;
                button3.Text = "On";

            }
            else
            {
                wmPlayer.settings.mute = false;
                mut = false;
                button3.Text = "Off";

            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            wmPlayer.settings.volume = trackBar1.Value;
            label4.Text = "" + trackBar1.Value;
        }

        private void CountChannel()
        {
            for (int i = 0; i < nameChannel.Length; i++)
            {
               
                if (nameChannel.Length > count)
                {
                    label1.Text = nameChannel[count];
                }
                else
                {
                    label1.Text = "" + count;
                }
            }

            
        }


        #region Private

        private List<string> list = new List<string>();
        private int count = 0;
        private bool mut = false;
       
       

        #endregion
        
        #region 
        private void Radio_Load(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            PlayURL(textBox1.Text);
            label1.Text = "I Don't Know";
        }
    }
}
