using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMatchWithCamera : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        float spritex = spriteRenderer.bounds.size.x;
        float spritey = spriteRenderer.bounds.size.y;

        float screenY = Camera.main.orthographicSize * 2;
        float screenX = screenY / Screen.height * Screen.width;

        transform.localScale = new Vector2(Mathf.Ceil(screenX / spritex), Mathf.Ceil(screenY / spritey));



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
