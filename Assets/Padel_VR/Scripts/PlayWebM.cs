using UnityEngine;
using UnityEngine.Video;

public class PlayWebM : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        string path = System.IO.Path.Combine(Application.streamingAssetsPath, "video.webm");

        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = path;

        videoPlayer.Play();
        Debug.Log(path);
    }
}