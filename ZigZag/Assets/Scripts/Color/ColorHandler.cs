using System.Collections;
using UnityEngine;

public class ColorHandler : MonoBehaviour
{
    [SerializeField] private Color[] colorList;
    private int colorIndex;
    [SerializeField] private float timeToChangeColor;
    private float currentTime;
    [SerializeField] private Material groundMaterial;
    [SerializeField] [Range(0,3)] private float lerpValue;

    void Start(){
        groundMaterial.color = colorList[0];
        StartCoroutine(ColorChanger());
    }

    void Update(){
        ChangeColor();
    }

    private IEnumerator ColorChanger(){
        while(true){
            yield return new WaitForSeconds(timeToChangeColor);
            UpdateColorIndex();
        }
    }

    private void UpdateColorIndex(){
        colorIndex++;
        if(colorIndex >= colorList.Length){
            colorIndex = 0;
        }
    }

    private void ChangeColor(){
        groundMaterial.color = Color.Lerp(groundMaterial.color, colorList[colorIndex], lerpValue * Time.deltaTime);
    }

    void OnDestroy(){
        groundMaterial.color = colorList[0];
    }
    

}
