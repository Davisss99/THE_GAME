using UnityEngine;

public class HideWhenClose : MonoBehaviour

{
    public static int globalCoins=0;
    public Transform target; // The target object that triggers the hiding
    public float hideDistance = 0.001f; // Distance within which the object will be hidden
    public PlayerController player;
    public bool increaseSpeed=false;
    public bool increaseTime=false;
    public bool zoomOut=false;

    public bool isCoin=true;

    public ZoomCamera zoomCamera;

    public Timer timer;
    private Renderer objectRenderer; // Reference to the Renderer component of the object

    void Start()
    {
        globalCoins=0;
        // Get the Renderer component of the object
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Check the distance between this object and the target
        if (Vector3.Distance(transform.position, target.position) < hideDistance)
        {
            // If within the hide distance, hide the object
            if (objectRenderer.enabled){
                objectRenderer.enabled = false;
                if(isCoin){
                    globalCoins++;
                }
                if (increaseTime)  {
                    timer.remainingDuration += 5;
                }
                if (increaseSpeed)  {
                    player.highSpeedSeconds += 5.0f;
                }
                if (zoomOut)  {
                    zoomCamera.zoomOut = true;
                }
            }
        }
        
        
    }
}

