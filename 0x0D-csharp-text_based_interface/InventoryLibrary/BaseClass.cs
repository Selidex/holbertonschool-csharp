using System;

namespace InventoryLibrary
{
    /// BaseClass for inventory objects
    public class BaseClass
    {
        /// The id that identifies the object
        public string id;
        /// time the object was created
        public DateTime date_created;
        /// time the object was last updated at
        public DateTime date_updated;
        /// constructor for base class;
        public BaseClass(string id=null){
            if(id == null)
                this.id = Guid.NewGuid().ToString();
            else
                this.id = id;
            date_created = DateTime.Now;
            date_updated = date_created;
        }
    }
}