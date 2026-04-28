using UnityEngine;
using UnityEngine.Video;

public class VRVideoTrigger : MonoBehaviour
{
    public GameObject uiPanel;
    public GameObject videoPanel;   // Quad
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Hide initially
        uiPanel.SetActive(false);
        videoPanel.SetActive(false);
    }

    void Update()
    {
        // Press D key
        if (Input.GetKeyDown(KeyCode.D))
        {
            Show();
        }
    }

    void Show()
    {
        uiPanel.SetActive(true);
        videoPanel.SetActive(true);

        if (!videoPlayer.isPlaying)
            videoPlayer.Play();
    }
}