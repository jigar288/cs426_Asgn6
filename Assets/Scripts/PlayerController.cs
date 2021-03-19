// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System;

// public class PlayerController : MonoBehaviour {
//     [SerializeField] GameObject player;

//     //direction of the bear going 1-4
//     int direction = 1; 

//     //level
//     int[,] level = 
//     { 
//     { -1, -1, -1, -1, -1, -1, -1, -1, -1},
//     { -1, 1, 4, 4, 4, 4, 4, 4, -1},
//     { -1, 1, 4, 4, 4, 4, 4, 3, -1},
//     { -1, 2, 4, 4, 4, 4, 4, 3, -1},
//     { -1, 2, 4, 4, 4, 4, 4, 2, -1},
//     { -1, 3, 4, 4, 4, 4, 4, 2, -1},
//     { -1, 3, 4, 4, 4, 4, 4, 1, -1},
//     { -1, 4, 4, 4, 4, 4, 4, 1, -1},
//     { -1, -1, -1, -1, -1, -1, -1, -1, -1}
//     };

//     //bear position
//     int bearx = 7;
//     int beary = 7;

    

//     // Update is called once per frame
//     void Update() {
//         if(Input.GetKeyDown(KeyCode.Q))
//             transform.RotateAround(player.transform.position, Vector3.up, 90f);
//         else if(Input.GetKeyDown(KeyCode.E))
//             transform.RotateAround(player.transform.position, Vector3.up, -90f);

//         // TODO - Implement Player Movement
//         if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
//             player.transform.Rotate(Vector3.up*-90f);

//              // TODO - Update player direction to keep track
//             direction--; 
//             if(direction == 0)
//                 direction = 4;
           
//         } else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
//             player.transform.Rotate(Vector3.up*90f);
//             // TODO - Update player direction to keep track
//             direction++; 
//             if(direction == 5)
//                 direction = 1;
            
//         } else if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
//             // TODO - Implement Moving one tile forward

//             bool validMove = checkMovement(); 

//             if(validMove)
//                 handleHeight();

//             if(direction == 1 && validMove) {
//                 player.transform.position += Vector3.forward;  
//                 beary--;
//                 print(bearx + " " + beary); 
//             }
//             if(direction == 2 && validMove) {
//                 player.transform.position += Vector3.right; 
//                 bearx++; 
//             } 
//             if(direction == 3 && validMove) {
//                 player.transform.position += Vector3.back;
//                 beary++; 
//             }  
//             if(direction == 4 && validMove) {
//                 player.transform.position += Vector3.left; 
//                 bearx--;  
//             }
//         }
//     } // End of Update

//     void handleHeight(){

//         int delta = getDelta(); 

//         if(delta == 1){
//             player.transform.position += Vector3.up; 
//         }
//         if(delta == -1){
//             player.transform.position += Vector3.down; 
//         }
//     }

//     bool checkMovement(){

//         if(Math.Abs(getDelta()) > 1){
//             return false;
//         }

//         return true;
//     }

//     int getDelta(){
//         int delta = 0;
        
//         if(direction == 1){
//             delta = level[beary - 1, bearx] - level[beary, bearx];
//         } 
//         if(direction == 2){
//             delta = level[beary, bearx + 1] - level[beary, bearx];
//         }
  
//         if(direction == 3){

//             delta = level[beary + 1, bearx] - level[beary, bearx];
//         }
//         if(direction == 4){

//             delta = level[beary, bearx - 1] - level[beary, bearx];
//         }

//         return delta; 
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI; 

public class PlayerController : MonoBehaviour {
    [SerializeField] GameObject player, parent;

    public Text endtext; 

    //direction of the bear going 1-4
    int direction = 1; 

    //level
    int[,] level = 
    { 
    { -1, -1, -1, -1, -1, -1, -1, -1, -1},
    { -1, 1, 4, 4, 4, 4, 4, 4, -1},
    { -1, 1, 4, 5, 8, 5, 4, 3, -1},
    { -1, 2, 4, 5, 7, 5, 4, 3, -1},
    { -1, 2, 4, 5, 6, 5, 4, 2, -1},
    { -1, 3, 4, 4, 5, 4, 4, 2, -1},
    { -1, 3, 4, 4, 4, 4, 4, 1, -1},
    { -1, 4, 4, 4, 4, 4, 4, 1, -1},
    { -1, -1, -1, -1, -1, -1, -1, -1, -1}
    };

    //bear position
    int bearx = 7;
    int beary = 7;

    int endx = 1;
    int endy = 1;

    void Start(){
        endtext.enabled = false; 
    }
    

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Q))
            transform.RotateAround(player.transform.position, Vector3.up, 90f);
        else if(Input.GetKeyDown(KeyCode.E))
            transform.RotateAround(player.transform.position, Vector3.up, -90f);

        // TODO - Implement Player Movement
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            player.transform.Rotate(Vector3.up*-90f);

             // TODO - Update player direction to keep track
            direction--; 
            if(direction == 0)
                direction = 4;
           
        } else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
            player.transform.Rotate(Vector3.up*90f);
            // TODO - Update player direction to keep track
            direction++; 
            if(direction == 5)
                direction = 1;
            
        } else if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            // TODO - Implement Moving one tile forward

            bool validMove = checkMovement(); 

            if(validMove)
                handleHeight();

            if(direction == 1 && validMove) {
                parent.transform.position += Vector3.forward;  
                beary--;
                print(bearx + " " + beary); 
            }
            if(direction == 2 && validMove) {
                parent.transform.position += Vector3.right; 
                bearx++; 
            } 
            if(direction == 3 && validMove) {
                parent.transform.position += Vector3.back;
                beary++; 
            }  
            if(direction == 4 && validMove) {
                parent.transform.position += Vector3.left; 
                bearx--;  
            }
        }

        if(endx == bearx && endy == beary){
            endtext.enabled = true; 
            Debug.Log("End");
        }
    } // End of Update

    void handleHeight(){

        int delta = getDelta(); 

        if(delta == 1){
            parent.transform.position += Vector3.up; 
        }
        if(delta == -1){
            parent.transform.position += Vector3.down; 
        }
    }

    bool checkMovement(){

        if(Math.Abs(getDelta()) > 1){
            return false;
        }

        return true;
    }

    int getDelta(){
        int delta = 0;
        
        if(direction == 1){
            delta = level[beary - 1, bearx] - level[beary, bearx];
        } 
        if(direction == 2){
            delta = level[beary, bearx + 1] - level[beary, bearx];
        }
  
        if(direction == 3){

            delta = level[beary + 1, bearx] - level[beary, bearx];
        }
        if(direction == 4){

            delta = level[beary, bearx - 1] - level[beary, bearx];
        }

        return delta; 
    }
}
