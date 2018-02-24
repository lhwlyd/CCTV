using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// C:\acsnfs4.ucsd.edu\CifsHomes\648\q3dong\GitHub

public class Cat : MonoBehaviour
{

    private int moodPoints;
    Animation catAnimation;

    AnimationClip idle;
    AnimationClip idle1;
    AnimationClip idle2;
    AnimationClip walk;
    AnimationClip attack;
    AnimationClip jump;

    public Transform target;


    public void getTouched()
    {
        // Logic for mood
    }

    public void increaseMood(int pts)
    {
        moodPoints += pts;
    }

    public void decreaseMood(int pts)
    {
        moodPoints -= pts;
    }


    public void walkTo(Transform target) {
        this.target = target;

        playClip(walk);
    }


    public float smoothTime = 15F;
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 targetPosition = target.transform.position;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }


    private void Awake()
    {
        catAnimation = this.gameObject.GetComponent<Animation>();
        assignClips();

    }

    private void playClip(AnimationClip inputClip) {
        catAnimation.clip = inputClip;
        catAnimation.Play();
    }

    private void assignClips()
    {
        idle = catAnimation.GetClip("Cat_arm|_idle_1");
        idle1 = catAnimation.GetClip("Cat_arm|Idle_2");
        idle2 = catAnimation.GetClip("Cat_arm|sit_idle");
        walk = catAnimation.GetClip("Cat_arm|Walk");
        attack = catAnimation.GetClip("Cat_arm|attack");
        jump = catAnimation.GetClip("Cat_arm|jump");

    }
}
