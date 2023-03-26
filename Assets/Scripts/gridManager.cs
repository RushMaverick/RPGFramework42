using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridManager : MonoBehaviour
{
    [SerializeField] private int width, height;

    [SerializeField] private tile tile;

    [SerializeField] private Transform camT;

    void Start() {
        camT = GameObject.Find("camera").GetComponent<Transform>();
        generateGrid();
    }
    void generateGrid()
    {
        for (int x = 0; x < width; x++){
            for (int y = 0; y < height; y++){
                var spawnedTile = Instantiate(tile, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isOffset);
            }
        }
        camT.transform.position = new Vector3((float)width / 2 - 0.5f, (float)height / 2 - 0.5f, -10);
    }
}
