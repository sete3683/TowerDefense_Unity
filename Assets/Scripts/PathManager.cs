using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public static PathManager instance;
    public List<Tile> path;

    private void Awake()
    {
        instance = this;
    }
}
