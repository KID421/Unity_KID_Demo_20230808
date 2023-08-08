using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    [SerializeField, Header("�ɺt����")]
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
