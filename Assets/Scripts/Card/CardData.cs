using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData : MonoBehaviour
{
    private int cost;
    private string type;
    private string content; // TODO: String?

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SetCost(int now) {
        this.cost = now;
    }

    void SetType(string now) {
        this.type = now;
    }

    void SetContent(string now) {
        this.content = now;
    }
}
