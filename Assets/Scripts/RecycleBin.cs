using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleBin : MonoBehaviour
{
    private int _score = 0;
    public List<Bottle> bottles;
    // Start is called before the first frame update
    void Start()
    {
        bottles = new List<Bottle>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //make a new bottle and add it to the list
            Bottle newBottle = new Bottle();
            bottles.Add(newBottle);
            UpdateScore();
        }
        
    }

    public void UpdateScore()
    {
        _score = bottles.Count;
        Debug.Log("Score: " + _score);
    }

    public void AddBottle(Bottle bottle)
    {
        bottles.Add(bottle);
    }

}
