using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Item : MonoBehaviour 
{
    private static string directory = "Assets/Items";
    private static string itemFile = "item.json";
    itemDescriptor item;
	// Use this for initialization
	void Start () {
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);
        if(!File.Exists(directory+"/"+itemFile))
        {
            string json = UnityEngine.JsonUtility.ToJson(item);
            File.WriteAllText(directory + "/" + itemFile, json);
        }
        else
        {
            string json = File.ReadAllText(directory+"/"+itemFile);
            item = JsonUtility.FromJson<itemDescriptor>(json);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private struct itemDescriptor
    {
        public string name;
        public string ID;
        public string param1;
    }
}
