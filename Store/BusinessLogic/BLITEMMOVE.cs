using System;
using System.Data;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;
using DevExpress.XtraReports.UI;
using Store.COMMON;
using VIRETAILDAL.Transfers;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store.BusinessLogic
{
    public class Blitemmove
    {
        public string Tranid { get; set; }
        public string FromId { get; set; }
        public string ToId { get; set; }
        public DateTime Trandate { get; set;}
        public bool Hold { get; set; }
        public decimal Netvalue { get; set; }
        public string Notes { get; set; }
        public int Movetype { get; set; }
        public string Frmname { get; set; }
        public string Toname { get; set; }
        public string Stype { get; set; }
        public DsInventory.ITEMTRANSFERDETAILDataTable Itemtransferdetail;
        public DsInventory.ITEMTRANSFERMAINRow ItemtransfermainRow;
        //public Blitemmove(DataRow d)
        //{
        //    var dr = (DsInventory.ITEMTRANSFERMAINRow) d;
        //    ItemtransfermainRow = dr;
        //     if(!string.IsNullOrEmpty(dr.TRANID))
        //         Tranid = dr.TRANID;
        //     Trandate = dr.TRANDATE;
        //    Hold = dr.HOLD;
        //    Movetype = dr.TTYPE;
        //    Netvalue = dr.TOTVALUE;

        //}
        public  string DoSave()
        {
            var dm = new ItemMoveDataManager();
           
            var retval = dm.DoSave(ItemtransfermainRow, Itemtransferdetail,Stype);
            if (retval == "1")
            {
                Tranid = Utils.Tranid;
            }
            return retval;
        }
        public void GetItemMoveByTranid(bool othercomp=false,string concomp="")
        {
            var ds = ClsGetData.GetItemTransferById(Tranid,othercomp,concomp);
            foreach (DataRow d in ds.Rows)
            {
                Tranid = d["TRANID"].ToString();
                FromId = d["FRMSTOREID"].ToString();
                ToId = d["TOSTOREID"].ToString();
                Trandate = DateTime.Parse(d["TRANDATE"].ToString());
                if(!string.IsNullOrEmpty(d["TOTVALUE"].ToString()))
                    Netvalue = decimal.Parse(d["TOTVALUE"].ToString());
                Movetype = int.Parse(d["TTYPE"].ToString());
                Notes = d["NOTE"].ToString();
                Hold = bool.Parse(d["HOLD"].ToString());
            }
            Itemtransferdetail = ClsGetData.GetItemTransferDetailById(Tranid, othercomp, concomp);
        }
        public DsInventory.ITEMTRANSFERMAINDataTable GetItemTransfer()
        {
           return ClsGetData.GetItemTransfer();
        }
        public static void DoPrint(string tranid)
        {
            var dm = new ItemMoveDataManager();
            var rpt = new Reports.RptItemMove { Company = Utils.Companyname , Header = "Item Transfer"};
            var ds = dm.RptItemMove(tranid, Utils.Company);
            rpt.DataSource = ds;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            
            printTool.ShowPreview();

      
            
        }
        public string GetMaxTranid()
        {
           return   new ItemMoveDataManager().GetMaxTranid();
        }
        public void DeleteItemMove(string tranid)
        {
            var da = new ItemMoveDataManager();
            da.DeleteItemMove(tranid);
        }
        public DsInventory.ITEMTRANSFERDETAILDataTable GetItemTranferDetails(string tranid)
        {
            return ClsGetData.GetItemTransferDetailById(tranid);
        }
        public DsMaster.TEMPBCODEPRINTDataTable CreateBarCode(string  tranid )
        {
            var dt = new DsMaster().TEMPBCODEPRINT;
            Itemtransferdetail = GetItemTranferDetails(tranid);
            foreach (DataRow dr in Itemtransferdetail.Rows)
            {
                var dnew = dt.NewRow();
                dnew["ITEMCODE"] = dr["itemno"];
                dnew["ITEMNAME"] = new BlItemMaster().GetItemname(dr["itemno"].ToString());
                dnew["QTY"] = dr["qty"];
                dnew["PRICE"] = dr["SPRICE"];
                dt.Rows.Add(dnew);
            }
             

            return dt;
        }
        public void CreateItemtransferdetailsFrmMr(DsPurchase.PURCHASEREQUESTDataTable dst,string whid)
        {
            Itemtransferdetail = new ItemMoveDataManager().CreateItemtransferdetailsFrmMR(dst, whid);
        }

         
    }
    public class BLDiskManager
        {
            public string tranid { get; set; }
            public int ftype { get; set; }
            public string fileno { get; set; }
            public void DoSave()
            {
                var bl = new DiskDataManager();
                bl.Tranid = tranid;
                bl.fileno = fileno;
                bl.ftype = ftype;
                bl.DoSave();
            }

            public XmlDocument CreateEncriptedXmlfile(string txtXml)
            {
                XmlDocument xmlDoc = new XmlDocument();
                try
                {
                    xmlDoc.LoadXml(txtXml);
                    var rsa = new RSACryptoServiceProvider();
                    XmlElement xmlElemt;
                    xmlElemt = xmlDoc.DocumentElement;
                    EncryptedXml xmlEnc = new EncryptedXml(xmlDoc);
                    xmlEnc.AddKeyNameMapping("asyncKey", rsa);
                    EncryptedData encXml = xmlEnc.Encrypt(xmlElemt, "asyncKey");
                    EncryptedXml.ReplaceElement(xmlElemt, encXml, false);
                }
                catch (XmlException ex)
                {
                    throw ex;
                }
                return  xmlDoc ;
            }
            public XmlDocument DecryptEncriptedXmlfile(string txtEncryptedXml)
            {
                XmlDocument xmlEncDoc = new XmlDocument();
                xmlEncDoc.LoadXml(txtEncryptedXml);
                var rsa = new RSACryptoServiceProvider();
                EncryptedXml encXml = new EncryptedXml(xmlEncDoc);
                encXml.AddKeyNameMapping("asyncKey", rsa);
                encXml.DecryptDocument();
                return xmlEncDoc;
            }
         }
    }
