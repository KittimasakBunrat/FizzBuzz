using FizzBuzz.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFizzBuzz _fizzBizz;
        public List<string> FizzBuzzList { get; set; }
        [BindProperty]
        public bool IsDivisibleByFour { get; set; }
        [BindProperty]
        public bool IsDivisibleByNine { get; set; }
        [BindProperty]
        public bool ReverseOrder { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IFizzBuzz fizzBuzz)
        {
            _logger = logger;
            _fizzBizz = fizzBuzz;
            FizzBuzzList = new List<string>();
        }

        public void OnPostGenerateFizzBuzz()
        {
            FizzBuzzList = new List<string>();
            FizzBuzzList = _fizzBizz.GenerateFizzBuzz(IsDivisibleByFour, IsDivisibleByNine, ReverseOrder);
        }

    }
}