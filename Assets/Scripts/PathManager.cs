using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    private static PathManager instance;
    public List<Tile> path;

    public static PathManager Instance { get { return instance; } }

    private void Awake()
    {
        instance = this;
    }
}
