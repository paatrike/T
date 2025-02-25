using UnityEngine;

public class PlayerDance : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component

    void Update()
    {
        // Check for input to trigger dance animations
        if (Input.GetKeyDown(KeyCode.1))
        {
            PlayDanceAnimation("Dance1");
        }
        else if (Input.GetKeyDown(KeyCode.2))
        {
            PlayDanceAnimation("Dance2");
        }
        else if (Input.GetKeyDown(KeyCode.3))
        {
            PlayDanceAnimation("Dance3");
        }
    }

    void PlayDanceAnimation(string animationName)
    {
        if (animator != null)
        {
            animator.Play(animationName);
        }
        else
        {
            Debug.LogWarning("Animator component is not assigned!");
        }
    }
}
