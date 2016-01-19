using System.Data.SqlClient;

namespace VIRETAILDAL.DsInventoryTableAdapters {
    partial class YearEndInventoryTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Transaction = trans;
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
    
    partial class SALESINVDETAIL_DELTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Transaction = trans;
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }

    partial class SALESINVDETAILTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Transaction = trans;
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }

    partial class SALESMAINTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }

    partial class ITEMMAST1TableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
    partial class ADJDETAILTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
    partial class ADJMASTTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
    partial class STOCKMASTERTableAdapter
    {
        public void AssignConnection(SqlConnection conn,SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Transaction = trans;
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
    partial class ITEMTRANSFERMAINTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (trans != null)
            {
                if (Adapter == null)
                {
                    InitAdapter();
                }
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
    partial class ITEMTRANSFERDETAILTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (trans != null)
            {
                if (Adapter == null)
                {
                    InitAdapter();
                }
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
    partial class AUTONOSTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
   }
    partial class DISKDETAILSTableAdapter
    {
        public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
    partial class SUPPLIERTableAdapter
    {
         public void AssignConnection(SqlConnection conn, SqlTransaction trans)
        {
            Connection = conn;
            if (Adapter == null)
            {
                InitAdapter();
            }
            if (trans != null)
            {
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
   

}
