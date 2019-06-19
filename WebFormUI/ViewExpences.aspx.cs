using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeOnline.Business.Abstract;
using OfficeOnline.Business.Concrete;
using OfficeOnline.DataAccess.Concrete.EntityFramework;
using OfficeOnline.Entities.Concrete;
using System.IO;


namespace WebFormUI
{
    public partial class ViewExpences : System.Web.UI.Page
    {
        private IExpenseService _expenseService;
        private IPersonService _personService;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Users"] != null && Session["CategoryId"] != null)
            {
                _expenseService = new ExpenseManager(new EfExpenseDal());
                _personService = new PersonManager(new EfPersonDal());
                int OwnerF1 = _personService.GetPersonId(Session["Users"].ToString()).PersonId;
                int CategoryIdF1 = Convert.ToInt32(Session["CategoryId"]);
                RepaterDataSet.DataSource = _expenseService.GetOwnerAndSpecificCategories(OwnerF1, CategoryIdF1);
                RepaterDataSet.DataBind();
                lblUserTitle.Text = Session["Users"].ToString();
                lblInformation.Text = " ";
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExpencesView.aspx");
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            string a1 = string.Format("{0: yyyy.MM.dd}", Request.Form["dateTimePickerf1"]);
            string a2 = string.Format("{0: yyyy.MM.dd}", Request.Form["dateTimePickerf2"]);
            int OwnerF1 = _personService.GetPersonId(Session["Users"].ToString()).PersonId;
            int CategoryIdF1 = Convert.ToInt32(Session["CategoryId"]);
            RepaterDataSet.DataSource = _expenseService.GetAllDateTimeList(a1, a2, OwnerF1, CategoryIdF1);
            RepaterDataSet.DataBind();
            //lblInformation.Text = "Belirtilen Tarihe Göre Sıralanma İşlemi Gerçekleştirildi.";
            /*
            try
            {
                
            }
            catch (Exception)
            {
                lblInformation.Text = "Lütfen İleri Bir tarih Girmeyiniz";
            }
            */
        }
    }
}