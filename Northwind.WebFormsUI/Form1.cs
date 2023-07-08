using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.Entity;
using Northwind.DataAccess.Concrete.NHiberNate;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
            //ProductManager productManager = new ProductManager(new NhProductDal());

            dataGridView1.DataSource = _productService.GetAll();
        }
    }
}