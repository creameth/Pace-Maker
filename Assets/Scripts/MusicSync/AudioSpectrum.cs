using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioSpectrum : MonoBehaviour {
    
    
    private void Update()
    {
        // get the data
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hamming);

        // normalize the spectrum data
        float maxVal = Mathf.Max(m_audioSpectrum);
        for (int i = 0; i < m_audioSpectrum.Length; i++)
        {
            m_audioSpectrum[i] /= maxVal;
        }

        // assign spectrum value
        if (m_audioSpectrum != null && m_audioSpectrum.Length > 0)
        {
            spectrumValue = m_audioSpectrum[0] * 100;
        }
    }


    private void Start()
    {
       
        m_audioSpectrum = new float[128];
    }
    
    public static float spectrumValue {get; private set;}
    
    private float[] m_audioSpectrum;

}
