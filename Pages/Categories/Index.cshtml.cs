using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AbbyTryout.Data;
using AbbyTryout.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using ClosedXML.Excel;

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

    /*    public async Task<IActionResult> OnPostExportExcelAsync()
        {

            var AlhasrTabelvar = _db.AlhasrTabel.FromSqlRaw("SELECT TOP (10) * FROM [dbo].[AlhasrTabel]");
            // above code loads the data using LINQ with EF (query of table), you can substitute this with any data source.
            var stream = new MemoryStream();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                workSheet.Cells.LoadFromCollection(AlhasrTabelvar, true);
                package.Save();
            }
            stream.Position = 0;

            string excelName = $"data-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            // above I define the name of the file using the current datetime.

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName); // this will be the actual export.
        }*/

    public FileResult OnPostExport()
    {
        DataTable dt = new DataTable("Grid");
        dt.Columns.AddRange(new DataColumn[2] { new DataColumn("location"),
                                        new DataColumn("Title")});

        var AlhasrTabelVar = from AlhasrTabel in this._db.AlhasrTabel.Take(10)
                        select AlhasrTabel;

        foreach (var customer in AlhasrTabelVar)
        {
            dt.Rows.Add(customer.location, customer.Title);
        }

        using (XLWorkbook wb = new XLWorkbook())
        {
            wb.Worksheets.Add(dt);
            using (MemoryStream stream = new MemoryStream())
            {
                wb.SaveAs(stream);
                return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Grid.xlsx");
            }
        }
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