using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
namespace BinaryClock {
 
    public partial class Form1:Form 
    {
        TimeManager timemanager;
        List<Button> seconds;
        List<Button> minutes;
        List<Button> hours;
        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Enabled = true;
            timemanager =new TimeManager();
            seconds=new List<Button> { seconds1,seconds2,seconds4,seconds8,seconds16,seconds32 };
            minutes=new List<Button> { minutes1,minutes2,minutes4,minutes8,minutes16,minutes32 };
            hours=  new List<Button> { hours1,hours2,hours4,hours8,hours16 };
        }

        private void updateButtons()
        {
            drawSeconds();
            drawMinutes();
            drawHours();
        }

        private void drawSeconds() 
        {
            char[] arr = Convert.ToString(Int32.Parse(timemanager.Seconds),2).PadLeft(6,'0').ToCharArray();
            Array.Reverse(arr);
            string s = new string(arr);
            for(int x = 0;x<s.Length;x++) 
            {
                setBox(seconds[x],s.Substring(x,1));
            }
        }
        private void drawMinutes() 
        {
            char[] arr = Convert.ToString(Int32.Parse(timemanager.Minutes),2).PadLeft(6,'0').ToCharArray();
            Array.Reverse(arr);
            string s = new string(arr);
            for(int x = 0;x<s.Length;x++)
            {
                setBox(minutes[x],s.Substring(x,1));
            }
        }
        private void drawHours() 
        {
            
            char[] arr = Convert.ToString(Int32.Parse(timemanager.Hours),2).PadLeft(5,'0').ToCharArray();
            Array.Reverse(arr);
            string s = new string(arr);
            for(int x = 0;x<s.Length;x++) {
                setBox(hours[x],s.Substring(x,1));
            }
        }
        private void setBox(Object o,string flag) 
        {
            Button b = o as Button;
            if(flag.Equals("1"))
                b.BackColor=Color.MediumPurple;
            else
                b.BackColor=Color.Gray;
        }

        private void timer1_Tick(Object sender,EventArgs e)
        {
            timemanager.Update();
            updateButtons();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.label11.Text = time.ToString("h:mm:ss tt");
        }
    }
}