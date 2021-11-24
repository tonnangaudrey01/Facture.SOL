using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Factures.DAL
{
    /// <summary>
    /// permet de preciser un mode de serialisation
    /// </summary>
    public enum Mode
    {
        /// <summary>
        /// mode de serialisation binaire
        /// </summary>
        Binary,
        /// <summary>
        /// mode de serialisation xml
        /// </summary>
        Xml,
        /// <summary>
        /// mode de serialisation json
        /// </summary>
        Json
    }
    /// <summary>
    /// permet de serialiser et deserialiser les donnees d'un objet selon un format(binaire, xml, json) dans un fichier
    /// </summary>
    /// <typeparam name="T">correspond au type d'objet qui sera serialise</typeparam>
    public class Serializer<T>
    {
        private string Path { get; set; }
        private Mode mode { get; set; }
        private Dictionary<Mode, Action<object>> Serializers { get; set; }
        private Dictionary<Mode, Func<T>> Deserializers { get; set; }
        /// <summary>
        /// instancie un objet de type Serializer
        /// </summary>
        /// <param name="path">correspond au chemin du fichier de serialisation ou de deserialisation</param>
        /// <param name="mode">correspond au mode de serialisation</param>
        public Serializer(string path, Mode mode)
        {
            this.Path = path;
            this.mode = mode;
            Serializers = new Dictionary<Mode, Action<object>>();
            Serializers.Add(Mode.Binary, SerialiseBinary);
            Serializers.Add(Mode.Xml, SerialiseXml);
            Serializers.Add(Mode.Json, SerialiseJson);
            Deserializers = new Dictionary<Mode, Func<T>>();
            Deserializers.Add(Mode.Binary, DeserialiseBinary);
            Deserializers.Add(Mode.Xml, DeserialiseXml);
            Deserializers.Add(Mode.Json, DeserialiseJson);
        }


        #region Serialise
        /// <summary>
        /// permet de serialiser les donnees d'un objet
        /// </summary>
        /// <param name="Obj">correspond a l'objet a serialiser</param>
        public void Serialize(object Obj)
        {
            Serializers[this.mode](Obj);
        }

        private void SerialiseJson(object Obj)
        {
            using (Stream file = File.OpenWrite(this.Path))
            {
                Utf8JsonWriter utf = new Utf8JsonWriter(file);
                JsonSerializer.Serialize(utf, Obj, typeof(T));
            }
        }

        private void SerialiseXml(object Obj)
        {
            using (Stream file = File.OpenWrite(this.Path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(file, Obj);
            }
        }

        private void SerialiseBinary(object Obj)
        {
            using (Stream file = File.OpenWrite(this.Path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Obj);
            }
        }

        #endregion

        #region Deserialise
        /// <summary>
        /// permet de deserialiser les donnees d'un objet
        /// </summary>
        /// <returns>un objet de type T avec des donnees deserialise</returns>
        public T Deserialise()
        {
            return Deserializers[this.mode]();
        }

        private T DeserialiseJson()
        {
            using (StreamReader sr = new StreamReader(this.Path))
            {
                string json = "";
                while (!sr.EndOfStream)
                {
                    json += sr.ReadLine();
                }
                return (T)JsonSerializer.Deserialize(json, typeof(T));
            }
        }

        private T DeserialiseXml()
        {
            using (Stream file = File.Open(this.Path, FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                return (T)xs.Deserialize(file);
            }
        }

        private T DeserialiseBinary()
        {
            using (Stream file = File.Open(this.Path, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (T)bf.Deserialize(file);
            }
        }
        #endregion
    }
}
