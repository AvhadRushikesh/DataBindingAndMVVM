﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingPractice.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public List<string> People { get; set; }

        public PeopleViewModel()
        {
            People = new List<string>
            {
                "Tony",
                "Steve",
                "Thor",
                "Natasha",
                "Clint",
                "Bruce"
            };
        }
    }
}