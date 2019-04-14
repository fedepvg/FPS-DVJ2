using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    public GameObject[] floorTemplate;
    float templatesSize = 20f;
    public int mapWidth;
    public int mapHeight;
    Vector3[,] floorPos;

    // Start is called before the first frame update
    void Start()
    {
        floorPos = new Vector3[mapWidth, mapHeight];
        for(int i = 0; i < mapHeight; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                floorPos[i, j] = Vector3.zero + new Vector3(templatesSize * i, 0, templatesSize * j);
                Instantiate(floorTemplate[Random.Range(0, floorTemplate.Length)], floorPos[i, j], Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
