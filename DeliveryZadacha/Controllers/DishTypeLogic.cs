using DeliveryZadacha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryZadacha.Controllers
{
    public class DishTypeLogic
    {
        private DeliveryContext _context = new DeliveryContext();
        public List<DishType> GetAllDishTypes()
        {
            return _context.DishTypes.ToList();
        }

        public DishType GetDishTypeById(int id)
        {
            return _context.DishTypes.Find(id);
        }
        public string GetDishTypeNameById(int id)
        {
            return _context.DishTypes
                           .Where(dt => dt.Id == id)
                           .Select(dt => dt.TypeName)
                           .FirstOrDefault();
        }
        public void Create(DishType dishType)
        {
            _context.DishTypes.Add(dishType);
            _context.SaveChanges();
        }

        public void Update(int id, DishType dishType)
        {
            var found = _context.DishTypes.Find(id);
            if (found == null) return;

            found.TypeName = dishType.TypeName;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var found = _context.DishTypes.Find(id);
            if (found == null) return;

            _context.DishTypes.Remove(found);
            _context.SaveChanges();
        }
    }
}

