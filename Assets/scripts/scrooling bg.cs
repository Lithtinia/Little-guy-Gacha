using UnityEngine;

public class scroolingbg : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    
    [SerializeField]
    private Renderer bgRen;
    // Update is called once per frame
    void Update()
    {
        bgRen.material.mainTextureOffset += new Vector2(Time.deltaTime * speed, 0);
    }
}
