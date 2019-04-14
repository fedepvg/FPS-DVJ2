using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    public struct LevelBounds
    {
        public float top;
        public float right;
        public float left;
        public float bottom;
    }

    static LevelCreator instance;
    public GameObject[] floorTemplate;
    public float templatesSize = 20f;
    public int mapWidth;
    public int mapHeight;
    Vector3[,] floorPos;
    public GameObject trapPrefab;
    const int maxTraps = 20;
    private List<GameObject> traps;
    public LevelBounds levelBounds;
    float timer;

    private void Awake()
    {
        instance = this;
    }

    private void OnEnable()
    {
        if (traps!=null)
        {
            traps.Clear();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        levelBounds.top = 0f;
        levelBounds.left = 0f;
        levelBounds.right = templatesSize*mapWidth;
        levelBounds.bottom = templatesSize*mapHeight;

        floorPos = new Vector3[mapWidth, mapHeight];
        for(int i = 0; i < mapHeight; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                floorPos[i, j] = Vector3.zero + new Vector3(templatesSize * i+templatesSize/2, 0, templatesSize * j + templatesSize / 2);
                Instantiate(floorTemplate[Random.Range(0, floorTemplate.Length)], floorPos[i, j], Quaternion.identity);
            }
        }

        traps = new List<GameObject>();

        for(int i=0;i<maxTraps;i++)
        {
            GameObject go = Instantiate(trapPrefab);
            go.SetActive(false);
            traps.Add(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(timer==0f||timer>=10f)
        {
            timer = 0f;
            for(int i=0;i<maxTraps;i++)
            {
                if(!traps[i].activeInHierarchy)
                {
                    traps[i].SetActive(true);
                    break;
                }
            }
        }
        timer += Time.deltaTime;
    }

    public static LevelCreator Instance
    {
        get { return instance; }
    }
}
