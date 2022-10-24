using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class CoodinateLabeler : MonoBehaviour
{
    private TextMeshPro label;
    private Tile tile;

    private void Awake()
    {
        label = GetComponent<TextMeshPro>();
        tile = GetComponentInParent<Tile>();
        UpdateCoordinate();
    }

    private void Update()
    {
        ColorCoordinate();

        if (Input.GetKeyDown(KeyCode.L))
            ToggleCoordinate();

        if (!Application.isPlaying)
            UpdateCoordinate();
    }

    private void UpdateCoordinate()
    {
        label.text = $"({transform.position.x / UnityEditor.EditorSnapSettings.move.x}, {transform.position.z / UnityEditor.EditorSnapSettings.move.z})";
        transform.parent.name = label.text;
    }

    private void ColorCoordinate()
    {
        if (tile.IsPlaceable)
            label.color = Color.black;
        else
            label.color = Color.grey;
    }

    private void ToggleCoordinate()
    {
        label.enabled ^= true;
    }
}
