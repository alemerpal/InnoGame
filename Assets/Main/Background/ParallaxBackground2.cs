using UnityEngine;

public class ParallaxBackground2 : MonoBehaviour
{

    public float speed;

    private Transform[] childs;

    // Update is called once per frame
    void Start()
    {
        childs = new Transform[3];

        for (int i = 0; i < transform.childCount; i++)
        {
            childs[i] = transform.GetChild(i);
        }
    }

    private void Update() {
        foreach (Transform child in childs)
        {
            child.Translate(Vector2.left * speed * Time.deltaTime);
            if (child.localPosition.x < -2.25f) {
                child.localPosition += new Vector3(4.75f, 0.0f, 0.0f);
            }
        }
    }
}
