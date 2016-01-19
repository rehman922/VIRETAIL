namespace VIRETAILSTORE
{
    partial class Terms
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
            C1.Win.C1TrueDBGrid.Style style1 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style2 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style3 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style4 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style5 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style6 = new C1.Win.C1TrueDBGrid.Style();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terms));
            C1.Win.C1TrueDBGrid.Style style7 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style8 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style9 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style10 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style11 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style12 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style13 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style14 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style15 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style16 = new C1.Win.C1TrueDBGrid.Style();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tERMSDETAILMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPOSSTORE = new VIRETAILSTORE.DSPOSSTORE();
            this.tERMSDETAILMASTTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.TERMSDETAILMASTTableAdapter();
            this.c1TrueDBDropdown1 = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.pAYMENTONMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAYMENTONMASTTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.PAYMENTONMASTTableAdapter();
            this.c1TrueDBDropdown2 = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.pAYTYPEMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAYTYPEMASTTableAdapter = new VIRETAILSTORE.DSPOSSTORETableAdapters.PAYTYPEMASTTableAdapter();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.tERMSDETAILMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTONMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYTYPEMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(16, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Term Code:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 53);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(206, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Term name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(279, 53);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 22);
            this.textBox2.TabIndex = 9;
            // 
            // tERMSDETAILMASTBindingSource
            // 
            this.tERMSDETAILMASTBindingSource.DataMember = "TERMSDETAILMAST";
            this.tERMSDETAILMASTBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // dSPOSSTORE
            // 
            this.dSPOSSTORE.DataSetName = "DSPOSSTORE";
            this.dSPOSSTORE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tERMSDETAILMASTTableAdapter
            // 
            this.tERMSDETAILMASTTableAdapter.ClearBeforeFill = true;
            // 
            // c1TrueDBDropdown1
            // 
            this.c1TrueDBDropdown1.AllowColMove = true;
            this.c1TrueDBDropdown1.AllowColSelect = true;
            this.c1TrueDBDropdown1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TrueDBDropdown1.AlternatingRows = false;
            this.c1TrueDBDropdown1.CaptionStyle = style1;
            this.c1TrueDBDropdown1.ColumnCaptionHeight = 17;
            this.c1TrueDBDropdown1.ColumnFooterHeight = 17;
            this.c1TrueDBDropdown1.ColumnHeaders = false;
            this.c1TrueDBDropdown1.DataSource = this.pAYMENTONMASTBindingSource;
            this.c1TrueDBDropdown1.DisplayMember = "PAYNAME";
            this.c1TrueDBDropdown1.EvenRowStyle = style2;
            this.c1TrueDBDropdown1.FetchRowStyles = false;
            this.c1TrueDBDropdown1.FooterStyle = style3;
            this.c1TrueDBDropdown1.HeadingStyle = style4;
            this.c1TrueDBDropdown1.HighLightRowStyle = style5;
            this.c1TrueDBDropdown1.Location = new System.Drawing.Point(146, 148);
            this.c1TrueDBDropdown1.Name = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.OddRowStyle = style6;
            this.c1TrueDBDropdown1.PropBag = resources.GetString("c1TrueDBDropdown1.PropBag");
            this.c1TrueDBDropdown1.RecordSelectorStyle = style7;
            this.c1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBDropdown1.RowHeight = 22;
            this.c1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.ScrollTips = false;
            this.c1TrueDBDropdown1.Size = new System.Drawing.Size(266, 131);
            this.c1TrueDBDropdown1.Style = style8;
            this.c1TrueDBDropdown1.TabIndex = 11;
            this.c1TrueDBDropdown1.TabStop = false;
            this.c1TrueDBDropdown1.Text = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.ValueMember = "PAYMENTON";
            this.c1TrueDBDropdown1.ValueTranslate = true;
            this.c1TrueDBDropdown1.Visible = false;
            // 
            // pAYMENTONMASTBindingSource
            // 
            this.pAYMENTONMASTBindingSource.DataMember = "PAYMENTONMAST";
            this.pAYMENTONMASTBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // pAYMENTONMASTTableAdapter
            // 
            this.pAYMENTONMASTTableAdapter.ClearBeforeFill = true;
            // 
            // c1TrueDBDropdown2
            // 
            this.c1TrueDBDropdown2.AllowColMove = true;
            this.c1TrueDBDropdown2.AllowColSelect = true;
            this.c1TrueDBDropdown2.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TrueDBDropdown2.AlternatingRows = false;
            this.c1TrueDBDropdown2.CaptionStyle = style9;
            this.c1TrueDBDropdown2.ColumnCaptionHeight = 17;
            this.c1TrueDBDropdown2.ColumnFooterHeight = 17;
            this.c1TrueDBDropdown2.ColumnHeaders = false;
            this.c1TrueDBDropdown2.DataSource = this.pAYTYPEMASTBindingSource;
            this.c1TrueDBDropdown2.DisplayMember = "PAYNAME";
            this.c1TrueDBDropdown2.EvenRowStyle = style10;
            this.c1TrueDBDropdown2.FetchRowStyles = false;
            this.c1TrueDBDropdown2.FooterStyle = style11;
            this.c1TrueDBDropdown2.HeadingStyle = style12;
            this.c1TrueDBDropdown2.HighLightRowStyle = style13;
            this.c1TrueDBDropdown2.Location = new System.Drawing.Point(491, 148);
            this.c1TrueDBDropdown2.Name = "c1TrueDBDropdown2";
            this.c1TrueDBDropdown2.OddRowStyle = style14;
            this.c1TrueDBDropdown2.PropBag = resources.GetString("c1TrueDBDropdown2.PropBag");
            this.c1TrueDBDropdown2.RecordSelectorStyle = style15;
            this.c1TrueDBDropdown2.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown2.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBDropdown2.RowHeight = 22;
            this.c1TrueDBDropdown2.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown2.ScrollTips = false;
            this.c1TrueDBDropdown2.Size = new System.Drawing.Size(280, 131);
            this.c1TrueDBDropdown2.Style = style16;
            this.c1TrueDBDropdown2.TabIndex = 12;
            this.c1TrueDBDropdown2.TabStop = false;
            this.c1TrueDBDropdown2.Text = "c1TrueDBDropdown2";
            this.c1TrueDBDropdown2.ValueMember = "PAYTYPE";
            this.c1TrueDBDropdown2.ValueTranslate = true;
            this.c1TrueDBDropdown2.Visible = false;
            // 
            // pAYTYPEMASTBindingSource
            // 
            this.pAYTYPEMASTBindingSource.DataMember = "PAYTYPEMAST";
            this.pAYTYPEMASTBindingSource.DataSource = this.dSPOSSTORE;
            // 
            // pAYTYPEMASTTableAdapter
            // 
            this.pAYTYPEMASTTableAdapter.ClearBeforeFill = true;
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.AllowAddNew = true;
            this.c1TrueDBGrid1.CaptionHeight = 17;
            this.c1TrueDBGrid1.DataSource = this.tERMSDETAILMASTBindingSource;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 81);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            this.c1TrueDBGrid1.RowHeight = 22;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(780, 201);
            this.c1TrueDBGrid1.TabIndex = 10;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.BeforeColUpdate += new C1.Win.C1TrueDBGrid.BeforeColUpdateEventHandler(this.c1TrueDBGrid1_BeforeColUpdate);
            this.c1TrueDBGrid1.BeforeUpdate += new C1.Win.C1TrueDBGrid.CancelEventHandler(this.c1TrueDBGrid1_BeforeUpdate);
            // 
            // Terms
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 292);
            this.Controls.Add(this.c1TrueDBDropdown2);
            this.Controls.Add(this.c1TrueDBDropdown1);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "Terms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terms";
            this.Load += new System.EventHandler(this.Terms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tERMSDETAILMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPOSSTORE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTONMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYTYPEMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

         
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox textBox2;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private DSPOSSTORE dSPOSSTORE;
        private System.Windows.Forms.BindingSource tERMSDETAILMASTBindingSource;
        private DSPOSSTORETableAdapters.TERMSDETAILMASTTableAdapter tERMSDETAILMASTTableAdapter;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown1;
        private System.Windows.Forms.BindingSource pAYMENTONMASTBindingSource;
        private DSPOSSTORETableAdapters.PAYMENTONMASTTableAdapter pAYMENTONMASTTableAdapter;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown2;
        private System.Windows.Forms.BindingSource pAYTYPEMASTBindingSource;
        private DSPOSSTORETableAdapters.PAYTYPEMASTTableAdapter pAYTYPEMASTTableAdapter;
    }
}