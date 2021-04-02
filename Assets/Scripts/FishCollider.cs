<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollider : MonoBehaviour {
    FishCountController fcc;

    // Start is called before the first frame update
    void Start()
    {
        fcc = (GameObject.FindGameObjectWithTag("Canvas")).GetComponent<FishCountController>();
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("PlayerObj")) {
            fcc.updateImages(fcc.getFishCount());
            fcc.updateFishCount(1);
            Destroy(this.gameObject);
        }
    }
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollider : MonoBehaviour {
    FishCountController fcc;

    // Start is called before the first frame update
    void Start()
    {
        fcc = (GameObject.FindGameObjectWithTag("Canvas")).GetComponent<FishCountController>();
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("PlayerObj")) {
            fcc.updateImages(fcc.getFishCount());
            fcc.updateFishCount(1);
            Destroy(this.gameObject);
        }
    }
>>>>>>> f4d4002b9f9b6fd8977836e79fa09ca2f883209c
}