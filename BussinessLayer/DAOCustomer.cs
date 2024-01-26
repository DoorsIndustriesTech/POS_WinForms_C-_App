using EntityLayer;
using DataLayer;

namespace BussinessLayer
{
    public class DAOCustomer
    {
        dbConnection connection = new dbConnection();
        public bool validateData(DTOCustomer customer)
        {
            bool res = true;
            if (customer.name == string.Empty)
            {
                MessageBox.Show("Field name is required");
                res = false;
            }
            else if (customer.email == string.Empty)
            {
                MessageBox.Show("Field email is required");
                res = false;
            }
            else if (customer.phone == string.Empty)
            {
                MessageBox.Show("Field phone is required");
                res = false;
            }
            return res;
        }
    }
}