using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour {

    private int moodPoints;
    Animation catAnimation;
    AnimationClip[] clips;

    public void getTouched() {
        // Logic for mood
    }

    public void increaseMood(int pts) {
        moodPoints += pts;
    }

    public void decreaseMood(int pts) {
        moodPoints -= pts;
    }


    public Transform target;
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
        Debug.Log("Number of anims: " + catAnimation.GetClipCount());
        AnimationClip clip = catAnimation.GetClip("Cat_arm|attack");
        catAnimation.clip = clip;
        catAnimation.Play();
        //List<AnimationState> states = new List<AnimationState>(catAnimation.Cast<AnimationState>());
    }
}
