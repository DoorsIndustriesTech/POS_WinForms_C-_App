using EntityLayer;
using BussinessLayer;

namespace PresentationLayer
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTOCustomer dtoCustomer = new DTOCustomer();
            DAOCustomer daoCustomer = new DAOCustomer();
            dtoCustomer.ID = 0;
            dtoCustomer.name = txtName.Text;
            dtoCustomer.email = txtEmail.Text;
            dtoCustomer.phone = txtPhone.Text;
        }
    }
}