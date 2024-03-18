using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropdownListBinding.Models;

namespace DropdownListBinding.Models.ViewModel
{
    public class ServantsViewModel
    {
        public Servants Servants { get; set; }
        public List<SelectListItem> SkillsList { get; set; }
    }
}
