using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasingSpawn : MonoBehaviour
{
    [Header("Change force here")]
    public float Force;
    [Header("How many times to spawn")]
    public float amountOfBullets;
    [Header("Add Bullet Casing Here")]
    public GameObject casingObject;
    [Header("Add Transform where you want to spawn it")]
    public Transform transformm;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))  //<-------- change to any key that you would like eg: "KeyCode.AnyKeyYouWouldLike"
        {
            for (int i = 0; i < amountOfBullets; i++)
            {
                GameObject castingBullet = Instantiate(casingObject, transformm.position, transformm.rotation);
                Rigidbody2D rbCasting = castingBullet.GetComponent<Rigidbody2D>();
                rbCasting.AddForce(transformm.up * Force, ForceMode2D.Impulse);
            }
        } 
    }
}
