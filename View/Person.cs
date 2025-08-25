using ApplicationService;
using ApplicationService.Dtos;
using Service.Dtos;

namespace View
{
    public partial class Person : Form
    {
        private readonly PersonApplicationService _personService;
        public Person()
        {
            InitializeComponent();
            _personService = new PersonApplicationService();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            dgvPerson.DataSource = _personService.GetAll();
            MessageBox.Show("done!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var postPersonDto = new PostPersonDto()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
            };
            _personService.Post(postPersonDto);
            MessageBox.Show("Insertion is done!");
            dgvPerson.DataSource = _personService.GetAll();

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Person_Load(object sender, EventArgs e)
        {
            dgvPerson.DataSource = _personService.GetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPerson.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            var id = Convert.ToInt32(dgvPerson.CurrentRow.Cells["Id"].Value);

            var updatePersonDto = new PatchPersonDto()
            {
                Id = id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };

            _personService.Edit(updatePersonDto);
            MessageBox.Show("Record updated successfully!");

            dgvPerson.DataSource = _personService.GetAll();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPerson.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            var id = Convert.ToInt32(dgvPerson.CurrentRow.Cells["Id"].Value);

            _personService.Delete(id);
            MessageBox.Show("Record deleted successfully!");

            dgvPerson.DataSource = _personService.GetAll();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPerson.CurrentRow != null)
            {
                var firstName = dgvPerson.CurrentRow.Cells["FirstName"].Value?.ToString();
                var lastName = dgvPerson.CurrentRow.Cells["LastName"].Value?.ToString();

                txtFirstName.Text = firstName;
                txtLastName.Text = lastName;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainPage = new Page_1();
            mainPage.Show();
            Close();
        }
    }
}