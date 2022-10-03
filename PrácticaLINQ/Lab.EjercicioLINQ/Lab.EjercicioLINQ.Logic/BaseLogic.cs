using Lab.EjercicioLINQ.Data;

namespace Lab.EjercicioLINQ.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext _context;

        public BaseLogic()
        {
            _context = new NorthwindContext();
        }
    }
}
