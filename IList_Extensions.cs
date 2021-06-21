using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Extend this list of extension methods if needed.
/// <summary>
/// Extension methods helping in handling small sized ILists.<br />
/// Does not implement exception handling.
/// </summary>
public static class IList_Extensions
{
    #region Explicit deconstructing
    // public static T Decompose1<T>(this IList<T> list) => list[0];
    public static (T, T) Decompose2<T>(this IList<T> list) => (list[0], list[1]);
    public static (T, T, T) Decompose3<T>(this IList<T> list) => (list[0], list[1], list[2]);
    public static (T, T, T, T) Decompose4<T>(this IList<T> list) => (list[0], list[1], list[2], list[3]);
    public static (T, T, T, T, T) Decompose5<T>(this IList<T> list) => (list[0], list[1], list[2], list[3], list[4]);
    #endregion

    #region Implicit deconstructing
    // public static void Deconstruct<T>(this IList<T> container, out T item0)
    //     => (item0) = (container[0]);
    public static void Deconstruct<T>(this IList<T> container, out T item0, out T item1)
        => (item0, item1) = (container[0], container[1]);
    public static void Deconstruct<T>(this IList<T> container, out T item0, out T item1, out T item2)
        => (item0, item1, item2) = (container[0], container[1], container[2]);
    public static void Deconstruct<T>(this IList<T> container, out T item0, out T item1, out T item2, out T item3)
        => (item0, item1, item2, item3) = (container[0], container[1], container[2], container[3]);
    #endregion
}