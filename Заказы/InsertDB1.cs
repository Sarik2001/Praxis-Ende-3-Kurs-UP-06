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
    public partial class InsertDB1 : MetroForm
    {
        public InsertDB1()
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
                cmd.CommandText = "insert into [ПостоянныеПокупатели] (Фамилия,Имя,Отчество,[Скидка %]) values ('" + Familiya + "','" + Imya + "'" +
                        ",'" + Otchestvo + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данные успешно добавленны");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Постоянные_клиенты постоянные = new Постоянные_клиенты();
            постоянные.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
