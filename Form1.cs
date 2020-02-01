using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CD_Minder
{
    public partial class frmMain : Form
    {
        // Possible Form colors
        enum Colors { Blue, Red, Yellow, Green, Black, White, Gray };

        SqlConnection connection;
        string connectionString;

        public frmMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CD_Minder.Properties.Settings.CD_DatabaseConnectionString"].ConnectionString;
        }
                
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Use enum color
            this.BackColor = Color.FromName(Colors.White.ToString());

            // Populate all lists
            PopulateArtists();
            PopulateAllSongs();
        }

        private void PopulateArtists()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Artists", connection))
            {
                DataTable artistTable = new DataTable();
                adapter.Fill(artistTable);

                lstArtistInformation.DisplayMember = "Artist";
                lstArtistInformation.ValueMember = "Id";
                lstArtistInformation.DataSource = artistTable;
            }
        }

        private void PopulateSongs()
        {
            string query = "SELECT s.SongTitle FROM Songs s " +
            "INNER JOIN Associations a ON a.SongId = s.Id " +
            "WHERE a.ArtistId = @ArtistId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ArtistId", lstArtistInformation.SelectedIndex + 1);

                DataTable songTable = new DataTable();
                adapter.Fill(songTable);

                lstSongInformation.DisplayMember = "SongTitle";
                lstSongInformation.ValueMember = "Id";
                lstSongInformation.DataSource = songTable;
            }
        }

        private void lstArtistInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh song listing
            PopulateSongs();
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Artists (Artist, AlbumName, ReleaseYear) VALUES (@Artist,'New Album', 2020)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection)) 
            {
                connection.Open();
                command.Parameters.AddWithValue("@Artist", txtDataEntry.Text);

                command.ExecuteNonQuery();
            }

            // Refresh artist listing
            PopulateArtists();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDataEntry.Text = "";
        }

        private void btnUpdateArtist_Click_1(object sender, EventArgs e)
        {
            string query = "UPDATE Artists SET Artist = @Artist WHERE Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id", lstArtistInformation.SelectedIndex + 1);
                command.Parameters.AddWithValue("@Artist", txtDataEntry.Text);

                command.ExecuteNonQuery();
            }

            PopulateArtists();
        }

        private void btnUpdateSongName_Click(object sender, EventArgs e)
        {
            // Get song title
            // string text = lstSongInformation.GetItemText(lstSongInformation.SelectedItem);
            // MessageBox.Show(text);

            string query = "UPDATE Songs SET SongTitle = @SongTitle WHERE Id = @Id";
            
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id", lstAllSongs.SelectedIndex + 1);
                command.Parameters.AddWithValue("@SongTitle", txtDataEntry.Text);

                command.ExecuteNonQuery();
            }

            PopulateSongs();
            PopulateAllSongs();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Associations (ArtistId, SongId) VALUES (@ArtistId, @SongId)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ArtistId", lstArtistInformation.SelectedIndex + 1);
                command.Parameters.AddWithValue("@SongId", lstAllSongs.SelectedValue);

                command.ExecuteNonQuery();
            }

            PopulateSongs();
        }

        private void PopulateAllSongs ()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Songs", connection))
            {
                DataTable allSongTable = new DataTable();
                adapter.Fill(allSongTable);

                lstAllSongs.DisplayMember = "SongTitle";
                lstAllSongs.ValueMember = "Id";
                lstAllSongs.DataSource = allSongTable;
            }
        }

        private void butSongs_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Songs VALUES (@SongTitle)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@SongTitle", txtDataEntry.Text);

                command.ExecuteNonQuery();
            }

            PopulateAllSongs();
        }
        
        // Throws exception due to foreign key
        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            //string query = "DELETE FROM Artists WHERE Id = @Id";

            //using (connection = new SqlConnection(connectionString))
            //using (SqlCommand command = new SqlCommand(query, connection))
            //{
            //    connection.Open();
            //    command.Parameters.AddWithValue("@Id", lstArtistInformation.SelectedIndex + 1);

            //    command.ExecuteNonQuery();
            //}

            //PopulateArtists();
        }
    }
}
