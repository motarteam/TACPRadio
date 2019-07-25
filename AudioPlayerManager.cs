using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerManager : MonoBehaviour
{

    public AudioSource m_AudioPlayer; // Audio Output.
    public AudioClip[] m_AudioSoundClips; // clips Array.
    public int m_clip; // clip to be played.



    // Start is called before the first frame update
    void Start()
    {

        m_AudioPlayer = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudioClip()
    {

        if (m_AudioPlayer.isPlaying)
        {
            m_AudioPlayer.Stop();
        } 

        // m_AudioPlayer.enabled = true;
        if (!m_AudioPlayer.isPlaying)
        {
            
            m_AudioPlayer.clip = m_AudioSoundClips[m_clip];
            m_AudioPlayer.volume = 1.0f;
            m_AudioPlayer.Play();
            
           
            Debug.Log("Audio Clip is Playing!");
            Debug.Log("Playing audio clip " + m_AudioPlayer.clip);

            return;
        }
        else
        {
            Debug.Log("Audio failed to play");
        }
    }

    
           
    public void StopAudio()
    {
        m_AudioPlayer.Stop();
        m_clip = 0;
    }


}
