using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Logic_Level2 : MonoBehaviour
{
    //logic for the battleaxe puzzle
    //Declarations
    //Pieces
    public GameObject axeHead;
    public GameObject rivet1;
    public GameObject rivet2;
    
    //Static Pieces
    public GameObject staticAxeHead;
    public GameObject staticRivet1;
    public GameObject staticRivet2;

    //Bools for checking pieces
    public bool isAxeHead;
    public bool isRivet1;
    public bool isRivet2;
    void Start()
    {
        staticAxeHead.gameObject.SetActive(false);
        staticRivet1.gameObject.SetActive(false);
        staticRivet2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isAxeHead) { axeHead.gameObject.SetActive(false); staticAxeHead.gameObject.SetActive(true); }
        if (isRivet1) { rivet1.gameObject.SetActive(false); staticRivet1 .gameObject.SetActive(true); }
        if (isRivet2) { rivet2.gameObject.SetActive(false); staticRivet2.gameObject.SetActive(true); }
    }
}
