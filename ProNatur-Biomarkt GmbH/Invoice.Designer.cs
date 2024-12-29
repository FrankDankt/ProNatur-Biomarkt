namespace ProNatur_Biomarkt_GmbH
{
    partial class Rechnungen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.invoicesDGV = new System.Windows.Forms.DataGridView();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInvoiceSave = new System.Windows.Forms.Button();
            this.btnInvoiceEdit = new System.Windows.Forms.Button();
            this.btnInvoiceClear = new System.Windows.Forms.Button();
            this.btnInvoiceDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._Pro_Natur_Biomarkt_GmbHDataSet = new ProNatur_Biomarkt_GmbH._Pro_Natur_Biomarkt_GmbHDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new ProNatur_Biomarkt_GmbH._Pro_Natur_Biomarkt_GmbHDataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Pro_Natur_Biomarkt_GmbHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesDGV
            // 
            this.invoicesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDGV.Location = new System.Drawing.Point(12, 122);
            this.invoicesDGV.MultiSelect = false;
            this.invoicesDGV.Name = "invoicesDGV";
            this.invoicesDGV.ReadOnly = true;
            this.invoicesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoicesDGV.Size = new System.Drawing.Size(762, 150);
            this.invoicesDGV.TabIndex = 0;
            this.invoicesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicesDGV_CellContentClick);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(142, 38);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(150, 20);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menge";
            // 
            // btnInvoiceSave
            // 
            this.btnInvoiceSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInvoiceSave.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceSave.Location = new System.Drawing.Point(30, 79);
            this.btnInvoiceSave.Name = "btnInvoiceSave";
            this.btnInvoiceSave.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceSave.TabIndex = 6;
            this.btnInvoiceSave.Text = "Speichern";
            this.btnInvoiceSave.UseVisualStyleBackColor = false;
            this.btnInvoiceSave.Click += new System.EventHandler(this.btnInvoiceSave_Click);
            // 
            // btnInvoiceEdit
            // 
            this.btnInvoiceEdit.BackColor = System.Drawing.Color.Orange;
            this.btnInvoiceEdit.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceEdit.Location = new System.Drawing.Point(111, 79);
            this.btnInvoiceEdit.Name = "btnInvoiceEdit";
            this.btnInvoiceEdit.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceEdit.TabIndex = 7;
            this.btnInvoiceEdit.Text = "Bearbeiten";
            this.btnInvoiceEdit.UseVisualStyleBackColor = false;
            this.btnInvoiceEdit.Click += new System.EventHandler(this.btnInvoiceEdit_Click);
            // 
            // btnInvoiceClear
            // 
            this.btnInvoiceClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.btnInvoiceClear.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceClear.Location = new System.Drawing.Point(192, 79);
            this.btnInvoiceClear.Name = "btnInvoiceClear";
            this.btnInvoiceClear.Size = new System.Drawing.Size(97, 23);
            this.btnInvoiceClear.TabIndex = 8;
            this.btnInvoiceClear.Text = "Felder leeren";
            this.btnInvoiceClear.UseVisualStyleBackColor = false;
            // 
            // btnInvoiceDelete
            // 
            this.btnInvoiceDelete.BackColor = System.Drawing.Color.Red;
            this.btnInvoiceDelete.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceDelete.Location = new System.Drawing.Point(295, 79);
            this.btnInvoiceDelete.Name = "btnInvoiceDelete";
            this.btnInvoiceDelete.Size = new System.Drawing.Size(97, 23);
            this.btnInvoiceDelete.TabIndex = 9;
            this.btnInvoiceDelete.Text = "Löschen";
            this.btnInvoiceDelete.UseVisualStyleBackColor = false;
            this.btnInvoiceDelete.Click += new System.EventHandler(this.btnInvoiceDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ProduktID";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(142, 12);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(150, 20);
            this.textBoxProductID.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productsBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // _Pro_Natur_Biomarkt_GmbHDataSet
            // 
            this._Pro_Natur_Biomarkt_GmbHDataSet.DataSetName = "_Pro_Natur_Biomarkt_GmbHDataSet";
            this._Pro_Natur_Biomarkt_GmbHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this._Pro_Natur_Biomarkt_GmbHDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this._Pro_Natur_Biomarkt_GmbHDataSet;
            // 
            // Rechnungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.btnInvoiceDelete);
            this.Controls.Add(this.btnInvoiceClear);
            this.Controls.Add(this.btnInvoiceEdit);
            this.Controls.Add(this.btnInvoiceSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.invoicesDGV);
            this.Name = "Rechnungen";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Rechnungen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Pro_Natur_Biomarkt_GmbHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoicesDGV;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInvoiceSave;
        private System.Windows.Forms.Button btnInvoiceEdit;
        private System.Windows.Forms.Button btnInvoiceClear;
        private System.Windows.Forms.Button btnInvoiceDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.ComboBox comboBox1;
        private _Pro_Natur_Biomarkt_GmbHDataSet _Pro_Natur_Biomarkt_GmbHDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _Pro_Natur_Biomarkt_GmbHDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource1;
    }
}