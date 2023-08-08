using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    [SerializeField, Header("導演物件")]
    private PlayableDirector playableDirector;

    private void Awake()
    {
        Invoke("DelayActivateTimeline", 5);
    }

    private void DelayActivateTimeline()
    {
        playableDirector.enabled = true;
    }
}
