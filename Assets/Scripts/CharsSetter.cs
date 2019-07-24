using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharsSetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.Find("Map_Generator");
        MapGenerator mapGenerator = gameObject.GetComponent<MapGenerator>();
        string testStr = mapGenerator.testString;
        Debug.Log(testStr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
