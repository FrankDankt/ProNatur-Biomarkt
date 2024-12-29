using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class Rechnungen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Frank\Documents\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        private int lastSelectedLineKey;
        public Rechnungen()
        {
            InitializeComponent();
            ShowInvoice();
        }
        private void ShowInvoice()
        {
            //Start
            databaseConnection.Open();
            string query = "select * from Invoice";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet invoiceData = new DataSet();
            sqlDataAdapter.Fill(invoiceData);
            invoicesDGV.DataSource = invoiceData.Tables[0];
            invoicesDGV.Columns[0].Visible = false;

            databaseConnection.Close();


        }
        private void clearAllFields()
        {
            textBoxProductID.Text = string.Empty;
            textBoxQuantity.Text = string.Empty;

        }

        private void btnInvoiceSave_Click(object sender, EventArgs e)
        {
            if (textBoxProductID.Text == ""
                 || textBoxQuantity.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
                return;
            }
            string specifier;
            CultureInfo culture;
            specifier = "G";
            culture = CultureInfo.CreateSpecificCulture("en-US");

            int productID = int.Parse(textBoxProductID.Text, CultureInfo.InvariantCulture);
            decimal quantity = decimal.Parse(textBoxQuantity.Text);
            decimal productPrice = ExecuteProductPriceQuery(textBoxProductID.Text);
            decimal vat = (decimal)1.19;
            decimal amount = calculateAmount(productPrice, quantity, vat);
            string productName = ExecuteProductNameQuery(textBoxProductID.Text);

            //string quantityParm = quantity.ToString(specifier,culture);
            //string productPriceParm = productPrice.ToString(specifier,culture);
            //string vatParm = vat.ToString(specifier,culture);
            //string amountParm = amount.ToString(specifier, culture);

            //string query = string.Format("insert into Invoice values({0},'{1}',{2},{3},{4},{5})", productID, productName, productPriceParm, quantityParm, vatParm, amountParm);
            string query = "INSERT INTO INVOICE (ProductID, Name, Price, Quantity, Vat, Amount) VALUES (@productID, @productName, @productPrice, @quantity, @vat, @amount)";
            ExecuteQuery(query, productID, productName, productPrice, quantity, vat, amount, 0);
            ShowInvoice();


        }
        private void btnInvoiceEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedLineKey == 0)
                MessageBox.Show("Bitte wählen Sie zuerst eine Rechnungszeile aus");
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture("en-US");

            int productID = int.Parse(textBoxProductID.Text, CultureInfo.InvariantCulture);
            decimal quantity = decimal.Parse(textBoxQuantity.Text);
            decimal productPrice = ExecuteProductPriceQuery(textBoxProductID.Text);
            decimal vat = (decimal)1.19;
            decimal amount = calculateAmount(productPrice, quantity, vat);
            string productName = ExecuteProductNameQuery(textBoxProductID.Text);

            string query = "update Invoice set ProductID = @productID, Name = @productName, Price = @productPrice, Quantity = @quantity, Vat = @vat, Amount = @amount where id = @id";
            ExecuteQuery(query, productID, productName, productPrice, quantity, vat, amount, lastSelectedLineKey);
            ShowInvoice();


        }


        private decimal ExecuteProductPriceQuery(string productID)
        {
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            databaseConnection.Open();
            string query = string.Format("select * from Products where Id = {0}", productID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            databaseConnection.Close();
            object value = dataSet.Tables[0].Rows[0]["Price"];
            string price = Convert.ToString(value);
            //return decimal.Parse(price, CultureInfo.InvariantCulture);
            return decimal.Parse(price);

        }
        private string ExecuteProductNameQuery(string productID)
        {
            //productID = "blub";
            //productID = "1";
            databaseConnection.Open();
            string query = string.Format("select * from Products where Id = {0}", productID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            databaseConnection.Close();
            object value = dataSet.Tables[0].Rows[0]["Name"];
            string productName = Convert.ToString(value);
            return productName;

        }

        private void ExecuteQuery(string query, int productID, string productName, decimal productPrice, decimal quantity, decimal vat, decimal amount, int id)
        {
            databaseConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            using (SqlCommand cmd = new SqlCommand(query, databaseConnection))
            {
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@productName", productName);
                cmd.Parameters.AddWithValue("@productPrice", productPrice);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@vat", vat);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }

            databaseConnection.Close();
        }

        private void ExecuteDelQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }




        private decimal calculateAmount(decimal price, decimal quantity, decimal vat)
        {
            return (quantity * price * vat);
        }



        private void invoicesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProductID.Text = invoicesDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxQuantity.Text = invoicesDGV.SelectedRows[0].Cells[4].Value.ToString();

            lastSelectedLineKey = (int)invoicesDGV.SelectedRows[0].Cells[0].Value;

        }

        private void btnInvoiceDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedLineKey == 0)
                MessageBox.Show("Bitte wählen Sie zuerst eine Rechnungszeile aus");
            string query = string.Format("delete from Invoice where Id = {0};", lastSelectedLineKey);
            ExecuteDelQuery(query);
            clearAllFields();
            ShowInvoice();


        }

        private void Rechnungen_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_Pro_Natur_Biomarkt_GmbHDataSet.Products". Sie können sie bei Bedarf verschieben oder entfernen.
            this.productsTableAdapter.Fill(this._Pro_Natur_Biomarkt_GmbHDataSet.Products);

        }
    }
    
}
