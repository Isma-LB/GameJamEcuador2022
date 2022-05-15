using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EndCanvasController : MonoBehaviour
{
    [SerializeField] CanvasGroup[] characters = null;
    [SerializeField, Range(0,1f)] float activeAlpha = 1;
    [SerializeField, Range(0,1f)] float lockedAlpha = 0.2f;
    [SerializeField] GameObject panel = null;

    private void Awake() {
        panel.SetActive(false);
    }
    public void Activate(int level){
        panel.SetActive(true);
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].alpha = i < level? activeAlpha : lockedAlpha;
            if(i == level ){
                StartCoroutine(MakeTransition(characters[i]));
            }
        }
    }
    IEnumerator MakeTransition(CanvasGroup cg){
        yield return new WaitForSeconds(0.5f);
        float n = 0;
        while(n<1){
            n += Time.deltaTime;
            cg.alpha = Mathf.Lerp(activeAlpha,lockedAlpha,n);
            yield return null;
        }
        cg.alpha = activeAlpha;
    }
}
