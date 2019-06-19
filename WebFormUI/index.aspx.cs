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
    public partial class index : System.Web.UI.Page
    {
        private IPersonService _personService;
        protected void Page_Load(object sender, EventArgs e)
        {
            _personService = new PersonManager(new EfPersonDal());
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = String.Format("{0}", Request.Form["txtUserName"]);
            string password = String.Format("{0}", Request.Form["txtPass"]);
            bool result = _personService.GetAuthentication(userName, password);
            if (result == true)
            {                
                Session["Users"] = userName;
                Response.Redirect("Section.aspx");
            }
            else
            {               
                //Response.Redirect("index.aspx");
                txt1.Attributes.CssStyle.Add("display", "block");
            }           
        }
    }
}