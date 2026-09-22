using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class TargetVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private ObserverBehaviour observer;

    void Start()
    {
        observer = GetComponent<ObserverBehaviour>();
        if (observer)
        {
            observer.OnTargetStatusChanged += OnStatusChanged;
        }
    }

    private void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if (status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED)
        {
            videoPlayer.Play();
        }
        else
        {
            videoPlayer.Pause();
        }
    }
}