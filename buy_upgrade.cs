using System.Threading;
using UnityEngine;

public class buy_upgrade : MonoBehaviour
{
    public void upgrader(string name)
    {
        int cost = 0;
        if (name == "net")
        {
            cost = 1000;
        }
        else if (name == "magnet")
        {
            cost = 10000;
        }
        else if (name == "gravity gun")
        {
            cost = 100000;
        }
        if (globals.money >= cost)
        {
            globals.money = globals.money - cost;
            globals.upgrade = name;
        }
    }
}
