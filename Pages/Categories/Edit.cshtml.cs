using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AbbyTryout.Data;
using AbbyTryout.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyTryout.Pages.Categories;

[BindProperties]
public class EditModel : PageModel
{
    private readonly ApplicationDbContext _db;

    public AlhasrTabel AlhasrTabel { get; set; }


    public EditModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet(String ID)
    {
        AlhasrTabel = _db.AlhasrTabel.Find(ID);
        //Category = _db.Category.FirstOrDefault(u=>u.Id==id);
        //Category = _db.Category.SingleOrDefault(u=>u.Id==id);
        //Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
    }

    public async Task<IActionResult> OnPost()
    {
        if (AlhasrTabel.Title == AlhasrTabel.location.ToString())
        {
            ModelState.AddModelError("AlhasrTabel.Title", "The DisplayOrder cannot exactly match the Name.");
        }
        if (ModelState.IsValid)
        {
            await _db.AlhasrTabel.AddAsync(AlhasrTabel);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
        return Page();
    }
}