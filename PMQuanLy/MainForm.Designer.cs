namespace PMQuanLy
{
    partial class MainForm
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
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo1 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarProductDetail = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarOrder = new DevExpress.XtraNavBar.NavBarItem();
            this.panelProductDetail = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelProductDetailGrid = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridProductDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.panelOrder = new DevExpress.XtraEditors.PanelControl();
            this.btnOrderSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblSumWeight = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.gv3 = new DevExpress.XtraGrid.GridControl();
            this.sqlDSInventory = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridOrderOrderProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.product_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.product_product_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.product_weight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOrderProductDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gv2 = new DevExpress.XtraGrid.GridControl();
            this.gridOrderOrderInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_code2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqr_code2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colweight2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_date2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOrderInventoryDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderSearchProductCode = new DevExpress.XtraEditors.TextEdit();
            this.txtOrderSearchProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderQrCode = new DevExpress.XtraEditors.TextEdit();
            this.gv1 = new DevExpress.XtraGrid.GridControl();
            this.gridOrderInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.product_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qr_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductDetail)).BeginInit();
            this.panelProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductDetailGrid)).BeginInit();
            this.panelProductDetailGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelOrder)).BeginInit();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderOrderProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderProductDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderOrderInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderInventoryDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderSearchProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderSearchProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderQrCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.Text = "Status bar";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarProduct,
            this.navBarProductDetail,
            this.navBarOrder});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 563);
            this.navBarControl1.TabIndex = 5;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Catalog";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarProductDetail)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarProduct
            // 
            this.navBarProduct.Caption = "Product";
            this.navBarProduct.Name = "navBarProduct";
            this.navBarProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarProduct_LinkClicked);
            // 
            // navBarProductDetail
            // 
            this.navBarProductDetail.Caption = "Inventory";
            this.navBarProductDetail.Name = "navBarProductDetail";
            this.navBarProductDetail.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarProductDetail_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Order";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarOrder)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarOrder
            // 
            this.navBarOrder.Caption = "Order";
            this.navBarOrder.Name = "navBarOrder";
            this.navBarOrder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarOrder_LinkClicked);
            // 
            // panelProductDetail
            // 
            this.panelProductDetail.Controls.Add(this.labelControl3);
            this.panelProductDetail.Controls.Add(this.panelProductDetailGrid);
            this.panelProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductDetail.Location = new System.Drawing.Point(0, 0);
            this.panelProductDetail.Name = "panelProductDetail";
            this.panelProductDetail.Size = new System.Drawing.Size(974, 557);
            this.panelProductDetail.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.labelControl3.Location = new System.Drawing.Point(21, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(207, 24);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Inventory Management";
            // 
            // panelProductDetailGrid
            // 
            this.panelProductDetailGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProductDetailGrid.Controls.Add(this.labelControl4);
            this.panelProductDetailGrid.Controls.Add(this.gridProductDetail);
            this.panelProductDetailGrid.Location = new System.Drawing.Point(2, 62);
            this.panelProductDetailGrid.Name = "panelProductDetailGrid";
            this.panelProductDetailGrid.Size = new System.Drawing.Size(970, 493);
            this.panelProductDetailGrid.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 13);
            this.labelControl4.TabIndex = 0;
            // 
            // gridProductDetail
            // 
            this.gridProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductDetail.Location = new System.Drawing.Point(2, 2);
            this.gridProductDetail.MainView = this.gridView2;
            this.gridProductDetail.Name = "gridProductDetail";
            this.gridProductDetail.Size = new System.Drawing.Size(966, 489);
            this.gridProductDetail.TabIndex = 0;
            this.gridProductDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridProductDetail;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(116, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1003, 563);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(974, 557);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.labelControl1);
            this.panelControl5.Controls.Add(this.panelControl6);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(974, 557);
            this.panelControl5.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.labelControl1.Location = new System.Drawing.Point(21, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 24);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Product Management";
            // 
            // panelControl6
            // 
            this.panelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl6.Controls.Add(this.labelControl2);
            this.panelControl6.Controls.Add(this.gridProduct);
            this.panelControl6.Location = new System.Drawing.Point(2, 62);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(970, 493);
            this.panelControl6.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 0;
            // 
            // gridProduct
            // 
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.Location = new System.Drawing.Point(2, 2);
            this.gridProduct.MainView = this.gridView1;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(966, 489);
            this.gridProduct.TabIndex = 0;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridProduct;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panelProductDetail);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(974, 557);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.panelOrder);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(974, 557);
            this.xtraTabPage3.Text = "xtraTabPage3";
            // 
            // panelOrder
            // 
            this.panelOrder.AutoSize = true;
            this.panelOrder.Controls.Add(this.btnOrderSubmit);
            this.panelOrder.Controls.Add(this.labelControl5);
            this.panelOrder.Controls.Add(this.panelControl2);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(974, 557);
            this.panelOrder.TabIndex = 7;
            // 
            // btnOrderSubmit
            // 
            this.btnOrderSubmit.Location = new System.Drawing.Point(362, 527);
            this.btnOrderSubmit.Name = "btnOrderSubmit";
            this.btnOrderSubmit.Size = new System.Drawing.Size(108, 23);
            this.btnOrderSubmit.TabIndex = 4;
            this.btnOrderSubmit.Text = "submit";
            this.btnOrderSubmit.Click += new System.EventHandler(this.btnOrderSubmit_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.labelControl5.Location = new System.Drawing.Point(21, 20);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(172, 24);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Order Management";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.splitContainerControl1);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Location = new System.Drawing.Point(2, 62);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(972, 460);
            this.panelControl2.TabIndex = 1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(968, 456);
            this.splitContainerControl1.SplitterPosition = 468;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.lblSumWeight);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.gv3);
            this.panelControl1.Controls.Add(this.gv2);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(468, 456);
            this.panelControl1.TabIndex = 0;
            // 
            // lblSumWeight
            // 
            this.lblSumWeight.Location = new System.Drawing.Point(342, 257);
            this.lblSumWeight.Name = "lblSumWeight";
            this.lblSumWeight.Size = new System.Drawing.Size(0, 13);
            this.lblSumWeight.TabIndex = 5;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(278, 257);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 13);
            this.labelControl11.TabIndex = 4;
            this.labelControl11.Text = "Sum Weight:";
            // 
            // gv3
            // 
            this.gv3.DataMember = "inventory";
            this.gv3.DataSource = this.sqlDSInventory;
            this.gv3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gv3.Location = new System.Drawing.Point(2, 2);
            this.gv3.MainView = this.gridOrderOrderProduct;
            this.gv3.Name = "gv3";
            this.gv3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnOrderProductDelete});
            this.gv3.Size = new System.Drawing.Size(464, 242);
            this.gv3.TabIndex = 1;
            this.gv3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOrderOrderProduct});
            // 
            // sqlDSInventory
            // 
            this.sqlDSInventory.ConnectionName = "sqlite_quanly_db";
            this.sqlDSInventory.Name = "sqlDSInventory";
            tableQuery1.FilterString = "[inventory.status] = 1L";
            tableQuery1.Name = "inventory";
            relationColumnInfo1.NestedKeyColumn = "product_code";
            relationColumnInfo1.ParentKeyColumn = "product_code";
            relationInfo1.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo1});
            relationInfo1.NestedTable = "list_product";
            relationInfo1.ParentTable = "inventory";
            tableQuery1.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo1});
            tableInfo1.Name = "inventory";
            columnInfo1.Name = "qr_code";
            columnInfo2.Name = "weight";
            columnInfo3.Name = "status";
            columnInfo4.Name = "product_code";
            columnInfo5.Name = "created_date";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4,
            columnInfo5});
            tableInfo2.Name = "list_product";
            columnInfo6.Name = "name";
            tableInfo2.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo6});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1,
            tableInfo2});
            this.sqlDSInventory.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.sqlDSInventory.ResultSchemaSerializable = resources.GetString("sqlDSInventory.ResultSchemaSerializable");
            // 
            // gridOrderOrderProduct
            // 
            this.gridOrderOrderProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.product_name,
            this.product_product_code,
            this.product_weight,
            this.gridColumn1});
            this.gridOrderOrderProduct.GridControl = this.gv3;
            this.gridOrderOrderProduct.Name = "gridOrderOrderProduct";
            this.gridOrderOrderProduct.OptionsView.ShowGroupPanel = false;
            // 
            // product_name
            // 
            this.product_name.FieldName = "name";
            this.product_name.Name = "product_name";
            this.product_name.Visible = true;
            this.product_name.VisibleIndex = 0;
            this.product_name.Width = 203;
            // 
            // product_product_code
            // 
            this.product_product_code.FieldName = "product_code";
            this.product_product_code.Name = "product_product_code";
            this.product_product_code.Visible = true;
            this.product_product_code.VisibleIndex = 1;
            this.product_product_code.Width = 115;
            // 
            // product_weight
            // 
            this.product_weight.FieldName = "weight";
            this.product_weight.Name = "product_weight";
            this.product_weight.Visible = true;
            this.product_weight.VisibleIndex = 2;
            this.product_weight.Width = 53;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Delete";
            this.gridColumn1.ColumnEdit = this.btnOrderProductDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // btnOrderProductDelete
            // 
            this.btnOrderProductDelete.AutoHeight = false;
            this.btnOrderProductDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnOrderProductDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnOrderProductDelete.Name = "btnOrderProductDelete";
            this.btnOrderProductDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnOrderProductDelete.Click += new System.EventHandler(this.btnOrderProductDelete_Click);
            // 
            // gv2
            // 
            this.gv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv2.DataMember = "inventory";
            this.gv2.DataSource = this.sqlDSInventory;
            this.gv2.Location = new System.Drawing.Point(2, 277);
            this.gv2.MainView = this.gridOrderOrderInventory;
            this.gv2.Name = "gv2";
            this.gv2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnOrderInventoryDelete});
            this.gv2.Size = new System.Drawing.Size(464, 177);
            this.gv2.TabIndex = 3;
            this.gv2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOrderOrderInventory});
            // 
            // gridOrderOrderInventory
            // 
            this.gridOrderOrderInventory.ActiveFilterEnabled = false;
            this.gridOrderOrderInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname1,
            this.colproduct_code2,
            this.colqr_code2,
            this.colweight2,
            this.colcreated_date2,
            this.gridColumn2});
            this.gridOrderOrderInventory.GridControl = this.gv2;
            this.gridOrderOrderInventory.Name = "gridOrderOrderInventory";
            this.gridOrderOrderInventory.OptionsView.ShowGroupPanel = false;
            // 
            // colname1
            // 
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.OptionsColumn.AllowEdit = false;
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 4;
            // 
            // colproduct_code2
            // 
            this.colproduct_code2.FieldName = "product_code";
            this.colproduct_code2.Name = "colproduct_code2";
            this.colproduct_code2.OptionsColumn.AllowEdit = false;
            this.colproduct_code2.Visible = true;
            this.colproduct_code2.VisibleIndex = 2;
            // 
            // colqr_code2
            // 
            this.colqr_code2.FieldName = "qr_code";
            this.colqr_code2.Name = "colqr_code2";
            this.colqr_code2.OptionsColumn.AllowEdit = false;
            this.colqr_code2.Visible = true;
            this.colqr_code2.VisibleIndex = 0;
            // 
            // colweight2
            // 
            this.colweight2.FieldName = "weight";
            this.colweight2.Name = "colweight2";
            this.colweight2.OptionsColumn.AllowEdit = false;
            this.colweight2.Visible = true;
            this.colweight2.VisibleIndex = 1;
            // 
            // colcreated_date2
            // 
            this.colcreated_date2.FieldName = "created_date";
            this.colcreated_date2.Name = "colcreated_date2";
            this.colcreated_date2.OptionsColumn.AllowEdit = false;
            this.colcreated_date2.Visible = true;
            this.colcreated_date2.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Delete";
            this.gridColumn2.ColumnEdit = this.btnOrderInventoryDelete;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // btnOrderInventoryDelete
            // 
            this.btnOrderInventoryDelete.AutoHeight = false;
            this.btnOrderInventoryDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnOrderInventoryDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnOrderInventoryDelete.Name = "btnOrderInventoryDelete";
            this.btnOrderInventoryDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnOrderInventoryDelete.Click += new System.EventHandler(this.btnOrderInventoryDelete_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.gv1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(495, 456);
            this.panelControl3.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl10);
            this.panelControl4.Controls.Add(this.txtOrderSearchProductCode);
            this.panelControl4.Controls.Add(this.txtOrderSearchProductName);
            this.panelControl4.Controls.Add(this.labelControl9);
            this.panelControl4.Controls.Add(this.labelControl8);
            this.panelControl4.Controls.Add(this.labelControl7);
            this.panelControl4.Controls.Add(this.txtOrderQrCode);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(491, 168);
            this.panelControl4.TabIndex = 3;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl10.Location = new System.Drawing.Point(325, 105);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(65, 13);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Product Code";
            // 
            // txtOrderSearchProductCode
            // 
            this.txtOrderSearchProductCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtOrderSearchProductCode.Location = new System.Drawing.Point(325, 125);
            this.txtOrderSearchProductCode.Name = "txtOrderSearchProductCode";
            this.txtOrderSearchProductCode.Size = new System.Drawing.Size(183, 20);
            this.txtOrderSearchProductCode.TabIndex = 10;
            this.txtOrderSearchProductCode.TextChanged += new System.EventHandler(this.txtOrderSearchProductCode_TextChanged);
            // 
            // txtOrderSearchProductName
            // 
            this.txtOrderSearchProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderSearchProductName.Location = new System.Drawing.Point(24, 125);
            this.txtOrderSearchProductName.Name = "txtOrderSearchProductName";
            this.txtOrderSearchProductName.Size = new System.Drawing.Size(270, 20);
            this.txtOrderSearchProductName.TabIndex = 8;
            this.txtOrderSearchProductName.TextChanged += new System.EventHandler(this.txtOrderSearchProductName_TextChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 105);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 13);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Product Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(24, 86);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Search:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 20);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Barcode";
            // 
            // txtOrderQrCode
            // 
            this.txtOrderQrCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderQrCode.Location = new System.Drawing.Point(24, 40);
            this.txtOrderQrCode.Name = "txtOrderQrCode";
            this.txtOrderQrCode.Size = new System.Drawing.Size(484, 20);
            this.txtOrderQrCode.TabIndex = 4;
            this.txtOrderQrCode.TextChanged += new System.EventHandler(this.txtQrCode_TextChanged);
            // 
            // gv1
            // 
            this.gv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv1.DataMember = "inventory";
            this.gv1.DataSource = this.sqlDSInventory;
            this.gv1.Location = new System.Drawing.Point(2, 176);
            this.gv1.MainView = this.gridOrderInventory;
            this.gv1.Name = "gv1";
            this.gv1.Size = new System.Drawing.Size(527, 288);
            this.gv1.TabIndex = 2;
            this.gv1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOrderInventory});
            // 
            // gridOrderInventory
            // 
            this.gridOrderInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.name,
            this.product_code,
            this.qr_code,
            this.weight,
            this.created_date});
            this.gridOrderInventory.GridControl = this.gv1;
            this.gridOrderInventory.Name = "gridOrderInventory";
            this.gridOrderInventory.OptionsBehavior.Editable = false;
            this.gridOrderInventory.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridOrderInventory.DoubleClick += new System.EventHandler(this.gridView3_DoubleClick);
            // 
            // name
            // 
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 4;
            // 
            // product_code
            // 
            this.product_code.FieldName = "product_code";
            this.product_code.Name = "product_code";
            this.product_code.Visible = true;
            this.product_code.VisibleIndex = 2;
            // 
            // qr_code
            // 
            this.qr_code.FieldName = "qr_code";
            this.qr_code.Name = "qr_code";
            this.qr_code.Visible = true;
            this.qr_code.VisibleIndex = 0;
            // 
            // weight
            // 
            this.weight.FieldName = "weight";
            this.weight.Name = "weight";
            this.weight.Visible = true;
            this.weight.VisibleIndex = 1;
            // 
            // created_date
            // 
            this.created_date.FieldName = "created_date";
            this.created_date.Name = "created_date";
            this.created_date.Visible = true;
            this.created_date.VisibleIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(0, 0);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 13);
            this.labelControl6.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 563);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductDetail)).EndInit();
            this.panelProductDetail.ResumeLayout(false);
            this.panelProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductDetailGrid)).EndInit();
            this.panelProductDetailGrid.ResumeLayout(false);
            this.panelProductDetailGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelOrder)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderOrderProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderProductDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderOrderInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderInventoryDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderSearchProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderSearchProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderQrCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarProduct;
        private DevExpress.XtraNavBar.NavBarItem navBarProductDetail;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraEditors.PanelControl panelProductDetail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelProductDetailGrid;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridProductDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraNavBar.NavBarItem navBarOrder;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.PanelControl panelOrder;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gv3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOrderOrderProduct;
        private DevExpress.XtraGrid.GridControl gv1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOrderInventory;
        private DevExpress.XtraGrid.GridControl gv2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOrderOrderInventory;
        private DevExpress.XtraEditors.TextEdit txtOrderQrCode;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtOrderSearchProductCode;
        private DevExpress.XtraEditors.TextEdit txtOrderSearchProductName;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDSInventory;
        private DevExpress.XtraGrid.Columns.GridColumn qr_code;
        private DevExpress.XtraGrid.Columns.GridColumn weight;
        private DevExpress.XtraGrid.Columns.GridColumn product_code;
        private DevExpress.XtraGrid.Columns.GridColumn created_date;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn product_weight;
        private DevExpress.XtraGrid.Columns.GridColumn product_product_code;
        private DevExpress.XtraGrid.Columns.GridColumn product_name;
        private DevExpress.XtraGrid.Columns.GridColumn colqr_code2;
        private DevExpress.XtraGrid.Columns.GridColumn colweight2;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_code2;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_date2;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnOrderInventoryDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnOrderProductDelete;
        private DevExpress.XtraEditors.LabelControl lblSumWeight;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnOrderSubmit;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;


    }
}

