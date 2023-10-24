using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class utils : MonoBehaviour
{
    public static TextMesh CreateWorldText(
        string text,
        Transform parent,
        Vector3 localPosition,
        int fontSize,
        Color color,
        TextAnchor textAnchor
    )
    {
        GameObject go = new GameObject("world_text", typeof(TextMesh));
        Transform transform = go.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPosition;
        TextMesh textMesh = go.GetComponent<TextMesh>();
        textMesh.anchor = textAnchor;
        // textMesh.alignment = textAlignment;
        textMesh.text = text;
        textMesh.fontSize = fontSize;
        textMesh.color = color;
        return textMesh;
    }

    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }

    public static Vector3 GetMouseWorldPositionWithZ(Camera worldCamera)
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, worldCamera);
    }

    public static Vector3 GetMouseWorldPositionWithZ()
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
    }

    public static Vector3 GetMouseWorldPosition(float z = 0f)
    {
        Debug.Log(Input.mousePosition);
        Vector3 vec = GetMouseWorldPositionWithZ(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, z),
            Camera.main
        );
        vec.z = 0f;
        Debug.Log(vec);
        return vec;
    }
}
