using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public List<Bottle> bottles;
    // Start is called before the first frame update
    void Start()
    {
        bottles = new List<Bottle>();
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void AddBottle(Bottle bottle)
    {
        bottles.Add(bottle);
    }
}
