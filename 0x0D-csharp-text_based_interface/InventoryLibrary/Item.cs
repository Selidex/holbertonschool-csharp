using System;
using System.Collections.Generic;
using System.Collections;

namespace InventoryLibrary
{
    /// Class defining the Item object for our inventory
    public class Item : BaseClass{
        /// Item's name; required
        public string name;
        /// description of the item; optional
        public string description;
        /// price of the item; optional
        public float price;
        /// tags attached to the item; optional
        public List<string> tags;
        /// constructor for item
        public Item(string name, string id=null, string description=null, float price=0f, List<string> tags=null){
            if(id == null)
                this.id = Guid.NewGuid().ToString();
            else
                this.id = id;
            this.date_updated = DateTime.Now;
            this.date_created = this.date_updated;
            this.name = name;
            this.description = description;
            this.price = price;
            this.tags = tags;

        }
    }
}
