using UnityEngine;
using UnityEngine.XR;
using System.Collections; // Para IEnumerator <button class="citation-flag" data-index="3">

public class ContinuousHapticFeedback : MonoBehaviour
{
    private InputDevice _device; // Referencia al dispositivo XR
    private Coroutine _hapticRoutine;

    void Start()
    {
        // Obtiene el dispositivo asociado al controlador derecho
        _device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);

        // Verifica si el dispositivo es válido
        if (!_device.isValid)
        {
            Debug.LogWarning("Dispositivo XR no encontrado. Asegúrate de que el controlador esté conectado.");
        }
    }

    public void OnHoverEntered()
    {
        if (_device.isValid)
        {
            _hapticRoutine = StartCoroutine(SendContinuousHaptics());
        }
        else
        {
            Debug.LogWarning("No se puede iniciar la vibración: Dispositivo XR no válido.");
        }
    }

    public void OnHoverExited()
    {
        if (_hapticRoutine != null)
        {
            StopCoroutine(_hapticRoutine);
            _hapticRoutine = null;
        }
    }

    private IEnumerator SendContinuousHaptics()
    {
        while (true)
        {
            // Verifica nuevamente si el dispositivo es válido
            if (_device.isValid)
            {
                _device.SendHapticImpulse(0, 0.5f, 0.1f); // Canal 0, amplitud 0.5, duración 0.1s
            }
            else
            {
                Debug.LogWarning("Dispositivo XR no válido durante la vibración.");
                yield break; // Detiene la corrutina si el dispositivo no es válido
            }

            yield return new WaitForSeconds(0.1f); // Espera antes de enviar el siguiente impulso
        }
    }
}