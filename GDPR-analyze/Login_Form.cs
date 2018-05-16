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

namespace GDPR_analyze
{
    public partial class Login_Form : Form
    {
        private SqlConnection dbConnection;
        public static string logged_in_email;
        public Login_Form()
        {
            InitializeComponent();
            panel1.Visible = false;
            bunifuCustomLabel1.Visible = true;
            bunifuCustomLabel3.Visible = true;
            string connetionString = null;
            
            connetionString =
                "Data Source='carbox.database.windows.net';Initial Catalog='GDPR';User ID='carbox@carbox';Password='GDCBnpsf0517'";
            dbConnection = new SqlConnection(connetionString);
            try
            {
                dbConnection.Open();
                //MessageBox.Show("Conexiune reusita!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexiune esuata!\n" + ex);
            }

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void Login_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            bunifuCustomLabel1.Visible = false;
            bunifuCustomLabel3.Visible = false;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            bunifuCustomLabel1.Visible = true;
            bunifuCustomLabel3.Visible = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (dbConnection.State == ConnectionState.Open)
            {
                string name = bunifuMetroTextbox1.Text;
                string first_name = bunifuMetroTextbox2.Text;
                string email = bunifuMetroTextbox3.Text;
                string password= bunifuMetroTextbox4.Text;
                string repeated_password = bunifuMetroTextbox5.Text;
                string role = "Company";


                if (password == repeated_password)
                {
                    //string sqlQuery = "INSERT INTO Users VALUES ('" + email + "', " + "'" + password + "', " + "'" + role + "', " + "'" + name + "', " + "'" + first_name + "'" + ")";
                    string sqlQuery = "INSERT INTO Users VALUES (@Email, @Pass, @Rol, @Name, @First_Name)";
                    SqlCommand command = new SqlCommand(sqlQuery, dbConnection);
                    command.Parameters.Add("@Email", email);
                    command.Parameters.Add("@Pass", password);
                    command.Parameters.Add("@Rol", role);
                    command.Parameters.Add("@First_Name", first_name);
                    command.Parameters.Add("@Name", name);

                    command.ExecuteNonQuery();
                        logged_in_email = email;
                        NewMainForm main_menu = new NewMainForm();
                        this.Hide();
                    MessageBox.Show("Felicitari! V-ati inregistrat cu succes");
                        main_menu.ShowDialog();
                        this.Close();
                    command.Dispose();
                    //dbConnection.Close();
                }
                else
                {
                    MessageBox.Show("Campurile corespunzatoare parolei nu corespund.");
                }
            }
            else
            {
                bunifuCustomLabel6.Text = "Nu s-a putut efectua conexiunea la baza de date";
            }
        }
        /*
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (dbConnection.State == ConnectionState.Open)
            {
                string sqlQuery = "SELECT email, password WHERE email = '" + bunifuMaterialTextbox1 + "' AND password = '" + bunifuMaterialTextbox2 + "'";
                SqlCommand command = new SqlCommand(sqlQuery, dbConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    NewMainForm main_menu= new NewMainForm();
                    this.Hide();
                    main_menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    bunifuCustomLabel6.Text = "Email sau parola gresita";
                }
                dataReader.Close();
                command.Dispose();
                dbConnection.Close();
            }
            else
            {
                bunifuCustomLabel6.Text = "Nu s-a putut efectua conexiunea la baza de date";
            }
        }
		*/
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
            if (dbConnection.State == ConnectionState.Open)
            {
                string sqlQuery = "SELECT email, password FROM Users WHERE email = '" + bunifuMaterialTextbox1.Text + "' AND password = '" + bunifuMaterialTextbox2.Text + "';";
                SqlCommand command = new SqlCommand(sqlQuery, dbConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    NewMainForm main_menu = new NewMainForm();
                    this.Hide();
                    main_menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email sau parola gresita");
                    //bunifuCustomLabel6.Text = "Email sau parola gresita";
                }
                dataReader.Close();
                command.Dispose();
                //dbConnection.Close();
            }
            else
            {
                bunifuCustomLabel6.Text = "Nu s-a putut efectua conexiunea la baza de date";
            }
		}
	}
}
