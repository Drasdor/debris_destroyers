using UnityEngine;

public class sell_debris : MonoBehaviour
{
    public void sell(int index)
    {
        if (index == 0)
        {
            if (globals.metal >= 2)
            {
                globals.money += 100;
                globals.metal += -2;
            }            
        }
        else if (index == 1)
        {
            if (globals.rock >= 2)
            {
                globals.money += 200;
                globals.rock += -2;
            }
        }
        else if (index == 2)
        {
            if (globals.rock >= 3 && globals.electronics >= 1)
            {
                globals.money += 1000;
                globals.rock += -3;
                globals.electronics += -1;
            }
        }
        else if (index == 3)
        {
            if (globals.metal >= 3 && globals.electronics >= 1)
            {
                globals.money += 1500;
                globals.metal += -3;
                globals.electronics += -1;
            }
        }
    }
}
