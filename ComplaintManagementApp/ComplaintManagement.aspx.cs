using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using ComplaintManagementApp.DAL;

namespace ComplaintManagementApp
{
    public partial class ComplaintManagement : Page
    {
        datalayer dl;
        private readonly DAL.Interfaces.IComplaintService _complaintService;

        public ComplaintManagement()
        {
            _complaintService = new DAL.Services.ComplaintService(new DAL.Services.ComplaintRepository(new ComplaintManagementApp.DAL.ComplaintDbContext()));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var query = _complaintService.GetAll();
            dl = new datalayer();
            dl.fillgridView(query, gv);

        }
        static string Id;
        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = gv.SelectedRow.Cells[1].Text.ToString();
            txtTitle.Text = gv.SelectedRow.Cells[2].Text.ToString();
            txtIsResolved.Text = gv.SelectedRow.Cells[3].Text.ToString();
            txtDueDate.Text = gv.SelectedRow.Cells[4].Text.ToString();
           
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            var query = _complaintService.Add();
            string qry = query + txtTitle.Text + "','" + txtIsResolved.Text + "','" + txtDueDate.Text + "')";
            lblmessage.Text = dl.insertUpdateCreateOrDelete(qry);

            
            txtTitle.Text = "";
            txtIsResolved.Text = "";
            txtDueDate.Text = "";
        
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            var query = _complaintService.Update();
            string qry = query + txtTitle.Text + "',IsResolved='" + txtIsResolved.Text + "',DueDate='" + txtDueDate.Text;
            lblmessage.Text = dl.insertUpdateCreateOrDelete(qry);
            txtTitle.Text = "";
            txtIsResolved.Text = "";
            txtDueDate.Text = "";
        
        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            var query = _complaintService.Delete();
            string qry = query + Id + "'";
            lblmessage.Text = dl.insertUpdateCreateOrDelete(qry);
        }
    }
}