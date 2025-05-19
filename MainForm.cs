using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseViewer
{
    public partial class MainForm : Form
    {
        private SqlConnection _connection;

        public MainForm()
        {
            InitializeComponent();
            try
            {
                _connection = new SqlConnection($"Data Source={Program.DatabaseName};Initial Catalog=Aquapark;Integrated Security=True");
                _connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void ReloadTables()
        {
            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(null, _connection);
            for (int i = 0; i < aquaparkDataSet.Tables.Count; i++)
            {
                var table = aquaparkDataSet.Tables[i];
                adapter.SelectCommand.CommandText = "SELECT * FROM " + table.TableName;
                adapter.Fill(table);
            }
            // var task = Task.Run(async () =>
            // {
            //     using var adapter = new SqlDataAdapter();
            //     adapter.SelectCommand = new SqlCommand(null, _connection);
            //     for (int i = 0; i < aquaparkDataSet.Tables.Count; i++)
            //     {
            //         var table = aquaparkDataSet.Tables[i];
            //         adapter.SelectCommand.CommandText = "SELECT * FROM " + table.TableName;
            //         using var reader = await adapter.SelectCommand.ExecuteReaderAsync();
            //         table.BeginLoadData();
            //         table.Load(reader);
            //         //adapter.Fill(table);
            //         table.EndLoadData()
            //     }
            // });
        }

        private void Form1_Load(object sender, EventArgs e) => ReloadTables();

        private void ReloadButtonClick(object sender, EventArgs e) => ReloadTables();

        private void AddServiceButtonClick(object sender, EventArgs e) => new FormAdditionService(_connection, ReloadTables).Show();
    }
}
