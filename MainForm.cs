using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validate())
                MessageBox.Show("Cannot validate this record");

            productsBindingSource.EndEdit();
            Console.WriteLine("Upated rows: {0}", tableAdapterManager.ProductsTableAdapter.Update(nwindDataSet.Products));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            categoriesTableAdapter.Fill(nwindDataSet.Categories);
            suppliersTableAdapter.Fill(nwindDataSet.Suppliers);
            productsTableAdapter.Fill(nwindDataSet.Products);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private StatusStrip statusStrip;
        private TabControl tabs;
        private TabPage productsTab;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView productsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn Supplier;
        private BindingSource productsSuppliersBindingSource;
        private IContainer components;
        private NwindDataSet nwindDataSet;
        private DataGridViewComboBoxColumn Category;
        private BindingSource productsCategoriesbindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private BindingSource productsBindingSource;
        private BindingNavigator productsBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton productsBindingNavigatorSaveItem;
        private TabPage customersTab;
        private TabPage ordersTab;
        private BindingSource customersBindingSource;
        private NwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private NwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private NwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private NwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label unitsInStockLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label discontinuedLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label categoryIDLabel1;
            System.Windows.Forms.Label quantityPerUnitLabel;
            System.Windows.Forms.Label unitsInStockLabel1;
            System.Windows.Forms.Label unitsOnOrderLabel;
            System.Windows.Forms.Label reorderLevelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tabs = new System.Windows.Forms.TabControl();
            this.productsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new NorthwindEditor.NwindDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnOrderTextBox = new System.Windows.Forms.TextBox();
            this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDListBox = new System.Windows.Forms.ListBox();
            this.supplierIDListBox = new System.Windows.Forms.ListBox();
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productsCategoriesbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new NorthwindEditor.NwindDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new NorthwindEditor.NwindDataSetTableAdapters.TableAdapterManager();
            this.suppliersTableAdapter = new NorthwindEditor.NwindDataSetTableAdapters.SuppliersTableAdapter();
            this.categoriesTableAdapter = new NorthwindEditor.NwindDataSetTableAdapters.CategoriesTableAdapter();
            this.customersTableAdapter = new NorthwindEditor.NwindDataSetTableAdapters.CustomersTableAdapter();
            categoryIDLabel = new System.Windows.Forms.Label();
            unitsInStockLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            categoryIDLabel1 = new System.Windows.Forms.Label();
            quantityPerUnitLabel = new System.Windows.Forms.Label();
            unitsInStockLabel1 = new System.Windows.Forms.Label();
            unitsOnOrderLabel = new System.Windows.Forms.Label();
            reorderLevelLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.productsTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsCategoriesbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(512, 126);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(86, 17);
            categoryIDLabel.TabIndex = 6;
            categoryIDLabel.Text = "Category ID:";
            // 
            // unitsInStockLabel
            // 
            unitsInStockLabel.AutoSize = true;
            unitsInStockLabel.Location = new System.Drawing.Point(512, 84);
            unitsInStockLabel.Name = "unitsInStockLabel";
            unitsInStockLabel.Size = new System.Drawing.Size(98, 17);
            unitsInStockLabel.TabIndex = 14;
            unitsInStockLabel.Text = "Units In Stock:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            productIDLabel.Location = new System.Drawing.Point(3, 0);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(216, 30);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            productNameLabel.Location = new System.Drawing.Point(3, 30);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(216, 30);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "Product Name:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            unitPriceLabel.Location = new System.Drawing.Point(3, 60);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(216, 30);
            unitPriceLabel.TabIndex = 4;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            discontinuedLabel.Location = new System.Drawing.Point(3, 90);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(216, 30);
            discontinuedLabel.TabIndex = 6;
            discontinuedLabel.Text = "Discontinued:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            supplierIDLabel.Location = new System.Drawing.Point(558, 120);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(216, 138);
            supplierIDLabel.TabIndex = 8;
            supplierIDLabel.Text = "Supplier:";
            // 
            // categoryIDLabel1
            // 
            categoryIDLabel1.AutoSize = true;
            categoryIDLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            categoryIDLabel1.Location = new System.Drawing.Point(3, 120);
            categoryIDLabel1.Name = "categoryIDLabel1";
            categoryIDLabel1.Size = new System.Drawing.Size(216, 138);
            categoryIDLabel1.TabIndex = 10;
            categoryIDLabel1.Text = "Category:";
            // 
            // quantityPerUnitLabel
            // 
            quantityPerUnitLabel.AutoSize = true;
            quantityPerUnitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            quantityPerUnitLabel.Location = new System.Drawing.Point(558, 0);
            quantityPerUnitLabel.Name = "quantityPerUnitLabel";
            quantityPerUnitLabel.Size = new System.Drawing.Size(216, 30);
            quantityPerUnitLabel.TabIndex = 12;
            quantityPerUnitLabel.Text = "Quantity Per Unit:";
            // 
            // unitsInStockLabel1
            // 
            unitsInStockLabel1.AutoSize = true;
            unitsInStockLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            unitsInStockLabel1.Location = new System.Drawing.Point(558, 30);
            unitsInStockLabel1.Name = "unitsInStockLabel1";
            unitsInStockLabel1.Size = new System.Drawing.Size(216, 30);
            unitsInStockLabel1.TabIndex = 14;
            unitsInStockLabel1.Text = "Units In Stock:";
            // 
            // unitsOnOrderLabel
            // 
            unitsOnOrderLabel.AutoSize = true;
            unitsOnOrderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            unitsOnOrderLabel.Location = new System.Drawing.Point(558, 60);
            unitsOnOrderLabel.Name = "unitsOnOrderLabel";
            unitsOnOrderLabel.Size = new System.Drawing.Size(216, 30);
            unitsOnOrderLabel.TabIndex = 16;
            unitsOnOrderLabel.Text = "Units On Order:";
            // 
            // reorderLevelLabel
            // 
            reorderLevelLabel.AutoSize = true;
            reorderLevelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            reorderLevelLabel.Location = new System.Drawing.Point(558, 90);
            reorderLevelLabel.Name = "reorderLevelLabel";
            reorderLevelLabel.Size = new System.Drawing.Size(216, 30);
            reorderLevelLabel.TabIndex = 18;
            reorderLevelLabel.Text = "Reorder Level:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 655);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1130, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tabs
            // 
            this.tabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabs.Controls.Add(this.productsTab);
            this.tabs.Controls.Add(this.customersTab);
            this.tabs.Controls.Add(this.ordersTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 28);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1130, 627);
            this.tabs.TabIndex = 2;
            // 
            // productsTab
            // 
            this.productsTab.Controls.Add(this.tableLayoutPanel3);
            this.productsTab.Location = new System.Drawing.Point(4, 4);
            this.productsTab.Name = "productsTab";
            this.productsTab.Padding = new System.Windows.Forms.Padding(3);
            this.productsTab.Size = new System.Drawing.Size(1122, 598);
            this.productsTab.TabIndex = 0;
            this.productsTab.Text = "Products";
            this.productsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.productsBindingNavigator, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1116, 592);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.productsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.productsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 565);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.productsBindingNavigator.Size = new System.Drawing.Size(286, 27);
            this.productsBindingNavigator.TabIndex = 3;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "NwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.productsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 559);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(reorderLevelLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.reorderLevelTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(unitsOnOrderLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.unitsOnOrderTextBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(unitsInStockLabel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.unitsInStockTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(quantityPerUnitLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.quantityPerUnitTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(categoryIDLabel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.categoryIDListBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(supplierIDLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.supplierIDListBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(discontinuedLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.discontinuedCheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(unitPriceLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.unitPriceTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(productNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.productNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(productIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productIDTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1110, 258);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ReorderLevel", true));
            this.reorderLevelTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reorderLevelTextBox.Location = new System.Drawing.Point(780, 93);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(327, 22);
            this.reorderLevelTextBox.TabIndex = 19;
            // 
            // unitsOnOrderTextBox
            // 
            this.unitsOnOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitsOnOrder", true));
            this.unitsOnOrderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsOnOrderTextBox.Location = new System.Drawing.Point(780, 63);
            this.unitsOnOrderTextBox.Name = "unitsOnOrderTextBox";
            this.unitsOnOrderTextBox.Size = new System.Drawing.Size(327, 22);
            this.unitsOnOrderTextBox.TabIndex = 17;
            // 
            // unitsInStockTextBox
            // 
            this.unitsInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitsInStock", true));
            this.unitsInStockTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsInStockTextBox.Location = new System.Drawing.Point(780, 33);
            this.unitsInStockTextBox.Name = "unitsInStockTextBox";
            this.unitsInStockTextBox.Size = new System.Drawing.Size(327, 22);
            this.unitsInStockTextBox.TabIndex = 15;
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "QuantityPerUnit", true));
            this.quantityPerUnitTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(780, 3);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(327, 22);
            this.quantityPerUnitTextBox.TabIndex = 13;
            // 
            // categoryIDListBox
            // 
            this.categoryIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "CategoryID", true));
            this.categoryIDListBox.DataSource = this.productsCategoriesbindingSource;
            this.categoryIDListBox.DisplayMember = "CategoryName";
            this.categoryIDListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryIDListBox.FormattingEnabled = true;
            this.categoryIDListBox.ItemHeight = 16;
            this.categoryIDListBox.Location = new System.Drawing.Point(225, 123);
            this.categoryIDListBox.Name = "categoryIDListBox";
            this.categoryIDListBox.Size = new System.Drawing.Size(327, 132);
            this.categoryIDListBox.TabIndex = 11;
            this.categoryIDListBox.ValueMember = "CategoryID";
            // 
            // supplierIDListBox
            // 
            this.supplierIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "SupplierID", true));
            this.supplierIDListBox.DataSource = this.productsSuppliersBindingSource;
            this.supplierIDListBox.DisplayMember = "CompanyName";
            this.supplierIDListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierIDListBox.FormattingEnabled = true;
            this.supplierIDListBox.ItemHeight = 16;
            this.supplierIDListBox.Location = new System.Drawing.Point(780, 123);
            this.supplierIDListBox.Name = "supplierIDListBox";
            this.supplierIDListBox.Size = new System.Drawing.Size(327, 132);
            this.supplierIDListBox.TabIndex = 9;
            this.supplierIDListBox.ValueMember = "SupplierID";
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "Discontinued", true));
            this.discontinuedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discontinuedCheckBox.Location = new System.Drawing.Point(225, 93);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(327, 24);
            this.discontinuedCheckBox.TabIndex = 7;
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitPriceTextBox.Location = new System.Drawing.Point(225, 63);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(327, 22);
            this.unitPriceTextBox.TabIndex = 5;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNameTextBox.Location = new System.Drawing.Point(225, 33);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(327, 22);
            this.productNameTextBox.TabIndex = 3;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
            this.productIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productIDTextBox.Location = new System.Drawing.Point(225, 3);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(327, 22);
            this.productIDTextBox.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 291);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToOrderColumns = true;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Supplier,
            this.Category,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.Size = new System.Drawing.Size(1110, 291);
            this.productsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Supplier.DataPropertyName = "SupplierID";
            this.Supplier.DataSource = this.productsSuppliersBindingSource;
            this.Supplier.DisplayMember = "CompanyName";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.ValueMember = "SupplierID";
            this.Supplier.Width = 66;
            // 
            // productsSuppliersBindingSource
            // 
            this.productsSuppliersBindingSource.DataMember = "Suppliers";
            this.productsSuppliersBindingSource.DataSource = this.nwindDataSet;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.DataPropertyName = "CategoryID";
            this.Category.DataSource = this.productsCategoriesbindingSource;
            this.Category.DisplayMember = "CategoryName";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Category.ValueMember = "CategoryID";
            this.Category.Width = 94;
            // 
            // productsCategoriesbindingSource
            // 
            this.productsCategoriesbindingSource.DataMember = "Categories";
            this.productsCategoriesbindingSource.DataSource = this.nwindDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.HeaderText = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 137;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 94;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.HeaderText = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 115;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UnitsOnOrder";
            this.dataGridViewTextBoxColumn8.HeaderText = "UnitsOnOrder";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ReorderLevel";
            this.dataGridViewTextBoxColumn9.HeaderText = "ReorderLevel";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 123;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Discontinued";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Discontinued";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 96;
            // 
            // customersTab
            // 
            this.customersTab.Location = new System.Drawing.Point(4, 4);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(1122, 598);
            this.customersTab.TabIndex = 1;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // ordersTab
            // 
            this.ordersTab.Location = new System.Drawing.Point(4, 4);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Size = new System.Drawing.Size(1122, 598);
            this.ordersTab.TabIndex = 2;
            this.ordersTab.Text = "Orders";
            this.ordersTab.UseVisualStyleBackColor = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.nwindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NorthwindEditor.NwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 677);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NorthwindEditor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.productsTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsCategoriesbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TableLayoutPanel tableLayoutPanel1;


        private SplitContainer splitContainer1;
        private Splitter splitter1;
        private TextBox productIDTextBox;
        private TextBox productNameTextBox;
        private TextBox unitPriceTextBox;
        private CheckBox discontinuedCheckBox;
        private ListBox supplierIDListBox;
        private ListBox categoryIDListBox;
        private TextBox quantityPerUnitTextBox;
        private TextBox unitsInStockTextBox;
        private TextBox unitsOnOrderTextBox;
        private TextBox reorderLevelTextBox;
    }
}
