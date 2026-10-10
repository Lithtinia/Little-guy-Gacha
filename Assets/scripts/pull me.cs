using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class pullme : MonoBehaviour
{
    public ActorsSO[] Actors;
    public Image oc;
    public TMP_Text name;

    
  
    public void gachapull()
    {
        //Debug.Log("you pull");
int random = Random.Range(0, Actors.Length);
 


oc.sprite = Actors[random].charaters;
    name.text = Actors[random].Names;
    }
}
