using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageResizer : MonoBehaviour
{
    [SerializeField] private Image escImage;
    [SerializeField] private Image pauseImage;
    void Start()
    {
        escImage.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height); 
        pauseImage.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height); 
    }

    
}
