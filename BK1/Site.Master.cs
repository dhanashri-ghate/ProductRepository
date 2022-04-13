using BK1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BK1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //public List<Product> GetProducts()
        //{
        //    var _db = new BK1.Models.ProductContext();
        //    var query = _db.Products.ToList();
        //    return query;
        //}

        public List<Category> GetCategories()
        {
            var _db = new BK1.Models.ProductContext();
            var query = _db.Categories.ToList();
            return query;
        }
    }
}