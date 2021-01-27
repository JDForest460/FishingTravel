using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hook_controller : MonoBehaviour
{

    public Rigidbody2D hook_rb;
    public float hook_power;
    public LineRenderer fish_line;
    private bool is_pull_hook;
    void Start()
    {
        fish_line.SetPosition(0, hook_rb.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        draw_line();
        pull_hook();

    }
    void draw_line()
	{
        fish_line.SetPosition(1, hook_rb.transform.position);
	}
    void pull_hook()
	{
        is_pull_hook = Input.GetMouseButton(0);
        if (is_pull_hook)
		{
            hook_rb.velocity = new Vector2(hook_rb.velocity.x, hook_power * Time.deltaTime);
        }
	}
}
