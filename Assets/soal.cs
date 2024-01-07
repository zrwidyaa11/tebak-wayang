using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class soal : MonoBehaviour
{
 public string jawaban;
 public Text info, jawab;

 void Start () {

 }

 void Update () {

 }

 public void cek(){
    if (jawab.text == jawaban) {
    info.text = "hebat!";
    } else {
        info.text = "salah";
    }
 }
}