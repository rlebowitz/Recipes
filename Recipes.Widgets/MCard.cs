using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Widgets
{
    public partial class MCard
    {
        [Parameter]
        public string Title { get; set; }
    }
}
