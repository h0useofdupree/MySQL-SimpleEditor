using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KAÜbung
{
    public partial class MainWindow : Form
    {
        BindingSource bs = new BindingSource();
        public MainWindow()
        {
            InitializeComponent();
            LoadDataFromDB();
        }
        
        private void LoadDataFromDB()
        {
            bs.DataSource = GetBooks();
            mainView.DataSource = bs;
        }
        public List<Book> GetBooks()
        {
            List<Book> retVal = new List<Book>();
            MySqlConnection con = new MySqlConnection(ConHelper.ConVal("ka"));
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_buecher1", con);
            MySqlDataReader reader = null;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    retVal.Add(new Book(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Connection" +
                               $"{ ex.Message }");
            }
            finally
            {
                con.Close();
            }
            return retVal;
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        { 
            if (!String.IsNullOrEmpty(txt_ISBN.Text) && !String.IsNullOrEmpty(txt_Titel.Text) && !String.IsNullOrEmpty(txt_Autor.Text))
            {
                Book book = new Book(txt_ISBN.Text, txt_Titel.Text, txt_Autor.Text, dtp_YOR.Value.ToString());
                InsertBooks(book);
            }
            else
            {
                MessageBox.Show("Bitte ALLE Felder ausfüllen.");
            }


        }

        private void InsertBooks(Book book)
        { 
            MySqlConnection con = new MySqlConnection(ConHelper.ConVal("ka"));
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO `tbl_buecher1`" +
                "(`ISBN`, `Titel`, `Autor`, `Erscheinungsjahr`)" +
                $" VALUES ('{ txt_ISBN.Text }','{ txt_Titel.Text }','{ txt_Autor.Text }','{ dtp_YOR.Value.ToString("MM/dd/yyyy") }')",
                con
            );
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                bs.Add(book);
                refreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Connection" +
                               $"{ ex.Message }");
            }
            finally { con.Close(); }
        }
        private void refreshData()
        {
            mainView.DataSource = null;
            mainView.DataSource = bs;
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteEntry();
        }

        private void DeleteEntry() // Deletes selected Entry from DB and BS / DGV
        {
            string id = mainView.CurrentCell.Value.ToString(); // Getting ID of currently selected book in 
            MySqlConnection con = new MySqlConnection(ConHelper.ConVal("ka"));
            MySqlCommand cmd = new MySqlCommand(
                $"DELETE FROM tbl_buecher1 WHERE ISBN = { id }",
                con
                );
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                bs.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" +
                    $"{ ex.Message }");
            }finally { con.Close(); }
        }

        private void btn_SaveAndExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bist du sicher?", "Speichern und Beenden", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
