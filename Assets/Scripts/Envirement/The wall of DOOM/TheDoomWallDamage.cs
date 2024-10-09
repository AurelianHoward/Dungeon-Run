using UnityEngine;
using UnityEngine.SceneManagement;

public class TheDoomWallDamage : MonoBehaviour
{
    [SerializeField]
    float rawDamage = 10f;
    [SerializeField]
    bool isPickupOnCollision = true;
    [SerializeField] string MainMenuScene = "MainMenu";

    // Start is called before the first frame update
    void Start()
    {
        if (isPickupOnCollision)
        {
            gameObject.GetComponent<Collider>().isTrigger = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        //Debug.Log("testing");
        if (isPickupOnCollision)
        {
            //Debug.Log("Shit works");
            if (collider2D.tag == "Player")
            {
                SceneManager.LoadScene(MainMenuScene);
                Cursor.visible = true;
                //collider2D.gameObject.GetComponent<HealthManager>().Hit(rawDamage);
                Debug.Log("trap activated");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
