using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Birdscript : MonoBehaviour
{   
    private SpriteRenderer birdrenderer;
    private int rendererindex;
    [SerializeField] private Sprite[] birdsprites;
    private Rigidbody2D birdbody;
    float jump = 5f;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        birdrenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {   
        birdbody = GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(Birdrendering), 0.2f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdbody.velocity = (Vector2.up * jump);
            birdbody.rotation = 20f;
        }
        
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
