using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easy_learning
{
    public partial class Form1 : Form
    {
        private object tableTableAdapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == 0)
            {

            }

            else if (listBox1.SelectedIndex == 1)
            {
                MessageBox.Show("Hier können Sie die ihre eigen hinzugefügten Vokabeln abfragen");
            }

            //Wenn kein Themaenbereich ausgewählt wurde
            else
            {
                MessageBox.Show("Sie müssen einen Themenbereich auswählen");
            }
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.my_DBDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //2.Form öffnen um neue Vokabel abzuspeichern
            Form2 frm = new Form2();
            frm.Show();



        }
    }
}
