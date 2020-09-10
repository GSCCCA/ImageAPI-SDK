namespace GSCCCA.ImageAPI.TestApplication
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtClientSecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtClientId = new System.Windows.Forms.TextBox();
            this.ClientOptionsGrid = new System.Windows.Forms.PropertyGrid();
            this.PropertyGridTiffValidation = new System.Windows.Forms.PropertyGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TabUploadFiles = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileData = new System.Data.DataSet();
            this.UploadFilesTable = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.DownloadFilesTable = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.PnlUploadFiles = new System.Windows.Forms.Panel();
            this.PrgUploadProgress = new System.Windows.Forms.ProgressBar();
            this.LblUploadStatus = new System.Windows.Forms.Label();
            this.TxtUploadBatchName = new System.Windows.Forms.TextBox();
            this.BtnPerformUpload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSelectFiles = new System.Windows.Forms.Button();
            this.TabGetBatches = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LstBatches = new System.Windows.Forms.ListBox();
            this.PropGridBatch = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkShowClosed = new System.Windows.Forms.CheckBox();
            this.BtnGetBatch = new System.Windows.Forms.Button();
            this.PropGridBatchOptions = new System.Windows.Forms.PropertyGrid();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.BtnBatchReport = new System.Windows.Forms.Button();
            this.LblGetBatchStatus = new System.Windows.Forms.Label();
            this.BtnCloseBatch = new System.Windows.Forms.Button();
            this.BtnGetBatches = new System.Windows.Forms.Button();
            this.TabGetBatch = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LstImages = new System.Windows.Forms.ListBox();
            this.PropGridImageInfo = new System.Windows.Forms.PropertyGrid();
            this.panel10 = new System.Windows.Forms.Panel();
            this.TxtBatchNameGetBatch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGetBatchGetBatch = new System.Windows.Forms.Button();
            this.PropGridGetBatchOptions = new System.Windows.Forms.PropertyGrid();
            this.LblGetBatchStatusGetBatch = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
            this.TabDownloadBatch = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.statusImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.FileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDownloadButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnBrowseFolder = new System.Windows.Forms.Button();
            this.BtnListFiles = new System.Windows.Forms.Button();
            this.TxtTargetPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PrgDownloadProgress = new System.Windows.Forms.ProgressBar();
            this.LblDownloadStatus = new System.Windows.Forms.Label();
            this.TxtDownloadBatchName = new System.Windows.Forms.TextBox();
            this.BtnDownloadAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TabReports = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TxtJsonReport = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TxtEmailTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEmailBatchSummaryReport = new System.Windows.Forms.Button();
            this.BtnEmailBatchReport = new System.Windows.Forms.Button();
            this.BtnGetBatchSummaryReport = new System.Windows.Forms.Button();
            this.LblGetReportStatus = new System.Windows.Forms.Label();
            this.BtnGetReport = new System.Windows.Forms.Button();
            this.TxtBatchNameGetReport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TabImageSupport = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LstImageBrowser = new System.Windows.Forms.ListBox();
            this.BtnBrowseImageFolder = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PropertyGridImageInfo = new System.Windows.Forms.PropertyGrid();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LblUploadImageInfoStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBatchNameImageInfo = new System.Windows.Forms.TextBox();
            this.BtnUploadImageFromInfo = new System.Windows.Forms.Button();
            this.BtnSaveImage = new System.Windows.Forms.Button();
            this.BtnTestImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dataColumn8 = new System.Data.DataColumn();
            this.folderBrowserDialogImageInfo = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.TabUploadFiles.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadFilesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadFilesTable)).BeginInit();
            this.PnlUploadFiles.SuspendLayout();
            this.TabGetBatches.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabGetBatch.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.TabDownloadBatch.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.TabReports.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.TabImageSupport.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(39, 525);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 0;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Visible = false;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 581);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Options";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.01887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.98113F));
            this.tableLayoutPanel1.Controls.Add(this.TxtClientSecret, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtClientId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClientOptionsGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PropertyGridTiffValidation, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtClientSecret
            // 
            this.TxtClientSecret.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtClientSecret.Location = new System.Drawing.Point(64, 33);
            this.TxtClientSecret.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.TxtClientSecret.Name = "TxtClientSecret";
            this.TxtClientSecret.Size = new System.Drawing.Size(171, 20);
            this.TxtClientSecret.TabIndex = 5;
            this.TxtClientSecret.Tag = "Client Secret";
            this.TxtClientSecret.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Secret:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtClientId
            // 
            this.TxtClientId.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtClientId.Location = new System.Drawing.Point(64, 3);
            this.TxtClientId.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.TxtClientId.Name = "TxtClientId";
            this.TxtClientId.Size = new System.Drawing.Size(171, 20);
            this.TxtClientId.TabIndex = 1;
            this.TxtClientId.Tag = "Client ID";
            this.TxtClientId.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // ClientOptionsGrid
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ClientOptionsGrid, 2);
            this.ClientOptionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientOptionsGrid.Location = new System.Drawing.Point(3, 63);
            this.ClientOptionsGrid.Name = "ClientOptionsGrid";
            this.ClientOptionsGrid.Size = new System.Drawing.Size(259, 245);
            this.ClientOptionsGrid.TabIndex = 6;
            this.ClientOptionsGrid.ToolbarVisible = false;
            // 
            // PropertyGridTiffValidation
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PropertyGridTiffValidation, 2);
            this.PropertyGridTiffValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGridTiffValidation.Location = new System.Drawing.Point(3, 314);
            this.PropertyGridTiffValidation.Name = "PropertyGridTiffValidation";
            this.PropertyGridTiffValidation.Size = new System.Drawing.Size(259, 245);
            this.PropertyGridTiffValidation.TabIndex = 7;
            this.PropertyGridTiffValidation.ToolbarVisible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(271, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 581);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.TabUploadFiles);
            this.MainTabControl.Controls.Add(this.TabGetBatches);
            this.MainTabControl.Controls.Add(this.TabGetBatch);
            this.MainTabControl.Controls.Add(this.TabDownloadBatch);
            this.MainTabControl.Controls.Add(this.TabReports);
            this.MainTabControl.Controls.Add(this.TabImageSupport);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(274, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(641, 581);
            this.MainTabControl.TabIndex = 3;
            // 
            // TabUploadFiles
            // 
            this.TabUploadFiles.Controls.Add(this.panel2);
            this.TabUploadFiles.Controls.Add(this.PnlUploadFiles);
            this.TabUploadFiles.Location = new System.Drawing.Point(4, 22);
            this.TabUploadFiles.Name = "TabUploadFiles";
            this.TabUploadFiles.Padding = new System.Windows.Forms.Padding(3);
            this.TabUploadFiles.Size = new System.Drawing.Size(633, 555);
            this.TabUploadFiles.TabIndex = 0;
            this.TabUploadFiles.Text = "Upload Files";
            this.TabUploadFiles.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 461);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataMember = "UploadFiles";
            this.dataGridView1.DataSource = this.FileData;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(627, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.DataPropertyName = "StatusImage";
            this.dataGridViewImageColumn2.FillWeight = 60F;
            this.dataGridViewImageColumn2.HeaderText = "Status";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FilePath";
            this.dataGridViewTextBoxColumn2.FillWeight = 104.3148F;
            this.dataGridViewTextBoxColumn2.HeaderText = "FilePath";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Result";
            this.dataGridViewTextBoxColumn3.FillWeight = 104.3148F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Result";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FileData
            // 
            this.FileData.DataSetName = "NewDataSet";
            this.FileData.Tables.AddRange(new System.Data.DataTable[] {
            this.UploadFilesTable,
            this.DownloadFilesTable});
            // 
            // UploadFilesTable
            // 
            this.UploadFilesTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.UploadFilesTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "FilePath"}, true)});
            this.UploadFilesTable.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn2};
            this.UploadFilesTable.TableName = "UploadFiles";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Status";
            this.dataColumn1.ColumnName = "StatusImage";
            this.dataColumn1.DataType = typeof(object);
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.Caption = "File Path";
            this.dataColumn2.ColumnName = "FilePath";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Result";
            this.dataColumn3.ColumnName = "Result";
            // 
            // DownloadFilesTable
            // 
            this.DownloadFilesTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn7});
            this.DownloadFilesTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "FileId"}, true)});
            this.DownloadFilesTable.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn4};
            this.DownloadFilesTable.TableName = "DownloadFiles";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Status";
            this.dataColumn6.ColumnName = "StatusImage";
            this.dataColumn6.DataType = typeof(object);
            // 
            // dataColumn4
            // 
            this.dataColumn4.AllowDBNull = false;
            this.dataColumn4.Caption = "File ID";
            this.dataColumn4.ColumnName = "FileId";
            this.dataColumn4.DataType = typeof(long);
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "File Name";
            this.dataColumn5.ColumnName = "FileName";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Result";
            this.dataColumn7.ColumnName = "Result";
            // 
            // PnlUploadFiles
            // 
            this.PnlUploadFiles.Controls.Add(this.PrgUploadProgress);
            this.PnlUploadFiles.Controls.Add(this.LblUploadStatus);
            this.PnlUploadFiles.Controls.Add(this.TxtUploadBatchName);
            this.PnlUploadFiles.Controls.Add(this.BtnPerformUpload);
            this.PnlUploadFiles.Controls.Add(this.label3);
            this.PnlUploadFiles.Controls.Add(this.BtnSelectFiles);
            this.PnlUploadFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUploadFiles.Location = new System.Drawing.Point(3, 3);
            this.PnlUploadFiles.Name = "PnlUploadFiles";
            this.PnlUploadFiles.Size = new System.Drawing.Size(627, 88);
            this.PnlUploadFiles.TabIndex = 2;
            // 
            // PrgUploadProgress
            // 
            this.PrgUploadProgress.Location = new System.Drawing.Point(304, 47);
            this.PrgUploadProgress.Name = "PrgUploadProgress";
            this.PrgUploadProgress.Size = new System.Drawing.Size(296, 23);
            this.PrgUploadProgress.TabIndex = 6;
            // 
            // LblUploadStatus
            // 
            this.LblUploadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUploadStatus.Location = new System.Drawing.Point(301, 9);
            this.LblUploadStatus.Name = "LblUploadStatus";
            this.LblUploadStatus.Size = new System.Drawing.Size(299, 35);
            this.LblUploadStatus.TabIndex = 5;
            // 
            // TxtUploadBatchName
            // 
            this.TxtUploadBatchName.Location = new System.Drawing.Point(85, 12);
            this.TxtUploadBatchName.Name = "TxtUploadBatchName";
            this.TxtUploadBatchName.Size = new System.Drawing.Size(170, 20);
            this.TxtUploadBatchName.TabIndex = 4;
            this.TxtUploadBatchName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBatchName_Validating);
            // 
            // BtnPerformUpload
            // 
            this.BtnPerformUpload.Enabled = false;
            this.BtnPerformUpload.Location = new System.Drawing.Point(108, 47);
            this.BtnPerformUpload.Name = "BtnPerformUpload";
            this.BtnPerformUpload.Size = new System.Drawing.Size(147, 23);
            this.BtnPerformUpload.TabIndex = 3;
            this.BtnPerformUpload.Text = "Perform Upload";
            this.BtnPerformUpload.UseVisualStyleBackColor = true;
            this.BtnPerformUpload.Click += new System.EventHandler(this.BtnPerformUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Batch Name:";
            // 
            // BtnSelectFiles
            // 
            this.BtnSelectFiles.Location = new System.Drawing.Point(12, 47);
            this.BtnSelectFiles.Name = "BtnSelectFiles";
            this.BtnSelectFiles.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFiles.TabIndex = 1;
            this.BtnSelectFiles.Text = "Select Files";
            this.BtnSelectFiles.UseVisualStyleBackColor = true;
            this.BtnSelectFiles.Click += new System.EventHandler(this.BtnSelectFiles_Click);
            // 
            // TabGetBatches
            // 
            this.TabGetBatches.Controls.Add(this.tableLayoutPanel2);
            this.TabGetBatches.Controls.Add(this.panel1);
            this.TabGetBatches.Location = new System.Drawing.Point(4, 22);
            this.TabGetBatches.Name = "TabGetBatches";
            this.TabGetBatches.Padding = new System.Windows.Forms.Padding(3);
            this.TabGetBatches.Size = new System.Drawing.Size(633, 555);
            this.TabGetBatches.TabIndex = 2;
            this.TabGetBatches.Text = "Get Batches";
            this.TabGetBatches.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LstBatches, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PropGridBatch, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 167);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(627, 385);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // LstBatches
            // 
            this.LstBatches.DisplayMember = "BatchName";
            this.LstBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstBatches.FormattingEnabled = true;
            this.LstBatches.Location = new System.Drawing.Point(3, 3);
            this.LstBatches.Name = "LstBatches";
            this.LstBatches.Size = new System.Drawing.Size(307, 379);
            this.LstBatches.TabIndex = 0;
            this.LstBatches.SelectedValueChanged += new System.EventHandler(this.LstBatches_SelectedValueChanged);
            // 
            // PropGridBatch
            // 
            this.PropGridBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropGridBatch.Location = new System.Drawing.Point(316, 3);
            this.PropGridBatch.Name = "PropGridBatch";
            this.PropGridBatch.Size = new System.Drawing.Size(308, 379);
            this.PropGridBatch.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChkShowClosed);
            this.panel1.Controls.Add(this.BtnGetBatch);
            this.panel1.Controls.Add(this.PropGridBatchOptions);
            this.panel1.Controls.Add(this.BtnDownload);
            this.panel1.Controls.Add(this.BtnBatchReport);
            this.panel1.Controls.Add(this.LblGetBatchStatus);
            this.panel1.Controls.Add(this.BtnCloseBatch);
            this.panel1.Controls.Add(this.BtnGetBatches);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 164);
            this.panel1.TabIndex = 3;
            // 
            // ChkShowClosed
            // 
            this.ChkShowClosed.AutoSize = true;
            this.ChkShowClosed.Location = new System.Drawing.Point(117, 14);
            this.ChkShowClosed.Name = "ChkShowClosed";
            this.ChkShowClosed.Size = new System.Drawing.Size(88, 17);
            this.ChkShowClosed.TabIndex = 9;
            this.ChkShowClosed.Text = "Show Closed";
            this.ChkShowClosed.UseVisualStyleBackColor = true;
            // 
            // BtnGetBatch
            // 
            this.BtnGetBatch.Enabled = false;
            this.BtnGetBatch.Location = new System.Drawing.Point(17, 39);
            this.BtnGetBatch.Name = "BtnGetBatch";
            this.BtnGetBatch.Size = new System.Drawing.Size(93, 23);
            this.BtnGetBatch.TabIndex = 8;
            this.BtnGetBatch.Text = "GetBatch";
            this.BtnGetBatch.UseVisualStyleBackColor = true;
            this.BtnGetBatch.Click += new System.EventHandler(this.BtnGetBatch_Click);
            // 
            // PropGridBatchOptions
            // 
            this.PropGridBatchOptions.HelpVisible = false;
            this.PropGridBatchOptions.Location = new System.Drawing.Point(211, 9);
            this.PropGridBatchOptions.Name = "PropGridBatchOptions";
            this.PropGridBatchOptions.Size = new System.Drawing.Size(210, 149);
            this.PropGridBatchOptions.TabIndex = 7;
            // 
            // BtnDownload
            // 
            this.BtnDownload.Enabled = false;
            this.BtnDownload.Location = new System.Drawing.Point(17, 97);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(93, 23);
            this.BtnDownload.TabIndex = 6;
            this.BtnDownload.Text = "Download";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // BtnBatchReport
            // 
            this.BtnBatchReport.Enabled = false;
            this.BtnBatchReport.Location = new System.Drawing.Point(17, 68);
            this.BtnBatchReport.Name = "BtnBatchReport";
            this.BtnBatchReport.Size = new System.Drawing.Size(93, 23);
            this.BtnBatchReport.TabIndex = 5;
            this.BtnBatchReport.Text = "Batch Report";
            this.BtnBatchReport.UseVisualStyleBackColor = true;
            this.BtnBatchReport.Click += new System.EventHandler(this.BtnBatchReport_Click);
            // 
            // LblGetBatchStatus
            // 
            this.LblGetBatchStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblGetBatchStatus.Location = new System.Drawing.Point(427, 14);
            this.LblGetBatchStatus.Name = "LblGetBatchStatus";
            this.LblGetBatchStatus.Size = new System.Drawing.Size(195, 144);
            this.LblGetBatchStatus.TabIndex = 4;
            // 
            // BtnCloseBatch
            // 
            this.BtnCloseBatch.Enabled = false;
            this.BtnCloseBatch.Location = new System.Drawing.Point(17, 126);
            this.BtnCloseBatch.Name = "BtnCloseBatch";
            this.BtnCloseBatch.Size = new System.Drawing.Size(93, 23);
            this.BtnCloseBatch.TabIndex = 3;
            this.BtnCloseBatch.Text = "Close Batch";
            this.BtnCloseBatch.UseVisualStyleBackColor = true;
            this.BtnCloseBatch.Click += new System.EventHandler(this.BtnCloseBatch_Click);
            // 
            // BtnGetBatches
            // 
            this.BtnGetBatches.Location = new System.Drawing.Point(17, 9);
            this.BtnGetBatches.Name = "BtnGetBatches";
            this.BtnGetBatches.Size = new System.Drawing.Size(93, 23);
            this.BtnGetBatches.TabIndex = 2;
            this.BtnGetBatches.Text = "GetBatches";
            this.BtnGetBatches.UseVisualStyleBackColor = true;
            this.BtnGetBatches.Click += new System.EventHandler(this.BtnGetBatches_Click);
            // 
            // TabGetBatch
            // 
            this.TabGetBatch.Controls.Add(this.tableLayoutPanel3);
            this.TabGetBatch.Controls.Add(this.panel10);
            this.TabGetBatch.Controls.Add(this.listBox1);
            this.TabGetBatch.Controls.Add(this.propertyGrid2);
            this.TabGetBatch.Location = new System.Drawing.Point(4, 22);
            this.TabGetBatch.Name = "TabGetBatch";
            this.TabGetBatch.Padding = new System.Windows.Forms.Padding(3);
            this.TabGetBatch.Size = new System.Drawing.Size(633, 555);
            this.TabGetBatch.TabIndex = 5;
            this.TabGetBatch.Text = "Get Batch";
            this.TabGetBatch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LstImages, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.PropGridImageInfo, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 167);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(627, 385);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // LstImages
            // 
            this.LstImages.DisplayMember = "FileName";
            this.LstImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstImages.FormattingEnabled = true;
            this.LstImages.Location = new System.Drawing.Point(3, 3);
            this.LstImages.Name = "LstImages";
            this.LstImages.Size = new System.Drawing.Size(307, 379);
            this.LstImages.TabIndex = 0;
            this.LstImages.SelectedValueChanged += new System.EventHandler(this.LstImages_SelectedValueChanged);
            // 
            // PropGridImageInfo
            // 
            this.PropGridImageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropGridImageInfo.Location = new System.Drawing.Point(316, 3);
            this.PropGridImageInfo.Name = "PropGridImageInfo";
            this.PropGridImageInfo.Size = new System.Drawing.Size(308, 379);
            this.PropGridImageInfo.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.TxtBatchNameGetBatch);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.BtnGetBatchGetBatch);
            this.panel10.Controls.Add(this.PropGridGetBatchOptions);
            this.panel10.Controls.Add(this.LblGetBatchStatusGetBatch);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(627, 164);
            this.panel10.TabIndex = 6;
            // 
            // TxtBatchNameGetBatch
            // 
            this.TxtBatchNameGetBatch.Location = new System.Drawing.Point(16, 30);
            this.TxtBatchNameGetBatch.Name = "TxtBatchNameGetBatch";
            this.TxtBatchNameGetBatch.Size = new System.Drawing.Size(170, 20);
            this.TxtBatchNameGetBatch.TabIndex = 10;
            this.TxtBatchNameGetBatch.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBatchName_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Batch Name:";
            // 
            // BtnGetBatchGetBatch
            // 
            this.BtnGetBatchGetBatch.Location = new System.Drawing.Point(16, 68);
            this.BtnGetBatchGetBatch.Name = "BtnGetBatchGetBatch";
            this.BtnGetBatchGetBatch.Size = new System.Drawing.Size(170, 23);
            this.BtnGetBatchGetBatch.TabIndex = 8;
            this.BtnGetBatchGetBatch.Text = "GetBatch";
            this.BtnGetBatchGetBatch.UseVisualStyleBackColor = true;
            this.BtnGetBatchGetBatch.Click += new System.EventHandler(this.BtnGetBatchGetBatch_Click);
            // 
            // PropGridGetBatchOptions
            // 
            this.PropGridGetBatchOptions.HelpVisible = false;
            this.PropGridGetBatchOptions.Location = new System.Drawing.Point(211, 9);
            this.PropGridGetBatchOptions.Name = "PropGridGetBatchOptions";
            this.PropGridGetBatchOptions.Size = new System.Drawing.Size(210, 149);
            this.PropGridGetBatchOptions.TabIndex = 7;
            // 
            // LblGetBatchStatusGetBatch
            // 
            this.LblGetBatchStatusGetBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblGetBatchStatusGetBatch.Location = new System.Drawing.Point(427, 14);
            this.LblGetBatchStatusGetBatch.Name = "LblGetBatchStatusGetBatch";
            this.LblGetBatchStatusGetBatch.Size = new System.Drawing.Size(195, 144);
            this.LblGetBatchStatusGetBatch.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "BatchName";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(627, 549);
            this.listBox1.TabIndex = 4;
            // 
            // propertyGrid2
            // 
            this.propertyGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid2.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid2.Name = "propertyGrid2";
            this.propertyGrid2.Size = new System.Drawing.Size(627, 549);
            this.propertyGrid2.TabIndex = 5;
            // 
            // TabDownloadBatch
            // 
            this.TabDownloadBatch.Controls.Add(this.panel4);
            this.TabDownloadBatch.Controls.Add(this.panel3);
            this.TabDownloadBatch.Location = new System.Drawing.Point(4, 22);
            this.TabDownloadBatch.Name = "TabDownloadBatch";
            this.TabDownloadBatch.Padding = new System.Windows.Forms.Padding(3);
            this.TabDownloadBatch.Size = new System.Drawing.Size(633, 555);
            this.TabDownloadBatch.TabIndex = 1;
            this.TabDownloadBatch.Text = "Download Batch";
            this.TabDownloadBatch.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(627, 461);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusImageDataGridViewTextBoxColumn,
            this.FileId,
            this.FileName,
            this.dataGridViewTextBoxColumn5,
            this.ColumnDownloadButton});
            this.dataGridView2.DataMember = "DownloadFiles";
            this.dataGridView2.DataSource = this.FileData;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(627, 461);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // statusImageDataGridViewTextBoxColumn
            // 
            this.statusImageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusImageDataGridViewTextBoxColumn.DataPropertyName = "StatusImage";
            this.statusImageDataGridViewTextBoxColumn.FillWeight = 60F;
            this.statusImageDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusImageDataGridViewTextBoxColumn.Name = "statusImageDataGridViewTextBoxColumn";
            this.statusImageDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusImageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.statusImageDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusImageDataGridViewTextBoxColumn.Width = 50;
            // 
            // FileId
            // 
            this.FileId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FileId.DataPropertyName = "FileId";
            this.FileId.HeaderText = "File Id";
            this.FileId.Name = "FileId";
            this.FileId.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Result";
            this.dataGridViewTextBoxColumn5.FillWeight = 104.3148F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Result";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ColumnDownloadButton
            // 
            this.ColumnDownloadButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDownloadButton.HeaderText = "Download";
            this.ColumnDownloadButton.Name = "ColumnDownloadButton";
            this.ColumnDownloadButton.ReadOnly = true;
            this.ColumnDownloadButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDownloadButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDownloadButton.Text = "Download";
            this.ColumnDownloadButton.UseColumnTextForButtonValue = true;
            this.ColumnDownloadButton.Width = 60;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnBrowseFolder);
            this.panel3.Controls.Add(this.BtnListFiles);
            this.panel3.Controls.Add(this.TxtTargetPath);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.PrgDownloadProgress);
            this.panel3.Controls.Add(this.LblDownloadStatus);
            this.panel3.Controls.Add(this.TxtDownloadBatchName);
            this.panel3.Controls.Add(this.BtnDownloadAll);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 88);
            this.panel3.TabIndex = 3;
            // 
            // BtnBrowseFolder
            // 
            this.BtnBrowseFolder.CausesValidation = false;
            this.BtnBrowseFolder.Location = new System.Drawing.Point(180, 62);
            this.BtnBrowseFolder.Name = "BtnBrowseFolder";
            this.BtnBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowseFolder.TabIndex = 10;
            this.BtnBrowseFolder.Text = "Browse";
            this.BtnBrowseFolder.UseVisualStyleBackColor = true;
            this.BtnBrowseFolder.Click += new System.EventHandler(this.BtnBrowseFolder_Click);
            // 
            // BtnListFiles
            // 
            this.BtnListFiles.Location = new System.Drawing.Point(270, 12);
            this.BtnListFiles.Name = "BtnListFiles";
            this.BtnListFiles.Size = new System.Drawing.Size(92, 23);
            this.BtnListFiles.TabIndex = 9;
            this.BtnListFiles.Text = "List Files";
            this.BtnListFiles.UseVisualStyleBackColor = true;
            this.BtnListFiles.Click += new System.EventHandler(this.BtnListFiles_Click);
            // 
            // TxtTargetPath
            // 
            this.TxtTargetPath.Location = new System.Drawing.Point(85, 40);
            this.TxtTargetPath.Name = "TxtTargetPath";
            this.TxtTargetPath.Size = new System.Drawing.Size(170, 20);
            this.TxtTargetPath.TabIndex = 8;
            this.TxtTargetPath.Tag = "Target Path";
            this.TxtTargetPath.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Target Path:";
            // 
            // PrgDownloadProgress
            // 
            this.PrgDownloadProgress.Location = new System.Drawing.Point(382, 47);
            this.PrgDownloadProgress.Name = "PrgDownloadProgress";
            this.PrgDownloadProgress.Size = new System.Drawing.Size(218, 23);
            this.PrgDownloadProgress.TabIndex = 6;
            // 
            // LblDownloadStatus
            // 
            this.LblDownloadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDownloadStatus.Location = new System.Drawing.Point(382, 9);
            this.LblDownloadStatus.Name = "LblDownloadStatus";
            this.LblDownloadStatus.Size = new System.Drawing.Size(218, 35);
            this.LblDownloadStatus.TabIndex = 5;
            // 
            // TxtDownloadBatchName
            // 
            this.TxtDownloadBatchName.Location = new System.Drawing.Point(85, 12);
            this.TxtDownloadBatchName.Name = "TxtDownloadBatchName";
            this.TxtDownloadBatchName.Size = new System.Drawing.Size(170, 20);
            this.TxtDownloadBatchName.TabIndex = 4;
            this.TxtDownloadBatchName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBatchName_Validating);
            // 
            // BtnDownloadAll
            // 
            this.BtnDownloadAll.Enabled = false;
            this.BtnDownloadAll.Location = new System.Drawing.Point(270, 41);
            this.BtnDownloadAll.Name = "BtnDownloadAll";
            this.BtnDownloadAll.Size = new System.Drawing.Size(92, 23);
            this.BtnDownloadAll.TabIndex = 3;
            this.BtnDownloadAll.Text = "Download All";
            this.BtnDownloadAll.UseVisualStyleBackColor = true;
            this.BtnDownloadAll.Click += new System.EventHandler(this.BtnDownloadAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Batch Name:";
            // 
            // TabReports
            // 
            this.TabReports.Controls.Add(this.panel9);
            this.TabReports.Controls.Add(this.panel8);
            this.TabReports.Location = new System.Drawing.Point(4, 22);
            this.TabReports.Name = "TabReports";
            this.TabReports.Padding = new System.Windows.Forms.Padding(3);
            this.TabReports.Size = new System.Drawing.Size(633, 555);
            this.TabReports.TabIndex = 3;
            this.TabReports.Text = "Get Report";
            this.TabReports.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.TxtJsonReport);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 102);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(627, 450);
            this.panel9.TabIndex = 1;
            // 
            // TxtJsonReport
            // 
            this.TxtJsonReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtJsonReport.Location = new System.Drawing.Point(0, 0);
            this.TxtJsonReport.Multiline = true;
            this.TxtJsonReport.Name = "TxtJsonReport";
            this.TxtJsonReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtJsonReport.Size = new System.Drawing.Size(627, 450);
            this.TxtJsonReport.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.TxtEmailTo);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.BtnEmailBatchSummaryReport);
            this.panel8.Controls.Add(this.BtnEmailBatchReport);
            this.panel8.Controls.Add(this.BtnGetBatchSummaryReport);
            this.panel8.Controls.Add(this.LblGetReportStatus);
            this.panel8.Controls.Add(this.BtnGetReport);
            this.panel8.Controls.Add(this.TxtBatchNameGetReport);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(627, 99);
            this.panel8.TabIndex = 0;
            // 
            // TxtEmailTo
            // 
            this.TxtEmailTo.Location = new System.Drawing.Point(89, 34);
            this.TxtEmailTo.Name = "TxtEmailTo";
            this.TxtEmailTo.Size = new System.Drawing.Size(201, 20);
            this.TxtEmailTo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email To:";
            // 
            // BtnEmailBatchSummaryReport
            // 
            this.BtnEmailBatchSummaryReport.Location = new System.Drawing.Point(456, 35);
            this.BtnEmailBatchSummaryReport.Name = "BtnEmailBatchSummaryReport";
            this.BtnEmailBatchSummaryReport.Size = new System.Drawing.Size(154, 22);
            this.BtnEmailBatchSummaryReport.TabIndex = 6;
            this.BtnEmailBatchSummaryReport.Text = "Email Batch Summary Report";
            this.BtnEmailBatchSummaryReport.UseVisualStyleBackColor = true;
            this.BtnEmailBatchSummaryReport.Click += new System.EventHandler(this.BtnEmailBatchSummaryReport_Click);
            // 
            // BtnEmailBatchReport
            // 
            this.BtnEmailBatchReport.Location = new System.Drawing.Point(456, 7);
            this.BtnEmailBatchReport.Name = "BtnEmailBatchReport";
            this.BtnEmailBatchReport.Size = new System.Drawing.Size(154, 20);
            this.BtnEmailBatchReport.TabIndex = 5;
            this.BtnEmailBatchReport.Text = "Email Batch Report";
            this.BtnEmailBatchReport.UseVisualStyleBackColor = true;
            this.BtnEmailBatchReport.Click += new System.EventHandler(this.BtnEmailBatchReport_Click);
            // 
            // BtnGetBatchSummaryReport
            // 
            this.BtnGetBatchSummaryReport.Location = new System.Drawing.Point(296, 34);
            this.BtnGetBatchSummaryReport.Name = "BtnGetBatchSummaryReport";
            this.BtnGetBatchSummaryReport.Size = new System.Drawing.Size(154, 23);
            this.BtnGetBatchSummaryReport.TabIndex = 4;
            this.BtnGetBatchSummaryReport.Text = "Get Batch Summary Report";
            this.BtnGetBatchSummaryReport.UseVisualStyleBackColor = true;
            this.BtnGetBatchSummaryReport.Click += new System.EventHandler(this.BtnGetBatchSummaryReport_Click);
            // 
            // LblGetReportStatus
            // 
            this.LblGetReportStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblGetReportStatus.Location = new System.Drawing.Point(0, 65);
            this.LblGetReportStatus.Name = "LblGetReportStatus";
            this.LblGetReportStatus.Padding = new System.Windows.Forms.Padding(5);
            this.LblGetReportStatus.Size = new System.Drawing.Size(627, 34);
            this.LblGetReportStatus.TabIndex = 3;
            // 
            // BtnGetReport
            // 
            this.BtnGetReport.Location = new System.Drawing.Point(296, 8);
            this.BtnGetReport.Name = "BtnGetReport";
            this.BtnGetReport.Size = new System.Drawing.Size(154, 20);
            this.BtnGetReport.TabIndex = 2;
            this.BtnGetReport.Text = "Get Batch Report";
            this.BtnGetReport.UseVisualStyleBackColor = true;
            this.BtnGetReport.Click += new System.EventHandler(this.BtnGetReport_Click);
            // 
            // TxtBatchNameGetReport
            // 
            this.TxtBatchNameGetReport.Location = new System.Drawing.Point(88, 8);
            this.TxtBatchNameGetReport.Name = "TxtBatchNameGetReport";
            this.TxtBatchNameGetReport.Size = new System.Drawing.Size(201, 20);
            this.TxtBatchNameGetReport.TabIndex = 1;
            this.TxtBatchNameGetReport.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBatchName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Batch Name:";
            // 
            // TabImageSupport
            // 
            this.TabImageSupport.Controls.Add(this.panel6);
            this.TabImageSupport.Controls.Add(this.panel5);
            this.TabImageSupport.Controls.Add(this.BtnTestImage);
            this.TabImageSupport.Location = new System.Drawing.Point(4, 22);
            this.TabImageSupport.Name = "TabImageSupport";
            this.TabImageSupport.Padding = new System.Windows.Forms.Padding(3);
            this.TabImageSupport.Size = new System.Drawing.Size(633, 555);
            this.TabImageSupport.TabIndex = 4;
            this.TabImageSupport.Text = "Image Info";
            this.TabImageSupport.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LstImageBrowser);
            this.panel6.Controls.Add(this.BtnBrowseImageFolder);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(291, 549);
            this.panel6.TabIndex = 3;
            // 
            // LstImageBrowser
            // 
            this.LstImageBrowser.DisplayMember = "FileName";
            this.LstImageBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstImageBrowser.FormattingEnabled = true;
            this.LstImageBrowser.Location = new System.Drawing.Point(0, 23);
            this.LstImageBrowser.Name = "LstImageBrowser";
            this.LstImageBrowser.Size = new System.Drawing.Size(291, 526);
            this.LstImageBrowser.TabIndex = 1;
            this.LstImageBrowser.SelectedValueChanged += new System.EventHandler(this.LstImageBrowser_SelectedValueChanged);
            // 
            // BtnBrowseImageFolder
            // 
            this.BtnBrowseImageFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBrowseImageFolder.Location = new System.Drawing.Point(0, 0);
            this.BtnBrowseImageFolder.Name = "BtnBrowseImageFolder";
            this.BtnBrowseImageFolder.Size = new System.Drawing.Size(291, 23);
            this.BtnBrowseImageFolder.TabIndex = 0;
            this.BtnBrowseImageFolder.Text = "Browse Folder";
            this.BtnBrowseImageFolder.UseVisualStyleBackColor = true;
            this.BtnBrowseImageFolder.Click += new System.EventHandler(this.BtnBrowseImageFolder_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.PropertyGridImageInfo);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.BtnSaveImage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(294, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(336, 549);
            this.panel5.TabIndex = 2;
            // 
            // PropertyGridImageInfo
            // 
            this.PropertyGridImageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGridImageInfo.Location = new System.Drawing.Point(0, 0);
            this.PropertyGridImageInfo.Name = "PropertyGridImageInfo";
            this.PropertyGridImageInfo.Size = new System.Drawing.Size(336, 464);
            this.PropertyGridImageInfo.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LblUploadImageInfoStatus);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.TxtBatchNameImageInfo);
            this.panel7.Controls.Add(this.BtnUploadImageFromInfo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 464);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(336, 62);
            this.panel7.TabIndex = 4;
            // 
            // LblUploadImageInfoStatus
            // 
            this.LblUploadImageInfoStatus.AutoSize = true;
            this.LblUploadImageInfoStatus.Location = new System.Drawing.Point(136, 7);
            this.LblUploadImageInfoStatus.Name = "LblUploadImageInfoStatus";
            this.LblUploadImageInfoStatus.Size = new System.Drawing.Size(0, 13);
            this.LblUploadImageInfoStatus.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Batch Name:";
            // 
            // TxtBatchNameImageInfo
            // 
            this.TxtBatchNameImageInfo.Location = new System.Drawing.Point(6, 28);
            this.TxtBatchNameImageInfo.Name = "TxtBatchNameImageInfo";
            this.TxtBatchNameImageInfo.Size = new System.Drawing.Size(211, 20);
            this.TxtBatchNameImageInfo.TabIndex = 4;
            this.TxtBatchNameImageInfo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBatchName_Validating);
            // 
            // BtnUploadImageFromInfo
            // 
            this.BtnUploadImageFromInfo.Location = new System.Drawing.Point(223, 28);
            this.BtnUploadImageFromInfo.Name = "BtnUploadImageFromInfo";
            this.BtnUploadImageFromInfo.Size = new System.Drawing.Size(108, 23);
            this.BtnUploadImageFromInfo.TabIndex = 3;
            this.BtnUploadImageFromInfo.Text = "Upload Image";
            this.BtnUploadImageFromInfo.UseVisualStyleBackColor = true;
            this.BtnUploadImageFromInfo.Click += new System.EventHandler(this.BtnUploadImageFromInfo_Click);
            // 
            // BtnSaveImage
            // 
            this.BtnSaveImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSaveImage.Location = new System.Drawing.Point(0, 526);
            this.BtnSaveImage.Name = "BtnSaveImage";
            this.BtnSaveImage.Size = new System.Drawing.Size(336, 23);
            this.BtnSaveImage.TabIndex = 2;
            this.BtnSaveImage.Text = "Save Image";
            this.BtnSaveImage.UseVisualStyleBackColor = true;
            this.BtnSaveImage.Click += new System.EventHandler(this.BtnSaveImage_Click);
            // 
            // BtnTestImage
            // 
            this.BtnTestImage.Location = new System.Drawing.Point(47, 57);
            this.BtnTestImage.Name = "BtnTestImage";
            this.BtnTestImage.Size = new System.Drawing.Size(75, 23);
            this.BtnTestImage.TabIndex = 0;
            this.BtnTestImage.Text = "Test";
            this.BtnTestImage.UseVisualStyleBackColor = true;
            this.BtnTestImage.Visible = false;
            this.BtnTestImage.Click += new System.EventHandler(this.BtnTestImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Tiff Files|*.tif;*.tiff";
            this.openFileDialog.Multiselect = true;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Success");
            this.ImageList.Images.SetKeyName(1, "Error");
            this.ImageList.Images.SetKeyName(2, "Processing");
            this.ImageList.Images.SetKeyName(3, "Pending");
            this.ImageList.Images.SetKeyName(4, "Downloading");
            this.ImageList.Images.SetKeyName(5, "Uploading");
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Status";
            this.dataColumn8.ColumnName = "StatusImage";
            this.dataColumn8.DataType = typeof(object);
            // 
            // folderBrowserDialogImageInfo
            // 
            this.folderBrowserDialogImageInfo.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogImageInfo.ShowNewFolderButton = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "tif";
            this.saveFileDialog1.Filter = "Tif Files|*.tif;*.tiff";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 581);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Image API Test Application";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.TabUploadFiles.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadFilesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadFilesTable)).EndInit();
            this.PnlUploadFiles.ResumeLayout(false);
            this.PnlUploadFiles.PerformLayout();
            this.TabGetBatches.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabGetBatch.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.TabDownloadBatch.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TabReports.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.TabImageSupport.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtClientId;
        private System.Windows.Forms.TextBox TxtClientSecret;
        private System.Windows.Forms.PropertyGrid ClientOptionsGrid;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage TabUploadFiles;
        private System.Windows.Forms.TabPage TabDownloadBatch;
        private System.Windows.Forms.Button BtnSelectFiles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet FileData;
        private System.Data.DataTable UploadFilesTable;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlUploadFiles;
        private System.Windows.Forms.TextBox TxtUploadBatchName;
        private System.Windows.Forms.Button BtnPerformUpload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ProgressBar PrgUploadProgress;
        private System.Windows.Forms.Label LblUploadStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage TabGetBatches;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox LstBatches;
        private System.Windows.Forms.PropertyGrid PropGridBatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGetBatches;
        private System.Windows.Forms.Label LblGetBatchStatus;
        private System.Windows.Forms.Button BtnCloseBatch;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Button BtnBatchReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBrowseFolder;
        private System.Windows.Forms.Button BtnListFiles;
        private System.Windows.Forms.TextBox TxtTargetPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar PrgDownloadProgress;
        private System.Windows.Forms.Label LblDownloadStatus;
        private System.Windows.Forms.TextBox TxtDownloadBatchName;
        private System.Windows.Forms.Button BtnDownloadAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Data.DataTable DownloadFilesTable;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridViewImageColumn statusImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDownloadButton;
        private System.Windows.Forms.TabPage TabReports;
        private System.Windows.Forms.TabPage TabImageSupport;
        private System.Windows.Forms.Button BtnTestImage;
        private System.Windows.Forms.PropertyGrid PropertyGridTiffValidation;
        private System.Windows.Forms.PropertyGrid PropertyGridImageInfo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox LstImageBrowser;
        private System.Windows.Forms.Button BtnBrowseImageFolder;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnSaveImage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogImageInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtnUploadImageFromInfo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBatchNameImageInfo;
        private System.Windows.Forms.Label LblUploadImageInfoStatus;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox TxtJsonReport;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label LblGetReportStatus;
        private System.Windows.Forms.Button BtnGetReport;
        private System.Windows.Forms.TextBox TxtBatchNameGetReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnGetBatch;
        private System.Windows.Forms.PropertyGrid PropGridBatchOptions;
        private System.Windows.Forms.CheckBox ChkShowClosed;
        private System.Windows.Forms.TabPage TabGetBatch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox LstImages;
        private System.Windows.Forms.PropertyGrid PropGridImageInfo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button BtnGetBatchGetBatch;
        private System.Windows.Forms.PropertyGrid PropGridGetBatchOptions;
        private System.Windows.Forms.Label LblGetBatchStatusGetBatch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid2;
        private System.Windows.Forms.TextBox TxtBatchNameGetBatch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGetBatchSummaryReport;
        private System.Windows.Forms.Button BtnEmailBatchSummaryReport;
        private System.Windows.Forms.Button BtnEmailBatchReport;
        private System.Windows.Forms.TextBox TxtEmailTo;
        private System.Windows.Forms.Label label4;
    }
}

