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
    public partial class InsertCategories : System.Web.UI.Page
    {
        private ICategoryService _categoryService;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Users"] != null)
            {
                _categoryService = new CategoryManager(new EfCategoryDal());                
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnInsertCategory_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Add(new Category
                {
                    CategoryName = String.Format("{0}", Request.Form["txtCategoryName"])                    
                });
                lblInformation.Text = "Ürün Eklendi";
            }
            catch (Exception ex)
            {
                lblInformation.Text = ex.Message;
            }
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExpencesAccess.aspx");
        }
    }
}