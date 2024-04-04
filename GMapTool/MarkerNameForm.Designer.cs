namespace GMapTool
{
    partial class MarkerNameForm
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
            this.lblMarkerName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxMarkerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMarkerName
            // 
            this.lblMarkerName.AutoSize = true;
            this.lblMarkerName.Location = new System.Drawing.Point(12, 28);
            this.lblMarkerName.Name = "lblMarkerName";
            this.lblMarkerName.Size = new System.Drawing.Size(189, 16);
            this.lblMarkerName.TabIndex = 0;
            this.lblMarkerName.Text = "Please enter the marker name:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(80, 89);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(49, 31);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(138, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxMarkerName
            // 
            this.txtBoxMarkerName.Location = new System.Drawing.Point(12, 47);
            this.txtBoxMarkerName.Name = "txtBoxMarkerName";
            this.txtBoxMarkerName.Size = new System.Drawing.Size(242, 22);
            this.txtBoxMarkerName.TabIndex = 3;
            // 
            // MarkerNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 132);
            this.Controls.Add(this.txtBoxMarkerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMarkerName);
            this.Name = "MarkerNameForm";
            this.Text = "Marker Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarkerName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBoxMarkerName;
    }
}