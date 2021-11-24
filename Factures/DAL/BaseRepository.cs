using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factures.BO;

namespace Factures.DAL
{
    /// <summary>
    /// cette classe contient quelques methodes necessaires pour les classes de type User, Product...
    /// </summary>
    /// <typeparam name="T">T est une classe de type User ou autre ayant herite de la classe BaseModel </typeparam>
    public class BaseRepository<T> where T : BaseModel
    {
        /// <summary>
        /// liste qui va contenir les objets de type T
        /// </summary>
        protected List<T> datas;
        private string PATH { get; set; }
        private Serializer<List<T>> serializer;
        /// <summary>
        /// creer un objet de type BaseRepository
        /// </summary>
        /// <param name="mode">le type enum Mode permet de specifier le type de serialisation attendu</param>
        /// <param name="path">correspond au chemin du fichier ou seront stockees les donnees d'operations (serialisation/deserialisation)</param>
        /// <example>exemple :
        /// BaseRepository(Binary)
        /// </example>
        public BaseRepository(string path, Mode mode)
        {
            this.PATH = path;
            this.serializer = new Serializer<List<T>>(PATH, mode);
            if (File.Exists(this.PATH))
                this.datas = serializer.Deserialise();
            else
                this.datas = new List<T>();
        }
        /// <summary>
        /// permet d'ajouter un nouvel objet
        /// </summary>
        /// <param name="Obj">parametre qui correspond a l'objet qui sera ajoute</param>
        public void Add(T Obj)
        {
            foreach (var data in datas)
            {
                if (data.Equals(Obj))
                {
                    throw new DuplicateWaitObjectException($"{nameof(T)} already exists");
                }
            }
            datas.Add(Obj);
            this.serializer.Serialize(datas);
        }
        /// <summary>
        /// permet de sauvegarder dans un fichier un objet
        /// </summary>
        public void Save()
        {
            this.serializer.Serialize(datas);
        }
        /// <summary>
        /// permet  de recuperer dans tous les objets deja stockes dans une liste
        /// </summary>
        /// <returns>une liste de type T</returns>
        public List<T> GetAll()
        {
            List<T> list = this.serializer.Deserialise();
            return list;
        }
        /// <summary>
        /// permet de modifier un objet deja enregistre
        /// </summary>
        /// <param name="oldObj">parametre qui correspond a l'objet a modifier</param>
        /// <param name="newObj">parametre qui correspond a l'objet deja modifie</param>
        public void Set(T oldObj, T newObj)
        {
            var oldIndex = -1;
            for (int i = 0; i < datas.Count; i++)
            {
                if (datas[i].Equals(oldObj))
                {
                    oldIndex = i;
                }
            }
            if (oldIndex < 0)
            {
                throw new KeyNotFoundException($"{nameof(T)} not found");
            }
            var newIndex = -1;
            for (int i = 0; i < datas.Count; i++)
            {
                if (datas[i].Equals(newObj))
                {
                    newIndex = i;
                }
            }
            if (newIndex >= 0 && newIndex != oldIndex)
            {
                throw new KeyNotFoundException($"{nameof(T)} already exists");
            }
            datas[oldIndex] = newObj;
            this.serializer.Serialize(datas);
        }
        /// <summary>
        /// permet de supprimer un objet
        /// </summary>
        /// <param name="obj">parametre qui correspond a l'objet a supprimer</param>
        public void Delete(T obj)
        {
            var index = -1;
            for (int i = 0; i < datas.Count; i++)
            {
                if (datas[i].Equals(obj))
                {
                    index = i;
                }
            }
            if (index >= 0)
            {
                datas.RemoveAt(index);
                this.serializer.Serialize(datas);
            }
            else
                throw new KeyNotFoundException("item not found");
        }
        /// <summary>
        /// permet de recuperer des elements a partir de leur nom
        /// </summary>
        /// <param name="value">parametre qui correspond au nom recherche</param>
        /// <returns>une liste de type T</returns>
        public List<T> FindByname(string value)
        {
            List<T> list = new List<T>();
            foreach (var data in datas)
            {
                if (data.Name.ToLower().Contains(value.ToLower()))
                {
                    list.Add(data);
                }
            }
            return list;
        }
        /// <summary>
        /// permet de savoir si un objet existe deja
        /// </summary>
        /// <param name="obj">parametre qui correspond a l'objet</param>
        /// <returns>true si l'objet existe et false sinon</returns>
        public bool IsExists(T obj)
        {
            foreach (var item in datas)
            {
                if (item.Equals(obj))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// permet de recuperer un element a partir de son id
        /// </summary>
        /// <param name="id">parametre qui correspond a l'id a rechercher</param>
        /// <returns>un objet de type T</returns>
        public T FindById(string id)
        {
            foreach (var data in datas)
            {
                if (data.Id.Equals(id))
                {
                    return data;
                }
            }
            return default;
        }
        /// <summary>
        /// permet de recuperer un ensemble d'elements de type T qui contiennent une valeur donnee en ignorant la casse
        /// </summary>
        /// <param name="value">correspond a la valeur qui sera contenu dans les elements recherches</param>
        /// <returns>une liste de type T</returns>
        public virtual List<T> GetContains(string value)
        {
            List<T> items = new List<T>();
            foreach (var item in datas)
            {
                if (item.Name.ToLower().Contains(value.ToLower()))
                    items.Add(item);
            }
            return items;
        }
        /// <summary>
        /// supprime tous les objets deja crees
        /// </summary>
        public void DeleteAll()
        {
            if (File.Exists(this.PATH))
                File.Delete(this.PATH);
        }
    }
}
