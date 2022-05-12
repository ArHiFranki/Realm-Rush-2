using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    [SerializeField] private Node currentSearchNode;

    private Vector2Int[] directions = { Vector2Int.right, Vector2Int.left, Vector2Int.up, Vector2Int.down };
    private GridManager gridManager;
    private Dictionary<Vector2Int, Node> grid;

    private void Awake()
    {
        gridManager = FindObjectOfType<GridManager>();
        if (gridManager != null)
        {
            grid = gridManager.Grid;
        }
    }

    private void Start()
    {
        ExploreNeighbors();
    }

    private void ExploreNeighbors()
    {
        List<Node> neighbors = new List<Node>();

        foreach (Vector2Int direction in directions)
        {
            Vector2Int neighborsCoordinates = currentSearchNode.coordinates + direction;

            if (grid.ContainsKey(neighborsCoordinates))
            {
                neighbors.Add(grid[neighborsCoordinates]);

                // ToDo: Remove after testing
                grid[neighborsCoordinates].isExplored = true;
                grid[currentSearchNode.coordinates].isPath = true;
            }
        }
    }
}
