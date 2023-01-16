using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;
    public GameObject StartTeleporter;
    public GameObject TeleportTo2;
    public GameObject StartTeleporter2;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Teleporter"))
        {
            Player.transform.position = TeleportTo.transform.position;
        }

        if (collision.gameObject.CompareTag("SecondTeleporter"))
        {
            Player.transform.position = StartTeleporter.transform.position;
        }
        if (collision.gameObject.CompareTag("ThirdTeleporter"))
        {
            Player.transform.position = TeleportTo2.transform.position;
        }

        if (collision.gameObject.CompareTag("FourthTeleporter"))
        {
            Player.transform.position = StartTeleporter2.transform.position;
        }
    }
}
