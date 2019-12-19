using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentGiris.Models;

namespace ViewComponentGiris.ViewComponents
{
    public class CategoriesListViewComponent : ViewComponent
    {
        private readonly Database db;
        public CategoriesListViewComponent(Database database)
        {
            db = database;
        }

        public IViewComponentResult Invoke()
        {
            Database db = new Database();

            return View(db.GetCategories());
        }
    }
}
