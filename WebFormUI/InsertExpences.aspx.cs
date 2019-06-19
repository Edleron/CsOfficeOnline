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
    public partial class InsertExpences : System.Web.UI.Page
    {
        private IPersonService _personService;
        private IExpenseService _expenseService;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Users"] != null && Session["CategoryId"] != null)
            {
                _personService = new PersonManager(new EfPersonDal());
                _expenseService = new ExpenseManager(new EfExpenseDal());
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
                _expenseService.Add(new Expense
                {
                    ExpenselName = String.Format("{0}", Request.Form["txtExpenselName"]),
                    CategoryId = Convert.ToInt32(Session["CategoryId"]),
                    UnitPrice = Convert.ToDecimal(String.Format("{0}", Request.Form["txtUnitPrice"])),
                    Explanation = String.Format("{0}", Request.Form["txtExplanation"]),
                    DateOperation = Convert.ToDateTime(String.Format("{0: yyyy.MM.dd}", Request.Form["txtDateTime"])),
                    ImagePath = ImageUploadPath(),
                    PersonId = _personService.GetPersonId(Session["Users"].ToString()).PersonId,
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


        private string ImageUploadPath()
        {
            if (fileUploadImage.HasFile)
            {
                try
                {
                    if (fileUploadImage.PostedFile.ContentType == "image/jpeg")
                    {
                        if (fileUploadImage.PostedFile.ContentLength < 5024000)
                        {
                            string filename = Path.GetFileName(fileUploadImage.FileName);
                            if (filename != "")
                            {
                                fileUploadImage.SaveAs(Server.MapPath("~/FrontEndTolling/ExpencesImages/") + filename);
                                lblInformation.Text = filename + " Dosyası Yüklendi!";
                                return "/FrontEndTolling/ExpencesImages/" + filename;
                            }
                            else
                            {
                                return "";
                            }
                        }
                        else
                        {
                            lblInformation.Text = "Dosya boyutu 100 KB'dan düşük olmalı!";
                            return "";
                        }
                    }
                    else
                    {
                        lblInformation.Text = "Sadece JPEG formatı kabul edilir.";
                        return "";
                    }

                }
                catch (Exception ex)
                {
                    lblInformation.Text = "Dosya yüklenemedi: " + ex.Message;
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
    }


}
