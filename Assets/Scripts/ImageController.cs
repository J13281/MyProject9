using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageController : MonoBehaviour
{
    public float d;

    Vector3 target;
    Vector3 source;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (0 < d)
        {
            transform.position = source + d * (target - source);
        }
    }

    public void Move(Vector3 target)
    {
        d = 0;
        this.target = target;
        source = transform.position;
        animator.SetTrigger("Move");
    }
}
