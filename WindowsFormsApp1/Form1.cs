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

            MessageBox.Show("jeonghun branch");

            textBox_print.Text = "안녕하세요\r\n이정훈\r\n입니다.";
        }
    }
}
