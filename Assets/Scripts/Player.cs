using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody PlayerRb;
    public float BounceForce;

    public AudioSource bounceSound;
    public AudioSource loseSound;
    public AudioSource winSound;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (!GameManager.mute)
            bounceSound.Play();

        PlayerRb.velocity = new Vector3(PlayerRb.velocity.x, BounceForce, PlayerRb.velocity.z);
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

        if(materialName == "Safe (Instance)")
        {

        } else if(materialName == "Fail (Instance)")
        {
            GameManager.gameOver = true;
            if (!GameManager.mute)
                loseSound.Play();

        }
        else if(materialName == "Finish (Instance)" && !GameManager.levelCompleted)
        {
            GameManager.levelCompleted = true;
            if (!GameManager.mute)
                winSound.Play();
        }
    }
}
