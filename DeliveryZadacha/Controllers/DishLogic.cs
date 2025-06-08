using DeliveryZadacha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryZadacha.Controllers
{
    public class DishLogic
    {
        private DeliveryContext _deliveryContext = new DeliveryContext();
        public Dish Get(int id)
        {
            Dish foundDish = _deliveryContext.Dishes.Find(id);
            if (foundDish != null)
            {
                _deliveryContext.Entry(foundDish).Reference(d => d.DishType).Load();
            }
            return foundDish;
        }

        public List<Dish> GetAll()
        {
            return _deliveryContext.Dishes.Include("DishType").ToList();
        }

        public void Create(Dish dish)
        {
            _deliveryContext.Dishes.Add(dish);
            _deliveryContext.SaveChanges();
        }

        public void Update(int id, Dish dish)
        {
            Dish foundDish = _deliveryContext.Dishes.Find(id);
            if (foundDish == null)
            {
                return;
            }
            foundDish.Name = dish.Name;
            foundDish.Description = dish.Description;
            foundDish.Price = dish.Price;
            foundDish.Weight = dish.Weight;
            foundDish.DishTypeId = dish.DishTypeId;

            _deliveryContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Dish foundDish = _deliveryContext.Dishes.Find(id);
            if (foundDish == null)
            {
                return;
            }
            _deliveryContext.Dishes.Remove(foundDish);
            _deliveryContext.SaveChanges();
        }

        public List<DishType> GetAllDishTypes()
        {
            return _deliveryContext.DishTypes.ToList();
        }
    }
}
