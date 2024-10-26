using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] string PickupType;

    InvetoryManger invetoryManger;

    void Start()
    {
        invetoryManger = GameObject.FindGameObjectWithTag("Player").GetComponent<InvetoryManger>();
    }

    //move
    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("0");
                invetoryManger.AddWine();
            }
        }
    }
    // sdmdm
}
