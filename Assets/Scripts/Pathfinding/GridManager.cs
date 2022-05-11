using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private Node node;

    private void Start()
    {
        Debug.Log(node.coordinates);
        Debug.Log(node.isWalkable);
    }
}
