using System;

namespace InventoryLibrary
{
    /// An inventory, not sure what the exact purpose is here (project tells me to make it so i make it)
    public class Inventory : BaseClass{
        /// The id of the user attached to this inventory
        public int user_id;
        /// the id of the item attached to this inventory. why this isn't a list confuses me, project requirement
        public int item_id;
        /// the amount of the item in the inventory. seriously an entire class for one pairing seems wrong.
        public int quantity;
    }
}
