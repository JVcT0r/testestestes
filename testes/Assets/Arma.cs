using UnityEngine;

public class Arma : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            
            // if (mousePos.x < 0)
            // {
            //     transform.eulerAngles = mousePos - new Vector2(0, 180);
            // }
            // else
            // {
            //     transform.eulerAngles = mousePos - new Vector2(0, 0);
            // }
            
        }
}
