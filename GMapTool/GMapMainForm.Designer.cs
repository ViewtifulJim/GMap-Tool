namespace GMapTool
{
    partial class GMapToolMainForm
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
            this.pnlControlPanel = new System.Windows.Forms.Panel();
            this.cboBoxDataset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtaGridView = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBoxLatitudeY = new System.Windows.Forms.TextBox();
            this.txtBoxLongitudeX = new System.Windows.Forms.TextBox();
            this.txtBoxMarkerName = new System.Windows.Forms.TextBox();
            this.lblLatitudeY = new System.Windows.Forms.Label();
            this.lblLongitudeX = new System.Windows.Forms.Label();
            this.lblMarkerName = new System.Windows.Forms.Label();
            this.lblControlPanel = new System.Windows.Forms.Label();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.pnlControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlPanel
            // 
            this.pnlControlPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControlPanel.Controls.Add(this.cboBoxDataset);
            this.pnlControlPanel.Controls.Add(this.label1);
            this.pnlControlPanel.Controls.Add(this.btnHelp);
            this.pnlControlPanel.Controls.Add(this.btnUpdate);
            this.pnlControlPanel.Controls.Add(this.btnDelete);
            this.pnlControlPanel.Controls.Add(this.dtaGridView);
            this.pnlControlPanel.Controls.Add(this.btnAdd);
            this.pnlControlPanel.Controls.Add(this.btnClear);
            this.pnlControlPanel.Controls.Add(this.txtBoxLatitudeY);
            this.pnlControlPanel.Controls.Add(this.txtBoxLongitudeX);
            this.pnlControlPanel.Controls.Add(this.txtBoxMarkerName);
            this.pnlControlPanel.Controls.Add(this.lblLatitudeY);
            this.pnlControlPanel.Controls.Add(this.lblLongitudeX);
            this.pnlControlPanel.Controls.Add(this.lblMarkerName);
            this.pnlControlPanel.Controls.Add(this.lblControlPanel);
            this.pnlControlPanel.Location = new System.Drawing.Point(15, 13);
            this.pnlControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControlPanel.Name = "pnlControlPanel";
            this.pnlControlPanel.Size = new System.Drawing.Size(628, 860);
            this.pnlControlPanel.TabIndex = 1;
            // 
            // cboBoxDataset
            // 
            this.cboBoxDataset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxDataset.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxDataset.FormattingEnabled = true;
            this.cboBoxDataset.Items.AddRange(new object[] {
            "Custom Data",
            "Shipwreck Data"});
            this.cboBoxDataset.Location = new System.Drawing.Point(372, 7);
            this.cboBoxDataset.Name = "cboBoxDataset";
            this.cboBoxDataset.Size = new System.Drawing.Size(187, 35);
            this.cboBoxDataset.TabIndex = 17;
            this.cboBoxDataset.SelectedIndexChanged += new System.EventHandler(this.cboBoxDataset_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dataset:";
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(566, 3);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(44, 41);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(498, 809);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(380, 809);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtaGridView
            // 
            this.dtaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColY,
            this.ColX});
            this.dtaGridView.Location = new System.Drawing.Point(18, 235);
            this.dtaGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dtaGridView.Name = "dtaGridView";
            this.dtaGridView.RowHeadersWidth = 102;
            this.dtaGridView.Size = new System.Drawing.Size(594, 566);
            this.dtaGridView.TabIndex = 14;
            this.dtaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridView_CellClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 12;
            this.ColID.Name = "ColID";
            this.ColID.Width = 250;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 12;
            this.ColName.Name = "ColName";
            this.ColName.Width = 250;
            // 
            // ColY
            // 
            this.ColY.HeaderText = "Y";
            this.ColY.MinimumWidth = 12;
            this.ColY.Name = "ColY";
            this.ColY.Width = 250;
            // 
            // ColX
            // 
            this.ColX.HeaderText = "X";
            this.ColX.MinimumWidth = 12;
            this.ColX.Name = "ColX";
            this.ColX.Width = 250;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(498, 187);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 41);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(380, 187);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 41);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBoxLatitudeY
            // 
            this.txtBoxLatitudeY.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLatitudeY.Location = new System.Drawing.Point(246, 143);
            this.txtBoxLatitudeY.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLatitudeY.Name = "txtBoxLatitudeY";
            this.txtBoxLatitudeY.Size = new System.Drawing.Size(362, 35);
            this.txtBoxLatitudeY.TabIndex = 12;
            // 
            // txtBoxLongitudeX
            // 
            this.txtBoxLongitudeX.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLongitudeX.Location = new System.Drawing.Point(246, 100);
            this.txtBoxLongitudeX.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLongitudeX.Name = "txtBoxLongitudeX";
            this.txtBoxLongitudeX.Size = new System.Drawing.Size(362, 35);
            this.txtBoxLongitudeX.TabIndex = 11;
            // 
            // txtBoxMarkerName
            // 
            this.txtBoxMarkerName.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMarkerName.Location = new System.Drawing.Point(246, 58);
            this.txtBoxMarkerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMarkerName.Name = "txtBoxMarkerName";
            this.txtBoxMarkerName.Size = new System.Drawing.Size(362, 35);
            this.txtBoxMarkerName.TabIndex = 7;
            // 
            // lblLatitudeY
            // 
            this.lblLatitudeY.AutoSize = true;
            this.lblLatitudeY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLatitudeY.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitudeY.Location = new System.Drawing.Point(72, 144);
            this.lblLatitudeY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLatitudeY.Name = "lblLatitudeY";
            this.lblLatitudeY.Size = new System.Drawing.Size(166, 32);
            this.lblLatitudeY.TabIndex = 10;
            this.lblLatitudeY.Text = "Latitude (Y):";
            // 
            // lblLongitudeX
            // 
            this.lblLongitudeX.AutoSize = true;
            this.lblLongitudeX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLongitudeX.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitudeX.Location = new System.Drawing.Point(52, 101);
            this.lblLongitudeX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLongitudeX.Name = "lblLongitudeX";
            this.lblLongitudeX.Size = new System.Drawing.Size(187, 32);
            this.lblLongitudeX.TabIndex = 9;
            this.lblLongitudeX.Text = "Longitude (X):";
            // 
            // lblMarkerName
            // 
            this.lblMarkerName.AutoSize = true;
            this.lblMarkerName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarkerName.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkerName.Location = new System.Drawing.Point(25, 59);
            this.lblMarkerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarkerName.Name = "lblMarkerName";
            this.lblMarkerName.Size = new System.Drawing.Size(215, 32);
            this.lblMarkerName.TabIndex = 5;
            this.lblMarkerName.Text = "Name of Marker:";
            // 
            // lblControlPanel
            // 
            this.lblControlPanel.AutoSize = true;
            this.lblControlPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblControlPanel.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlPanel.Location = new System.Drawing.Point(14, 3);
            this.lblControlPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlPanel.Name = "lblControlPanel";
            this.lblControlPanel.Size = new System.Drawing.Size(182, 36);
            this.lblControlPanel.TabIndex = 6;
            this.lblControlPanel.Text = "Custom Map";
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(658, 13);
            this.gMap.Margin = new System.Windows.Forms.Padding(4);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 18;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1166, 860);
            this.gMap.TabIndex = 9;
            this.gMap.Zoom = 13D;
            this.gMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseDoubleClick);
            // 
            // GMapToolMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1835, 883);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.pnlControlPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1853, 930);
            this.MinimumSize = new System.Drawing.Size(1853, 930);
            this.Name = "GMapToolMainForm";
            this.Text = "GMapTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GMapToolMainForm_FormClosed);
            this.Load += new System.EventHandler(this.GMapToolMainForm_Load);
            this.pnlControlPanel.ResumeLayout(false);
            this.pnlControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControlPanel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtaGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxLatitudeY;
        private System.Windows.Forms.TextBox txtBoxLongitudeX;
        private System.Windows.Forms.TextBox txtBoxMarkerName;
        private System.Windows.Forms.Label lblLatitudeY;
        private System.Windows.Forms.Label lblLongitudeX;
        private System.Windows.Forms.Label lblMarkerName;
        private System.Windows.Forms.Label lblControlPanel;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBoxDataset;
    }
}

