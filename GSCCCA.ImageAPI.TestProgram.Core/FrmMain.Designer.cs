namespace GSCCCA.ImageAPI.TestProgram.Core
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BtnTest = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            TxtClientSecret = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            TxtClientId = new System.Windows.Forms.TextBox();
            ClientOptionsGrid = new System.Windows.Forms.PropertyGrid();
            PropertyGridTiffValidation = new System.Windows.Forms.PropertyGrid();
            splitter1 = new System.Windows.Forms.Splitter();
            MainTabControl = new System.Windows.Forms.TabControl();
            TabUploadFiles = new System.Windows.Forms.TabPage();
            panel2 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FileData = new System.Data.DataSet();
            UploadFilesTable = new System.Data.DataTable();
            dataColumn1 = new System.Data.DataColumn();
            dataColumn2 = new System.Data.DataColumn();
            dataColumn3 = new System.Data.DataColumn();
            DownloadFilesTable = new System.Data.DataTable();
            dataColumn6 = new System.Data.DataColumn();
            dataColumn4 = new System.Data.DataColumn();
            dataColumn5 = new System.Data.DataColumn();
            dataColumn7 = new System.Data.DataColumn();
            PnlUploadFiles = new System.Windows.Forms.Panel();
            PrgUploadProgress = new System.Windows.Forms.ProgressBar();
            LblUploadStatus = new System.Windows.Forms.Label();
            TxtUploadBatchName = new System.Windows.Forms.TextBox();
            BtnPerformUpload = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            BtnSelectFiles = new System.Windows.Forms.Button();
            TabGetBatches = new System.Windows.Forms.TabPage();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            LstBatches = new System.Windows.Forms.ListBox();
            PropGridBatch = new System.Windows.Forms.PropertyGrid();
            panel1 = new System.Windows.Forms.Panel();
            ChkShowClosed = new System.Windows.Forms.CheckBox();
            BtnGetBatch = new System.Windows.Forms.Button();
            PropGridBatchOptions = new System.Windows.Forms.PropertyGrid();
            BtnDownload = new System.Windows.Forms.Button();
            BtnBatchReport = new System.Windows.Forms.Button();
            LblGetBatchStatus = new System.Windows.Forms.Label();
            BtnCloseBatch = new System.Windows.Forms.Button();
            BtnGetBatches = new System.Windows.Forms.Button();
            TabGetBatch = new System.Windows.Forms.TabPage();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            LstImages = new System.Windows.Forms.ListBox();
            PropGridImageInfo = new System.Windows.Forms.PropertyGrid();
            panel10 = new System.Windows.Forms.Panel();
            TxtBatchNameGetBatch = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            BtnGetBatchGetBatch = new System.Windows.Forms.Button();
            PropGridGetBatchOptions = new System.Windows.Forms.PropertyGrid();
            LblGetBatchStatusGetBatch = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            propertyGrid2 = new System.Windows.Forms.PropertyGrid();
            TabDownloadBatch = new System.Windows.Forms.TabPage();
            panel4 = new System.Windows.Forms.Panel();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            statusImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            FileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnDownloadButton = new System.Windows.Forms.DataGridViewButtonColumn();
            panel3 = new System.Windows.Forms.Panel();
            BtnBrowseFolder = new System.Windows.Forms.Button();
            BtnListFiles = new System.Windows.Forms.Button();
            TxtTargetPath = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            PrgDownloadProgress = new System.Windows.Forms.ProgressBar();
            LblDownloadStatus = new System.Windows.Forms.Label();
            TxtDownloadBatchName = new System.Windows.Forms.TextBox();
            BtnDownloadAll = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            TabReports = new System.Windows.Forms.TabPage();
            panel9 = new System.Windows.Forms.Panel();
            TxtJsonReport = new System.Windows.Forms.TextBox();
            panel8 = new System.Windows.Forms.Panel();
            TxtEmailTo = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            BtnEmailBatchSummaryReport = new System.Windows.Forms.Button();
            BtnEmailBatchReport = new System.Windows.Forms.Button();
            BtnGetBatchSummaryReport = new System.Windows.Forms.Button();
            LblGetReportStatus = new System.Windows.Forms.Label();
            BtnGetReport = new System.Windows.Forms.Button();
            TxtBatchNameGetReport = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            TabImageSupport = new System.Windows.Forms.TabPage();
            panel6 = new System.Windows.Forms.Panel();
            LstImageBrowser = new System.Windows.Forms.ListBox();
            BtnBrowseImageFolder = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            PropertyGridImageInfo = new System.Windows.Forms.PropertyGrid();
            panel7 = new System.Windows.Forms.Panel();
            LblUploadImageInfoStatus = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            TxtBatchNameImageInfo = new System.Windows.Forms.TextBox();
            BtnUploadImageFromInfo = new System.Windows.Forms.Button();
            BtnSaveImage = new System.Windows.Forms.Button();
            BtnTestImage = new System.Windows.Forms.Button();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ImageList = new System.Windows.Forms.ImageList(components);
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            dataColumn8 = new System.Data.DataColumn();
            folderBrowserDialogImageInfo = new System.Windows.Forms.FolderBrowserDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            MainTabControl.SuspendLayout();
            TabUploadFiles.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FileData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UploadFilesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DownloadFilesTable).BeginInit();
            PnlUploadFiles.SuspendLayout();
            TabGetBatches.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            TabGetBatch.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel10.SuspendLayout();
            TabDownloadBatch.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            TabReports.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            TabImageSupport.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // BtnTest
            // 
            BtnTest.Location = new System.Drawing.Point(46, 606);
            BtnTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnTest.Name = "BtnTest";
            BtnTest.Size = new System.Drawing.Size(88, 27);
            BtnTest.TabIndex = 0;
            BtnTest.Text = "Test";
            BtnTest.UseVisualStyleBackColor = true;
            BtnTest.Visible = false;
            BtnTest.Click += BtnTest_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(316, 670);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client Options";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.01887F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.98113F));
            tableLayoutPanel1.Controls.Add(TxtClientSecret, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(TxtClientId, 1, 0);
            tableLayoutPanel1.Controls.Add(ClientOptionsGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(PropertyGridTiffValidation, 0, 3);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(308, 648);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtClientSecret
            // 
            TxtClientSecret.Dock = System.Windows.Forms.DockStyle.Top;
            TxtClientSecret.Location = new System.Drawing.Point(74, 38);
            TxtClientSecret.Margin = new System.Windows.Forms.Padding(4, 3, 35, 3);
            TxtClientSecret.Name = "TxtClientSecret";
            TxtClientSecret.Size = new System.Drawing.Size(199, 23);
            TxtClientSecret.TabIndex = 5;
            TxtClientSecret.Tag = "Client Secret";
            TxtClientSecret.Validating += RequiredTextBox_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(4, 35);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 30);
            label2.TabIndex = 4;
            label2.Text = "Client Secret:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Location = new System.Drawing.Point(4, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Client ID:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtClientId
            // 
            TxtClientId.Dock = System.Windows.Forms.DockStyle.Top;
            TxtClientId.Location = new System.Drawing.Point(74, 3);
            TxtClientId.Margin = new System.Windows.Forms.Padding(4, 3, 35, 3);
            TxtClientId.Name = "TxtClientId";
            TxtClientId.Size = new System.Drawing.Size(199, 23);
            TxtClientId.TabIndex = 1;
            TxtClientId.Tag = "Client ID";
            TxtClientId.Validating += RequiredTextBox_Validating;
            // 
            // ClientOptionsGrid
            // 
            tableLayoutPanel1.SetColumnSpan(ClientOptionsGrid, 2);
            ClientOptionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            ClientOptionsGrid.Location = new System.Drawing.Point(4, 73);
            ClientOptionsGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ClientOptionsGrid.Name = "ClientOptionsGrid";
            ClientOptionsGrid.Size = new System.Drawing.Size(300, 283);
            ClientOptionsGrid.TabIndex = 6;
            ClientOptionsGrid.ToolbarVisible = false;
            // 
            // PropertyGridTiffValidation
            // 
            tableLayoutPanel1.SetColumnSpan(PropertyGridTiffValidation, 2);
            PropertyGridTiffValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            PropertyGridTiffValidation.Location = new System.Drawing.Point(4, 362);
            PropertyGridTiffValidation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PropertyGridTiffValidation.Name = "PropertyGridTiffValidation";
            PropertyGridTiffValidation.Size = new System.Drawing.Size(300, 283);
            PropertyGridTiffValidation.TabIndex = 7;
            PropertyGridTiffValidation.ToolbarVisible = false;
            // 
            // splitter1
            // 
            splitter1.Location = new System.Drawing.Point(316, 0);
            splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(4, 670);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // MainTabControl
            // 
            MainTabControl.CausesValidation = false;
            MainTabControl.Controls.Add(TabUploadFiles);
            MainTabControl.Controls.Add(TabGetBatches);
            MainTabControl.Controls.Add(TabGetBatch);
            MainTabControl.Controls.Add(TabDownloadBatch);
            MainTabControl.Controls.Add(TabReports);
            MainTabControl.Controls.Add(TabImageSupport);
            MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            MainTabControl.Location = new System.Drawing.Point(320, 0);
            MainTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new System.Drawing.Size(748, 670);
            MainTabControl.TabIndex = 3;
            // 
            // TabUploadFiles
            // 
            TabUploadFiles.Controls.Add(panel2);
            TabUploadFiles.Controls.Add(PnlUploadFiles);
            TabUploadFiles.Location = new System.Drawing.Point(4, 24);
            TabUploadFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabUploadFiles.Name = "TabUploadFiles";
            TabUploadFiles.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabUploadFiles.Size = new System.Drawing.Size(740, 642);
            TabUploadFiles.TabIndex = 0;
            TabUploadFiles.Text = "Upload Files";
            TabUploadFiles.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(4, 105);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(732, 534);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewImageColumn2, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.DataMember = "UploadFiles";
            dataGridView1.DataSource = FileData;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(732, 534);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewImageColumn2.DataPropertyName = "StatusImage";
            dataGridViewImageColumn2.FillWeight = 60F;
            dataGridViewImageColumn2.HeaderText = "Status";
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.ReadOnly = true;
            dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FilePath";
            dataGridViewTextBoxColumn2.FillWeight = 104.3148F;
            dataGridViewTextBoxColumn2.HeaderText = "FilePath";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Result";
            dataGridViewTextBoxColumn3.FillWeight = 104.3148F;
            dataGridViewTextBoxColumn3.HeaderText = "Result";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FileData
            // 
            FileData.DataSetName = "NewDataSet";
            FileData.Tables.AddRange(new System.Data.DataTable[] { UploadFilesTable, DownloadFilesTable });
            // 
            // UploadFilesTable
            // 
            UploadFilesTable.Columns.AddRange(new System.Data.DataColumn[] { dataColumn1, dataColumn2, dataColumn3 });
            UploadFilesTable.Constraints.AddRange(new System.Data.Constraint[] { new System.Data.UniqueConstraint("Constraint1", new string[] { "FilePath" }, true) });
            UploadFilesTable.Namespace = "";
            UploadFilesTable.PrimaryKey = new System.Data.DataColumn[] { dataColumn2 };
            UploadFilesTable.TableName = "UploadFiles";
            // 
            // dataColumn1
            // 
            dataColumn1.Caption = "Status";
            dataColumn1.ColumnName = "StatusImage";
            dataColumn1.DataType = typeof(object);
            dataColumn1.DefaultValue = resources.GetObject("dataColumn1.DefaultValue");
            dataColumn1.Namespace = "";
            // 
            // dataColumn2
            // 
            dataColumn2.AllowDBNull = false;
            dataColumn2.Caption = "File Path";
            dataColumn2.ColumnName = "FilePath";
            dataColumn2.DefaultValue = resources.GetObject("dataColumn2.DefaultValue");
            dataColumn2.Namespace = "";
            // 
            // dataColumn3
            // 
            dataColumn3.Caption = "Result";
            dataColumn3.ColumnName = "Result";
            dataColumn3.DefaultValue = resources.GetObject("dataColumn3.DefaultValue");
            dataColumn3.Namespace = "";
            // 
            // DownloadFilesTable
            // 
            DownloadFilesTable.Columns.AddRange(new System.Data.DataColumn[] { dataColumn6, dataColumn4, dataColumn5, dataColumn7 });
            DownloadFilesTable.Constraints.AddRange(new System.Data.Constraint[] { new System.Data.UniqueConstraint("Constraint1", new string[] { "FileId" }, true) });
            DownloadFilesTable.Namespace = "";
            DownloadFilesTable.PrimaryKey = new System.Data.DataColumn[] { dataColumn4 };
            DownloadFilesTable.TableName = "DownloadFiles";
            // 
            // dataColumn6
            // 
            dataColumn6.Caption = "Status";
            dataColumn6.ColumnName = "StatusImage";
            dataColumn6.DataType = typeof(object);
            dataColumn6.DefaultValue = resources.GetObject("dataColumn6.DefaultValue");
            dataColumn6.Namespace = "";
            // 
            // dataColumn4
            // 
            dataColumn4.AllowDBNull = false;
            dataColumn4.Caption = "File ID";
            dataColumn4.ColumnName = "FileId";
            dataColumn4.DataType = typeof(long);
            dataColumn4.DefaultValue = resources.GetObject("dataColumn4.DefaultValue");
            dataColumn4.Namespace = "";
            // 
            // dataColumn5
            // 
            dataColumn5.Caption = "File Name";
            dataColumn5.ColumnName = "FileName";
            dataColumn5.DefaultValue = resources.GetObject("dataColumn5.DefaultValue");
            dataColumn5.Namespace = "";
            // 
            // dataColumn7
            // 
            dataColumn7.Caption = "Result";
            dataColumn7.ColumnName = "Result";
            dataColumn7.DefaultValue = resources.GetObject("dataColumn7.DefaultValue");
            dataColumn7.Namespace = "";
            // 
            // PnlUploadFiles
            // 
            PnlUploadFiles.Controls.Add(PrgUploadProgress);
            PnlUploadFiles.Controls.Add(LblUploadStatus);
            PnlUploadFiles.Controls.Add(TxtUploadBatchName);
            PnlUploadFiles.Controls.Add(BtnPerformUpload);
            PnlUploadFiles.Controls.Add(label3);
            PnlUploadFiles.Controls.Add(BtnSelectFiles);
            PnlUploadFiles.Dock = System.Windows.Forms.DockStyle.Top;
            PnlUploadFiles.Location = new System.Drawing.Point(4, 3);
            PnlUploadFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PnlUploadFiles.Name = "PnlUploadFiles";
            PnlUploadFiles.Size = new System.Drawing.Size(732, 102);
            PnlUploadFiles.TabIndex = 2;
            // 
            // PrgUploadProgress
            // 
            PrgUploadProgress.Location = new System.Drawing.Point(355, 54);
            PrgUploadProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PrgUploadProgress.Name = "PrgUploadProgress";
            PrgUploadProgress.Size = new System.Drawing.Size(345, 27);
            PrgUploadProgress.TabIndex = 6;
            // 
            // LblUploadStatus
            // 
            LblUploadStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LblUploadStatus.Location = new System.Drawing.Point(351, 10);
            LblUploadStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblUploadStatus.Name = "LblUploadStatus";
            LblUploadStatus.Size = new System.Drawing.Size(349, 40);
            LblUploadStatus.TabIndex = 5;
            // 
            // TxtUploadBatchName
            // 
            TxtUploadBatchName.Location = new System.Drawing.Point(99, 14);
            TxtUploadBatchName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtUploadBatchName.Name = "TxtUploadBatchName";
            TxtUploadBatchName.Size = new System.Drawing.Size(198, 23);
            TxtUploadBatchName.TabIndex = 4;
            TxtUploadBatchName.Validating += TxtBatchName_Validating;
            // 
            // BtnPerformUpload
            // 
            BtnPerformUpload.Enabled = false;
            BtnPerformUpload.Location = new System.Drawing.Point(126, 54);
            BtnPerformUpload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnPerformUpload.Name = "BtnPerformUpload";
            BtnPerformUpload.Size = new System.Drawing.Size(172, 27);
            BtnPerformUpload.TabIndex = 3;
            BtnPerformUpload.Text = "Perform Upload";
            BtnPerformUpload.UseVisualStyleBackColor = true;
            BtnPerformUpload.Click += BtnPerformUpload_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 14);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Batch Name:";
            // 
            // BtnSelectFiles
            // 
            BtnSelectFiles.Location = new System.Drawing.Point(14, 54);
            BtnSelectFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnSelectFiles.Name = "BtnSelectFiles";
            BtnSelectFiles.Size = new System.Drawing.Size(88, 27);
            BtnSelectFiles.TabIndex = 1;
            BtnSelectFiles.Text = "Select Files";
            BtnSelectFiles.UseVisualStyleBackColor = true;
            BtnSelectFiles.Click += BtnSelectFiles_Click;
            // 
            // TabGetBatches
            // 
            TabGetBatches.Controls.Add(tableLayoutPanel2);
            TabGetBatches.Controls.Add(panel1);
            TabGetBatches.Location = new System.Drawing.Point(4, 24);
            TabGetBatches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabGetBatches.Name = "TabGetBatches";
            TabGetBatches.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabGetBatches.Size = new System.Drawing.Size(740, 642);
            TabGetBatches.TabIndex = 2;
            TabGetBatches.Text = "Get Batches";
            TabGetBatches.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LstBatches, 0, 0);
            tableLayoutPanel2.Controls.Add(PropGridBatch, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(4, 192);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(732, 447);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // LstBatches
            // 
            LstBatches.DisplayMember = "BatchName";
            LstBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            LstBatches.FormattingEnabled = true;
            LstBatches.ItemHeight = 15;
            LstBatches.Location = new System.Drawing.Point(4, 3);
            LstBatches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LstBatches.Name = "LstBatches";
            LstBatches.Size = new System.Drawing.Size(358, 441);
            LstBatches.TabIndex = 0;
            LstBatches.SelectedValueChanged += LstBatches_SelectedValueChanged;
            // 
            // PropGridBatch
            // 
            PropGridBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            PropGridBatch.Location = new System.Drawing.Point(370, 3);
            PropGridBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PropGridBatch.Name = "PropGridBatch";
            PropGridBatch.Size = new System.Drawing.Size(358, 441);
            PropGridBatch.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(ChkShowClosed);
            panel1.Controls.Add(BtnGetBatch);
            panel1.Controls.Add(PropGridBatchOptions);
            panel1.Controls.Add(BtnDownload);
            panel1.Controls.Add(BtnBatchReport);
            panel1.Controls.Add(LblGetBatchStatus);
            panel1.Controls.Add(BtnCloseBatch);
            panel1.Controls.Add(BtnGetBatches);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(4, 3);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(732, 189);
            panel1.TabIndex = 3;
            // 
            // ChkShowClosed
            // 
            ChkShowClosed.AutoSize = true;
            ChkShowClosed.Location = new System.Drawing.Point(136, 16);
            ChkShowClosed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkShowClosed.Name = "ChkShowClosed";
            ChkShowClosed.Size = new System.Drawing.Size(94, 19);
            ChkShowClosed.TabIndex = 9;
            ChkShowClosed.Text = "Show Closed";
            ChkShowClosed.UseVisualStyleBackColor = true;
            // 
            // BtnGetBatch
            // 
            BtnGetBatch.Enabled = false;
            BtnGetBatch.Location = new System.Drawing.Point(20, 45);
            BtnGetBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnGetBatch.Name = "BtnGetBatch";
            BtnGetBatch.Size = new System.Drawing.Size(108, 27);
            BtnGetBatch.TabIndex = 8;
            BtnGetBatch.Text = "GetBatch";
            BtnGetBatch.UseVisualStyleBackColor = true;
            BtnGetBatch.Click += BtnGetBatch_Click;
            // 
            // PropGridBatchOptions
            // 
            PropGridBatchOptions.HelpVisible = false;
            PropGridBatchOptions.Location = new System.Drawing.Point(246, 10);
            PropGridBatchOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PropGridBatchOptions.Name = "PropGridBatchOptions";
            PropGridBatchOptions.Size = new System.Drawing.Size(245, 172);
            PropGridBatchOptions.TabIndex = 7;
            // 
            // BtnDownload
            // 
            BtnDownload.Enabled = false;
            BtnDownload.Location = new System.Drawing.Point(20, 112);
            BtnDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnDownload.Name = "BtnDownload";
            BtnDownload.Size = new System.Drawing.Size(108, 27);
            BtnDownload.TabIndex = 6;
            BtnDownload.Text = "Download";
            BtnDownload.UseVisualStyleBackColor = true;
            BtnDownload.Click += BtnDownload_Click;
            // 
            // BtnBatchReport
            // 
            BtnBatchReport.Enabled = false;
            BtnBatchReport.Location = new System.Drawing.Point(20, 78);
            BtnBatchReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnBatchReport.Name = "BtnBatchReport";
            BtnBatchReport.Size = new System.Drawing.Size(108, 27);
            BtnBatchReport.TabIndex = 5;
            BtnBatchReport.Text = "Batch Report";
            BtnBatchReport.UseVisualStyleBackColor = true;
            BtnBatchReport.Click += BtnBatchReport_Click;
            // 
            // LblGetBatchStatus
            // 
            LblGetBatchStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LblGetBatchStatus.Location = new System.Drawing.Point(498, 16);
            LblGetBatchStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblGetBatchStatus.Name = "LblGetBatchStatus";
            LblGetBatchStatus.Size = new System.Drawing.Size(227, 166);
            LblGetBatchStatus.TabIndex = 4;
            // 
            // BtnCloseBatch
            // 
            BtnCloseBatch.Enabled = false;
            BtnCloseBatch.Location = new System.Drawing.Point(20, 145);
            BtnCloseBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnCloseBatch.Name = "BtnCloseBatch";
            BtnCloseBatch.Size = new System.Drawing.Size(108, 27);
            BtnCloseBatch.TabIndex = 3;
            BtnCloseBatch.Text = "Close Batch";
            BtnCloseBatch.UseVisualStyleBackColor = true;
            BtnCloseBatch.Click += BtnCloseBatch_Click;
            // 
            // BtnGetBatches
            // 
            BtnGetBatches.Location = new System.Drawing.Point(20, 10);
            BtnGetBatches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnGetBatches.Name = "BtnGetBatches";
            BtnGetBatches.Size = new System.Drawing.Size(108, 27);
            BtnGetBatches.TabIndex = 2;
            BtnGetBatches.Text = "GetBatches";
            BtnGetBatches.UseVisualStyleBackColor = true;
            BtnGetBatches.Click += BtnGetBatches_Click;
            // 
            // TabGetBatch
            // 
            TabGetBatch.Controls.Add(tableLayoutPanel3);
            TabGetBatch.Controls.Add(panel10);
            TabGetBatch.Controls.Add(listBox1);
            TabGetBatch.Controls.Add(propertyGrid2);
            TabGetBatch.Location = new System.Drawing.Point(4, 24);
            TabGetBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabGetBatch.Name = "TabGetBatch";
            TabGetBatch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabGetBatch.Size = new System.Drawing.Size(740, 642);
            TabGetBatch.TabIndex = 5;
            TabGetBatch.Text = "Get Batch";
            TabGetBatch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(LstImages, 0, 0);
            tableLayoutPanel3.Controls.Add(PropGridImageInfo, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(4, 192);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(732, 447);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // LstImages
            // 
            LstImages.DisplayMember = "FileName";
            LstImages.Dock = System.Windows.Forms.DockStyle.Fill;
            LstImages.FormattingEnabled = true;
            LstImages.ItemHeight = 15;
            LstImages.Location = new System.Drawing.Point(4, 3);
            LstImages.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LstImages.Name = "LstImages";
            LstImages.Size = new System.Drawing.Size(358, 441);
            LstImages.TabIndex = 0;
            LstImages.SelectedValueChanged += LstImages_SelectedValueChanged;
            // 
            // PropGridImageInfo
            // 
            PropGridImageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            PropGridImageInfo.Location = new System.Drawing.Point(370, 3);
            PropGridImageInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PropGridImageInfo.Name = "PropGridImageInfo";
            PropGridImageInfo.Size = new System.Drawing.Size(358, 441);
            PropGridImageInfo.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(TxtBatchNameGetBatch);
            panel10.Controls.Add(label9);
            panel10.Controls.Add(BtnGetBatchGetBatch);
            panel10.Controls.Add(PropGridGetBatchOptions);
            panel10.Controls.Add(LblGetBatchStatusGetBatch);
            panel10.Dock = System.Windows.Forms.DockStyle.Top;
            panel10.Location = new System.Drawing.Point(4, 3);
            panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(732, 189);
            panel10.TabIndex = 6;
            // 
            // TxtBatchNameGetBatch
            // 
            TxtBatchNameGetBatch.Location = new System.Drawing.Point(19, 35);
            TxtBatchNameGetBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBatchNameGetBatch.Name = "TxtBatchNameGetBatch";
            TxtBatchNameGetBatch.Size = new System.Drawing.Size(198, 23);
            TxtBatchNameGetBatch.TabIndex = 10;
            TxtBatchNameGetBatch.Validating += TxtBatchName_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(15, 16);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(75, 15);
            label9.TabIndex = 9;
            label9.Text = "Batch Name:";
            // 
            // BtnGetBatchGetBatch
            // 
            BtnGetBatchGetBatch.Location = new System.Drawing.Point(19, 78);
            BtnGetBatchGetBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnGetBatchGetBatch.Name = "BtnGetBatchGetBatch";
            BtnGetBatchGetBatch.Size = new System.Drawing.Size(198, 27);
            BtnGetBatchGetBatch.TabIndex = 8;
            BtnGetBatchGetBatch.Text = "GetBatch";
            BtnGetBatchGetBatch.UseVisualStyleBackColor = true;
            BtnGetBatchGetBatch.Click += BtnGetBatchGetBatch_Click;
            // 
            // PropGridGetBatchOptions
            // 
            PropGridGetBatchOptions.HelpVisible = false;
            PropGridGetBatchOptions.Location = new System.Drawing.Point(246, 10);
            PropGridGetBatchOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PropGridGetBatchOptions.Name = "PropGridGetBatchOptions";
            PropGridGetBatchOptions.Size = new System.Drawing.Size(245, 172);
            PropGridGetBatchOptions.TabIndex = 7;
            // 
            // LblGetBatchStatusGetBatch
            // 
            LblGetBatchStatusGetBatch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LblGetBatchStatusGetBatch.Location = new System.Drawing.Point(498, 16);
            LblGetBatchStatusGetBatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblGetBatchStatusGetBatch.Name = "LblGetBatchStatusGetBatch";
            LblGetBatchStatusGetBatch.Size = new System.Drawing.Size(227, 166);
            LblGetBatchStatusGetBatch.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.DisplayMember = "BatchName";
            listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(4, 3);
            listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(732, 636);
            listBox1.TabIndex = 4;
            // 
            // propertyGrid2
            // 
            propertyGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGrid2.Location = new System.Drawing.Point(4, 3);
            propertyGrid2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            propertyGrid2.Name = "propertyGrid2";
            propertyGrid2.Size = new System.Drawing.Size(732, 636);
            propertyGrid2.TabIndex = 5;
            // 
            // TabDownloadBatch
            // 
            TabDownloadBatch.Controls.Add(panel4);
            TabDownloadBatch.Controls.Add(panel3);
            TabDownloadBatch.Location = new System.Drawing.Point(4, 24);
            TabDownloadBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabDownloadBatch.Name = "TabDownloadBatch";
            TabDownloadBatch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabDownloadBatch.Size = new System.Drawing.Size(740, 642);
            TabDownloadBatch.TabIndex = 1;
            TabDownloadBatch.Text = "Download Batch";
            TabDownloadBatch.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.Location = new System.Drawing.Point(4, 105);
            panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(732, 534);
            panel4.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { statusImageDataGridViewTextBoxColumn, FileId, FileName, dataGridViewTextBoxColumn5, ColumnDownloadButton });
            dataGridView2.DataMember = "DownloadFiles";
            dataGridView2.DataSource = FileData;
            dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView2.Location = new System.Drawing.Point(0, 0);
            dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new System.Drawing.Size(732, 534);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // statusImageDataGridViewTextBoxColumn
            // 
            statusImageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            statusImageDataGridViewTextBoxColumn.DataPropertyName = "StatusImage";
            statusImageDataGridViewTextBoxColumn.FillWeight = 60F;
            statusImageDataGridViewTextBoxColumn.HeaderText = "Status";
            statusImageDataGridViewTextBoxColumn.Name = "statusImageDataGridViewTextBoxColumn";
            statusImageDataGridViewTextBoxColumn.ReadOnly = true;
            statusImageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            statusImageDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            statusImageDataGridViewTextBoxColumn.Width = 50;
            // 
            // FileId
            // 
            FileId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            FileId.DataPropertyName = "FileId";
            FileId.HeaderText = "File Id";
            FileId.Name = "FileId";
            FileId.ReadOnly = true;
            // 
            // FileName
            // 
            FileName.DataPropertyName = "FileName";
            FileName.HeaderText = "File Name";
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Result";
            dataGridViewTextBoxColumn5.FillWeight = 104.3148F;
            dataGridViewTextBoxColumn5.HeaderText = "Result";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ColumnDownloadButton
            // 
            ColumnDownloadButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnDownloadButton.HeaderText = "Download";
            ColumnDownloadButton.Name = "ColumnDownloadButton";
            ColumnDownloadButton.ReadOnly = true;
            ColumnDownloadButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ColumnDownloadButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            ColumnDownloadButton.Text = "Download";
            ColumnDownloadButton.UseColumnTextForButtonValue = true;
            ColumnDownloadButton.Width = 60;
            // 
            // panel3
            // 
            panel3.Controls.Add(BtnBrowseFolder);
            panel3.Controls.Add(BtnListFiles);
            panel3.Controls.Add(TxtTargetPath);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(PrgDownloadProgress);
            panel3.Controls.Add(LblDownloadStatus);
            panel3.Controls.Add(TxtDownloadBatchName);
            panel3.Controls.Add(BtnDownloadAll);
            panel3.Controls.Add(label6);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(4, 3);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(732, 102);
            panel3.TabIndex = 3;
            // 
            // BtnBrowseFolder
            // 
            BtnBrowseFolder.CausesValidation = false;
            BtnBrowseFolder.Location = new System.Drawing.Point(210, 72);
            BtnBrowseFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnBrowseFolder.Name = "BtnBrowseFolder";
            BtnBrowseFolder.Size = new System.Drawing.Size(88, 27);
            BtnBrowseFolder.TabIndex = 10;
            BtnBrowseFolder.Text = "Browse";
            BtnBrowseFolder.UseVisualStyleBackColor = true;
            BtnBrowseFolder.Click += BtnBrowseFolder_Click;
            // 
            // BtnListFiles
            // 
            BtnListFiles.Location = new System.Drawing.Point(315, 14);
            BtnListFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnListFiles.Name = "BtnListFiles";
            BtnListFiles.Size = new System.Drawing.Size(107, 27);
            BtnListFiles.TabIndex = 9;
            BtnListFiles.Text = "List Files";
            BtnListFiles.UseVisualStyleBackColor = true;
            BtnListFiles.Click += BtnListFiles_Click;
            // 
            // TxtTargetPath
            // 
            TxtTargetPath.Location = new System.Drawing.Point(99, 46);
            TxtTargetPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtTargetPath.Name = "TxtTargetPath";
            TxtTargetPath.Size = new System.Drawing.Size(198, 23);
            TxtTargetPath.TabIndex = 8;
            TxtTargetPath.Tag = "Target Path";
            TxtTargetPath.Validating += RequiredTextBox_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(10, 50);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(69, 15);
            label7.TabIndex = 7;
            label7.Text = "Target Path:";
            // 
            // PrgDownloadProgress
            // 
            PrgDownloadProgress.Location = new System.Drawing.Point(446, 54);
            PrgDownloadProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PrgDownloadProgress.Name = "PrgDownloadProgress";
            PrgDownloadProgress.Size = new System.Drawing.Size(254, 27);
            PrgDownloadProgress.TabIndex = 6;
            // 
            // LblDownloadStatus
            // 
            LblDownloadStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LblDownloadStatus.Location = new System.Drawing.Point(446, 10);
            LblDownloadStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblDownloadStatus.Name = "LblDownloadStatus";
            LblDownloadStatus.Size = new System.Drawing.Size(254, 40);
            LblDownloadStatus.TabIndex = 5;
            // 
            // TxtDownloadBatchName
            // 
            TxtDownloadBatchName.Location = new System.Drawing.Point(99, 14);
            TxtDownloadBatchName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtDownloadBatchName.Name = "TxtDownloadBatchName";
            TxtDownloadBatchName.Size = new System.Drawing.Size(198, 23);
            TxtDownloadBatchName.TabIndex = 4;
            TxtDownloadBatchName.Validating += TxtBatchName_Validating;
            // 
            // BtnDownloadAll
            // 
            BtnDownloadAll.Enabled = false;
            BtnDownloadAll.Location = new System.Drawing.Point(315, 47);
            BtnDownloadAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnDownloadAll.Name = "BtnDownloadAll";
            BtnDownloadAll.Size = new System.Drawing.Size(107, 27);
            BtnDownloadAll.TabIndex = 3;
            BtnDownloadAll.Text = "Download All";
            BtnDownloadAll.UseVisualStyleBackColor = true;
            BtnDownloadAll.Click += BtnDownloadAll_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 14);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 15);
            label6.TabIndex = 2;
            label6.Text = "Batch Name:";
            // 
            // TabReports
            // 
            TabReports.Controls.Add(panel9);
            TabReports.Controls.Add(panel8);
            TabReports.Location = new System.Drawing.Point(4, 24);
            TabReports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabReports.Name = "TabReports";
            TabReports.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabReports.Size = new System.Drawing.Size(740, 642);
            TabReports.TabIndex = 3;
            TabReports.Text = "Get Report";
            TabReports.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(TxtJsonReport);
            panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            panel9.Location = new System.Drawing.Point(4, 117);
            panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(732, 522);
            panel9.TabIndex = 1;
            // 
            // TxtJsonReport
            // 
            TxtJsonReport.Dock = System.Windows.Forms.DockStyle.Fill;
            TxtJsonReport.Location = new System.Drawing.Point(0, 0);
            TxtJsonReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtJsonReport.Multiline = true;
            TxtJsonReport.Name = "TxtJsonReport";
            TxtJsonReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            TxtJsonReport.Size = new System.Drawing.Size(732, 522);
            TxtJsonReport.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(TxtEmailTo);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(BtnEmailBatchSummaryReport);
            panel8.Controls.Add(BtnEmailBatchReport);
            panel8.Controls.Add(BtnGetBatchSummaryReport);
            panel8.Controls.Add(LblGetReportStatus);
            panel8.Controls.Add(BtnGetReport);
            panel8.Controls.Add(TxtBatchNameGetReport);
            panel8.Controls.Add(label8);
            panel8.Dock = System.Windows.Forms.DockStyle.Top;
            panel8.Location = new System.Drawing.Point(4, 3);
            panel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(732, 114);
            panel8.TabIndex = 0;
            // 
            // TxtEmailTo
            // 
            TxtEmailTo.Location = new System.Drawing.Point(104, 39);
            TxtEmailTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtEmailTo.Name = "TxtEmailTo";
            TxtEmailTo.Size = new System.Drawing.Size(234, 23);
            TxtEmailTo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 43);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Email To:";
            // 
            // BtnEmailBatchSummaryReport
            // 
            BtnEmailBatchSummaryReport.Location = new System.Drawing.Point(532, 40);
            BtnEmailBatchSummaryReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnEmailBatchSummaryReport.Name = "BtnEmailBatchSummaryReport";
            BtnEmailBatchSummaryReport.Size = new System.Drawing.Size(180, 25);
            BtnEmailBatchSummaryReport.TabIndex = 6;
            BtnEmailBatchSummaryReport.Text = "Email Batch Summary Report";
            BtnEmailBatchSummaryReport.UseVisualStyleBackColor = true;
            BtnEmailBatchSummaryReport.Click += BtnEmailBatchSummaryReport_Click;
            // 
            // BtnEmailBatchReport
            // 
            BtnEmailBatchReport.Location = new System.Drawing.Point(532, 8);
            BtnEmailBatchReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnEmailBatchReport.Name = "BtnEmailBatchReport";
            BtnEmailBatchReport.Size = new System.Drawing.Size(180, 23);
            BtnEmailBatchReport.TabIndex = 5;
            BtnEmailBatchReport.Text = "Email Batch Report";
            BtnEmailBatchReport.UseVisualStyleBackColor = true;
            BtnEmailBatchReport.Click += BtnEmailBatchReport_Click;
            // 
            // BtnGetBatchSummaryReport
            // 
            BtnGetBatchSummaryReport.Location = new System.Drawing.Point(345, 39);
            BtnGetBatchSummaryReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnGetBatchSummaryReport.Name = "BtnGetBatchSummaryReport";
            BtnGetBatchSummaryReport.Size = new System.Drawing.Size(180, 27);
            BtnGetBatchSummaryReport.TabIndex = 4;
            BtnGetBatchSummaryReport.Text = "Get Batch Summary Report";
            BtnGetBatchSummaryReport.UseVisualStyleBackColor = true;
            BtnGetBatchSummaryReport.Click += BtnGetBatchSummaryReport_Click;
            // 
            // LblGetReportStatus
            // 
            LblGetReportStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            LblGetReportStatus.Location = new System.Drawing.Point(0, 75);
            LblGetReportStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblGetReportStatus.Name = "LblGetReportStatus";
            LblGetReportStatus.Padding = new System.Windows.Forms.Padding(6);
            LblGetReportStatus.Size = new System.Drawing.Size(732, 39);
            LblGetReportStatus.TabIndex = 3;
            // 
            // BtnGetReport
            // 
            BtnGetReport.Location = new System.Drawing.Point(345, 9);
            BtnGetReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnGetReport.Name = "BtnGetReport";
            BtnGetReport.Size = new System.Drawing.Size(180, 23);
            BtnGetReport.TabIndex = 2;
            BtnGetReport.Text = "Get Batch Report";
            BtnGetReport.UseVisualStyleBackColor = true;
            BtnGetReport.Click += BtnGetReport_Click;
            // 
            // TxtBatchNameGetReport
            // 
            TxtBatchNameGetReport.Location = new System.Drawing.Point(103, 9);
            TxtBatchNameGetReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBatchNameGetReport.Name = "TxtBatchNameGetReport";
            TxtBatchNameGetReport.Size = new System.Drawing.Size(234, 23);
            TxtBatchNameGetReport.TabIndex = 1;
            TxtBatchNameGetReport.Validating += TxtBatchName_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(15, 13);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(75, 15);
            label8.TabIndex = 0;
            label8.Text = "Batch Name:";
            // 
            // TabImageSupport
            // 
            TabImageSupport.Controls.Add(panel6);
            TabImageSupport.Controls.Add(panel5);
            TabImageSupport.Controls.Add(BtnTestImage);
            TabImageSupport.Location = new System.Drawing.Point(4, 24);
            TabImageSupport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabImageSupport.Name = "TabImageSupport";
            TabImageSupport.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabImageSupport.Size = new System.Drawing.Size(740, 642);
            TabImageSupport.TabIndex = 4;
            TabImageSupport.Text = "Image Info";
            TabImageSupport.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(LstImageBrowser);
            panel6.Controls.Add(BtnBrowseImageFolder);
            panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            panel6.Location = new System.Drawing.Point(4, 3);
            panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(340, 636);
            panel6.TabIndex = 3;
            // 
            // LstImageBrowser
            // 
            LstImageBrowser.DisplayMember = "FileName";
            LstImageBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            LstImageBrowser.FormattingEnabled = true;
            LstImageBrowser.ItemHeight = 15;
            LstImageBrowser.Location = new System.Drawing.Point(0, 27);
            LstImageBrowser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LstImageBrowser.Name = "LstImageBrowser";
            LstImageBrowser.Size = new System.Drawing.Size(340, 609);
            LstImageBrowser.TabIndex = 1;
            LstImageBrowser.SelectedValueChanged += LstImageBrowser_SelectedValueChanged;
            // 
            // BtnBrowseImageFolder
            // 
            BtnBrowseImageFolder.CausesValidation = false;
            BtnBrowseImageFolder.Dock = System.Windows.Forms.DockStyle.Top;
            BtnBrowseImageFolder.Location = new System.Drawing.Point(0, 0);
            BtnBrowseImageFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnBrowseImageFolder.Name = "BtnBrowseImageFolder";
            BtnBrowseImageFolder.Size = new System.Drawing.Size(340, 27);
            BtnBrowseImageFolder.TabIndex = 0;
            BtnBrowseImageFolder.Text = "Browse Folder";
            BtnBrowseImageFolder.UseVisualStyleBackColor = true;
            BtnBrowseImageFolder.Click += BtnBrowseImageFolder_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(PropertyGridImageInfo);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(BtnSaveImage);
            panel5.Dock = System.Windows.Forms.DockStyle.Right;
            panel5.Location = new System.Drawing.Point(344, 3);
            panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(392, 636);
            panel5.TabIndex = 2;
            // 
            // PropertyGridImageInfo
            // 
            PropertyGridImageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            PropertyGridImageInfo.Location = new System.Drawing.Point(0, 0);
            PropertyGridImageInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PropertyGridImageInfo.Name = "PropertyGridImageInfo";
            PropertyGridImageInfo.Size = new System.Drawing.Size(392, 537);
            PropertyGridImageInfo.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(LblUploadImageInfoStatus);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(TxtBatchNameImageInfo);
            panel7.Controls.Add(BtnUploadImageFromInfo);
            panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel7.Location = new System.Drawing.Point(0, 537);
            panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(392, 72);
            panel7.TabIndex = 4;
            // 
            // LblUploadImageInfoStatus
            // 
            LblUploadImageInfoStatus.AutoSize = true;
            LblUploadImageInfoStatus.Location = new System.Drawing.Point(159, 8);
            LblUploadImageInfoStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblUploadImageInfoStatus.Name = "LblUploadImageInfoStatus";
            LblUploadImageInfoStatus.Size = new System.Drawing.Size(0, 15);
            LblUploadImageInfoStatus.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 10);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 15);
            label5.TabIndex = 5;
            label5.Text = "Batch Name:";
            // 
            // TxtBatchNameImageInfo
            // 
            TxtBatchNameImageInfo.Location = new System.Drawing.Point(7, 32);
            TxtBatchNameImageInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBatchNameImageInfo.Name = "TxtBatchNameImageInfo";
            TxtBatchNameImageInfo.Size = new System.Drawing.Size(245, 23);
            TxtBatchNameImageInfo.TabIndex = 4;
            TxtBatchNameImageInfo.Validating += TxtBatchName_Validating;
            // 
            // BtnUploadImageFromInfo
            // 
            BtnUploadImageFromInfo.Location = new System.Drawing.Point(260, 32);
            BtnUploadImageFromInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnUploadImageFromInfo.Name = "BtnUploadImageFromInfo";
            BtnUploadImageFromInfo.Size = new System.Drawing.Size(126, 27);
            BtnUploadImageFromInfo.TabIndex = 3;
            BtnUploadImageFromInfo.Text = "Upload Image";
            BtnUploadImageFromInfo.UseVisualStyleBackColor = true;
            BtnUploadImageFromInfo.Click += BtnUploadImageFromInfo_Click;
            // 
            // BtnSaveImage
            // 
            BtnSaveImage.CausesValidation = false;
            BtnSaveImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            BtnSaveImage.Location = new System.Drawing.Point(0, 609);
            BtnSaveImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnSaveImage.Name = "BtnSaveImage";
            BtnSaveImage.Size = new System.Drawing.Size(392, 27);
            BtnSaveImage.TabIndex = 2;
            BtnSaveImage.Text = "Save Image";
            BtnSaveImage.UseVisualStyleBackColor = true;
            BtnSaveImage.Click += BtnSaveImage_Click;
            // 
            // BtnTestImage
            // 
            BtnTestImage.Location = new System.Drawing.Point(55, 66);
            BtnTestImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnTestImage.Name = "BtnTestImage";
            BtnTestImage.Size = new System.Drawing.Size(88, 27);
            BtnTestImage.TabIndex = 0;
            BtnTestImage.Text = "Test";
            BtnTestImage.UseVisualStyleBackColor = true;
            BtnTestImage.Visible = false;
            BtnTestImage.Click += BtnTestImage_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Tiff Files|*.tif;*.tiff";
            openFileDialog.Multiselect = true;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            ImageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = System.Drawing.Color.Transparent;
            ImageList.Images.SetKeyName(0, "Success");
            ImageList.Images.SetKeyName(1, "Error");
            ImageList.Images.SetKeyName(2, "Processing");
            ImageList.Images.SetKeyName(3, "Pending");
            ImageList.Images.SetKeyName(4, "Downloading");
            ImageList.Images.SetKeyName(5, "Uploading");
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // dataColumn8
            // 
            dataColumn8.Caption = "Status";
            dataColumn8.ColumnName = "StatusImage";
            dataColumn8.DataType = typeof(object);
            dataColumn8.DefaultValue = resources.GetObject("dataColumn8.DefaultValue");
            dataColumn8.Namespace = "";
            // 
            // folderBrowserDialogImageInfo
            // 
            folderBrowserDialogImageInfo.RootFolder = System.Environment.SpecialFolder.MyComputer;
            folderBrowserDialogImageInfo.ShowNewFolderButton = false;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "tif";
            saveFileDialog1.Filter = "Tif Files|*.tif;*.tiff";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            ClientSize = new System.Drawing.Size(1068, 670);
            Controls.Add(BtnTest);
            Controls.Add(MainTabControl);
            Controls.Add(splitter1);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmMain";
            Text = "Image API Test Application";
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            MainTabControl.ResumeLayout(false);
            TabUploadFiles.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FileData).EndInit();
            ((System.ComponentModel.ISupportInitialize)UploadFilesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)DownloadFilesTable).EndInit();
            PnlUploadFiles.ResumeLayout(false);
            PnlUploadFiles.PerformLayout();
            TabGetBatches.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TabGetBatch.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            TabDownloadBatch.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            TabReports.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            TabImageSupport.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
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

