using Microsoft.AspNetCore.Mvc;
using SessionLogin.Library.Filters;
using SessionLogin.Models;
using System.Collections.Generic;
using System.Linq;

namespace SessionLogin.Controllers
{
    [Login]
    public class WordsController : Controller
    {
        private static List<Word> lstWord = new List<Word>();

        public IActionResult Index()
        {

            return View(lstWord);

        }

        [HttpGet]
        public IActionResult AddWord()
        {


            return View();
        }

        [HttpPost]
        public IActionResult AddWord([FromForm] Word word)
        {
            int id = 1;
            if (lstWord.Count() > 0)
            {
                id = lstWord.Max(x => x.Id) + 1;
            }

            lstWord.Add(new Word
            {
                Id = id,
                WordName = word.WordName,
                Difficult = word.Difficult
            });


            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult DelWord(int id)
        {

            lstWord.Remove(lstWord.FirstOrDefault(x => x.Id == id));

            return RedirectToAction("Index");
        }
    }
}
