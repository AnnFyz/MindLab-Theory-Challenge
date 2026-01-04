using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOfCamera : MonoBehaviour
{
    [SerializeField] private float followSpeed = 5;
    RectTransform selectedCardRectTransform;

    private void OnEnable()
    {
        CardManager.OnSelectedCard += SetTarget;
    }

    void OnDisable()
    {
        CardManager.OnSelectedCard -= SetTarget;
    }
    void LateUpdate()
    {
        selectedCardRectTransform = CardManager.selectedCard.GetComponent<RectTransform>();
        transform.position = Vector3.Lerp(
        transform.position,
        selectedCardRectTransform.position,
        Time.deltaTime * followSpeed
        );
    }

    void SetTarget()
    {
        selectedCardRectTransform = CardManager.selectedCard.GetComponent<RectTransform>();
        transform.position = selectedCardRectTransform.transform.position;
    }
}
