using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownHitBehavier : StateMachineBehaviour
{

    float startTime;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        startTime = Time.time;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject clown = animator.gameObject;
        clown.transform.localScale *= Mathf.Lerp(1, 0, Time.time - startTime);
    }


}