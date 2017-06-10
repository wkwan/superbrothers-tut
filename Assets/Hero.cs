using UnityEngine;
using DG.Tweening;

public class Hero : MonoBehaviour
{
    private Animator animator;
    private DeviceOrientation prevFrameOrientation;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (prevFrameOrientation == Input.deviceOrientation) return;
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                transform.DORotate(new Vector3(0, 0, 180), 0.5f);
                transform.DOScale(new Vector3(10, 10, 1), 0.5f);
                animator.SetBool("isFight", false);
                prevFrameOrientation = DeviceOrientation.LandscapeLeft;

                break;
            case DeviceOrientation.LandscapeRight:
                transform.DORotate(new Vector3(0, 0, 0), 0.5f);
                transform.DOScale(new Vector3(10, 10, 1), 0.5f);
                animator.SetBool("isFight", false);
                prevFrameOrientation = DeviceOrientation.LandscapeRight;


                break;
            case DeviceOrientation.PortraitUpsideDown:
                transform.DORotate(new Vector3(0, 0, 90), 0.5f);
                transform.DOScale(new Vector3(15, 15, 1), 0.5f);
                animator.SetBool("isFight", true);
                prevFrameOrientation = DeviceOrientation.PortraitUpsideDown;


                break;
            case DeviceOrientation.Portrait:
                transform.DORotate(new Vector3(0, 0, -90), 0.5f);
                transform.DOScale(new Vector3(15, 15, 1), 0.5f);
                animator.SetBool("isFight", true);
                prevFrameOrientation = DeviceOrientation.Portrait;


                break;
        }
    }
}