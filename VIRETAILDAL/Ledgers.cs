using System.Data.SqlClient;

namespace VIRETAILDAL.LedgersTableAdapters {
    partial class PROMOITEMSTableAdapter
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
    

    partial class YEARENDPROCESSTableAdapter
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

    partial class NewYearStockBackTableTableAdapter
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

    partial class ARAPRECEIPTSDETAILSTableAdapter
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

    partial class ARAPRECEIPTSTableAdapter
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

    partial class COMMISIONDETAILTableAdapter
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

    partial class COMMISIONMASTTableAdapter
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

    partial class SalesAmountDetailsTableAdapter
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

    partial class LEDGERSTableAdapter
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

    public partial class APARMAINTableAdapter {
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
