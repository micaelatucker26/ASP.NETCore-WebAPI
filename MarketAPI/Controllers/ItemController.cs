using Microsoft.AspNetCore.Mvc;
using MarketAPI.Repository;
using MarketAPI.Models;
using MarketAPI.Classes;

namespace MarketAPI.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;
        public ItemController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: api/items/getall
        [HttpGet]
        public IEnumerable<Item> GetAll()
        {
            IEnumerable<Item> items = new List<Item>();
            items = _unitOfWork.Item.GetAll();
            return items;
        }

        // GET api/items/getitem/{id}
        [HttpGet("{id}")]
        public Item GetItem(int id)
        {
            Item item = new Item();
            item = _unitOfWork.Item.GetByID(id);
            return item;
        }

        // POST api/items/createitem
        [HttpPost]
        public Item CreateItem (Item item)
        {
            Item itemObject = new Item();
            itemObject = _unitOfWork.Item.Add(item);
            return itemObject;
        }

        // PUT api/items/updateitem/{id}
        [HttpPut("{id}")]
        public void UpdateItem(int id)
        {
            _unitOfWork.Item.Update(id);
        }

        // DELETE api/items/deleteitem/{id}
        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
            _unitOfWork.Item.Delete(id);
        }
    }
}
