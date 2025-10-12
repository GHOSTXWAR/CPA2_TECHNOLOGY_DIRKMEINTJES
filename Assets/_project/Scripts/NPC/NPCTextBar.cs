using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPCTextBar: MonoBehaviour
{
    public GameObject NPC;

    private Camera playerCam;
    private Transform target;
    private TextMeshProUGUI TextBox;
    public Vector3 barOffset;

    private void Awake()
    {

        target = NPC.GetComponent<Transform>();
        playerCam = Camera.main;
        transform.position = target.position + barOffset;
    }
    private void FixedUpdate()
    {
        transform.rotation = playerCam.transform.rotation;
        
    }



}