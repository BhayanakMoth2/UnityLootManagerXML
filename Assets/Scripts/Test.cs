using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Database;
using System.Xml;
using System.Xml.Serialization;
public class Test : MonoBehaviour {

    public static Test ins;
    Ak47 ak;
    void Start () {
        ins = this;
        ak = new Ak47();
        XML.Save("Assets/Scripts/Items/Weapons/AK47/ak47.xml", typeof(Ak47), ak);
    }
    public WeaponList list;
    //This function will be triggered by the Save button.
    public void SaveList()
    {
       list = XML.Load("Assets/Scripts/Items/Weapons/AK47/ak47List.xml", typeof(WeaponList)) as WeaponList;
    }
    

}
[System.Serializable]
public class WeaponList
{
    //Just for testing, stores variation of weapons like Military Grade AK-47 or Rusted AK-47.
    [XmlArray("Weapon_Ak47")] 
    public List<Ak47> list = new List<Ak47>();

}
