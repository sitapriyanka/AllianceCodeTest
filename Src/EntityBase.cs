using System;
using System.IO;
namespace Tests
{
    /// <summary>
    /// Functions for performing Save, Find and Delete operations on entity.
    /// </summary>
    public class EntityBase<T> where T : new()
    {
        public string Id { get; set; }

        /// <summary>
        /// This funciton creats unique id for each entity and saves it to a file.
        ///Steps include 1.
        ///1.Create new Id to the entity
        ///2.Construct File Name
        ///3.Create directory to store file if not exists
        ///4.Serialize Object to json and write to file.
        /// </summary>
        public void Save()
        {
            this.Id = Helper.GetNewId();
            string filePath = Helper.ConstructFilePath(this.Id, this.GetType().Name);
            Helper.CreateDirectoryIfNotExists(this.GetType().Name);
            JsonSerialization.WriteToJsonFile<EntityBase<T>>(filePath, this);
        }


        /// <summary>
        /// This funciton delets the entity by deleting its file.
        /// </summary>
        public void Delete()
        {
            string filePath = Helper.ConstructFilePath(this.Id, this.GetType().Name);
            File.Delete(filePath);
            this.Id = null;
        }

        /// <summary>
        /// This funciton searches the entity by id and returns the entity.
        /// </summary>
        public static T Find(string id)
        {
            if(id==null) return default(T);
            string filePath = Helper.ConstructFilePath(id, typeof(T).Name);
            if (File.Exists(filePath))
            {
                return JsonSerialization.ReadFromJsonFile<T>(filePath);
            }
            else return default(T);
        }
    }
}

