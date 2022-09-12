using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class statemang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AddDefaultRecord();
        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        AddNewRecordRowToGrid();
    }

    private void AddDefaultRecord()
    {
        
        DataTable dt = new DataTable();
        DataRow dr;
        dt.TableName = "Stud";
        dt.Columns.Add(new DataColumn("rno", typeof(string)));
        dt.Columns.Add(new DataColumn("name", typeof(string)));
        dt.Columns.Add(new DataColumn("course", typeof(string)));
        dr = dt.NewRow();
        dt.Rows.Add(dr);
         
        ViewState["Stud"] = dt;

        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
    private void AddNewRecordRowToGrid()
    {
       
        if(ViewState["Stud"] != null)
        {
             
            DataTable dtCurrentTable = (DataTable)ViewState["Stud"];
            DataRow drCurrentRow = null;

            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["rno"] = txtrno.Text;
                    drCurrentRow["name"] = txtname.Text;
                    drCurrentRow["course"] = txtcourse.Text;
                }

                if (dtCurrentTable.Rows[0][0].ToString() == "")
                {
                    dtCurrentTable.Rows[0].Delete();
                    dtCurrentTable.AcceptChanges();
                } 
                dtCurrentTable.Rows.Add(drCurrentRow);
                ViewState["Stud"] = dtCurrentTable; 
                GridView1.DataSource = dtCurrentTable;
                GridView1.DataBind();
            }
        }
    }
 }