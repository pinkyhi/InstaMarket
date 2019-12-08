namespace InstaMarket
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.tablesToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexNewPublicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.salesStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.voluntarySqlRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putOnBotButton = new System.Windows.Forms.ToolStripButton();
            this.tableNameLable = new System.Windows.Forms.Label();
            this.mainFormGridView = new System.Windows.Forms.DataGridView();
            this.mainBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorOrderDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.saveReportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.goodDimensionPanel = new System.Windows.Forms.Panel();
            this.putOnPriceFiltering = new System.Windows.Forms.CheckBox();
            this.fromPriceFilteringNumeric = new System.Windows.Forms.NumericUpDown();
            this.toPriceFilteringNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.goodDimensionByVendorCodeRadio = new System.Windows.Forms.RadioButton();
            this.goodDimensionByDimensionNameRadio = new System.Windows.Forms.RadioButton();
            this.goodDimensionByGoodNameRadio = new System.Windows.Forms.RadioButton();
            this.goodDimensionSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.orderPanelOrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.orderPanelSaveReceipt = new System.Windows.Forms.Button();
            this.orderByEmailRadio = new System.Windows.Forms.RadioButton();
            this.orderByPhoneRadio = new System.Windows.Forms.RadioButton();
            this.orderByUsernameRadio = new System.Windows.Forms.RadioButton();
            this.orderSearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.publicationPanel = new System.Windows.Forms.Panel();
            this.publicationComboBox = new System.Windows.Forms.ComboBox();
            this.publicationByVendorCodeRadio = new System.Windows.Forms.RadioButton();
            this.publicationByShopRadio = new System.Windows.Forms.RadioButton();
            this.publicationSearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createNewOrderFromSelectedVendorCodesButton = new System.Windows.Forms.Button();
            this.dimensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodDimensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingNavigator)).BeginInit();
            this.mainBindingNavigator.SuspendLayout();
            this.goodDimensionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromPriceFilteringNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPriceFilteringNumeric)).BeginInit();
            this.orderPanel.SuspendLayout();
            this.publicationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodDimensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormToolStrip
            // 
            this.mainFormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripDropDownButton,
            this.actionsToolStripDropDownButton,
            this.reportsToolStripDropDownButton,
            this.advancedToolStripDropDownButton,
            this.putOnBotButton});
            this.mainFormToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormToolStrip.Name = "mainFormToolStrip";
            this.mainFormToolStrip.Size = new System.Drawing.Size(1038, 25);
            this.mainFormToolStrip.TabIndex = 0;
            this.mainFormToolStrip.Text = "toolStrip1";
            // 
            // tablesToolStripDropDownButton
            // 
            this.tablesToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tablesToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsToolStripMenuItem,
            this.dimensionsToolStripMenuItem,
            this.vendorCodesToolStripMenuItem,
            this.shopsToolStripMenuItem,
            this.publicationsToolStripMenuItem,
            this.deliveriesToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.tablesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tablesToolStripDropDownButton.Name = "tablesToolStripDropDownButton";
            this.tablesToolStripDropDownButton.Size = new System.Drawing.Size(53, 22);
            this.tablesToolStripDropDownButton.Text = "Tables";
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.goodsToolStripMenuItem.Text = "Goods";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.goodsToolStripMenuItem_Click);
            // 
            // dimensionsToolStripMenuItem
            // 
            this.dimensionsToolStripMenuItem.Name = "dimensionsToolStripMenuItem";
            this.dimensionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.dimensionsToolStripMenuItem.Text = "Dimensions for goods";
            this.dimensionsToolStripMenuItem.Click += new System.EventHandler(this.dimensionsToolStripMenuItem_Click);
            // 
            // vendorCodesToolStripMenuItem
            // 
            this.vendorCodesToolStripMenuItem.Name = "vendorCodesToolStripMenuItem";
            this.vendorCodesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.vendorCodesToolStripMenuItem.Text = "Vendor codes";
            this.vendorCodesToolStripMenuItem.Click += new System.EventHandler(this.vendorCodesToolStripMenuItem_Click);
            // 
            // shopsToolStripMenuItem
            // 
            this.shopsToolStripMenuItem.Name = "shopsToolStripMenuItem";
            this.shopsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.shopsToolStripMenuItem.Text = "Shops";
            this.shopsToolStripMenuItem.Click += new System.EventHandler(this.shopsToolStripMenuItem_Click);
            // 
            // publicationsToolStripMenuItem
            // 
            this.publicationsToolStripMenuItem.Name = "publicationsToolStripMenuItem";
            this.publicationsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.publicationsToolStripMenuItem.Text = "Publications";
            this.publicationsToolStripMenuItem.Click += new System.EventHandler(this.publicationsToolStripMenuItem_Click);
            // 
            // deliveriesToolStripMenuItem
            // 
            this.deliveriesToolStripMenuItem.Name = "deliveriesToolStripMenuItem";
            this.deliveriesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deliveriesToolStripMenuItem.Text = "Deliveries";
            this.deliveriesToolStripMenuItem.Click += new System.EventHandler(this.deliveriesToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // actionsToolStripDropDownButton
            // 
            this.actionsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.actionsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.indexNewPublicationsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.saveChangesToolStripMenuItem});
            this.actionsToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("actionsToolStripDropDownButton.Image")));
            this.actionsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionsToolStripDropDownButton.Name = "actionsToolStripDropDownButton";
            this.actionsToolStripDropDownButton.Size = new System.Drawing.Size(60, 22);
            this.actionsToolStripDropDownButton.Text = "Actions";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // indexNewPublicationsToolStripMenuItem
            // 
            this.indexNewPublicationsToolStripMenuItem.Name = "indexNewPublicationsToolStripMenuItem";
            this.indexNewPublicationsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.indexNewPublicationsToolStripMenuItem.Text = "Index new publications";
            this.indexNewPublicationsToolStripMenuItem.Visible = false;
            this.indexNewPublicationsToolStripMenuItem.Click += new System.EventHandler(this.indexNewPublicationsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveChangesToolStripMenuItem.Text = "Save changes";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // reportsToolStripDropDownButton
            // 
            this.reportsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reportsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesStatisticsToolStripMenuItem});
            this.reportsToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripDropDownButton.Image")));
            this.reportsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportsToolStripDropDownButton.Name = "reportsToolStripDropDownButton";
            this.reportsToolStripDropDownButton.Size = new System.Drawing.Size(60, 22);
            this.reportsToolStripDropDownButton.Text = "Reports";
            // 
            // salesStatisticsToolStripMenuItem
            // 
            this.salesStatisticsToolStripMenuItem.Name = "salesStatisticsToolStripMenuItem";
            this.salesStatisticsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salesStatisticsToolStripMenuItem.Text = "Sales statistics";
            this.salesStatisticsToolStripMenuItem.Click += new System.EventHandler(this.salesStatisticsToolStripMenuItem_Click);
            // 
            // advancedToolStripDropDownButton
            // 
            this.advancedToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.advancedToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voluntarySqlRequestToolStripMenuItem});
            this.advancedToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("advancedToolStripDropDownButton.Image")));
            this.advancedToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.advancedToolStripDropDownButton.Name = "advancedToolStripDropDownButton";
            this.advancedToolStripDropDownButton.Size = new System.Drawing.Size(73, 22);
            this.advancedToolStripDropDownButton.Text = "Advanced";
            // 
            // voluntarySqlRequestToolStripMenuItem
            // 
            this.voluntarySqlRequestToolStripMenuItem.Name = "voluntarySqlRequestToolStripMenuItem";
            this.voluntarySqlRequestToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.voluntarySqlRequestToolStripMenuItem.Text = "VoluntarySqlRequest";
            this.voluntarySqlRequestToolStripMenuItem.Click += new System.EventHandler(this.voluntarySqlRequestToolStripMenuItem_Click);
            // 
            // putOnBotButton
            // 
            this.putOnBotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.putOnBotButton.Image = ((System.Drawing.Image)(resources.GetObject("putOnBotButton.Image")));
            this.putOnBotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.putOnBotButton.Name = "putOnBotButton";
            this.putOnBotButton.Size = new System.Drawing.Size(67, 22);
            this.putOnBotButton.Text = "Put on bot";
            this.putOnBotButton.Click += new System.EventHandler(this.putOnBotButton_Click);
            // 
            // tableNameLable
            // 
            this.tableNameLable.AutoSize = true;
            this.tableNameLable.BackColor = System.Drawing.Color.White;
            this.tableNameLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableNameLable.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameLable.Location = new System.Drawing.Point(12, 51);
            this.tableNameLable.Name = "tableNameLable";
            this.tableNameLable.Size = new System.Drawing.Size(139, 50);
            this.tableNameLable.TabIndex = 1;
            this.tableNameLable.Text = "Goods";
            // 
            // mainFormGridView
            // 
            this.mainFormGridView.AllowUserToAddRows = false;
            this.mainFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainFormGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainFormGridView.Location = new System.Drawing.Point(12, 122);
            this.mainFormGridView.Name = "mainFormGridView";
            this.mainFormGridView.ReadOnly = true;
            this.mainFormGridView.Size = new System.Drawing.Size(1020, 355);
            this.mainFormGridView.TabIndex = 2;
            // 
            // mainBindingNavigator
            // 
            this.mainBindingNavigator.AddNewItem = null;
            this.mainBindingNavigator.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mainBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mainBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.mainBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorOrderDeleteButton});
            this.mainBindingNavigator.Location = new System.Drawing.Point(12, 480);
            this.mainBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mainBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mainBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mainBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mainBindingNavigator.Name = "mainBindingNavigator";
            this.mainBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mainBindingNavigator.Size = new System.Drawing.Size(240, 25);
            this.mainBindingNavigator.TabIndex = 3;
            this.mainBindingNavigator.Text = "mainBindingNavigator";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorOrderDeleteButton
            // 
            this.bindingNavigatorOrderDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorOrderDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorOrderDeleteButton.Image")));
            this.bindingNavigatorOrderDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorOrderDeleteButton.Name = "bindingNavigatorOrderDeleteButton";
            this.bindingNavigatorOrderDeleteButton.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorOrderDeleteButton.Text = "Delete";
            this.bindingNavigatorOrderDeleteButton.Visible = false;
            this.bindingNavigatorOrderDeleteButton.Click += new System.EventHandler(this.bindingNavigatorOrderDeleteButton_Click);
            // 
            // saveReportFileDialog
            // 
            this.saveReportFileDialog.Filter = "*.txt|*.txt";
            // 
            // goodDimensionPanel
            // 
            this.goodDimensionPanel.Controls.Add(this.putOnPriceFiltering);
            this.goodDimensionPanel.Controls.Add(this.fromPriceFilteringNumeric);
            this.goodDimensionPanel.Controls.Add(this.toPriceFilteringNumeric);
            this.goodDimensionPanel.Controls.Add(this.label4);
            this.goodDimensionPanel.Controls.Add(this.goodDimensionByVendorCodeRadio);
            this.goodDimensionPanel.Controls.Add(this.goodDimensionByDimensionNameRadio);
            this.goodDimensionPanel.Controls.Add(this.goodDimensionByGoodNameRadio);
            this.goodDimensionPanel.Controls.Add(this.goodDimensionSearchTextBox);
            this.goodDimensionPanel.Controls.Add(this.label1);
            this.goodDimensionPanel.Location = new System.Drawing.Point(321, 44);
            this.goodDimensionPanel.Name = "goodDimensionPanel";
            this.goodDimensionPanel.Size = new System.Drawing.Size(711, 72);
            this.goodDimensionPanel.TabIndex = 4;
            this.goodDimensionPanel.Visible = false;
            // 
            // putOnPriceFiltering
            // 
            this.putOnPriceFiltering.AutoSize = true;
            this.putOnPriceFiltering.Location = new System.Drawing.Point(406, 38);
            this.putOnPriceFiltering.Name = "putOnPriceFiltering";
            this.putOnPriceFiltering.Size = new System.Drawing.Size(57, 17);
            this.putOnPriceFiltering.TabIndex = 5;
            this.putOnPriceFiltering.Text = "Put on";
            this.putOnPriceFiltering.UseVisualStyleBackColor = true;
            this.putOnPriceFiltering.CheckedChanged += new System.EventHandler(this.goodDimensionPanelChanging);
            // 
            // fromPriceFilteringNumeric
            // 
            this.fromPriceFilteringNumeric.Location = new System.Drawing.Point(470, 37);
            this.fromPriceFilteringNumeric.Maximum = new decimal(new int[] {
            9999998,
            0,
            0,
            0});
            this.fromPriceFilteringNumeric.Name = "fromPriceFilteringNumeric";
            this.fromPriceFilteringNumeric.Size = new System.Drawing.Size(111, 20);
            this.fromPriceFilteringNumeric.TabIndex = 4;
            // 
            // toPriceFilteringNumeric
            // 
            this.toPriceFilteringNumeric.Location = new System.Drawing.Point(587, 37);
            this.toPriceFilteringNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.toPriceFilteringNumeric.Name = "toPriceFilteringNumeric";
            this.toPriceFilteringNumeric.Size = new System.Drawing.Size(111, 20);
            this.toPriceFilteringNumeric.TabIndex = 4;
            this.toPriceFilteringNumeric.Value = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filtering by price from to";
            // 
            // goodDimensionByVendorCodeRadio
            // 
            this.goodDimensionByVendorCodeRadio.AutoSize = true;
            this.goodDimensionByVendorCodeRadio.Location = new System.Drawing.Point(210, 40);
            this.goodDimensionByVendorCodeRadio.Name = "goodDimensionByVendorCodeRadio";
            this.goodDimensionByVendorCodeRadio.Size = new System.Drawing.Size(100, 17);
            this.goodDimensionByVendorCodeRadio.TabIndex = 2;
            this.goodDimensionByVendorCodeRadio.Text = "By vendor code";
            this.goodDimensionByVendorCodeRadio.UseVisualStyleBackColor = true;
            this.goodDimensionByVendorCodeRadio.CheckedChanged += new System.EventHandler(this.goodDimensionPanelChanging);
            // 
            // goodDimensionByDimensionNameRadio
            // 
            this.goodDimensionByDimensionNameRadio.AutoSize = true;
            this.goodDimensionByDimensionNameRadio.Location = new System.Drawing.Point(98, 40);
            this.goodDimensionByDimensionNameRadio.Name = "goodDimensionByDimensionNameRadio";
            this.goodDimensionByDimensionNameRadio.Size = new System.Drawing.Size(116, 17);
            this.goodDimensionByDimensionNameRadio.TabIndex = 2;
            this.goodDimensionByDimensionNameRadio.Text = "By dimension name";
            this.goodDimensionByDimensionNameRadio.UseVisualStyleBackColor = true;
            this.goodDimensionByDimensionNameRadio.CheckedChanged += new System.EventHandler(this.goodDimensionPanelChanging);
            // 
            // goodDimensionByGoodNameRadio
            // 
            this.goodDimensionByGoodNameRadio.AutoSize = true;
            this.goodDimensionByGoodNameRadio.Checked = true;
            this.goodDimensionByGoodNameRadio.Location = new System.Drawing.Point(8, 40);
            this.goodDimensionByGoodNameRadio.Name = "goodDimensionByGoodNameRadio";
            this.goodDimensionByGoodNameRadio.Size = new System.Drawing.Size(93, 17);
            this.goodDimensionByGoodNameRadio.TabIndex = 2;
            this.goodDimensionByGoodNameRadio.TabStop = true;
            this.goodDimensionByGoodNameRadio.Text = "By good name";
            this.goodDimensionByGoodNameRadio.UseVisualStyleBackColor = true;
            this.goodDimensionByGoodNameRadio.CheckedChanged += new System.EventHandler(this.goodDimensionPanelChanging);
            // 
            // goodDimensionSearchTextBox
            // 
            this.goodDimensionSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodDimensionSearchTextBox.Location = new System.Drawing.Point(88, 8);
            this.goodDimensionSearchTextBox.MaxLength = 128;
            this.goodDimensionSearchTextBox.Name = "goodDimensionSearchTextBox";
            this.goodDimensionSearchTextBox.Size = new System.Drawing.Size(316, 22);
            this.goodDimensionSearchTextBox.TabIndex = 1;
            this.goodDimensionSearchTextBox.TextChanged += new System.EventHandler(this.goodDimensionPanelChanging);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.orderPanelOrderStatusComboBox);
            this.orderPanel.Controls.Add(this.orderPanelSaveReceipt);
            this.orderPanel.Controls.Add(this.orderByEmailRadio);
            this.orderPanel.Controls.Add(this.orderByPhoneRadio);
            this.orderPanel.Controls.Add(this.orderByUsernameRadio);
            this.orderPanel.Controls.Add(this.orderSearchTextBox);
            this.orderPanel.Controls.Add(this.label2);
            this.orderPanel.Location = new System.Drawing.Point(199, 44);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(704, 72);
            this.orderPanel.TabIndex = 4;
            this.orderPanel.Visible = false;
            // 
            // orderPanelOrderStatusComboBox
            // 
            this.orderPanelOrderStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderPanelOrderStatusComboBox.FormattingEnabled = true;
            this.orderPanelOrderStatusComboBox.Location = new System.Drawing.Point(245, 38);
            this.orderPanelOrderStatusComboBox.Name = "orderPanelOrderStatusComboBox";
            this.orderPanelOrderStatusComboBox.Size = new System.Drawing.Size(159, 21);
            this.orderPanelOrderStatusComboBox.TabIndex = 4;
            this.orderPanelOrderStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.orderPanelChanging);
            // 
            // orderPanelSaveReceipt
            // 
            this.orderPanelSaveReceipt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderPanelSaveReceipt.Location = new System.Drawing.Point(410, 7);
            this.orderPanelSaveReceipt.Name = "orderPanelSaveReceipt";
            this.orderPanelSaveReceipt.Size = new System.Drawing.Size(280, 53);
            this.orderPanelSaveReceipt.TabIndex = 3;
            this.orderPanelSaveReceipt.Text = "Save receipt of selected";
            this.orderPanelSaveReceipt.UseVisualStyleBackColor = true;
            this.orderPanelSaveReceipt.Click += new System.EventHandler(this.orderPanelSaveReceipt_Click);
            // 
            // orderByEmailRadio
            // 
            this.orderByEmailRadio.AutoSize = true;
            this.orderByEmailRadio.Location = new System.Drawing.Point(174, 40);
            this.orderByEmailRadio.Name = "orderByEmailRadio";
            this.orderByEmailRadio.Size = new System.Drawing.Size(64, 17);
            this.orderByEmailRadio.TabIndex = 2;
            this.orderByEmailRadio.Text = "By email";
            this.orderByEmailRadio.UseVisualStyleBackColor = true;
            this.orderByEmailRadio.CheckedChanged += new System.EventHandler(this.orderPanelChanging);
            // 
            // orderByPhoneRadio
            // 
            this.orderByPhoneRadio.AutoSize = true;
            this.orderByPhoneRadio.Location = new System.Drawing.Point(98, 40);
            this.orderByPhoneRadio.Name = "orderByPhoneRadio";
            this.orderByPhoneRadio.Size = new System.Drawing.Size(70, 17);
            this.orderByPhoneRadio.TabIndex = 2;
            this.orderByPhoneRadio.Text = "By phone";
            this.orderByPhoneRadio.UseVisualStyleBackColor = true;
            this.orderByPhoneRadio.CheckedChanged += new System.EventHandler(this.orderPanelChanging);
            // 
            // orderByUsernameRadio
            // 
            this.orderByUsernameRadio.AutoSize = true;
            this.orderByUsernameRadio.Checked = true;
            this.orderByUsernameRadio.Location = new System.Drawing.Point(8, 40);
            this.orderByUsernameRadio.Name = "orderByUsernameRadio";
            this.orderByUsernameRadio.Size = new System.Drawing.Size(86, 17);
            this.orderByUsernameRadio.TabIndex = 2;
            this.orderByUsernameRadio.TabStop = true;
            this.orderByUsernameRadio.Text = "By username";
            this.orderByUsernameRadio.UseVisualStyleBackColor = true;
            this.orderByUsernameRadio.CheckedChanged += new System.EventHandler(this.orderPanelChanging);
            // 
            // orderSearchTextBox
            // 
            this.orderSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderSearchTextBox.Location = new System.Drawing.Point(88, 8);
            this.orderSearchTextBox.MaxLength = 128;
            this.orderSearchTextBox.Name = "orderSearchTextBox";
            this.orderSearchTextBox.Size = new System.Drawing.Size(316, 22);
            this.orderSearchTextBox.TabIndex = 1;
            this.orderSearchTextBox.TextChanged += new System.EventHandler(this.orderPanelChanging);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // publicationPanel
            // 
            this.publicationPanel.Controls.Add(this.publicationComboBox);
            this.publicationPanel.Controls.Add(this.publicationByVendorCodeRadio);
            this.publicationPanel.Controls.Add(this.publicationByShopRadio);
            this.publicationPanel.Controls.Add(this.publicationSearchTextBox);
            this.publicationPanel.Controls.Add(this.label3);
            this.publicationPanel.Location = new System.Drawing.Point(405, 44);
            this.publicationPanel.Name = "publicationPanel";
            this.publicationPanel.Size = new System.Drawing.Size(417, 72);
            this.publicationPanel.TabIndex = 4;
            this.publicationPanel.Visible = false;
            // 
            // publicationComboBox
            // 
            this.publicationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publicationComboBox.FormattingEnabled = true;
            this.publicationComboBox.Items.AddRange(new object[] {
            "All",
            "With vendor codes",
            "Without vendor codes"});
            this.publicationComboBox.Location = new System.Drawing.Point(245, 38);
            this.publicationComboBox.Name = "publicationComboBox";
            this.publicationComboBox.Size = new System.Drawing.Size(159, 21);
            this.publicationComboBox.TabIndex = 4;
            this.publicationComboBox.SelectedIndexChanged += new System.EventHandler(this.publicationPanelChanging);
            // 
            // publicationByVendorCodeRadio
            // 
            this.publicationByVendorCodeRadio.AutoSize = true;
            this.publicationByVendorCodeRadio.Location = new System.Drawing.Point(98, 40);
            this.publicationByVendorCodeRadio.Name = "publicationByVendorCodeRadio";
            this.publicationByVendorCodeRadio.Size = new System.Drawing.Size(100, 17);
            this.publicationByVendorCodeRadio.TabIndex = 2;
            this.publicationByVendorCodeRadio.Text = "By vendor code";
            this.publicationByVendorCodeRadio.UseVisualStyleBackColor = true;
            this.publicationByVendorCodeRadio.CheckedChanged += new System.EventHandler(this.publicationPanelChanging);
            // 
            // publicationByShopRadio
            // 
            this.publicationByShopRadio.AutoSize = true;
            this.publicationByShopRadio.Checked = true;
            this.publicationByShopRadio.Location = new System.Drawing.Point(8, 40);
            this.publicationByShopRadio.Name = "publicationByShopRadio";
            this.publicationByShopRadio.Size = new System.Drawing.Size(63, 17);
            this.publicationByShopRadio.TabIndex = 2;
            this.publicationByShopRadio.TabStop = true;
            this.publicationByShopRadio.Text = "By shop";
            this.publicationByShopRadio.UseVisualStyleBackColor = true;
            this.publicationByShopRadio.CheckedChanged += new System.EventHandler(this.publicationPanelChanging);
            // 
            // publicationSearchTextBox
            // 
            this.publicationSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicationSearchTextBox.Location = new System.Drawing.Point(88, 8);
            this.publicationSearchTextBox.MaxLength = 128;
            this.publicationSearchTextBox.Name = "publicationSearchTextBox";
            this.publicationSearchTextBox.Size = new System.Drawing.Size(316, 22);
            this.publicationSearchTextBox.TabIndex = 1;
            this.publicationSearchTextBox.TextChanged += new System.EventHandler(this.publicationPanelChanging);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search";
            // 
            // createNewOrderFromSelectedVendorCodesButton
            // 
            this.createNewOrderFromSelectedVendorCodesButton.Location = new System.Drawing.Point(275, 483);
            this.createNewOrderFromSelectedVendorCodesButton.Name = "createNewOrderFromSelectedVendorCodesButton";
            this.createNewOrderFromSelectedVendorCodesButton.Size = new System.Drawing.Size(757, 23);
            this.createNewOrderFromSelectedVendorCodesButton.TabIndex = 5;
            this.createNewOrderFromSelectedVendorCodesButton.Text = "Create new order from selected vendor codes";
            this.createNewOrderFromSelectedVendorCodesButton.UseVisualStyleBackColor = true;
            this.createNewOrderFromSelectedVendorCodesButton.Click += new System.EventHandler(this.createNewOrderFromSelectedVendorCodesButton_Click);
            // 
            // dimensionBindingSource
            // 
            this.dimensionBindingSource.DataSource = typeof(InstaMarket.Model.Dimension);
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataSource = typeof(InstaMarket.Model.Delivery);
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataSource = typeof(InstaMarket.Model.Good);
            // 
            // goodDimensionBindingSource
            // 
            this.goodDimensionBindingSource.DataSource = typeof(InstaMarket.Model.Good_Dimension);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(InstaMarket.Model.Order);
            // 
            // publicationBindingSource
            // 
            this.publicationBindingSource.DataSource = typeof(InstaMarket.Model.Publication);
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataSource = typeof(InstaMarket.Model.Shop);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1038, 518);
            this.Controls.Add(this.createNewOrderFromSelectedVendorCodesButton);
            this.Controls.Add(this.publicationPanel);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.goodDimensionPanel);
            this.Controls.Add(this.mainBindingNavigator);
            this.Controls.Add(this.mainFormGridView);
            this.Controls.Add(this.tableNameLable);
            this.Controls.Add(this.mainFormToolStrip);
            this.Name = "MainForm";
            this.Text = "InstaMarket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainFormToolStrip.ResumeLayout(false);
            this.mainFormToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingNavigator)).EndInit();
            this.mainBindingNavigator.ResumeLayout(false);
            this.mainBindingNavigator.PerformLayout();
            this.goodDimensionPanel.ResumeLayout(false);
            this.goodDimensionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromPriceFilteringNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPriceFilteringNumeric)).EndInit();
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.publicationPanel.ResumeLayout(false);
            this.publicationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodDimensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainFormToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton tablesToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton actionsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton reportsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem salesStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton advancedToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem voluntarySqlRequestToolStripMenuItem;
        private System.Windows.Forms.Label tableNameLable;
        private System.Windows.Forms.DataGridView mainFormGridView;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexNewPublicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator mainBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private System.Windows.Forms.BindingSource goodDimensionBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource publicationBindingSource;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.BindingSource dimensionBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorOrderDeleteButton;
        private System.Windows.Forms.SaveFileDialog saveReportFileDialog;
        private System.Windows.Forms.Panel goodDimensionPanel;
        private System.Windows.Forms.RadioButton goodDimensionByVendorCodeRadio;
        private System.Windows.Forms.RadioButton goodDimensionByDimensionNameRadio;
        private System.Windows.Forms.RadioButton goodDimensionByGoodNameRadio;
        private System.Windows.Forms.TextBox goodDimensionSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.RadioButton orderByEmailRadio;
        private System.Windows.Forms.RadioButton orderByPhoneRadio;
        private System.Windows.Forms.RadioButton orderByUsernameRadio;
        private System.Windows.Forms.TextBox orderSearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button orderPanelSaveReceipt;
        private System.Windows.Forms.ComboBox orderPanelOrderStatusComboBox;
        private System.Windows.Forms.Panel publicationPanel;
        private System.Windows.Forms.ComboBox publicationComboBox;
        private System.Windows.Forms.RadioButton publicationByVendorCodeRadio;
        private System.Windows.Forms.RadioButton publicationByShopRadio;
        private System.Windows.Forms.TextBox publicationSearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton putOnBotButton;
        private System.Windows.Forms.Button createNewOrderFromSelectedVendorCodesButton;
        private System.Windows.Forms.CheckBox putOnPriceFiltering;
        private System.Windows.Forms.NumericUpDown fromPriceFilteringNumeric;
        private System.Windows.Forms.NumericUpDown toPriceFilteringNumeric;
        private System.Windows.Forms.Label label4;
    }
}

