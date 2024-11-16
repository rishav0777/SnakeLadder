using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleEtting : MonoBehaviour
{
  public Sprite sprite1,sprite2;
  public Image obj;
  public void makrtoggle(){
    if(obj.sprite==sprite1){
        obj.sprite=sprite2;
    }
    else{
        obj.sprite=sprite1;
    }
  }
}
