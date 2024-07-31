using Microsoft.AspNetCore.Mvc;
using PalindromeFinder.Models;

namespace PalindromeFinder.Controllers
{
    public class PalindromeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FindPalindromes(int number)
        {
            var model = new PalindromeModel
            {
                Number = number,
                Palindromes = GetPalindromes(number)
            };
            return View("Index", model);
        }

        private List<int> GetPalindromes(int number)
        {
            var palindromes = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i.ToString()))
                {
                    palindromes.Add(i);
                }
            }
            return palindromes;
        }

        private bool IsPalindrome(string s)
        {
            var reversed = string.Join("", s.Reverse());
            return s == reversed;
        }
    }
}
