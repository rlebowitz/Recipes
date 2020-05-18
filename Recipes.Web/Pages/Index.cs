
using Microsoft.AspNetCore.Components;

namespace Recipes.Web.Pages
{
    /// <summary>
    /// Defines the <see cref="Index" />.
    /// </summary>
    public partial class Index
    {
        [CascadingParameter]
        public string Title { get; set;}
        /// <summary>
        /// Gets or sets the Sum.
        /// </summary>
        private int Sum { get; set; }

        /// <summary>
        /// Method used to handle button clicks to add 2 to the Sum.
        /// </summary>
        private void OnClick()
        {
            Sum++;
            Sum++;
        }
    }
}
