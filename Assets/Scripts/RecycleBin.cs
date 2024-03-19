using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RecycleBin : MonoBehaviour
{
    private int _score = 0;
    public List<Bottle> bottles;
    private TextMeshProUGUI _textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        _textMeshPro = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        bottles = new List<Bottle>();    
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore()
    {
        _score = bottles.Count;
        _textMeshPro.text = "Score : " + _score;
    }

    public void AddBottle(Bottle bottle)
    {
        bottles.Add(bottle);
        UpdateScore();
    }

}
