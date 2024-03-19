using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public List<Bottle> bottles;
    public GameObject bottleinhand;
    // Start is called before the first frame update
    void Start()
    {
        bottles = new List<Bottle>();
        bottleinhand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (bottles.Count == 0) 
        {
            bottleinhand.SetActive(false);
        }
        
    }

    public void AddBottle(Bottle bottle)
    {
        bottles.Add(bottle);
        bottleinhand.SetActive(true);
    }
}
