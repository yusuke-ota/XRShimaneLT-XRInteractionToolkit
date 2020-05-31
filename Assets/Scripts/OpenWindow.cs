using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenWindow : MonoBehaviour
{
    [SerializeField][Tooltip("XR Interactableをセットしてください")]
    private XRBaseInteractable xrBaseInteractable;
    [SerializeField][Tooltip("表示したいウィンドウをセットしてください")]
    private GameObject explainWindow;
    
    private void OnEnable()
    {
        xrBaseInteractable = GetComponent<XRBaseInteractable>();

        // 早期リターン
        if (xrBaseInteractable == null || explainWindow == null) return;
        
        // イベント登録
        xrBaseInteractable.onHoverEnter.AddListener(OnHoverEnter);
        xrBaseInteractable.onHoverExit.AddListener(OnHoverExit);
    }
    
    private void OnDisable()
    {
        // 早期リターン
        if (xrBaseInteractable == null || explainWindow == null) return;
        
        // イベント登録
        xrBaseInteractable.onHoverEnter.RemoveListener(OnHoverEnter);
        xrBaseInteractable.onHoverExit.RemoveListener(OnHoverExit);
    }
    
    private void OnHoverEnter(XRBaseInteractor arg0)
    {
        explainWindow.SetActive(true);
    }

    private void OnHoverExit(XRBaseInteractor arg0)
    {
        explainWindow.SetActive(false);
    }
}
