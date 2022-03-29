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

        // GET api/items/{item}/subcategorybyitem
        [HttpGet]
        public SubCategory SubCategoryByItem(Item item)
        {
            SubCategory subCategory = new SubCategory();
            int subcategoryID = item.SubCategoryID;

            // call a method from the subcategory controller to get a subcategory by its id
            // and pass in "subcategoryID" to get the specific category you found

            // store that subcategory in "subCategory"

            return subCategory;
        }

        //GET api/items/{item}/categorybyitem
        [HttpGet]
        public Category CategoryByItem(Item item)
        {
            Category category = new Category();
            int subcategoryID = item.SubCategoryID;
            SubCategory subCategory = new SubCategory();

            // from the GetSubcategory method in the SubCategoryController, call this method here
            // and pass in "subcategoryID" to get the specific subcategory you found

            // store that subcategory in "subCategory"

            int categoryID = subCategory.CategoryID;

            // call a method from the category controller to get a category by its id
            // and pass in "categoryID" to get the specific category you found

            // store that category in "category"

            return category;
        }
    }
}
