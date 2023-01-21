using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OpenClosePrinsiple_OCP.After
{
    public abstract class Question
    {
        public string Title { get; set; }
        public int Mark { get; set; }

        public abstract void Print();
    }
}
