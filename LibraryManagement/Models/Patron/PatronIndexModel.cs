﻿using System;
using System.Collections.Generic;

namespace LibraryManagement.Models.Patron
{
    public class PatronIndexModel
    {
        public IEnumerable<PatronDetailModel> Patrons { get; set; }
    }
}
