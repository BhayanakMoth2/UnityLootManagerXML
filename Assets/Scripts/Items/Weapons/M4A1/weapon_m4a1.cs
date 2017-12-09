using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Database;
[System.Serializable]
public class M4A1
{
    [XmlElement("Damage")]
    public int damage { get; set; }
    [XmlElement("Descriptor")]
    public Descriptor desc;
}
