using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishCountController : MonoBehaviour {
    public Sprite[] fishSprites = new Sprite[2];
    public Image[] currentFish = new Image[2];
    private int fishCount = 0;

    // Start is called before the first frame update
    void Start() {

        for(int i = 0; i < currentFish.Length; i++) {
            currentFish[i].sprite = fishSprites[0];
        }
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void updateImages(int idx) {
        if(idx > -1 && idx < currentFish.Length)
            currentFish[idx].sprite = fishSprites[1];
    } // End of updateImages

    public int getFishCount() {
        return fishCount;
    } // End of getFishCount

    public void updateFishCount(int val) {
        fishCount += val;
    } // End of updateFishCount
}