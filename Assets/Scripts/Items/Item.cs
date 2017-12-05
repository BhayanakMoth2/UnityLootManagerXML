using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System;
namespace Database
{
    [XmlRoot("Descriptor")]
    public struct Descriptor
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("ItemHandle")]
        public string itemHandle { get; set; }
        [XmlElement("ItemID")]
        public string itemID { get; set; }
        [XmlElement("Cost")]
        public int cost { get; set; }
        [XmlElement("Weight")]
        public int weight { get; set; }
    }

    public class XML
    {
        public static void Save(string Path, Type t, object o)
        {
            var Serializer = new XmlSerializer(t);
            var stream = new FileStream(Path, FileMode.Create);
            Serializer.Serialize(stream, o);
            stream.Close();

        }
        public static object Load(string path, Type t)
        {
            var Serializer = new XmlSerializer(t);
            var stream = new FileStream(path, FileMode.Open);
            var deserializedContainer = Serializer.Deserialize(stream) as object;
            stream.Close();
            return deserializedContainer;

        }
    }
}