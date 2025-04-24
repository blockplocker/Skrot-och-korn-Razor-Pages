using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Skrot_och_korn_Razor_Pages.Pages
{
    public class ProductModel : PageModel
    {
        public int Price { get; set; }
        [BindProperty]
        public bool Vehicle1 { get; set; }
        [BindProperty]
        public bool Vehicle2 { get; set; }
        [BindProperty]
        public bool Vehicle3 { get; set; }
        public void OnGet()
        {
            Price = 0;
        }
        public void OnPost()
        {
            Price = (Vehicle1 ? 200000 : 0) + (Vehicle2 ? 500000 : 0) + (Vehicle3 ? 700000 : 0);
        }
    }
}
