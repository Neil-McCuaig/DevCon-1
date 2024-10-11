using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rivet2Trigger : MonoBehaviour
{
    public Puzzle_Logic_Level2 AxePuzzleLogic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece3")
        {
            AxePuzzleLogic.isRivet2 = true;
        }
    }
}
