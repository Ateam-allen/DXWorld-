namespace DXWorld查询器
{
    partial class OfficeSel
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
            this.textPathEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.textNREdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxSel = new DevExpress.XtraEditors.ListBoxControl();
            this.LabelCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textWJMEdit = new DevExpress.XtraEditors.TextEdit();
            this.NRlistBox = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textPathEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNREdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWJMEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NRlistBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textPathEdit
            // 
            this.textPathEdit.Location = new System.Drawing.Point(108, 26);
            this.textPathEdit.Name = "textPathEdit";
            this.textPathEdit.Properties.AutoHeight = false;
            this.textPathEdit.Size = new System.Drawing.Size(349, 27);
            this.textPathEdit.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "文件夹路径：";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(473, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 27);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "浏览";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Bezier";
            // 
            // textNREdit
            // 
            this.textNREdit.Location = new System.Drawing.Point(295, 59);
            this.textNREdit.Name = "textNREdit";
            this.textNREdit.Size = new System.Drawing.Size(162, 24);
            this.textNREdit.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(273, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "文件名关键字：（多个关键词用“|”分割）";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(473, 72);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(108, 29);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "查询";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // listBoxSel
            // 
            this.listBoxSel.Location = new System.Drawing.Point(24, 149);
            this.listBoxSel.Name = "listBoxSel";
            this.listBoxSel.Size = new System.Drawing.Size(557, 243);
            this.listBoxSel.TabIndex = 7;
            // 
            // LabelCount
            // 
            this.LabelCount.Location = new System.Drawing.Point(23, 398);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(45, 18);
            this.LabelCount.TabIndex = 8;
            this.LabelCount.Text = "合计：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(258, 18);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "内容关键字：（多个关键词用“|”分割）";
            // 
            // textWJMEdit
            // 
            this.textWJMEdit.Location = new System.Drawing.Point(295, 87);
            this.textWJMEdit.Name = "textWJMEdit";
            this.textWJMEdit.Size = new System.Drawing.Size(162, 24);
            this.textWJMEdit.TabIndex = 11;
            // 
            // NRlistBox
            // 
            this.NRlistBox.Location = new System.Drawing.Point(587, 62);
            this.NRlistBox.Name = "NRlistBox";
            this.NRlistBox.Size = new System.Drawing.Size(552, 354);
            this.NRlistBox.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(803, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(135, 18);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "内容搜索段落结果：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(247, 125);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(105, 18);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "对应文件路径：";
            // 
            // OfficeSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 437);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.NRlistBox);
            this.Controls.Add(this.textWJMEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.listBoxSel);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textNREdit);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textPathEdit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OfficeSel";
            this.Text = "WPS文件查询器";
            this.Load += new System.EventHandler(this.OfficeSel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textPathEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNREdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWJMEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NRlistBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textPathEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.TextEdit textNREdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ListBoxControl listBoxSel;
        private DevExpress.XtraEditors.LabelControl LabelCount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textWJMEdit;
        private DevExpress.XtraEditors.ListBoxControl NRlistBox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}

