using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Web.Pages
{
    public partial class Treats
    {

        [Inject]
        protected IMatToaster Toaster { get; set; }

        public void OnPeopleClick()
        {
            Toaster.Add("Toast body text", MatToastType.Success, "Toast title");
        }

        public void OnDifficultyClick()
        {

        }

        public void OnTypeClick()
        {

        }

        public void OnTimeClick()
        {

        }
    }
}
