using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            //MessageBox.Show("Hi");

            textBox_print.Text = "이것은\r\n텍스트 박스\r\n입니다.";
        }
    }
}
