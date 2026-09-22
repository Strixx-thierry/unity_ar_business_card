using UnityEngine;

// Attach to a UI Button and set 'url'. Wire the Button's OnClick() event to
// call Open() (see the inspector steps). Works for web links (https://...),
// email (mailto:...), and on a real phone, the dialer (tel:...).
public class OpenURLOnClick : MonoBehaviour
{
    [Tooltip("e.g. https://twitter.com/you, mailto:you@example.com, tel:+250700000000")]
    public string url;

    public void Open()
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.LogWarning($"OpenURLOnClick on '{name}' has no URL set.");
            return;
        }
        Application.OpenURL(url);
    }
}
