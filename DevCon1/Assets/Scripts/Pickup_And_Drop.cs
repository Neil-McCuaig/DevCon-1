using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_And_Drop : MonoBehaviour
{
    //Code inspired by https://www.youtube.com/watch?v=8kKLUsn7tcg

    public GameObject BladeOnPlayer;
    public GameObject DiskOnPlayer;

    public Transform handPosition;

    public float pickUpRange;

    public bool equipped;
    public static bool handFull;

    private void Start()
    {
        BladeOnPlayer.SetActive(false);
        DiskOnPlayer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && handFull == false)
        {
            RaycastHit target;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out target, pickUpRange)) 
            {
                Debug.Log("Second layer works");
                if(target.transform.gameObject.tag == "Shuriken Blade")
                {
                    this.gameObject.SetActive(false);
                    BladeOnPlayer.SetActive(true);
                    handFull = true;
                }
            }
        }
    }
}
