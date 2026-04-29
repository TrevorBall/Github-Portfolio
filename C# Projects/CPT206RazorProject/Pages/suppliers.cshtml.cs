using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Cpt206SqlServer;

namespace CPT206RazorProject.Pages
{
    public class suppliersModel : PageModel
    {
        private NorthwindContext db;
        public IEnumerable<Supplier> Suppliers { get; set; }
        public suppliersModel(NorthwindContext database)
        {
            db = database;
        }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Suppliers CPT 206";
            Suppliers = db.Suppliers.OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
        }

        [BindProperty]
        public Supplier? Supplier { get; set; }
        public IActionResult OnPost()
        {
            //runs when data, the supplier is submitted on our page
            if ((Supplier != null) && ModelState.IsValid)
            {
                //hot reloads the page with the new supplier in database
                db.Suppliers.Add(Supplier); //database add method
                db.SaveChanges(); //save changed to database
                return RedirectToPage("/suppliers");
            }
            else
            {
                //return to supplier page like it was before
                return Page();
            }


        }
    }
}
