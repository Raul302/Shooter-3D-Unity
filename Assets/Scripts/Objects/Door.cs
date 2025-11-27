using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        SoundManager.Instance.PlayOpenDoorSound();
        animator.SetTrigger("OpenDoor");
    }
}
