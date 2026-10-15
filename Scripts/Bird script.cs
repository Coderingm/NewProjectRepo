using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{   
    private SpriteRenderer birdrenderer;
    private int rendererindex;
    [SerializeField] private Sprite[] birdsprites;
    
    // Start is called before the first frame update
    void Awake()
    {
        birdrenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {   
       
        InvokeRepeating(nameof(Birdrendering), 0.2f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Birdrendering()
    {
        rendererindex++ ;
        if (rendererindex >= birdsprites.Length)
        {
            rendererindex = 0;
        }
        birdrenderer.sprite = birdsprites[rendererindex];
    }
}
