using UnityEngine;
using UnityEngine.Video;
using System.IO;

public class HologramPlayer : MonoBehaviour
{
    public VideoPlayer vp;

    void Start()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "UnityReadyVideo.webm");
        vp.url = path;
    }

    public void PlayVideo()
    {
        vp.Play();
    }
}