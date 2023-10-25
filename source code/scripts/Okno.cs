using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okno : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite sprite1;
    [SerializeField] private Sprite sprite2;
    [SerializeField] private Collider2D colliderSelf;
    [SerializeField] private Collider2D coliderKot;
    [SerializeField] private SpriteRenderer Victory;
    [SerializeField] private GameObject cat; 
    bool isOpen = true;
    int chances = 2000;

    // Start is called before the first frame update
    void Start()
    {
        colliderSelf.enabled = !colliderSelf.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        int temp = Random.Range(0, chances);
        if (temp == 1) {
            if (isOpen) {
                spriteRenderer.sprite = sprite2;
                colliderSelf.enabled = !colliderSelf.enabled;
                chances = 500;
            }
            else {
                spriteRenderer.sprite = sprite1;
                colliderSelf.enabled = !colliderSelf.enabled;
                chances = 2000;
            }
            isOpen = !isOpen;
        }
    }
    
    void OnTriggerEnter2D(Collider2D colliderKot) {
        Debug.Log("Ti krutoy!!!");
        Victory.enabled = true;
        cat.GetComponent<Kot>().enabled = false;
        Debug.Break();
    }
}
