namespace Store
{
    partial class Warehouselist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouselist));
            this.dataSet1 = new Store.DataSet1();
            this.wAREHOUSEMASTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wAREHOUSEMASTTableAdapter = new Store.DataSet1TableAdapters.WAREHOUSEMASTTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wAREHOUSEMASTBindingSource
            // 
            this.wAREHOUSEMASTBindingSource.DataMember = "WAREHOUSEMAST";
            this.wAREHOUSEMASTBindingSource.DataSource = this.dataSet1;
            // 
            // wAREHOUSEMASTTableAdapter
            // 
            this.wAREHOUSEMASTTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.AllowUpdate = false;
            this.c1TrueDBGrid1.Caption = "Warehouse Name";
            this.c1TrueDBGrid1.CaptionHeight = 17;
            this.c1TrueDBGrid1.ColumnHeaders = false;
            this.c1TrueDBGrid1.DataSource = this.wAREHOUSEMASTBindingSource;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            this.c1TrueDBGrid1.RowHeight = 22;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(522, 261);
            this.c1TrueDBGrid1.TabIndex = 2;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.DoubleClick += new System.EventHandler(this.c1TrueDBGrid1_DoubleClick);
            // 
            // Warehouselist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 261);
            this.ControlBox = false;
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warehouselist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Warehouselist_FormClosing);
            this.Load += new System.EventHandler(this.Warehouselist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource wAREHOUSEMASTBindingSource;
        private DataSet1TableAdapters.WAREHOUSEMASTTableAdapter wAREHOUSEMASTTableAdapter;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
    }
}