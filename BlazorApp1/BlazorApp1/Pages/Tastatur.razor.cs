using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp1.Pages
{
    public partial class Tastatur
    {
        private string taste = string.Empty;
        private string wert = string.Empty;

        private void VerarbeiteTaste(KeyboardEventArgs e)
        {
            taste = e.Key;
        }
    }
}
