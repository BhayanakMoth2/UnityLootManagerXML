using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Database;
public class weapon_m4a1 
{
    [XmlElement("Damage")]
    public int damage { get; set; }
    [XmlElement("Descriptor")]
    public Descriptor desc;

    private static string directory = "Assets/Scripts/Items/Weapons/M4A1";
    private static string itemFile = "m4a1.xml";
    
    public weapon_m4a1()
    {
        desc.Name = "m4";
        desc.cost = 12000;
        desc.itemID = "RandomlyGeneratedID";
        desc.itemHandle = "PredefinedID";
        desc.weight = 5;
        damage = 90;
        XML.Save(directory + "/" + itemFile, typeof(weapon_m4a1),this);
    }
}
