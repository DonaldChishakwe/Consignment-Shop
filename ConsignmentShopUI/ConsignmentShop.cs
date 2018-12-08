using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Link to ConsignmentShopLibrary Library
using ConsignmentShopLibrary;


namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        //Now we can access ConsignmentShopLibrary since namespace has been added(Store Object)
        private Store store = new Store();

        //Creating list for shopping cart
        private List<Item> shoppingCartData = new List<Item>();

        //Connecting to Listbox(Done at form level)
        BindingSource itemsBinding = new BindingSource();

        //Connecting to Shopping cart
        BindingSource cartBinding = new BindingSource();

        //Connecting to vendor listbox
        BindingSource vendorsBinding = new BindingSource();

        //Pvt var to store Store profit
        private decimal storeProfit = 0;



        //Constructor
        public ConsignmentShop()
        {
            InitializeComponent();
            //Calling method below holding data
            SetupData();

            //Linking items to binding source...... where(filter to show items that have not been sold)
            itemsBinding.DataSource = store.Items.Where(x=>x.Sold==false).ToList();  
            
            //Linking listbox to binding source
            itemsListbox.DataSource = itemsBinding;

            //Giving listbox something to display
            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            ShoppingCartListbox.DataSource = cartBinding;

            ShoppingCartListbox.DisplayMember = "Display";
            ShoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListbox.DataSource = vendorsBinding;

            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";

        }

        // METHOD TO CREATE DUMMY DATA
        private void SetupData() {

            //New instanceS of type vendor + populating
            //Commission setup by constructor in vendor class

            store.Vendors.Add(new Vendor { FirstName = "Chris", LastName = "Paul" });
            store.Vendors.Add(new Vendor { FirstName = "Serge", LastName = "Ibaka" });

            store.Items.Add(new Item {Title="Moby Dick",Description="Hardy Boys",Price=5.0M,Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Bob Dicks", Description = "Nancy Drew", Price = 5.5M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Jean Grae", Description = "Bars", Price = 9.5M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "William", Description = "EPL", Price = 3.5M, Owner = store.Vendors[1] });

            store.Name = "Teflon's";
        }


      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
     

        private void ltemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Add to cart button click
        private void AddToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListbox.SelectedItem;

            shoppingCartData.Add(selectedItem);

            //Refresh binding list to add something to list

            cartBinding.ResetBindings(false);
            
        }


        private void MakePurchase_Click(object sender, EventArgs e)
        {
            //Mark item as sold

            foreach (Item item in shoppingCartData)

            {
                item.Sold = true;
                //add sold money to vendor
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;

                //Calc store profit
                storeProfit += (1-(decimal)item.Owner.Commission) * item.Price;
            }
            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            //Updating label
            storeProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            //Refreshing binding for commission
            vendorsBinding.ResetBindings(false);
        }
    }
}
