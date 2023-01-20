using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace pruebaTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection.Connect();
            MessageBox.Show("Conectado con exito");
            string queryCont = "select * from CONTINENTE";
            SqlCommand cmd = new SqlCommand(queryCont, Connection.Connect());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxContinent.Items.Add(dr["NOMBRE"].ToString());
            }
            dataGridView1.DataSource = Listar();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxCI.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ageSelect.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                comboBoxContinent.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //dateTimeNacimiento.Value = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxDescription.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Masculino")
                {
                    radioButton1Sexo.Checked = true;
                    radioButton2Sexo.Checked = false;
                }
                if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Femenino")
                {
                    radioButton2Sexo.Checked = true;
                    radioButton1Sexo.Checked = false;
                }
            }
            catch { }
            
        }

        public DataTable Listar()
        {
            Connection.Connect();
            DataTable dt = new DataTable();
            string query = "select * FROM ESTUDIANTE";
            SqlCommand cmd = new SqlCommand(query, Connection.Connect());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Connection.Connect();
            string query = "INSERT INTO ESTUDIANTE(CI,NOMBRE,EDAD,CONTINENTE,NACIMIENTO,DESCRIPCION,SEXO) VALUES (@CI,@NOMBRE,@EDAD,@CONTINENTE,@NACIMIENTO,@DESCRIPCION,@SEXO)";
            SqlCommand cmd1 = new SqlCommand(query, Connection.Connect());
            cmd1.Parameters.AddWithValue("@CI", textBoxCI.Text);
            if (radioButton1Sexo.Checked)
            {
                cmd1.Parameters.AddWithValue("@SEXO", radioButton1Sexo.Text);
            }
            if (radioButton2Sexo.Checked)
            {
                cmd1.Parameters.AddWithValue("@SEXO", radioButton2Sexo.Text);
            }
            cmd1.Parameters.AddWithValue("@NOMBRE", textBoxName.Text);
            cmd1.Parameters.AddWithValue("@EDAD", ageSelect.Value);
            cmd1.Parameters.AddWithValue("@DESCRIPCION", textBoxDescription.Text);
            cmd1.Parameters.AddWithValue("@NACIMIENTO", dateTimeNacimiento.Value);
            cmd1.Parameters.AddWithValue("@CONTINENTE", comboBoxContinent.Text);
            cmd1.ExecuteNonQuery();
            dataGridView1.DataSource = Listar();

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Connection.Connect();
            string query = "UPDATE ESTUDIANTE SET CI=@CI, NOMBRE=@NOMBRE, EDAD=@EDAD, CONTINENTE=@CONTINENTE, NACIMIENTO=@NACIMIENTO,DESCRIPCION=@DESCRIPCION, SEXO=@SEXO WHERE CI=@CI";
            SqlCommand cmd2 = new SqlCommand(query, Connection.Connect());

            cmd2.Parameters.AddWithValue("@CI", textBoxCI.Text);
            if (radioButton1Sexo.Checked)
            {
                cmd2.Parameters.AddWithValue("@SEXO", "Masculino");
            }
            if (radioButton2Sexo.Checked)
            {
                cmd2.Parameters.AddWithValue("@SEXO", "Femenino");
            }
            cmd2.Parameters.AddWithValue("@NOMBRE", textBoxName.Text);
            cmd2.Parameters.AddWithValue("@EDAD", ageSelect.Value);
            cmd2.Parameters.AddWithValue("@DESCRIPCION", textBoxDescription.Text);
            cmd2.Parameters.AddWithValue("@NACIMIENTO", dateTimeNacimiento.Value);
            cmd2.Parameters.AddWithValue("@CONTINENTE", comboBoxContinent.Text);
            cmd2.ExecuteNonQuery();
            dataGridView1.DataSource = Listar();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Connection.Connect();
            string query = "DELETE FROM ESTUDIANTE WHERE CI = @CI";
            SqlCommand cmd3 = new SqlCommand(query, Connection.Connect());
            cmd3.Parameters.AddWithValue("@CI",textBoxCI.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            dataGridView1.DataSource = Listar();
        }
    }
}
