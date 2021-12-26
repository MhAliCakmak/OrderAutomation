using OrderAutomation.Business.Abstract;
using OrderAutomation.Business.Concrete;
using OrderAutomation.DataAccsessLayer.Concrete.EntityFrameWork;
using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomation
{
    public partial class AdminControlUI : Form
    {
        public AdminControlUI()
        {
            InitializeComponent();
            _cashServices = new CashManager(new EfCashDal());
            _checkServices = new CheckManager(new EfCheckDal());
            _creditServices = new CreditManager(new EfCreditDal());
            _customerChooseServices = new CustomerChooseManager(new EfCustomerChooseDal());
            _customerServices = new CustomerManager(new EfCustomerDal());
            _itemServices = new ItemManager(new EfItemDal());
            _orderDetailServices = new OrderDetailManager(new EfOrderDetailDal());
            _orderServices = new OrderManager(new EfOrderDal());
        }
        private ICashServices _cashServices;
        private ICheckServices _checkServices;
        private ICreditServices _creditServices;
        private ICustomerChooseServices _customerChooseServices;
        private ICustomerServices _customerServices;
        private IItemServices _itemServices;
        private IOrderDetailServices _orderDetailServices;
        private IOrderServices _orderServices;

        public AdminControlUI(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        public AdminControlUI(IOrderDetailServices orderDetailServices)
        {
            _orderDetailServices = orderDetailServices;
        }

        public AdminControlUI(IItemServices ıtemServices)
        {
            _itemServices = ıtemServices;
        }

        public AdminControlUI(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        public AdminControlUI(ICustomerChooseServices customerChooseServices)
        {
            _customerChooseServices = customerChooseServices;
        }

        public AdminControlUI(ICreditServices creditServices)
        {
            _creditServices = creditServices;
        }

        public AdminControlUI(ICheckServices checkServices)
        {
            _checkServices = checkServices;
        }

        public AdminControlUI(ICashServices cashServices)
        {
            _cashServices = cashServices;
        }
        private void AdminControlUI_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        public void LoadEntities()
        {
            OrderAutomationContext context = new OrderAutomationContext();
            var query = (from a in context.Customers
                         join b in context.CustomerChooses on a.CustomerId equals b.ID
                         join c in context.Orders on a.CustomerId equals c.OrderId
                         join d in context.OrderDetails on a.CustomerId equals d.OrderDetailId


                         select new
                         {
                             a.CustomerId,
                             a.Name,
                             a.Address,
                             b.CItemName,
                             b.CShippingWeight,
                             b.CDescription,
                             b.CPrice,
                             b.PayType,
                             c.Status,
                             c.Date,
                             d.Quantity,

                         });
            dgwAdmin.DataSource = query.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _customerServices.Update(new Customer
            {
                CustomerId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value),
                Name = tbxName.Text,
                Address = tbxAddress.Text
            });
            //_itemServices.Update(new Item
            //{
            //    ItemId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value),
            //    ItemName = tbxItemName.Text,
            //    ShippingWeight = Convert.ToDouble(tbxShippingWeight.Text),
            //    Description = tbxDescription.Text,
            //    Price = Convert.ToDecimal(tbxPrice.Text)
            //});
            _orderDetailServices.Update(new OrderDetail
            {
                OrderDetailId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value),
                Quantity = Convert.ToInt32(tbxQuantity.Text)
            });
            _orderServices.Update(new Order
            {
                OrderId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value),
                Status = tbxStatus.Text,
                Date = Convert.ToDateTime(dtpDate.Value.ToShortDateString())
            });
            _customerChooseServices.Update(new CustomerChoose
            {
                ID = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value),
                CItemName = tbxItemName.Text,
                CShippingWeight = Convert.ToDouble(tbxShippingWeight.Text),
                CDescription = tbxDescription.Text,
                CPrice = Convert.ToDecimal(tbxPrice.Text),
                PayType = tbxPayType.Text
            });
            MessageBox.Show("Order has been Updated!");
            LoadEntities();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _customerServices.Delete(new Customer
            {
                CustomerId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value)
            });
            //_itemServices.Delete(new Item
            //{
            //    ItemId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value)
            //});
            _orderDetailServices.Delete(new OrderDetail
            {
                OrderDetailId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value)
            });
            _orderServices.Delete(new Order
            {
                OrderId = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value)
            });
            _customerChooseServices.Delete(new CustomerChoose
            {
                ID = Convert.ToInt32(dgwAdmin.CurrentRow.Cells[0].Value)
            });

            MessageBox.Show("Order has been Deleted!");
            LoadEntities();
        }

        private void dgwAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var row = dgwAdmin.CurrentRow;
            tbxName.Text = row.Cells[1].Value.ToString();
            tbxAddress.Text = row.Cells[2].Value.ToString();
            tbxItemName.Text = row.Cells[3].Value.ToString();
            tbxShippingWeight.Text = row.Cells[4].Value.ToString();
            tbxDescription.Text = row.Cells[5].Value.ToString();
            tbxPrice.Text = row.Cells[6].Value.ToString();
            tbxPayType.Text = row.Cells[7].Value.ToString();
            tbxStatus.Text = row.Cells[8].Value.ToString();
            dtpDate.Text = row.Cells[9].Value.ToString();
            tbxQuantity.Text = row.Cells[10].Value.ToString();
        }
    }
}
