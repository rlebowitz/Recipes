namespace Recipes.Web.Pages
{
    /// <summary>
    /// Defines the <see cref="Index" />.
    /// </summary>
    public partial class Index
    {
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
