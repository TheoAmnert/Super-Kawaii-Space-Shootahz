using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
	// Gjort av Oscar
	public Transform camTransform;

	
	public static float shakeDuration = 0f; //Hur länge kameran skakas, ändras när man tar damage av en fiende

	// Hur mycket kameran skakar, högre shakeAmount = mer skakningar
	public float shakeAmount = 0.4f;
	public float decreaseFactor = 1.0f;

	Vector3 originalPos;

	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}

	void OnEnable()
	{ // Origninalpos är där kameran är från början
		originalPos = camTransform.localPosition;
	}

	void Update() // Här ändras positionen av cameran så det ser ut som den skakar, när shakedurationen ändras.
	{
		if (shakeDuration > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else // Om shakeduration ej ändras så stannar det på Originalpos
		{ 
			shakeDuration = 0f;
			camTransform.localPosition = originalPos;
		}
	}
}