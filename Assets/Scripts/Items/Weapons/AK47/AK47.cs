using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Database;
public class Ak47 
{
    [XmlElement("Damage")]
    public int damage { get; set; }
    [XmlElement("Descriptor")]
    public Descriptor desc;
    public static Ak47 ak;

    public const string directory = "Assets";
    public const string file = "ak47.xml";

    public Ak47()
    {
        if (!File.Exists(directory + "/" + file))
        {
            desc.Name = "m4";
            desc.cost = 12000;
            desc.itemID = "RandomlyGeneratedID";
            desc.itemHandle = "PredefinedID";
            desc.weight = 5;
            damage = 90;
            XML.Save(directory + "/" + file, typeof(Ak47), this);
        }
        
    }
    public void loadAk()
    {
        ak = XML.Load(directory + "/" + file, typeof(Ak47)) as Ak47;
    }
   public void getName()
    {
        string name = ak.desc.Name;
        int cost = ak.desc.cost;
        Debug.Log(name);
        Debug.Log(cost);
        Debug.Log(ak.desc.itemID);
        Debug.Log(ak.desc.weight);
        Debug.Log(ak.desc.itemHandle);

    }
}
