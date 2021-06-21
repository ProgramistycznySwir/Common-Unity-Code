using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector3_Extensions
{
    public static Vector3Int ToInt(this Vector3 vector3)
        => new Vector3Int((int)vector3.x, (int)vector3.y, (int)vector3.z);
    public static Vector3Int RoundToInt(this Vector3 vector3)
        => new Vector3Int(Mathf.RoundToInt(vector3.x), Mathf.RoundToInt(vector3.y), Mathf.RoundToInt(vector3.z));
    public static Vector3 ClampAxes(this Vector3 vector3, Range axisRange)
        => new Vector3(axisRange.Clamp(vector3.x), axisRange.Clamp(vector3.y), axisRange.Clamp(vector3.z));
}