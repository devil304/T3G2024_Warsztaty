using UnityEngine;

public class InputProvider : MonoBehaviour
{
    public InputSystem_Actions Inputs;

    private void Awake()
    {
        Inputs = new InputSystem_Actions();
        Inputs.Movement.Enable();
        Inputs.Interaction.Enable();
    }
}
