using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuciernagasManager : MonoBehaviour
{
    [SerializeField, Range(1,10)] int amount = 3;
    [SerializeField] InputTarget input = null;
    [SerializeField] GameObject characterPrefab = null;
    [SerializeField] Transform icons = null;
    [SerializeField] float iconsDistance = 0.2f;
    [SerializeField] GameObject iconPrefab = null;

    CharacterMovement currentChar = null;

    private void OnEnable() {
        input.onSelect += Spawn;
        input.onDiselect += Diselect;
    }
    private void OnDisable() {
        input.onSelect -= Spawn;
        input.onDiselect -= Diselect;
    }
    private void Start() {
        AddIcons(amount);
    }
    private void AddIcons(int amount){
        for (int i = 0; i < amount; i++)
        {
            Vector3 pos = transform.position + Vector3.right *iconsDistance * i;
            Instantiate(iconPrefab, pos, Quaternion.identity, icons);            
        }
    }
    private void RemoveIcon(){
        Destroy(icons.GetChild(icons.childCount-1).gameObject);
    }
    private void Spawn(){
        if(amount<=0) return;

        GameObject go = Instantiate(characterPrefab,transform.position,Quaternion.identity,transform);
        currentChar = go.GetComponent<CharacterMovement>();
        currentChar.input = input;
        amount--;
        RemoveIcon();
    }
    private void Diselect(){
        currentChar.input = null;
    }
   
}
