using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPCSystem : MonoBehaviour
{
bool player_detection = false;
    public GameObject canvas;
    public InputSystem_Actions playerMovement;
    private InputAction Talk;

    private void Awake()
    {
        playerMovement = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        Talk = playerMovement.Player.NPC;
        Talk.Enable();

    }

    private void OnDisable()
    {
        Talk.Disable();
    }


    private void Update()
    {
        if (player_detection && (Talk.ReadValue<float>()== 1)) {
            print("Dialogue Started!");
            canvas.SetActive(true);
        }
      
    }

    


    private void OnTriggerEnter(Collider other)
    { 
        if (other.GetComponentInChildren<CharacterController>() !=null) 

        {
            player_detection = true;
        }

    }


    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }
}
