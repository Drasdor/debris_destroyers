using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updater : MonoBehaviour
{
    public string type;
    public Text label;
    // Start is called before the first frame update
    void Start()
    {
        if (type == "money")
        {
            label.text = $"Money: {globals.money}";
        }
        else if (type == "metal")
        {
            label.text = $"Metal: {globals.metal}";
        }
        else if (type == "rock")
        {
            label.text = $"rock: {globals.rock}";
        }
        else if (type == "electronics")
        {
            label.text = $"Electronics: {globals.electronics}";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (type == "money")
        {
            label.text = $"Money: ${globals.money}";
        }
        else if (type == "metal")
        {
            label.text = $"Metal: {globals.metal}";
        }
        else if (type == "rock")
        {
            label.text = $"rock: {globals.rock}";
        }
        else if (type == "electronics")
        {
            label.text = $"Electronics: {globals.electronics}";
        }
    }
}
