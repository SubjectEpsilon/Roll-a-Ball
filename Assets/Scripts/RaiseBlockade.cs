using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseBlockade : MonoBehaviour
{
    public GameObject blockade;
    public GameObject blockadeTrigger;
    private void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag("PlayerTag")){
            blockadeTrigger.SetActive(false);
            blockade.transform.position = blockade.transform.position + new Vector3(0,1,0);
        }
    }
}
