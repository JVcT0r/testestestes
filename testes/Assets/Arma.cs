using UnityEngine;

public class Arma : MonoBehaviour
{
    private SpriteRenderer spr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        LookAtMouse();
    }
    
    private void LookAtMouse()
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.right = mousePos - new Vector2(transform.position.x, transform.position.y);
            
            if (mousePos.x < 0)
            {
                spr.flipY = true;
            }
            else if (mousePos.x > 0)
            {
                spr.flipY = false;
            }
            
        }
}
