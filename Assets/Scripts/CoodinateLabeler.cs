using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class CoodinateLabeler : MonoBehaviour
{
    private TextMeshPro label;

    private void Awake()
    {
        label = GetComponent<TextMeshPro>();
    }

    private void Update()
    {
        if (Application.isPlaying)
            Destroy(this);

        UpdateCoordinate();
    }

    private void UpdateCoordinate()
    {
        label.text = $"({transform.position.x / UnityEditor.EditorSnapSettings.move.x}, {transform.position.z / UnityEditor.EditorSnapSettings.move.z})";
        transform.parent.name = label.text;
    }
}
