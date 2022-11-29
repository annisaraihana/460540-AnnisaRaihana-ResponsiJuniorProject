using Npgsql;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Pasword=informatika;Database=Responsi2";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        public void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
