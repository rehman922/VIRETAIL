using System.ComponentModel;

namespace Store
{
    partial class NewPurInv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
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
            ((System.ComponentModel.ISupportInitialize)(this.Bsnav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookuptoStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURINVDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitem)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dropstoremast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitemgroup)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dropstoremast1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.duedays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupunits.Properties)).BeginInit();
            this.panelunit.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totdisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totvalue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totnetamt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totspecdisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
         
            this.SuspendLayout();
            // 
            // spdisc
            // 
            this.spdisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spdisc.Properties.Appearance.Options.UseFont = true;
            this.spdisc.Properties.Appearance.Options.UseTextOptions = true;
            this.spdisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.spdisc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spdisc.Validated += new System.EventHandler(this.SpdiscValidated);
            // 
            // txtpurno
            // 
            this.txtpurno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurno.Properties.Appearance.Options.UseFont = true;
            this.txtpurno.Properties.Appearance.Options.UseTextOptions = true;
            this.txtpurno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtpurno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            // 
            // LookuptoStore
            // 
            this.LookuptoStore.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookuptoStore.Properties.Appearance.Options.UseFont = true;
            this.LookuptoStore.EditValueChanged += new System.EventHandler(this.LookuptoStore_EditValueChanged);
            // 
            // LookupSupplier
            // 
            this.LookupSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookupSupplier.Properties.Appearance.Options.UseFont = true;
            // 
            // Lookupwarehouse
            // 
            this.Lookupwarehouse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lookupwarehouse.Properties.Appearance.Options.UseFont = true;
            // 
            // comboBoxEdit1
            // 
            // 
            // duedays
            // 
            this.duedays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedays.Properties.Appearance.Options.UseFont = true;
            this.duedays.Properties.Appearance.Options.UseTextOptions = true;
            this.duedays.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.duedays.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.duedays.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // invdate
            // 
            this.invdate.EditValue = new System.DateTime(2012, 7, 17, 0, 0, 0, 0);
            this.invdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invdate.Properties.Appearance.Options.UseFont = true;
            this.invdate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.invdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.invdate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.invdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // invno
            // 
            this.invno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invno.Properties.Appearance.Options.UseFont = true;
            this.invno.Properties.Appearance.Options.UseTextOptions = true;
            this.invno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.invno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            // 
            // adjustval
            // 
            this.adjustval.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustval.Properties.Appearance.Options.UseFont = true;
            this.adjustval.Properties.Appearance.Options.UseTextOptions = true;
            this.adjustval.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.adjustval.Properties.DisplayFormat.FormatString = "###,##0.00";
            this.adjustval.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
           // this.adjustval.EditValueChanged += new System.EventHandler(this.adjustval_EditValueChanged);
            // 
            // lookupunits
            // 
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(544, 3);
            this.panel4.Controls.SetChildIndex(this.totspecdisc, 0);
            this.panel4.Controls.SetChildIndex(this.totnetamt, 0);
            this.panel4.Controls.SetChildIndex(this.totvalue, 0);
            this.panel4.Controls.SetChildIndex(this.totdisc, 0);
            // 
            // totdisc
            // 
            this.totdisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totdisc.Properties.Appearance.Options.UseFont = true;
            this.totdisc.Properties.Appearance.Options.UseTextOptions = true;
            this.totdisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totdisc.Properties.DisplayFormat.FormatString = "###,###,##0.00";
            this.totdisc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // totvalue
            // 
            this.totvalue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totvalue.Properties.Appearance.Options.UseFont = true;
            this.totvalue.Properties.Appearance.Options.UseTextOptions = true;
            this.totvalue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totvalue.Properties.DisplayFormat.FormatString = "###,###,###,###.00";
            this.totvalue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // totnetamt
            // 
            this.totnetamt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totnetamt.Properties.Appearance.Options.UseFont = true;
            this.totnetamt.Properties.Appearance.Options.UseTextOptions = true;
            this.totnetamt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totnetamt.Properties.DisplayFormat.FormatString = "###,###,##0.00";
            this.totnetamt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // totspecdisc
            // 
            this.totspecdisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totspecdisc.Properties.Appearance.Options.UseFont = true;
            this.totspecdisc.Properties.Appearance.Options.UseTextOptions = true;
            this.totspecdisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totspecdisc.Properties.DisplayFormat.FormatString = "###,###,##0.00";
            this.totspecdisc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
             
            // 
   
            // NewPurInv
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(807, 571);
            this.Name = "NewPurInv";
            this.Text = "Purchase Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPurInvFormClosing);
            this.Load += new System.EventHandler(this.NewPurInvLoad);
            ((System.ComponentModel.ISupportInitialize)(this.Bsnav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookuptoStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURINVDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitem)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dropstoremast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropitemgroup)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dropstoremast1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lookupwarehouse.Properties)).EndInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.duedays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupunits.Properties)).EndInit();
            this.panelunit.ResumeLayout(false);
            this.panelunit.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.totdisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totvalue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totnetamt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totspecdisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
    
            this.ResumeLayout(false);

        }
        #endregion
        //private System.Windows.Forms.BindingSource bindingSource1;
        //private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}
