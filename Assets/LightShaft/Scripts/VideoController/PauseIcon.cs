using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseIcon : MonoBehaviour {

    public YoutubePlayer p;
    Text label;
    private void Start()
    {
        label = this.GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        if (p.pauseCalled)
        {
            label.text = ">";
        }
        else
        {
            label.text = "II";
        }
    }
}
