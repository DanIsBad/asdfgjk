using UnityEngine;

public class Torch : MonoBehaviour
{
    public float scaleFactor = 2;

    public float fullLightDuration = 10;
    public float remainingLightDuration;
    public Transform bar;
    
    bool isUsing = false;
    Vector3 size;

    void Start(){
        remainingLightDuration = fullLightDuration;
        size = transform.localScale;
    }

    void Update()
    {
        if (isUsing) remainingLightDuration -= Time.deltaTime;

        bar.localScale = new Vector3(remainingLightDuration/fullLightDuration, 1, 1);
        
        if(Input.GetButton("Jump") && remainingLightDuration > 0.01f){
            transform.localScale = size * scaleFactor;
            isUsing = true;
        }
        else{
            transform.localScale = size;
            isUsing = false;
        }

        

    }
}
