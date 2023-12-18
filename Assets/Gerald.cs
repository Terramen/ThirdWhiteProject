using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Gerald : MonoBehaviour
{


    public ScrollRect gdfgdf;
    
    public TMP_Text hhhh; // Ссылка на ваш компонент Text с текстом
    public RectTransform qweer;

    void Start()
    {
        HeightNormal();
    }

    public void HeightNormal() {
        float th = hhhh.preferredHeight;

        Vector2 sd = qweer.sizeDelta;
        sd.y = th;
        qweer.sizeDelta = sd;

        gdfgdf.normalizedPosition = new Vector2(0, 1);
    }
}
