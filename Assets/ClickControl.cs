using UnityEngine;

public class ClickControl : MonoBehaviour
{
    private Renderer _renderer;

    public GameObject player;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Click!");
        Destroy(this.gameObject);
        FindObjectOfType<PlayerControl>().increaseScore();
    }
}
