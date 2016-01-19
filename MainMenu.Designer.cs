namespace VIRETAILSTORE
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame3 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame4 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame5 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.groupsub = new DevExpress.XtraEditors.TileGroup();
            this.groupreports = new DevExpress.XtraEditors.TileGroup();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection();
            this.tilepurchasing = new DevExpress.XtraEditors.TileItem();
            this.tilesale = new DevExpress.XtraEditors.TileItem();
            this.tileinventory = new DevExpress.XtraEditors.TileItem();
            this.tilecomm = new DevExpress.XtraEditors.TileItem();
            this.tilesetup = new DevExpress.XtraEditors.TileItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.AllowItemHover = true;
            this.tileControl1.AllowSelectedItem = true;
            this.tileControl1.AppearanceGroupText.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl1.AppearanceGroupText.Options.UseFont = true;
            this.tileControl1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileControl1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl1.AppearanceText.Options.UseFont = true;
            this.tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileControl1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.tileControl1.ItemSize = 100;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.LookAndFeel.SkinName = "Office 2013";
            this.tileControl1.MaxId = 24;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControl1.RowCount = 6;
            this.tileControl1.SelectedItem = this.tilecomm;
            this.tileControl1.SelectionColor = System.Drawing.Color.Maroon;
            this.tileControl1.ShowGroupText = true;
            this.tileControl1.Size = new System.Drawing.Size(235, 594);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "Menu";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tilepurchasing);
            this.tileGroup2.Items.Add(this.tilesale);
            this.tileGroup2.Items.Add(this.tileinventory);
            this.tileGroup2.Items.Add(this.tilecomm);
            this.tileGroup2.Items.Add(this.tilesetup);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "Menu";
            // 
            // tileControl2
            // 
            this.tileControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl2.Groups.Add(this.groupsub);
            this.tileControl2.Groups.Add(this.groupreports);
            this.tileControl2.Location = new System.Drawing.Point(235, 0);
            this.tileControl2.MaxId = 14;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Size = new System.Drawing.Size(620, 594);
            this.tileControl2.TabIndex = 1;
            this.tileControl2.Text = "tileControl2";
            // 
            // groupsub
            // 
            this.groupsub.Name = "groupsub";
            this.groupsub.Text = null;
            // 
            // groupreports
            // 
            this.groupreports.Name = "groupreports";
            this.groupreports.Text = null;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // tilepurchasing
            // 
            this.tilepurchasing.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Chocolate;
            this.tilepurchasing.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tilepurchasing.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tilepurchasing.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilepurchasing.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tilepurchasing.AppearanceItem.Normal.Options.UseFont = true;
            this.tilepurchasing.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tilepurchasing.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilepurchasing.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tilepurchasing.AppearanceItem.Selected.Options.UseFont = true;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Image = global::VIRETAILSTORE.Properties.Resources.autoship;
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement1.Text = "Purchasing";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tilepurchasing.Elements.Add(tileItemElement1);
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Image = global::VIRETAILSTORE.Properties.Resources.autoship;
            tileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement2.Text = "Purchasing";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemFrame1.Elements.Add(tileItemElement2);
            tileItemFrame1.Image = global::VIRETAILSTORE.Properties.Resources.autoship;
            this.tilepurchasing.Frames.Add(tileItemFrame1);
            this.tilepurchasing.Id = 1;
            this.tilepurchasing.IsLarge = true;
            this.tilepurchasing.Name = "tilepurchasing";
            this.tilepurchasing.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tilepurchasing_ItemClick);
            // 
            // tilesale
            // 
            this.tilesale.AppearanceItem.Hovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tilesale.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tilesale.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.tilesale.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilesale.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tilesale.AppearanceItem.Normal.Options.UseFont = true;
            this.tilesale.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tilesale.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilesale.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tilesale.AppearanceItem.Selected.Options.UseFont = true;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Image = global::VIRETAILSTORE.Properties.Resources.shopping_trolley;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement3.Text = "Sales";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tilesale.Elements.Add(tileItemElement3);
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Image = global::VIRETAILSTORE.Properties.Resources.shopcartapply;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement4.Text = "Sales";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemFrame2.Elements.Add(tileItemElement4);
            tileItemFrame2.Image = global::VIRETAILSTORE.Properties.Resources.shopcartapply;
            this.tilesale.Frames.Add(tileItemFrame2);
            this.tilesale.Id = 2;
            this.tilesale.IsLarge = true;
            this.tilesale.Name = "tilesale";
            this.tilesale.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tilesales_ItemClick);
            // 
            // tileinventory
            // 
            this.tileinventory.AppearanceItem.Hovered.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tileinventory.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileinventory.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileinventory.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileinventory.AppearanceItem.Selected.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileinventory.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileinventory.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileinventory.AppearanceItem.Selected.Options.UseFont = true;
            tileItemElement5.Image = global::VIRETAILSTORE.Properties.Resources.Shipping;
            tileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement5.Text = "Inventory";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tileinventory.Elements.Add(tileItemElement5);
            tileItemElement6.Image = global::VIRETAILSTORE.Properties.Resources.Shipping;
            tileItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement6.Text = "Inventory";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemFrame3.Elements.Add(tileItemElement6);
            tileItemFrame3.Image = global::VIRETAILSTORE.Properties.Resources.Shipping;
            this.tileinventory.Frames.Add(tileItemFrame3);
            this.tileinventory.Id = 3;
            this.tileinventory.IsLarge = true;
            this.tileinventory.Name = "tileinventory";
            // 
            // tilecomm
            // 
            this.tilecomm.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Gray;
            this.tilecomm.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tilecomm.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.tilecomm.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilecomm.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tilecomm.AppearanceItem.Normal.Options.UseFont = true;
            this.tilecomm.AppearanceItem.Selected.BackColor = System.Drawing.Color.Gray;
            this.tilecomm.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilecomm.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tilecomm.AppearanceItem.Selected.Options.UseFont = true;
            tileItemElement7.Image = global::VIRETAILSTORE.Properties.Resources.comm1;
            tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement7.Text = "Communication";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tilecomm.Elements.Add(tileItemElement7);
            tileItemElement8.Image = global::VIRETAILSTORE.Properties.Resources.comm1;
            tileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement8.Text = "Communication";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemFrame4.Elements.Add(tileItemElement8);
            tileItemFrame4.Image = global::VIRETAILSTORE.Properties.Resources.comm1;
            this.tilecomm.Frames.Add(tileItemFrame4);
            this.tilecomm.Id = 5;
            this.tilecomm.IsLarge = true;
            this.tilecomm.Name = "tilecomm";
            // 
            // tilesetup
            // 
            this.tilesetup.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tilesetup.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tilesetup.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkRed;
            this.tilesetup.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilesetup.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tilesetup.AppearanceItem.Normal.Options.UseFont = true;
            this.tilesetup.AppearanceItem.Selected.BackColor = System.Drawing.Color.Maroon;
            this.tilesetup.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilesetup.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tilesetup.AppearanceItem.Selected.Options.UseFont = true;
            tileItemElement9.Image = global::VIRETAILSTORE.Properties.Resources.Administrative_Tools;
            tileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement9.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement9.Text = "Admin";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tilesetup.Elements.Add(tileItemElement9);
            tileItemElement10.Image = global::VIRETAILSTORE.Properties.Resources.Administrative_Tools;
            tileItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement10.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement10.Text = "Admin";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemFrame5.Elements.Add(tileItemElement10);
            tileItemFrame5.Image = global::VIRETAILSTORE.Properties.Resources.Administrative_Tools;
            this.tilesetup.Frames.Add(tileItemFrame5);
            this.tilesetup.Id = 4;
            this.tilesetup.IsLarge = true;
            this.tilesetup.Name = "tilesetup";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 594);
            this.Controls.Add(this.tileControl2);
            this.Controls.Add(this.tileControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Metropolis";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tilepurchasing;
        private DevExpress.XtraEditors.TileItem tilesale;
        private DevExpress.XtraEditors.TileItem tileinventory;
        private DevExpress.XtraEditors.TileItem tilesetup;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup groupsub;
        private DevExpress.XtraEditors.TileGroup groupreports;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.TileItem tilecomm;

    }
}