using UnityEngine;
using System.Collections;

/// <summary>
/// The TriggerAnimation class activates a transition whenever the Cardboard button is pressed (or the screen touched).
/// </summary>
public class TriggerAnimation : MonoBehaviour
{
	[Tooltip ("The Animator component on this gameobject")]
	public Animator animator;
	[Tooltip ("The name of the Animator trigger parameter")]
	public string triggerName;
    [Tooltip("The AudioSource to Play when clicked")]
    public AudioSource globeSFX;

    //private int SPEED_STATE = 0;

    void Start(){
        //animator.speed = 0.0f;
    }

	void Update ()
	{
		// If the player pressed the cardboard button (or touched the screen), set the trigger parameter to active (until it has been used in a transition)
		if (Input.GetMouseButtonDown (0)) {
            //SPEED_STATE = (SPEED_STATE + 1) % 4;
            //switch(SPEED_STATE){
            //    case 0:
            //        animator.speed = 0.0f;
            //        globeSFX.pitch = 0.5f;
            //        break;
            //    case 1:
            //        animator.speed = 0.5f;
            //        globeSFX.pitch = 1.0f;
            //        break;
            //    case 2:
            //        animator.speed = 1.0f;
            //        globeSFX.pitch = 1.5f;
            //        break;
            //    case 3:
            //        animator.speed = 2.0f;
            //        globeSFX.pitch = 2.0f;
            //        break;
            //}
            globeSFX.pitch = 1.0f;
            globeSFX.Play();
			animator.SetTrigger (triggerName);
		}
	}
}
