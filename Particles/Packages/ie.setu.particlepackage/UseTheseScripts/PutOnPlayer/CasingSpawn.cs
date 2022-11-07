using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasingSpawn : MonoBehaviour
{
    [Header("Add Bullet Casing Here")]
    public GameObject casingObject;
    [Header("Add Transform where you want to spawn it")]
    public Transform transformm;

    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))  //<-------- change to any key that you would like eg: "KeyCode.AnyKeyYouWouldLike"
        {
            GameObject castingBullet = Instantiate(casingObject, transformm.position, transformm.rotation);
            Rigidbody2D rbCasting = castingBullet.GetComponent<Rigidbody2D>();
            rbCasting.AddForce(transformm.up * 5, ForceMode2D.Impulse);
        } 
    }
}
