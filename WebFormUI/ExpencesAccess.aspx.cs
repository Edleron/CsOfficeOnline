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

namespace WebFormUI
{
    public partial class ExpencesAccess : System.Web.UI.Page
    {
        private ICategoryService _categoryService;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Users"] != null)
                {
                    _categoryService = new CategoryManager(new EfCategoryDal());
                    cbxCategory.DataSource = _categoryService.GetAll();
                    cbxCategory.DataTextField = "CategoryName";
                    cbxCategory.DataValueField = "CategoryId";
                    cbxCategory.DataBind();
                    lblUserTitle.Text = Session["Users"].ToString();
                }
                else
                {
                    Response.Redirect("index.aspx");
                }
            }           
        }

        protected void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Session["CategoryId"] = cbxCategory.SelectedValue;
                Response.Redirect("InsertExpences.aspx");
            }
            catch (Exception)
            {
                throw;
            }            
        }

        protected void btnNewInsertCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertCategories.aspx");
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataAccess.aspx");
        }
    }
}