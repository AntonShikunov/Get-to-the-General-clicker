//using System;
using System.Collections;
using System.Collections.Generic;
//using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ClickObj : MonoBehaviour {

    public bool move;
    public Vector2 randomVector;
    void Update() {
        if (!move) return;
        transform.Translate(randomVector * Time.deltaTime);
    }
    public void StartMotion(int score)
    {
        transform.localPosition = new Vector2(0f, -50f);
        GetComponent<Text>().text = "+" + score;
        randomVector = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        move = true;
        GetComponent<Animation>().Play("ClickTextAnim");
    }

    /*public static void vect()
    {
        randomVector = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
    }*/

    /*public void StopMotion()
    {
        move = false;
    }*/
}
