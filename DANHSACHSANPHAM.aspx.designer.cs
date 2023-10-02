
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System;

namespace QUANLIBANHANG_ONLINE
{


    public partial class DANHSACHSANPHAM : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XULIDULIEU xuly = new XULIDULIEU();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MASANPHAM", DBNull.Value);
            this.DataList1.RepeatColumns = 3;
            this.DataList1.DataSource = xuly.getTable("psGetTableSANPHAM", pr);
            this.DataList1.DataBind();
        }
    }
}
