using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font_Deneme
{
    public partial class Form1 : Form
    {
        public float currentSize;
        public Font font1;
        public bool bold1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            currentSize = label1.Font.Size;
            
            currentSize = 18;

            //label1.Font = new Font(label1.Font.Name,currentSize,label1.Font.Style,label1.Font.Unit);
            label1.Font = new Font(label1.Font.Name,label1.Font.Size,label1.Font.Style);
            font1 = new Font(label1.Font.Name,currentSize,label1.Font.Style,label1.Font.Unit);
            button1.Font = font1;

            if (!(this.Font.Bold))
            {
                this.Font =new Font(this.Font,FontStyle.Bold);
            }

            label1.Font = this.Font;
            //button1.Font = this.Font;
            //button1.Font = new Font (button1.Font,FontStyle.Bold);
            //button1.Font = new Font(button1.Font.FontFamily,36);
            button1.Font =new Font(button1.Font.Name,10);
        }
    }
}
