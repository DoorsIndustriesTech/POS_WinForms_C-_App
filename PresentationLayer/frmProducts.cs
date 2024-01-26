using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BussinessLayer;

namespace PresentationLayer
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTOProduct dtoProduct = new DTOProduct();
            DAOProducts daoProducts = new DAOProducts();
            dtoProduct.name = txtProductName.Text;
            dtoProduct.price = (double)txtProductPrice.Value;

            daoProducts.insertProduct(dtoProduct);
        }
    }
}
