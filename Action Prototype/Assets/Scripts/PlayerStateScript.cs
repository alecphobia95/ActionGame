using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStateScript : MonoBehaviour
{
    public string[] StaggerOptionArray = new string[] {"Staggerable", "Unstaggerable" };
    public string[] HitOptionArray = new string[] {"NeutralHitState", "HitstunState", "RecoveryHitState" };

    public string StaggerState = "Staggerable";
    public string HitState = "NeutralHitState";
    public GameObject HitBox;

    public float HitStunTime;
    public float StaggerTime;

    private void HaveIBeenHit(Collision collision)
    {
        if(collision.gameObject.name == "Weapon")
        {

        }
    }

    private string WeaponState(Collision collision)
    {
        string state = "neutral";
        GameObject weapon = collision.gameObject;
        WeaponStateClass weaponState;

        return (state);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
