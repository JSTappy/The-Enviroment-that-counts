using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private Bag bag;
    private RecycleBin recycleBin;
    // Start is called before the first frame update
    void Start()
    {
        bag = GameObject.Find("Bag").GetComponent<Bag>();
        recycleBin = GameObject.Find("RecycleBin").GetComponent<RecycleBin>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key was pressed");
            //send a raycast from the main cameras position from the middle
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10))
            {
                //if the raycast hits a bottle, destroy it
                if (hit.collider.gameObject.tag == "Bottle")
                {
                    bag.AddBottle(hit.collider.gameObject.GetComponent<Bottle>());
                    hit.collider.gameObject.SetActive(false);
                }
                if (hit.collider.gameObject.tag == "RecycleBin")
                {
                    if (bag.bottles.Count >= 1)
                    {
                        recycleBin.AddBottle(bag.bottles[0]);
                        bag.bottles.RemoveAt(0);
                      
                    }
                }
            }
        }
        
    }
}
