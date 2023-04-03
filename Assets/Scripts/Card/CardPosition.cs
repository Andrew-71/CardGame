// TODO: Code doesn't compile on Linux! Check how broken it is and fix later!

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritePosition : MonoBehaviour
{
    [SerializeField] public Transform card;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveTO(float x, float y) {
        card.positon = Vec3f(x, y, 0)
    }
}
