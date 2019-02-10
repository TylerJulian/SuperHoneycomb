using UnityEngine;
using UnityEngine.UI;  //its a must to access new UI in script
 public class scoreUpdate : MonoBehaviour
 {
     public Text score; // assign it from inspector

     void Start()
     {
         score.text = "";

     }

 void Update()
 {
     score.text = ("score: " + hexagon.counter + " Lives: " + player.livesLeft + " HighScore: " + player.highScore);
     


 }
 }