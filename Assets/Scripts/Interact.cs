using UnityEngine;
using static Unity.Collections.Unicode;
public class Interact : MonoBehaviour
{
    public GameObject Popup; // The popup game object
    public GameObject PlayerObject; // The player game object goes here
    bool InsideCK = false; // True or false check for if someone is the trigger area
    public string NodeName;
    private void Update()
    {
        if (InsideCK == true) // If player is in side of Collider2D
        {
            if (Input.GetKeyDown(KeyCode.E)) // If the key E is pressed it starts the StartNodeName
            {

                Debug.Log("HIIIIIII");
                
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Popup.SetActive(true);
            InsideCK = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            InsideCK = false;
            Popup.SetActive(false);
            

        }
    }
}


