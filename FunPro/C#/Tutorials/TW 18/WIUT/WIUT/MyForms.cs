using System.Linq;
using System.Windows.Forms;

namespace WIUT
{
    class MyForms
    {
        public static T GetForm<T>() where T : class, new()
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault() ?? new T();
        }
    }
}
