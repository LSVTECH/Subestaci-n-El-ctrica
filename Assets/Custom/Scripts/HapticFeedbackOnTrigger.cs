using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(Collider))]
public class HapticFeedbackOnTrigger : MonoBehaviour
{
    [Header("Haptic Settings")]
    public float amplitude = 0.5f;   // Intensidad de la vibración (0-1)
    public float duration = 0.2f;    // Duración de la vibración (en segundos)

    [Header("Hand Nodes")]
    public XRNode leftHand = XRNode.LeftHand;
    public XRNode rightHand = XRNode.RightHand;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica que el objeto que entra tenga la etiqueta "Player"
        if (other.CompareTag("Player"))
        {
            // Envía vibración a la mano izquierda
            SendHapticImpulse(leftHand, amplitude, duration);

            // Envía vibración a la mano derecha
            SendHapticImpulse(rightHand, amplitude, duration);

            Debug.Log("BRRRRR...");
        }
    }

    private void SendHapticImpulse(XRNode node, float amplitude, float duration)
    {
        // Obtiene el dispositivo de la mano (izquierda o derecha)
        InputDevice device = InputDevices.GetDeviceAtXRNode(node);
        if (device.isValid)
        {
            // Envío del impulso háptico
            // Canal 0: canal de vibración por defecto en la mayoría de dispositivos
            device.SendHapticImpulse(0, amplitude, duration);
        }
    }
}
