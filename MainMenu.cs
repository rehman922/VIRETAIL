using System;
using System.Data;
using System.Reflection;
using System.Threading;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace VIRETAILSTORE
{
    public partial class MainMenu : XtraForm
    {
        private DataTable _dt = new DataTable();
        public MainMenu()
        {
            InitializeComponent();
            var frm = new Store.Login();
            SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
            VIRETAILDAL.COMMON.Utils.Connectionstring = Properties.Settings.Default.POSConnectionString;
            AppDomain MyDomain = AppDomain.CurrentDomain;
            Assembly[] AssembliesLoaded = MyDomain.GetAssemblies();
            foreach (Assembly MyAssembly in AssembliesLoaded)
            {
                SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, MyAssembly.FullName);
                Thread.Sleep(100);
            }
            SplashScreenManager.CloseForm(false);
          
            frm.ShowDialog();
           if(!frm.LoginSucess)
               Dispose();
            CreateTableForPermissions();
            LoadPermissionsTiles();
             

                //XtraMessageBox.Show(imageCollection1.Images[20].Height.ToString());
                //XtraMessageBox.Show(imageCollection1.Images[30].Height.ToString());
            
        }
        void LoadPermissionsTiles()
        {
            
            //if(!string.IsNullOrEmpty(VIRETAILDAL.COMMON.Utils.Permissions))
            //{
            //    for(int i = 0 ;i< 3 ; i++)
            //    {
            //        foreach(DataRow dr in GetRows(i))
            //        {}
            //    }
            //}
            //else if(VIRETAILDAL.COMMON.Utils.UserType==3)
            //{}
            var mn = VIRETAILDAL.COMMON.Utils.Permissions.Substring(0, 5);
            string defaulttile = "-1";
            string maintilename = "";
            if(mn.Substring(0,1)=="1")
            {
                tilepurchasing.Visible = true;
                defaulttile = "1";
                maintilename = "Purchasing";
            }
            else
            {
                tilepurchasing.Visible = false;
            }
            if(mn.Substring(1,1)=="1")
            {
                tilesale.Visible = true;
                defaulttile += "2";
                if(string.IsNullOrEmpty(maintilename))
                    maintilename = "Sales";
            }
            else
            {
              tilesale.Visible = false;  
            }
            if(mn.Substring(2,1)=="1")
            {
                tileinventory.Visible = true;
                defaulttile += "3";
                if (string.IsNullOrEmpty(maintilename))
                    maintilename = "Inventory";
            }
            else
            {
                 tileinventory.Visible = false;
            }
            if(mn.Substring(3,1)=="1")
            {
                tilesetup.Visible = true;
                defaulttile += "4";
            }
            else
            {
                tilesetup.Visible = false;
            }
            if (mn.Substring(4, 1) == "1")
            {
                tilecomm.Visible = true;
                defaulttile += "5";
            }
            else
            {
                tilecomm.Visible = false;
            }
            LoadSubTiles(defaulttile,maintilename);
        }
        void LoadSubTiles(string sr,string maintilename)
        {
            var dataRow = _dt.Select(" MPARENTID = " + sr.Substring(0, 1));
            int reptid = 0;
            
            foreach (var dr in dataRow)
            {
                bool issub = false;
                if(int.Parse(dr["PARENTID"].ToString())==0 && int.Parse(dr["MPARENTID"].ToString()) > 0)
                {
                    reptid = int.Parse(dr["MENUID"].ToString());
                    tileControl2.Text = dr["MENUNAME"].ToString();
                }

                if (int.Parse(dr["PARENTID"].ToString()) == reptid && dr["MPARENTID"].ToString()==sr.Substring(0, 1))
                {
                     issub = true;
                }

                NewTile(dr[1].ToString(), int.Parse(dr[0].ToString()), issub, bool.Parse(dr["ISLARGE"].ToString()));
            }
        }
        DataRow[] GetRows(int i)
        {
          var drs = new DataRow[] {};
          if(i==0)
          {
              drs = _dt.Select("PARENTID = 0");
          }
          if (i == 0)
          {
              drs = _dt.Select("PARENTID = 0");
          }
           return drs;
        }
        void CreateTile(string name,string id,int tiletype)
        {
            TileItem newTile = new TileItem();
            //The first frame - Image only 
            TileItemFrame logoDXFrame = new TileItemFrame();
            logoDXFrame.UseImage = true;
            logoDXFrame.UseText = true;
            logoDXFrame.AnimateImage = true;
            logoDXFrame.AnimateText = true;
            var logoEl = new TileItemElement();
            if (id == "0")
                logoEl.Image = Properties.Resources.logout_icon;
            if(id=="1")
                logoEl.Image = Properties.Resources.packing;
            if (id == "2")
                logoEl.Image = Properties.Resources.shopping_trolley;
            if (id == "3")
                logoEl.Image = Properties.Resources.inventory;
            if (id == "4")
                logoEl.Image = Properties.Resources.skills_icon;
            logoEl.Text = "name";
            logoEl.ImageAlignment = TileItemContentAlignment.MiddleCenter;

            logoDXFrame.Elements.Add(logoEl);
            TileItemFrame mottoDXFrame = new TileItemFrame();
            TileItemElement mottoEl = new TileItemElement();
            mottoEl.Text = "<Size=+3><Color=white><b>Let's see what develops.</b></Color></Size>";
            mottoDXFrame.Elements.Add(mottoEl);
            mottoDXFrame.UseImage = true;
            mottoDXFrame.UseText = true;
            mottoDXFrame.AnimateImage = true;
            mottoDXFrame.AnimateText = true;
            //Global Tile Item Settings 
            newTile.Frames.Add(logoDXFrame);
            newTile.Frames.Add(mottoDXFrame);
            //newTile.Appearance.BackColor = System.Drawing.Color.Gray;
            //newTile.Appearance.BackColor2 = System.Drawing.Color.SandyBrown;
            //newTile.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            //newTile.Appearance.BorderColor = System.Drawing.Color.Bisque;
            newTile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            newTile.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            newTile.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            newTile.TextAlignment = TileItemContentAlignment.MiddleCenter;
            newTile.FrameAnimationInterval = 2000;
            newTile.IsLarge = true;
            if(tiletype==1)
                tileControl1.Groups[0].Items.Add(newTile);
            if (tiletype == 2)
                tileControl2.Groups[0].Items.Add(newTile);
            
                
        }
        private void tileControl2_Click(object sender, EventArgs e)
        {}
        private void tilesales_ItemClick(object sender, TileItemEventArgs e)
        {

        }
        void LoadTiles(DataTable ds)
        {
            
        }
        private void tilepurchasing_ItemClick(object sender, TileItemEventArgs e)
        {
           //for(int i=0;i<10;i++)
           //{
           //    NewTile(i + "d", i);
           //}
        }
        void clickhandler(object sender,TileItemEventArgs e)
        {
            
        }
        private void NewTile(string tilecaption,int tileid,bool mtype,bool islarge)
        {
                var newTile = new TileItem();
                
                newTile.ItemClick += clickhandler;
                newTile.Name = tileid.ToString();
                newTile.Tag = tileid;
                newTile.IsLarge = islarge;
                newTile.Text = tilecaption;
                var logoDXFrame = new TileItemFrame();
                logoDXFrame.UseImage = true;
                logoDXFrame.UseText = true;
                logoDXFrame.AnimateImage = true;
                logoDXFrame.AnimateText = true;
                var logoEl = new TileItemElement();
                logoDXFrame.Elements.Add(logoEl);
                if (!mtype)
                {
                    tileControl2.Groups[0].Items.Add(newTile);
                    tileControl2.ScrollMode = TileControlScrollMode.ScrollBar;
                }
                else
                {
                    tileControl2.Groups[1].Items.Add(newTile);
                    tileControl2.ScrollMode = TileControlScrollMode.ScrollBar;
                }
        }
        void  CreateTableForPermissions()
        {
            if(string.IsNullOrEmpty(VIRETAILDAL.COMMON.Utils.Permissions))
                return;
            
            var perms = VIRETAILDAL.COMMON.Utils.Permissions;
             _dt = new VIRETAILDAL.DataManager().LoadDataSetMenu();
         //   _dt =  new VIRETAILDAL.DataManager().LoadMenu("1,2,3,4,5,");
            int i =0;
            foreach(DataRow dr in _dt.Rows)
            {
               // if (perms.Substring(0, 1) == "1")
               // {
                    if (perms.Substring(i+9, 1) == "1")
                    {
                        if (dr["MENUID"].ToString() == i.ToString())
                        {
                            dr["SEL"] = true;
                        }
                        else
                        {
                            dr["SEL"] = false;
                        }
                    }
                i++;
               // }
                _dt.AcceptChanges();
            }
        }
        //private void NewTile(string Bno, string Fnm, string bdt,string rid, int anicount, string mfrom, int cstat, int act)
        //{

        //    TileItem newTile = new TileItem();
        //    newTile.ItemClick += new TileItemClickEventHandler(clickhandler);
        //    newTile.Name = rid;
        //    newTile.Tag = mfrom;
        //    //First Frame - Image only
        //    TileItemFrame logoDXFrame = new TileItemFrame();
        //    logoDXFrame.UseImage = true;
        //    logoDXFrame.UseText = true;
        //    logoDXFrame.AnimateImage = true;
        //    logoDXFrame.AnimateText = true;
        //    TileItemElement logoEl = new TileItemElement();
        //    logoDXFrame.Elements.Add(logoEl);
        //    logoDXFrame.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
        //    if (act == 0)
        //    {
        //        logoDXFrame.Elements[0].Text = "<Size=+1><Color=Black><b>Timesheet for Verification.</b></Color></Size>";
        //    }
        //    else
        //    {
        //        logoDXFrame.Elements[0].Text = "<Size=+1><Color=Black><b>Timesheet for Approval.</b></Color></Size>";
        //    }
        //    //logoDXFrame.Elements[0].Text = "<Size=+2><Color=Black><b>" + Bno + "</b></Color></Size>";
        //    logoDXFrame.Elements[0].TextAlignment = TileItemContentAlignment.TopLeft;
        //    //logoDXFrame.Elements[0].Appearance.Normal.BorderColor = abc;

           


        //    //Second Frame - Text only
        //    TileItemFrame mottoDXFrame = new TileItemFrame();
        //    TileItemElement mottoEl = new TileItemElement();

        //    if (act == 0)
        //    {
        //        mottoEl.Text = "<Size=+1><Color=White><b>Timesheet for Verification.</b></Color></Size>";
        //    }
        //    else
        //    {
        //        mottoEl.Text = "<Size=+1><Color=White><b>Timesheet for Approval.</b></Color></Size>";
        //    }
        //    mottoEl.TextAlignment = TileItemContentAlignment.TopLeft;
        //    mottoDXFrame.Elements.Add(mottoEl);
        //    mottoDXFrame.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
        //    mottoDXFrame.UseImage = true;
        //    mottoDXFrame.UseText = true;
        //    mottoDXFrame.AnimateImage = true;
        //    mottoDXFrame.AnimateText = true;



        //    TileItemElement mottoEl2 = new TileItemElement();
        //    mottoEl2.Text = "<Size=+1><Color=Black><i>" + Fnm + "</i></Color></Size>";
        //    mottoEl2.TextAlignment = TileItemContentAlignment.MiddleCenter;
        //    mottoDXFrame.Elements.Add(mottoEl2);
        //    mottoDXFrame.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;

        //    mottoDXFrame.UseImage = true;
        //    mottoDXFrame.UseText = true;
        //    mottoDXFrame.AnimateImage = true;
        //    mottoDXFrame.AnimateText = true;

        //    TileItemElement mottoEl3 = new TileItemElement();
        //    mottoEl3.Text = "<Color=White>Forward Dt: " + bdt + "</Color>";
        //    mottoEl3.TextAlignment = TileItemContentAlignment.BottomRight;
        //    mottoDXFrame.Elements.Add(mottoEl3);
        //    mottoDXFrame.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
           
        //    mottoDXFrame.UseImage = true;
        //    mottoDXFrame.UseText = true;
        //    mottoDXFrame.AnimateImage = true;
        //    mottoDXFrame.AnimateText = true;

        //    //Global Tile Item Settings
        //    newTile.Frames.Add(logoDXFrame);
        //    newTile.Frames.Add(mottoDXFrame);
        //    newTile.Appearance.BackColor = abc; // System.Drawing.Color.Bisque;
        //    newTile.Appearance.BackColor2 = abc; // System.Drawing.Color.SandyBrown;
        //    newTile.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
        //    newTile.Appearance.BorderColor = abc;// System.Drawing.Color.Bisque;
        //    newTile.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
        //    newTile.FrameAnimationInterval = anicount; //7500;
        //    newTile.IsLarge = true;
        //    if (cstat == 1)
        //    {
        //        newTile.Checked = true;
        //    }
        //    //  tileControl1.Groups.Add(new TileGroup());
        //    tileControl1.Groups[0].Items.Add(newTile);
        //    tileControl1.ScrollMode = TileControlScrollMode.ScrollBar;

        //    newTile.StartAnimation();

        //}

    }
}