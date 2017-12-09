using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Database;
[System.Serializable]
public class Ak47 
{
    [XmlElement("Damage")]
    public int damage;
    [XmlElement("Descriptor")]
    public Descriptor desc;
}
