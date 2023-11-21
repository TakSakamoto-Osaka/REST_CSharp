namespace MyREST_API
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpGetItem = new System.Windows.Forms.GroupBox();
            this.btnGETData = new System.Windows.Forms.Button();
            this.nudGetDataID = new System.Windows.Forms.NumericUpDown();
            this.lblGetDataID = new System.Windows.Forms.Label();
            this.dgvGetData = new System.Windows.Forms.DataGridView();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpGetDataList = new System.Windows.Forms.GroupBox();
            this.dgvGetDataList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGETDataList = new System.Windows.Forms.Button();
            this.txtGetDataListCompany = new System.Windows.Forms.TextBox();
            this.lblGetDataListCompany = new System.Windows.Forms.Label();
            this.rdbGetDataListALLFalse = new System.Windows.Forms.RadioButton();
            this.rdbGetDataListALLTrue = new System.Windows.Forms.RadioButton();
            this.grpPOST = new System.Windows.Forms.GroupBox();
            this.lblPOSTName = new System.Windows.Forms.Label();
            this.btnPOST = new System.Windows.Forms.Button();
            this.txtPOSTName = new System.Windows.Forms.TextBox();
            this.numPOSTPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPOSTPrice = new System.Windows.Forms.Label();
            this.lblPOSTCompany = new System.Windows.Forms.Label();
            this.txtPOSTCompany = new System.Windows.Forms.TextBox();
            this.lblPOSTRemarks = new System.Windows.Forms.Label();
            this.txtPOSTRemarks = new System.Windows.Forms.TextBox();
            this.grpPUT = new System.Windows.Forms.GroupBox();
            this.txtPUTRemarks = new System.Windows.Forms.TextBox();
            this.lblPUTRemarks = new System.Windows.Forms.Label();
            this.txtPUTCompany = new System.Windows.Forms.TextBox();
            this.lblPUTCompany = new System.Windows.Forms.Label();
            this.lblPUTPrice = new System.Windows.Forms.Label();
            this.numPUTPrice = new System.Windows.Forms.NumericUpDown();
            this.txtPUTName = new System.Windows.Forms.TextBox();
            this.lblPUTName = new System.Windows.Forms.Label();
            this.btnPUT = new System.Windows.Forms.Button();
            this.lblPUTID = new System.Windows.Forms.Label();
            this.nudPUTID = new System.Windows.Forms.NumericUpDown();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.lblDELETEID = new System.Windows.Forms.Label();
            this.nudDELETEID = new System.Windows.Forms.NumericUpDown();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.grpGetItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGetDataID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetData)).BeginInit();
            this.grpGetDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetDataList)).BeginInit();
            this.grpPOST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPOSTPrice)).BeginInit();
            this.grpPUT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPUTPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPUTID)).BeginInit();
            this.grpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDELETEID)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGetItem
            // 
            this.grpGetItem.Controls.Add(this.dgvGetData);
            this.grpGetItem.Controls.Add(this.lblGetDataID);
            this.grpGetItem.Controls.Add(this.nudGetDataID);
            this.grpGetItem.Controls.Add(this.btnGETData);
            this.grpGetItem.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpGetItem.Location = new System.Drawing.Point(25, 22);
            this.grpGetItem.Name = "grpGetItem";
            this.grpGetItem.Size = new System.Drawing.Size(590, 199);
            this.grpGetItem.TabIndex = 1;
            this.grpGetItem.TabStop = false;
            this.grpGetItem.Text = "GET : データ取得";
            // 
            // btnGETData
            // 
            this.btnGETData.Location = new System.Drawing.Point(149, 36);
            this.btnGETData.Name = "btnGETData";
            this.btnGETData.Size = new System.Drawing.Size(164, 41);
            this.btnGETData.TabIndex = 1;
            this.btnGETData.Text = "GET";
            this.btnGETData.UseVisualStyleBackColor = true;
            this.btnGETData.Click += new System.EventHandler(this.btnGETData_Click);
            // 
            // nudGetDataID
            // 
            this.nudGetDataID.Location = new System.Drawing.Point(53, 42);
            this.nudGetDataID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGetDataID.Name = "nudGetDataID";
            this.nudGetDataID.Size = new System.Drawing.Size(75, 31);
            this.nudGetDataID.TabIndex = 2;
            this.nudGetDataID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGetDataID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGetDataID
            // 
            this.lblGetDataID.AutoSize = true;
            this.lblGetDataID.Location = new System.Drawing.Point(15, 44);
            this.lblGetDataID.Name = "lblGetDataID";
            this.lblGetDataID.Size = new System.Drawing.Size(32, 24);
            this.lblGetDataID.TabIndex = 3;
            this.lblGetDataID.Text = "ID";
            // 
            // dgvGetData
            // 
            this.dgvGetData.AllowUserToAddRows = false;
            this.dgvGetData.AllowUserToDeleteRows = false;
            this.dgvGetData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm,
            this.clmName,
            this.clmPrice,
            this.clmCompany,
            this.clmRemarks});
            this.dgvGetData.Location = new System.Drawing.Point(6, 104);
            this.dgvGetData.Name = "dgvGetData";
            this.dgvGetData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGetData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGetData.RowTemplate.Height = 30;
            this.dgvGetData.RowTemplate.ReadOnly = true;
            this.dgvGetData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGetData.Size = new System.Drawing.Size(578, 73);
            this.dgvGetData.TabIndex = 4;
            // 
            // clm
            // 
            this.clm.HeaderText = "ID";
            this.clm.Name = "clm";
            this.clm.ReadOnly = true;
            this.clm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmCompany
            // 
            this.clmCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCompany.HeaderText = "Company";
            this.clmCompany.Name = "clmCompany";
            this.clmCompany.ReadOnly = true;
            this.clmCompany.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmRemarks
            // 
            this.clmRemarks.HeaderText = "Remarks";
            this.clmRemarks.Name = "clmRemarks";
            this.clmRemarks.ReadOnly = true;
            this.clmRemarks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grpGetDataList
            // 
            this.grpGetDataList.Controls.Add(this.rdbGetDataListALLTrue);
            this.grpGetDataList.Controls.Add(this.rdbGetDataListALLFalse);
            this.grpGetDataList.Controls.Add(this.lblGetDataListCompany);
            this.grpGetDataList.Controls.Add(this.txtGetDataListCompany);
            this.grpGetDataList.Controls.Add(this.dgvGetDataList);
            this.grpGetDataList.Controls.Add(this.btnGETDataList);
            this.grpGetDataList.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpGetDataList.Location = new System.Drawing.Point(25, 254);
            this.grpGetDataList.Name = "grpGetDataList";
            this.grpGetDataList.Size = new System.Drawing.Size(590, 411);
            this.grpGetDataList.TabIndex = 2;
            this.grpGetDataList.TabStop = false;
            this.grpGetDataList.Text = "GET : データリスト取得";
            // 
            // dgvGetDataList
            // 
            this.dgvGetDataList.AllowUserToAddRows = false;
            this.dgvGetDataList.AllowUserToDeleteRows = false;
            this.dgvGetDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvGetDataList.Location = new System.Drawing.Point(6, 209);
            this.dgvGetDataList.Name = "dgvGetDataList";
            this.dgvGetDataList.ReadOnly = true;
            this.dgvGetDataList.RowTemplate.Height = 30;
            this.dgvGetDataList.RowTemplate.ReadOnly = true;
            this.dgvGetDataList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGetDataList.Size = new System.Drawing.Size(578, 175);
            this.dgvGetDataList.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Company";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnGETDataList
            // 
            this.btnGETDataList.Location = new System.Drawing.Point(398, 148);
            this.btnGETDataList.Name = "btnGETDataList";
            this.btnGETDataList.Size = new System.Drawing.Size(164, 41);
            this.btnGETDataList.TabIndex = 1;
            this.btnGETDataList.Text = "GET";
            this.btnGETDataList.UseVisualStyleBackColor = true;
            this.btnGETDataList.Click += new System.EventHandler(this.btnGETDataList_Click);
            // 
            // txtGetDataListCompany
            // 
            this.txtGetDataListCompany.Location = new System.Drawing.Point(103, 54);
            this.txtGetDataListCompany.Name = "txtGetDataListCompany";
            this.txtGetDataListCompany.Size = new System.Drawing.Size(167, 31);
            this.txtGetDataListCompany.TabIndex = 5;
            // 
            // lblGetDataListCompany
            // 
            this.lblGetDataListCompany.AutoSize = true;
            this.lblGetDataListCompany.Location = new System.Drawing.Point(15, 57);
            this.lblGetDataListCompany.Name = "lblGetDataListCompany";
            this.lblGetDataListCompany.Size = new System.Drawing.Size(82, 24);
            this.lblGetDataListCompany.TabIndex = 6;
            this.lblGetDataListCompany.Text = "会社名";
            // 
            // rdbGetDataListALLFalse
            // 
            this.rdbGetDataListALLFalse.AutoSize = true;
            this.rdbGetDataListALLFalse.Checked = true;
            this.rdbGetDataListALLFalse.Location = new System.Drawing.Point(398, 39);
            this.rdbGetDataListALLFalse.Name = "rdbGetDataListALLFalse";
            this.rdbGetDataListALLFalse.Size = new System.Drawing.Size(124, 28);
            this.rdbGetDataListALLFalse.TabIndex = 7;
            this.rdbGetDataListALLFalse.TabStop = true;
            this.rdbGetDataListALLFalse.Text = "会社指定";
            this.rdbGetDataListALLFalse.UseVisualStyleBackColor = true;
            // 
            // rdbGetDataListALLTrue
            // 
            this.rdbGetDataListALLTrue.AutoSize = true;
            this.rdbGetDataListALLTrue.Location = new System.Drawing.Point(398, 83);
            this.rdbGetDataListALLTrue.Name = "rdbGetDataListALLTrue";
            this.rdbGetDataListALLTrue.Size = new System.Drawing.Size(157, 28);
            this.rdbGetDataListALLTrue.TabIndex = 8;
            this.rdbGetDataListALLTrue.Text = "全データ取得";
            this.rdbGetDataListALLTrue.UseVisualStyleBackColor = true;
            // 
            // grpPOST
            // 
            this.grpPOST.Controls.Add(this.txtPOSTRemarks);
            this.grpPOST.Controls.Add(this.lblPOSTRemarks);
            this.grpPOST.Controls.Add(this.txtPOSTCompany);
            this.grpPOST.Controls.Add(this.lblPOSTCompany);
            this.grpPOST.Controls.Add(this.lblPOSTPrice);
            this.grpPOST.Controls.Add(this.numPOSTPrice);
            this.grpPOST.Controls.Add(this.txtPOSTName);
            this.grpPOST.Controls.Add(this.lblPOSTName);
            this.grpPOST.Controls.Add(this.btnPOST);
            this.grpPOST.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpPOST.Location = new System.Drawing.Point(642, 22);
            this.grpPOST.Name = "grpPOST";
            this.grpPOST.Size = new System.Drawing.Size(311, 343);
            this.grpPOST.TabIndex = 3;
            this.grpPOST.TabStop = false;
            this.grpPOST.Text = "POST : データ追加";
            // 
            // lblPOSTName
            // 
            this.lblPOSTName.AutoSize = true;
            this.lblPOSTName.Location = new System.Drawing.Point(28, 89);
            this.lblPOSTName.Name = "lblPOSTName";
            this.lblPOSTName.Size = new System.Drawing.Size(82, 24);
            this.lblPOSTName.TabIndex = 3;
            this.lblPOSTName.Text = "商品名";
            // 
            // btnPOST
            // 
            this.btnPOST.Location = new System.Drawing.Point(116, 277);
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(164, 41);
            this.btnPOST.TabIndex = 1;
            this.btnPOST.Text = "POST";
            this.btnPOST.UseVisualStyleBackColor = true;
            this.btnPOST.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // txtPOSTName
            // 
            this.txtPOSTName.Location = new System.Drawing.Point(116, 87);
            this.txtPOSTName.Name = "txtPOSTName";
            this.txtPOSTName.Size = new System.Drawing.Size(167, 31);
            this.txtPOSTName.TabIndex = 6;
            // 
            // numPOSTPrice
            // 
            this.numPOSTPrice.Location = new System.Drawing.Point(116, 134);
            this.numPOSTPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPOSTPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPOSTPrice.Name = "numPOSTPrice";
            this.numPOSTPrice.Size = new System.Drawing.Size(167, 31);
            this.numPOSTPrice.TabIndex = 7;
            this.numPOSTPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPOSTPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblPOSTPrice
            // 
            this.lblPOSTPrice.AutoSize = true;
            this.lblPOSTPrice.Location = new System.Drawing.Point(28, 136);
            this.lblPOSTPrice.Name = "lblPOSTPrice";
            this.lblPOSTPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPOSTPrice.TabIndex = 8;
            this.lblPOSTPrice.Text = "価格";
            // 
            // lblPOSTCompany
            // 
            this.lblPOSTCompany.AutoSize = true;
            this.lblPOSTCompany.Location = new System.Drawing.Point(28, 186);
            this.lblPOSTCompany.Name = "lblPOSTCompany";
            this.lblPOSTCompany.Size = new System.Drawing.Size(82, 24);
            this.lblPOSTCompany.TabIndex = 9;
            this.lblPOSTCompany.Text = "会社名";
            // 
            // txtPOSTCompany
            // 
            this.txtPOSTCompany.Location = new System.Drawing.Point(116, 183);
            this.txtPOSTCompany.Name = "txtPOSTCompany";
            this.txtPOSTCompany.Size = new System.Drawing.Size(167, 31);
            this.txtPOSTCompany.TabIndex = 10;
            // 
            // lblPOSTRemarks
            // 
            this.lblPOSTRemarks.AutoSize = true;
            this.lblPOSTRemarks.Location = new System.Drawing.Point(28, 233);
            this.lblPOSTRemarks.Name = "lblPOSTRemarks";
            this.lblPOSTRemarks.Size = new System.Drawing.Size(58, 24);
            this.lblPOSTRemarks.TabIndex = 11;
            this.lblPOSTRemarks.Text = "備考";
            // 
            // txtPOSTRemarks
            // 
            this.txtPOSTRemarks.Location = new System.Drawing.Point(116, 230);
            this.txtPOSTRemarks.Name = "txtPOSTRemarks";
            this.txtPOSTRemarks.Size = new System.Drawing.Size(167, 31);
            this.txtPOSTRemarks.TabIndex = 12;
            // 
            // grpPUT
            // 
            this.grpPUT.Controls.Add(this.lblPUTID);
            this.grpPUT.Controls.Add(this.nudPUTID);
            this.grpPUT.Controls.Add(this.txtPUTRemarks);
            this.grpPUT.Controls.Add(this.lblPUTRemarks);
            this.grpPUT.Controls.Add(this.txtPUTCompany);
            this.grpPUT.Controls.Add(this.lblPUTCompany);
            this.grpPUT.Controls.Add(this.lblPUTPrice);
            this.grpPUT.Controls.Add(this.numPUTPrice);
            this.grpPUT.Controls.Add(this.txtPUTName);
            this.grpPUT.Controls.Add(this.lblPUTName);
            this.grpPUT.Controls.Add(this.btnPUT);
            this.grpPUT.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpPUT.Location = new System.Drawing.Point(959, 22);
            this.grpPUT.Name = "grpPUT";
            this.grpPUT.Size = new System.Drawing.Size(311, 343);
            this.grpPUT.TabIndex = 4;
            this.grpPUT.TabStop = false;
            this.grpPUT.Text = "PUT : データ変更";
            // 
            // txtPUTRemarks
            // 
            this.txtPUTRemarks.Location = new System.Drawing.Point(104, 230);
            this.txtPUTRemarks.Name = "txtPUTRemarks";
            this.txtPUTRemarks.Size = new System.Drawing.Size(167, 31);
            this.txtPUTRemarks.TabIndex = 12;
            // 
            // lblPUTRemarks
            // 
            this.lblPUTRemarks.AutoSize = true;
            this.lblPUTRemarks.Location = new System.Drawing.Point(16, 233);
            this.lblPUTRemarks.Name = "lblPUTRemarks";
            this.lblPUTRemarks.Size = new System.Drawing.Size(58, 24);
            this.lblPUTRemarks.TabIndex = 11;
            this.lblPUTRemarks.Text = "備考";
            // 
            // txtPUTCompany
            // 
            this.txtPUTCompany.Location = new System.Drawing.Point(104, 183);
            this.txtPUTCompany.Name = "txtPUTCompany";
            this.txtPUTCompany.Size = new System.Drawing.Size(167, 31);
            this.txtPUTCompany.TabIndex = 10;
            // 
            // lblPUTCompany
            // 
            this.lblPUTCompany.AutoSize = true;
            this.lblPUTCompany.Location = new System.Drawing.Point(16, 186);
            this.lblPUTCompany.Name = "lblPUTCompany";
            this.lblPUTCompany.Size = new System.Drawing.Size(82, 24);
            this.lblPUTCompany.TabIndex = 9;
            this.lblPUTCompany.Text = "会社名";
            // 
            // lblPUTPrice
            // 
            this.lblPUTPrice.AutoSize = true;
            this.lblPUTPrice.Location = new System.Drawing.Point(16, 136);
            this.lblPUTPrice.Name = "lblPUTPrice";
            this.lblPUTPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPUTPrice.TabIndex = 8;
            this.lblPUTPrice.Text = "価格";
            // 
            // numPUTPrice
            // 
            this.numPUTPrice.Location = new System.Drawing.Point(104, 134);
            this.numPUTPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPUTPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPUTPrice.Name = "numPUTPrice";
            this.numPUTPrice.Size = new System.Drawing.Size(167, 31);
            this.numPUTPrice.TabIndex = 7;
            this.numPUTPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPUTPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtPUTName
            // 
            this.txtPUTName.Location = new System.Drawing.Point(104, 87);
            this.txtPUTName.Name = "txtPUTName";
            this.txtPUTName.Size = new System.Drawing.Size(167, 31);
            this.txtPUTName.TabIndex = 6;
            // 
            // lblPUTName
            // 
            this.lblPUTName.AutoSize = true;
            this.lblPUTName.Location = new System.Drawing.Point(16, 89);
            this.lblPUTName.Name = "lblPUTName";
            this.lblPUTName.Size = new System.Drawing.Size(82, 24);
            this.lblPUTName.TabIndex = 3;
            this.lblPUTName.Text = "商品名";
            // 
            // btnPUT
            // 
            this.btnPUT.Location = new System.Drawing.Point(104, 277);
            this.btnPUT.Name = "btnPUT";
            this.btnPUT.Size = new System.Drawing.Size(164, 41);
            this.btnPUT.TabIndex = 1;
            this.btnPUT.Text = "PUT";
            this.btnPUT.UseVisualStyleBackColor = true;
            this.btnPUT.Click += new System.EventHandler(this.btnPUT_Click);
            // 
            // lblPUTID
            // 
            this.lblPUTID.AutoSize = true;
            this.lblPUTID.Location = new System.Drawing.Point(16, 44);
            this.lblPUTID.Name = "lblPUTID";
            this.lblPUTID.Size = new System.Drawing.Size(32, 24);
            this.lblPUTID.TabIndex = 14;
            this.lblPUTID.Text = "ID";
            // 
            // nudPUTID
            // 
            this.nudPUTID.Location = new System.Drawing.Point(104, 42);
            this.nudPUTID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPUTID.Name = "nudPUTID";
            this.nudPUTID.Size = new System.Drawing.Size(75, 31);
            this.nudPUTID.TabIndex = 13;
            this.nudPUTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPUTID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDELETE);
            this.grpDelete.Controls.Add(this.lblDELETEID);
            this.grpDelete.Controls.Add(this.nudDELETEID);
            this.grpDelete.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpDelete.Location = new System.Drawing.Point(959, 402);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(311, 145);
            this.grpDelete.TabIndex = 5;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "DELETE : データ削除";
            // 
            // lblDELETEID
            // 
            this.lblDELETEID.AutoSize = true;
            this.lblDELETEID.Location = new System.Drawing.Point(16, 44);
            this.lblDELETEID.Name = "lblDELETEID";
            this.lblDELETEID.Size = new System.Drawing.Size(32, 24);
            this.lblDELETEID.TabIndex = 14;
            this.lblDELETEID.Text = "ID";
            // 
            // nudDELETEID
            // 
            this.nudDELETEID.Location = new System.Drawing.Point(104, 42);
            this.nudDELETEID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDELETEID.Name = "nudDELETEID";
            this.nudDELETEID.Size = new System.Drawing.Size(75, 31);
            this.nudDELETEID.TabIndex = 13;
            this.nudDELETEID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDELETEID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(107, 88);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(164, 41);
            this.btnDELETE.TabIndex = 15;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpPUT);
            this.Controls.Add(this.grpPOST);
            this.Controls.Add(this.grpGetDataList);
            this.Controls.Add(this.grpGetItem);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メイン画面";
            this.grpGetItem.ResumeLayout(false);
            this.grpGetItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGetDataID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetData)).EndInit();
            this.grpGetDataList.ResumeLayout(false);
            this.grpGetDataList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetDataList)).EndInit();
            this.grpPOST.ResumeLayout(false);
            this.grpPOST.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPOSTPrice)).EndInit();
            this.grpPUT.ResumeLayout(false);
            this.grpPUT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPUTPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPUTID)).EndInit();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDELETEID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGetItem;
        private System.Windows.Forms.Label lblGetDataID;
        private System.Windows.Forms.NumericUpDown nudGetDataID;
        private System.Windows.Forms.Button btnGETData;
        private System.Windows.Forms.DataGridView dgvGetData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRemarks;
        private System.Windows.Forms.GroupBox grpGetDataList;
        private System.Windows.Forms.DataGridView dgvGetDataList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnGETDataList;
        private System.Windows.Forms.Label lblGetDataListCompany;
        private System.Windows.Forms.TextBox txtGetDataListCompany;
        private System.Windows.Forms.RadioButton rdbGetDataListALLTrue;
        private System.Windows.Forms.RadioButton rdbGetDataListALLFalse;
        private System.Windows.Forms.GroupBox grpPOST;
        private System.Windows.Forms.Label lblPOSTName;
        private System.Windows.Forms.Button btnPOST;
        private System.Windows.Forms.TextBox txtPOSTName;
        private System.Windows.Forms.NumericUpDown numPOSTPrice;
        private System.Windows.Forms.Label lblPOSTPrice;
        private System.Windows.Forms.TextBox txtPOSTCompany;
        private System.Windows.Forms.Label lblPOSTCompany;
        private System.Windows.Forms.TextBox txtPOSTRemarks;
        private System.Windows.Forms.Label lblPOSTRemarks;
        private System.Windows.Forms.GroupBox grpPUT;
        private System.Windows.Forms.TextBox txtPUTRemarks;
        private System.Windows.Forms.Label lblPUTRemarks;
        private System.Windows.Forms.TextBox txtPUTCompany;
        private System.Windows.Forms.Label lblPUTCompany;
        private System.Windows.Forms.Label lblPUTPrice;
        private System.Windows.Forms.NumericUpDown numPUTPrice;
        private System.Windows.Forms.TextBox txtPUTName;
        private System.Windows.Forms.Label lblPUTName;
        private System.Windows.Forms.Button btnPUT;
        private System.Windows.Forms.Label lblPUTID;
        private System.Windows.Forms.NumericUpDown nudPUTID;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Label lblDELETEID;
        private System.Windows.Forms.NumericUpDown nudDELETEID;
        private System.Windows.Forms.Button btnDELETE;
    }
}

