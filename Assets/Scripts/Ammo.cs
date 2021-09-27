/****
 * Created by: William Gulick
 * Date Created: 9/22/2021
 * 
 * Last edited by:
 * Last updated: 9/22/2021
 * 
 * Description: Controls ammo damage and lifetime
 ****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//------------------------------
public class Ammo : MonoBehaviour
{
    public float Damage = 100f;
    public float LifeTime = 2f;
    //------------------------------
    void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", LifeTime);
    }
    //------------------------------
    // Update is called once per frame
    void OnTriggerEnter(Collider Col)
    {
        //Get health component
        Health H = Col.gameObject.GetComponent<Health>();

        if (H == null) return;

        H.HP -= Damage;
    }
    //------------------------------
    void Die()
    {
        gameObject.SetActive(false);
    }

    //------------------------------
}
