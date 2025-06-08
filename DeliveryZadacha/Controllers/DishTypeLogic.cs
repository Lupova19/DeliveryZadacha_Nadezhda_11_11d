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
        private DeliveryContext _deliveryContext = new DeliveryContext();

        public List<DishType> GetAllDishTypes()
        {
            return _deliveryContext.DishTypes.ToList();
        }

        public string GetDishTypeNameById(int id)
        {
            var dishType = _deliveryContext.DishTypes
                                 .Where(dt => dt.Id == id)
                                 .Select(dt => dt.TypeName)
                                 .FirstOrDefault();
            return dishType; 
        }

        public void Create(DishType dishType)
        {
            _deliveryContext.DishTypes.Add(dishType);
            _deliveryContext.SaveChanges();
        }

        public void Update(int id, DishType dishType)
        {
            var foundDishType = _deliveryContext.DishTypes.Find(id);
            if (foundDishType == null)
                return;

            foundDishType.TypeName = dishType.TypeName;
            _deliveryContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var foundDishType = _deliveryContext.DishTypes.Find(id);
            if (foundDishType != null)
            {
                _deliveryContext.DishTypes.Remove(foundDishType);
                _deliveryContext.SaveChanges();
            }
        }
    }
}
