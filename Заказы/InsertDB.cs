using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using MetroFramework.Forms;

namespace Заказы
{
    public partial class InsertDB : MetroForm
    {
        public InsertDB()
        {
            InitializeComponent();
        }

        private void InsertBut_Click(object sender, EventArgs e)
        {
            try 
            {
                string[] FIO1 = FIO.Text.Split(' ');
                string Familiya = FIO1[0];
                string Imya = FIO1[1];
                string Otchestvo = FIO1[2];
                SqlConnection con = new SqlConnection(@"Data Source=desktop-khpsbod\sqlexpress;Initial Catalog=УчётЗаказов;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Заказы] (Фамилия,Имя,Отчество,Заказ,Адресс,[Номер телефона]) values ('" + Familiya + "','" + Imya + "'" +
                        ",'" + Otchestvo + "','" + richTextBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данные успешно добавленны");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 учзак = new Form1();
            учзак.Show();
            this.Hide();
        }

        private void InsertDB_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
