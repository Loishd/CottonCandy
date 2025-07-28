using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct TransitionGroup
{
    public string groupID;       
    public GameObject[] frames;  
}

public class TransitionManager : MonoBehaviour
{
    [Header("TRANSITION")]
    public TransitionGroup[] transitions;

    [Header("TIME")]
    public float delay = 1f;

    private class State { public int index = 0; public bool inProgress = false; }
    private Dictionary<string, State> _states = new Dictionary<string, State>();

    void Awake()
    {
       
        foreach (var tg in transitions)
            if (!_states.ContainsKey(tg.groupID))
                _states.Add(tg.groupID, new State());
    }

    public void Next(string groupID, Action onBetween = null)
    {
        if (!_states.TryGetValue(groupID, out var state)) return;
        if (state.inProgress) return;

      
        var tg = Array.Find(transitions, t => t.groupID == groupID);
        if (tg.frames == null || tg.frames.Length == 0) return;
        if (state.index >= tg.frames.Length - 1) return;

        StartCoroutine(DoTransition(tg, state, onBetween));
    }

    private IEnumerator DoTransition(TransitionGroup tg, State state, Action onBetween)
    {
        state.inProgress = true;

    
        yield return new WaitForSeconds(delay);

      
        tg.frames[state.index].SetActive(false);


        onBetween?.Invoke();

     
        state.index++;
        tg.frames[state.index].SetActive(true);


        yield return new WaitForSeconds(delay);

        state.inProgress = false;
    }

}
