using UnityEngine;

public class GetReady : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown("space")) InitGameplay();
    }

    public void InitGameplay()
    {
        GameObject.Find("Player").GetComponent<Player>().Jump();
        Destroy(this.gameObject);

    }

}
