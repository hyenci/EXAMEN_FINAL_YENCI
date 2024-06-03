using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_FINAL_YEN
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Usuario_text.Text == "ana21hm" && textcontra.Text == "hola123")
            {
                Form1 form1 = new Form1();

                // Muestra el Form1
                form1.Show();
            }
            else
            {
                Usuario_text.Clear();
                textcontra.Clear(); 
                MessageBox.Show("Contraseña o Usuario incorrectos");
            }
        }
    }
}
