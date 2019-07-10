using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public int width, height, tilePrefabsAmmount;
    public GameObject tilePrefab1;
    public GameObject tilePrefab2;
    public GameObject tilePrefab3;
    public float tileOffset = 1f;

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

                GameObject currentTile;

                int randomTile = Random.Range(0, tilePrefabsAmmount);

                switch (randomTile)
                {
                    case 0:
                        currentTile = (GameObject)Instantiate(tilePrefab1, pos, Quaternion.identity);
                        break;
                    case 1:
                        currentTile = (GameObject)Instantiate(tilePrefab2, pos, Quaternion.identity);
                        break;
                    case 2:
                        currentTile = (GameObject)Instantiate(tilePrefab3, pos, Quaternion.identity);
                        break;
                    default:
                        currentTile = (GameObject)Instantiate(tilePrefab1, pos, Quaternion.identity);
                        break;
                }

                tiles.Add(currentTile);
            }
        }
        for (int i = 0; i < tiles.Count; i++)
        {
            if (i % 2 == 0)
            {
               tiles[i].GetComponent<SpriteRenderer>().color = new Color32(200, 154, 135, 255);
            }
        }
    }
}
