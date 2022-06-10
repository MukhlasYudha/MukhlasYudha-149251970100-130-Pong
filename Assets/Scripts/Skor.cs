using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class Skor : MonoBehaviour
{

    public Text skorKiri;
    public Text skorKanan;
    public Score manager;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        skorKiri.text = manager.leftScore.ToString();
        skorKanan.text = manager.rightScore.ToString();
    }
}
