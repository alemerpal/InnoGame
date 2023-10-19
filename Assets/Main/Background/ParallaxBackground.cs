using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{

    public float speed;

    private Material material;

    private float pos = 0.0f;

    private void Start() {
        material = GetComponent<SpriteRenderer>().material;
    }

    private void Update() {
        pos += speed * Time.deltaTime;
        material.mainTextureOffset = new Vector2(pos, 0.0f);
    } 
}
