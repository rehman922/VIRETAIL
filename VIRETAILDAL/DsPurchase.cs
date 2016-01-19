using System.Data.SqlClient;

namespace VIRETAILDAL.DsPurchaseTableAdapters {
    partial class PURCHASEREQUESTTableAdapter
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

    partial class PODETAILTableAdapter
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
    partial class POMAINTableAdapter
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
    partial class RETURNDETAILTableAdapter
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
    partial class RETURNMASTTableAdapter
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
    partial class PURINVDETAILTableAdapter
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
    partial class PURINVMAINTableAdapter {
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
