using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseViewer
{
    public partial class FormAdditionService : Form
    {
        private SqlConnection _connection;
        private Callback _callback;

        private FormAdditionService()
        {
            InitializeComponent();
            Deactivate += (_, _) => Close();

            StartPosition = FormStartPosition.Manual;
            var activeForm = ActiveForm.Location;
            var button = ActiveForm.Controls["AddServiceButton"];
            var buttonLocation = button.Location;
            Location = new Point(activeForm.X + buttonLocation.X + button.Width / 2 - Width / 2, activeForm.Y + buttonLocation.Y + Height / 2);
        }

        public FormAdditionService(SqlConnection connection, Callback callback) : this()
        {
            _connection = connection;
            _callback = callback;
        }

        private void ApplyButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ServiceNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ServiceCostTextBox.Text))
                return;
            var task = Task.Run(async () =>
            {
                var sqlCommand =
                    new SqlCommand($"INSERT Services VALUES (\'{ServiceNameTextBox.Text}\', {ServiceCostTextBox.Text})",
                        _connection);
                await sqlCommand.ExecuteNonQueryAsync();
            });
            task.Wait();
            _callback();
            ServiceNameTextBox.Text = ServiceCostTextBox.Text = string.Empty;
        }

        private void ServiceCostTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}