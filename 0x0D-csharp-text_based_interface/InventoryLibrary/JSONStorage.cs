using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace InventoryLibrary{
    /// Stores all of our objects in a json file, and reloads them
    public class JSONStorage{
        /// Dictionary containing all objects being stored
        public Dictionary<string, Object> objects;
        /// Constructor for storage
        public JSONStorage(){
            objects = new Dictionary<string, Object>();
        }

        /// Returns the dictionary of objects
        public Dictionary<string, Object> All(){
            return objects;
        }
        /// Adds a new object to our dictionary
        public void New(BaseClass obj){
            string key = obj.GetType().Name + "." + obj.id;
            objects.Add(key, obj);
            this.Save();
        }
        /// saves the storage to json file
        public void Save(){
            string jsonString = JsonSerializer.Serialize(objects);
        }
    }
}   
