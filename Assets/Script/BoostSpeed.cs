using UnityEngine;

public class BoostSpeed : MonoBehaviour

{
    private SurfaceEffector2D surfaceEffector;
    private float defaultSpeed = 5f;
    private float boostSpeed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        surfaceEffector = FindFirstObjectByType<SurfaceEffector2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector.speed = boostSpeed;
        }
        else
        {
            surfaceEffector.speed = defaultSpeed;
        }
    }
}
