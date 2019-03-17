using Ooui;
using SatisfactoryCalculator.Views;
using Xamarin.Forms;

namespace SatisfactoryCalculator.WebAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.Init();

            UI.Publish("/", new ItemDetailPage().GetOouiElement());
        }
    }
}
