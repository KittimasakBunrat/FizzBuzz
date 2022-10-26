using FizzBuzz.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFizzBuzz _fizzBizz; 

        public IndexModel(ILogger<IndexModel> logger, IFizzBuzz fizzBuzz)
        {
            _logger = logger;
            _fizzBizz = fizzBuzz;
        }

        public void OnGet()
        {

        }
    }
}