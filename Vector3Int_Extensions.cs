using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector3Int_Extensions
{
    public static bool IsInBounds(this Vector3Int position, RangeInt cubicBounds)
    {
        return cubicBounds.IsInRange(position.x) && cubicBounds.IsInRange(position.y) && cubicBounds.IsInRange(position.z);
    }
}
