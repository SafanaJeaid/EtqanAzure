using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbbyTryout.Data;
using AbbyTryout.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AbbyTryout.Pages.Categories;


public class IndexModel : PageModel
{
    //class to connect to the databse
    private readonly ApplicationDbContext _db;

    // this is what has all the items in the database
    // IEnumerable is a collection or an array. something u can loop over.
    public IEnumerable<AlhasrTabel> AlhasrTabel { get; set; }

    // constructor to say we want the implementation of the private class
    public IndexModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet()
    {
        // this is what retrieves all the items. instead of query.
        AlhasrTabel = _db.AlhasrTabel.FromSqlRaw("SELECT TOP (10) * FROM [dbo].[AlhasrTabel]");
    }

    /*    public async Task OnGetAsync()
        {
            // using System;

            IQueryable<AlhasrTabel> studentsIQ = from _db.AlhasrTabel
                                             select ;

            switch (sortOrder)
            {
                case "name_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    studentsIQ = studentsIQ.OrderBy(s => s.EnrollmentDate);
                    break;
                case "date_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    studentsIQ = studentsIQ.OrderBy(s => s.LastName);
                    break;
            }

            Students = await studentsIQ.AsNoTracking().ToListAsync();
        }*/
}