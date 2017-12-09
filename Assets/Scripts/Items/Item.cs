using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System;
namespace Database
{
    //Set of Item Variables that are common.
    [XmlRoot("Descriptor")]
    [System.Serializable]
    public struct Descriptor
    {
        [XmlElement("Name")]
        public string Name;
        [XmlElement("ItemHandle")]
        public string itemHandle;
        [XmlElement("ItemID")]
        public string itemID;
        [XmlElement("Cost")]
        public int cost;
        [XmlElement("Weight")]
        public int weight;
    }

    // Save and Load function.
    public class XML
    {
        public static void Save(string Path, Type t, object o)
        {
            var Serializer = new XmlSerializer(t);
            var encoding = System.Text.Encoding.GetEncoding("UTF-8");
            var stream = new StreamWriter(Path, false, encoding);
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