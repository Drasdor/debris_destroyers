using UnityEngine;
using System.Collections.Generic;

public class globals : MonoBehaviour
{
    public static int money = 1000;
    public static int[] debris = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public static string upgrade = "";
    public static int metal = 0;
    public static int rock = 0;
    public static int electronics = 0;
    public static int counter = 0;
    public static List<string> hits = new List<string>();
}