using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct ValueInRange
{
    public Range range;
    float __value;
    public float value
    {
        get => __value;
        set => __value = range.Clamp(value);
    }

    public ValueInRange(float min, float max, float value) => (range, __value) = (new Range(min, max), value);
    public ValueInRange(Range range, float value) => (this.range, __value) = (range, value);

    public float Percent => range.Percent(value);

    public bool IsMin => __value <= range.min;
    public bool IsMax => __value >= range.max;

    public void MoveTowards(float target, float maxDelta)
    {
        value = Mathf.MoveTowards(__value, target, maxDelta);
    }

    public static implicit operator float(ValueInRange a) => a.value;
    // public static implicit operator Range(ValueInRange a) => a.range;

    public override string ToString() => $"Value: {value} in {range}";
}

[System.Serializable]
public struct Range
{
    public float min;
    public float max;


    public Range(float min, float max) => (this.min, this.max) = (min, max);
    public Range(float max) => (this.min, this.max) = (0, max);


    public float Evaluate(float t) => Mathf.Lerp(min, max, t);
    public float Percent(float value) => Mathf.InverseLerp(min, max, value);
    public float Clamp(float value) => Mathf.Clamp(value, min, max);
    public bool IsInRange(float value) => (value >= min && value <= max);
    public bool IsInRange(int value)   => (value >= min && value <= max);


    /// <summary>
    /// Returns random value in range
    /// </summary>
    /// <returns> Random value in range</returns>
    public float Random => Mathf.Lerp(min, max, UnityEngine.Random.value);

    public override string ToString() => $"Range: ({min}, {max})";
}