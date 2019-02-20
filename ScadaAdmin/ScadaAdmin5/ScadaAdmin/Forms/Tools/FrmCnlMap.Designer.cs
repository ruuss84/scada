﻿namespace Scada.Admin.App.Forms.Tools
{
    partial class FrmCnlMap
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
            this.gbCnlKind = new System.Windows.Forms.GroupBox();
            this.gbGroupBy = new System.Windows.Forms.GroupBox();
            this.rbInCnls = new System.Windows.Forms.RadioButton();
            this.rbOutCnls = new System.Windows.Forms.RadioButton();
            this.rbGroupByDevices = new System.Windows.Forms.RadioButton();
            this.rbGroupByObjects = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbCnlKind.SuspendLayout();
            this.gbGroupBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCnlKind
            // 
            this.gbCnlKind.Controls.Add(this.rbOutCnls);
            this.gbCnlKind.Controls.Add(this.rbInCnls);
            this.gbCnlKind.Location = new System.Drawing.Point(12, 12);
            this.gbCnlKind.Name = "gbCnlKind";
            this.gbCnlKind.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.gbCnlKind.Size = new System.Drawing.Size(360, 49);
            this.gbCnlKind.TabIndex = 0;
            this.gbCnlKind.TabStop = false;
            this.gbCnlKind.Text = "Channel Kind";
            // 
            // gbGroupBy
            // 
            this.gbGroupBy.Controls.Add(this.rbGroupByObjects);
            this.gbGroupBy.Controls.Add(this.rbGroupByDevices);
            this.gbGroupBy.Location = new System.Drawing.Point(12, 67);
            this.gbGroupBy.Name = "gbGroupBy";
            this.gbGroupBy.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.gbGroupBy.Size = new System.Drawing.Size(360, 49);
            this.gbGroupBy.TabIndex = 1;
            this.gbGroupBy.TabStop = false;
            this.gbGroupBy.Text = "Group By";
            // 
            // rbInCnls
            // 
            this.rbInCnls.AutoSize = true;
            this.rbInCnls.Checked = true;
            this.rbInCnls.Location = new System.Drawing.Point(13, 19);
            this.rbInCnls.Name = "rbInCnls";
            this.rbInCnls.Size = new System.Drawing.Size(95, 17);
            this.rbInCnls.TabIndex = 0;
            this.rbInCnls.TabStop = true;
            this.rbInCnls.Text = "Input channels";
            this.rbInCnls.UseVisualStyleBackColor = true;
            // 
            // rbOutCnls
            // 
            this.rbOutCnls.AutoSize = true;
            this.rbOutCnls.Location = new System.Drawing.Point(168, 19);
            this.rbOutCnls.Name = "rbOutCnls";
            this.rbOutCnls.Size = new System.Drawing.Size(103, 17);
            this.rbOutCnls.TabIndex = 1;
            this.rbOutCnls.Text = "Output channels";
            this.rbOutCnls.UseVisualStyleBackColor = true;
            // 
            // rbGroupByDevices
            // 
            this.rbGroupByDevices.AutoSize = true;
            this.rbGroupByDevices.Checked = true;
            this.rbGroupByDevices.Location = new System.Drawing.Point(13, 19);
            this.rbGroupByDevices.Name = "rbGroupByDevices";
            this.rbGroupByDevices.Size = new System.Drawing.Size(64, 17);
            this.rbGroupByDevices.TabIndex = 0;
            this.rbGroupByDevices.TabStop = true;
            this.rbGroupByDevices.Text = "Devices";
            this.rbGroupByDevices.UseVisualStyleBackColor = true;
            // 
            // rbGroupByObjects
            // 
            this.rbGroupByObjects.AutoSize = true;
            this.rbGroupByObjects.Location = new System.Drawing.Point(168, 19);
            this.rbGroupByObjects.Name = "rbGroupByObjects";
            this.rbGroupByObjects.Size = new System.Drawing.Size(61, 17);
            this.rbGroupByObjects.TabIndex = 1;
            this.rbGroupByObjects.Text = "Objects";
            this.rbGroupByObjects.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(216, 132);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(297, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmCnlMap
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 167);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbGroupBy);
            this.Controls.Add(this.gbCnlKind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCnlMap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Channel Map";
            this.Load += new System.EventHandler(this.FrmCnlMap_Load);
            this.gbCnlKind.ResumeLayout(false);
            this.gbCnlKind.PerformLayout();
            this.gbGroupBy.ResumeLayout(false);
            this.gbGroupBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCnlKind;
        private System.Windows.Forms.GroupBox gbGroupBy;
        private System.Windows.Forms.RadioButton rbInCnls;
        private System.Windows.Forms.RadioButton rbOutCnls;
        private System.Windows.Forms.RadioButton rbGroupByObjects;
        private System.Windows.Forms.RadioButton rbGroupByDevices;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}