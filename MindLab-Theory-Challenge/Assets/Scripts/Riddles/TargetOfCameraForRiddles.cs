using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOfCameraForRiddles : MonoBehaviour
{
    [SerializeField] private float followSpeed = 5;
    RectTransform selectedCardRectTransform;

    private void OnEnable()
    {
        RiddleManager.OnSelectedRiddle += SetTarget;
    }

    private void OnDisable()
    {
        RiddleManager.OnSelectedRiddle -= SetTarget;
    }
    void LateUpdate()
    {
        selectedCardRectTransform = RiddleManager.selectedRiddle.GetComponent<RectTransform>();
        transform.position = Vector3.Lerp(
        transform.position,
        selectedCardRectTransform.position,
        Time.deltaTime * followSpeed
        );
    }

    void SetTarget()
    {
        selectedCardRectTransform = RiddleManager.selectedRiddle.GetComponent<RectTransform>();
        transform.position = selectedCardRectTransform.transform.position;
    }
}
