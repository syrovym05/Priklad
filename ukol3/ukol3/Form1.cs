using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.ShowIcon = false;
            this.Text = "Příklad 3";

        }
       
        Form form2;

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 10)
            {
                form2 = new Form();                
                form2.Size = new Size(300, 200);
                form2.ShowIcon = false;               
                form2.Text = "Zadej slovo";


                Button uloz = new Button();
                uloz.DialogResult = DialogResult.OK;
                uloz.Location = new Point(40, 89);
                uloz.Size = new Size(75, 23);
                uloz.Text = "Ulož";
      

                Button zrus = new Button();
                zrus.DialogResult = DialogResult.Cancel;
                zrus.Location = new Point(40, 115);
                zrus.Size = new Size(75, 23);
                zrus.Text = "Zrus";
  

                TextBox textBox = new TextBox();
                textBox.Location = new Point(40, 40);
                textBox.Size = new Size(188, 22);


                form2.Controls.Add(textBox);
                form2.Controls.Add(uloz);
                form2.Controls.Add(zrus);

                form2.ActiveControl = textBox;
                form2.AcceptButton = uloz;
           

                if (form2.ShowDialog() == DialogResult.OK)
                {                    
                    if (textBox.Text != "") listBox1.Items.Add(textBox.Text);                  
                }

            }
            else MessageBox.Show("V listboxu je již zapsáno 10 slov");
        }
    }
}
