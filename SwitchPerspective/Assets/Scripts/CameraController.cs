using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Animator animator;
    bool isOrthographic = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchCam();
        }

    }

    void SwitchCam()
    {
        if (isOrthographic) {
            animator.Play("PerspectiveCam");
        }
        else
        {
            animator.Play("FakeOrthographicCam");

        }
        isOrthographic = !isOrthographic;
    }
}
