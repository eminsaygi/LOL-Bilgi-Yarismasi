using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void iTalk_Toggle1_ToggledChanged()
        {
            if (iTalk_Toggle1.Toggled == false) //açıp kapanınca kaydetme
            {
                Bilgi.sesSeçeneği = false;
            }
            else
            {
                Bilgi.sesSeçeneği = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //eski ses değerini alma
            if(Bilgi.sesSeçeneği == false)
            {
                iTalk_Toggle1.Toggled = false;
            }
            else
            {
                iTalk_Toggle1.Toggled = true;
            }
        }
    }
}
