using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.ASPdotnetFrontEndJsonfilecosumption.Models;
using ASPdotnetFrontEndJsonfilecosumption.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASPdotnetFrontEndJsonfilecosumption.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileBookService BookService;
        public IEnumerable<BookObj> Books { get;  private set; }


        public IndexModel(ILogger<IndexModel> logger,
            JsonFileBookService bookService
            )
        {
            _logger = logger;
            BookService = bookService;
        }

        public void OnGet()
        {
            Books = BookService.GetBooks();
        }
    }
}
