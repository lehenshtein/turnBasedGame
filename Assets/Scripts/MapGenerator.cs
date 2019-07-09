using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public int width, height;
    public GameObject tilePrefab;
    public float tileOffset = 1.1f;

    public List<GameObject> tiles;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GenerateMap();
        }
    }

    void GenerateMap()
    {
        for(int x = 0; x < width; x++)
        { for(int y = 0; y < height; y++)
            {
                Vector2 pos = new Vector2(x * tileOffset, y * tileOffset);
                GameObject currentTile = (GameObject)Instantiate(tilePrefab, pos, Quaternion.identity);
                tiles.Add(currentTile);
            }
        }
        for (int i = 0; i < tiles.Count; i++)
        {
            if (i % 2 == 0)
            {
               tiles[i].GetComponent<SpriteRenderer>().color = new Color32(157, 107, 87, 255);
            }
        }
    }
}
