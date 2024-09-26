using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Pickup_And_Drop : MonoBehaviour
{
    //These reference which item the player has in their hand
    public GameObject BladeOnPlayer;
    public GameObject DiskOnPlayer;

    //This tells the game where the held items should appear.
    public Transform handPosition;

    //This is how far away items can be picked up. Mostly just a formality to get code to work. Could probably be removed?
    public float pickUpRange;

    //Says what item type is in the player's hand. Meant to prevent the player from picking up a blade and putting down a core.
    public bool equippedShuriken;
    public bool equippedCentre;

    //Tells the player if they have an item in their hand already. Prevents the grabbing of multiple items.
    public static bool handFull;

    //References where the camera is so the raycast has an origin.
    public Camera camera;

    private void Start()
    {
        BladeOnPlayer.SetActive(false);
        DiskOnPlayer.SetActive(false);

        equippedShuriken = false;
        equippedCentre = false;
    }

    private float q = 0.0f;

    // Update is called once per frames
    void Update()
    {
        //Picks up the targeted object when you press E while the mouse is aimed at it if the hand is empty
        if (Input.GetKeyDown(KeyCode.E) && handFull == false)
        {
            //This primes the actual raycast
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            //If it's a shuriken, turn off the targeted shuriken blade, make one appear in the hand, and tell the backend code you have a blade in your hands
            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Shuriken Blade")
            {
                //This is for debug purposes and is to be removed for the final product
                //Debug.Log("Second layer works");
                UnityEngine.Color color = new UnityEngine.Color(q, q, 1.0f);
                Debug.DrawLine(Vector3.zero, new Vector3(0, 5, 0), color);

                hit.transform.gameObject.SetActive(false);

                BladeOnPlayer.SetActive(true);
                handFull = true;
                equippedShuriken = true;

            }

            //Like the above, but for the Shuriken's core rather then the blades
            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Shuriken Center")
            {
                hit.transform.gameObject.SetActive(false);

                DiskOnPlayer.SetActive(true);
                handFull = true;
                equippedCentre = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && handFull == true)
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Insert Finished Shuriken Blade Hitbox Tag Here")
            {
                //You may have to make a gameobject that references the actual model of the placed blade and rather then setting the hit target to true, you set that to true.
                hit.transform.gameObject.SetActive(true);

                BladeOnPlayer.SetActive(false);
                handFull = false;
                equippedShuriken = false;
            }

            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Insert Finished Shuriken Centre Hitbox Tag Here")
            {
                //You may have to make a gameobject that references the actual model of the placed centre and rather then setting the hit target to true, you set that to true.
                hit.transform.gameObject.SetActive(true);

                DiskOnPlayer.SetActive(false);
                handFull = false;
                equippedCentre = false;
            }
        }
    }
}
