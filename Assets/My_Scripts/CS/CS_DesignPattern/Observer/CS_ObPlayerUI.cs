using TMPro;
using UnityEngine;

public class CS_ObPlayerUI : MonoBehaviour, CS_IUIListener
{
    [SerializeField] CS_ObEChangeType changeType = CS_ObEChangeType.Gold;
    [SerializeField] TMP_Text goldUiText;

    private void Start()
    {
        CS_ObGlobalEvent.PlayerChangeEvent.RegisterObserver(this);
    }

    public void OnNotify(CS_ObEChangeType changeType, int value)
    {
        if (this.changeType == changeType)
        {
            goldUiText.text = $"{changeType.ToString()}: {value}";
        }
    }

    private void OnDestroy()
    {
        CS_ObGlobalEvent.PlayerChangeEvent.UnregisterObserver(this);
    }
}