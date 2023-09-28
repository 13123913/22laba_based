using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _22_lavba
{
    public partial class Form1 : Form
    {

        bool start = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a))
            {
                var number = textBox1.Text;
                Console.WriteLine(number);
            }
            else
            {
                textBox1.Text = "";
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a))
            {
                var number = textBox1.Text;
                Console.WriteLine(number);
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double a) && Int16.Parse(textBox1.Text) != 0)
            {


                dataGridView1.RowCount = Int16.Parse(textBox1.Text);
                dataGridView1.ColumnCount = Int16.Parse(textBox2.Text);

                int[,] array = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];

                Random random = new Random();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        array[i, j] = random.Next(100);
                        dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Максимального числа нет!","Матрица 1337");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var popup = new PopupForm();
            popup.ShowDialog();
        }
    }

         public class PopupForm: Form
    {
        public PopupForm()
        {
            Text = "about";
            Width = 400;
            Height = 300;
            StartPosition = FormStartPosition.CenterParent;
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Top;
            richTextBox.Text = "developers: Gustov, Perelygin, Peshkun\nGroup: 273\nMade with love from Russia";
            this.Controls.Add(richTextBox);
            Font newFont = new Font("TimesNewRomans", 14);
            richTextBox.Font = newFont;
            
        }

        
    }
}

