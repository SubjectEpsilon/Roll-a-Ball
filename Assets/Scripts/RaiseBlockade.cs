using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseBlockade : MonoBehaviour
{
    public GameObject blockade;
    public GameObject blockadeTrigger;
    public GameObject thisCell;
    public GameObject nextCell;


    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("PlayerTag")){
            GameObject cell = Instantiate(nextCell);
            cell.transform.position = thisCell.transform.position + new Vector3(0,0,51);
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag("PlayerTag")){
            blockadeTrigger.SetActive(false);
            blockade.transform.position = blockade.transform.position + new Vector3(0,1,0);
        }
    }
}
