using Econtact.ContactModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Econtact
{
    //
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            DALContacts.CreateSqliteDB();
            DALContacts.CreateSqliteTable();
            LoadDataGridView();
        }


        public void LoadDataGridView()
        {
            DataTable dt = DALContacts.GetAllContacts();
            dataGridView1.DataSource = dt;
        }

        public void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact();

                contact.FirstName = txtBoxContactName.Text;
                contact.LastName = txtBoxContactLastName.Text;
                contact.Address = txtBoxContactAddress.Text;
                contact.ContactNo = txtBoxContactNumber.Text;
                contact.Gender = cmbGender.SelectedItem?.ToString();
                DALContacts.Add(contact);
                MessageBox.Show("Contato adicionado com sucesso!");
                LoadDataGridView();

                txtBoxContactId.Text = "";
                txtBoxContactName.Text = "";
                txtBoxContactLastName.Text = "";
                txtBoxContactAddress.Text = "";
                txtBoxContactNumber.Text = "";

                cmbGender.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao atualizar o contato.\nDetalhes do erro: {ex.Message}", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnCloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            DataTable result = DALContacts.Search(keyword);
            if (result.Rows.Count > 0)
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            txtBoxContactId.Text = row.Cells["Contact_ID"].Value.ToString();
            txtBoxContactName.Text = row.Cells["First_Name"].Value.ToString();
            txtBoxContactLastName.Text = row.Cells["Last_Name"].Value.ToString();
            txtBoxContactNumber.Text = row.Cells["ContactNo"].Value.ToString();
            txtBoxContactAddress.Text = row.Cells["Address"].Value.ToString();
            cmbGender.Text = row.Cells["Gender"].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact();

                contact.ContactID = Convert.ToInt32(txtBoxContactId.Text);
                contact.FirstName = txtBoxContactName.Text;
                contact.LastName = txtBoxContactLastName.Text;
                contact.Address = txtBoxContactAddress.Text;
                contact.ContactNo = txtBoxContactNumber.Text;
                contact.Gender = cmbGender.SelectedItem?.ToString();

                DALContacts.Update(contact);
                LoadDataGridView();
                MessageBox.Show("Contato atualizado com sucesso!");

                txtBoxContactId.Text = "";
                txtBoxContactName.Text = "";
                txtBoxContactLastName.Text = "";
                txtBoxContactAddress.Text = "";
                txtBoxContactNumber.Text = "";

                cmbGender.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao atualizar o contato.\nDetalhes do erro: {ex.Message}", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtBoxContactId.Text);

                DALContacts.Delete(id);
                LoadDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao excluir o contato.\nDetalhes do erro: {ex.Message}", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
    }
}
