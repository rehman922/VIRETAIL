using System.Data.SqlClient;
namespace VIRETAILDAL.DsMasterTableAdapters {
    partial class INSCUSTDETAILSTableAdapter
    {
        
    }

    partial class DDDETAILSTableAdapter
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

    partial class DDMASTTableAdapter
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

    partial class TERMSMASTTableAdapter
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

    partial class TERMSDETAILMASTTableAdapter
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

    partial class INSCUSTOMERSTableAdapter
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
                Transaction = trans;
                Adapter.InsertCommand.Transaction = trans;
                Adapter.DeleteCommand.Transaction = trans;
                Adapter.UpdateCommand.Transaction = trans;
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }

    partial class SyscfgTableAdapter
    {
    }

    partial class USERINFOTableAdapter
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

    partial class PRICEMASTERTableAdapter
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
    partial class INSURANCEDISCTableAdapter
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
    partial class CUSTOMERTableAdapter
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
                foreach (SqlCommand cmd in this.CommandCollection)
                {
                    cmd.Transaction = trans;
                }
            }
            Adapter.AcceptChangesDuringUpdate = false;
            Adapter.ContinueUpdateOnError = false;
        }
    }
    partial class ITEMMASTTableAdapter
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
    public partial class STOREMASTTableAdapter {
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
