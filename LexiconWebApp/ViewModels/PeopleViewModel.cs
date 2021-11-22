using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconWebApp.Models
{
    public class PeopleViewModel : CreatePersonViewModel
    {
        public List<Person> PeopleListViewModel { get; set; }
        public string Filter { get; set; }
        public PeopleViewModel()
        {
            PeopleListViewModel = new List<Person>();
        }
    }
}
