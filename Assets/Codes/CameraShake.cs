using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
	// Gjort av Oscar
	public Transform camTransform;

	
	public static float shakeDuration = 0f; //Hur l�nge kameran skakas, �ndras n�r man tar damage av en fiende

	// Hur mycket kameran skakar, h�gre shakeAmount = mer skakningar
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
	{ // Origninalpos �r d�r kameran �r fr�n b�rjan
		originalPos = camTransform.localPosition;
	}

	void Update() // H�r �ndras positionen av cameran s� det ser ut som den skakar, n�r shakedurationen �ndras.
	{
		if (shakeDuration > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else // Om shakeduration ej �ndras s� stannar det p� Originalpos
		{ 
			shakeDuration = 0f;
			camTransform.localPosition = originalPos;
		}
	}
}