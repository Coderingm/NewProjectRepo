using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class Birdscript : MonoBehaviour
{   
    private SpriteRenderer birdrenderer;
    private int rendererindex;
    [SerializeField] private Sprite[] birdsprites;
    private Rigidbody2D birdbody;
    float jump = 5f;
    float rotation = 5f;
    int keycount = 0;
    // Start is called before the first frame update
    void Awake()
    {
        birdrenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {   
        birdbody = GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(Birdrendering), 0.2f, 0.2f);
        birdbody.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
     { 
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            birdbody.velocity = Vector2.up * jump;
            keycount += 1;
            Debug.Log(keycount);
        }
        if (keycount >= 1)
        {
            birdbody.transform.rotation = Quaternion.Euler(0f,0f, birdbody.velocity.y * rotation );
            birdbody.gravityScale = 1;
        }
    }
    private void Birdrendering()    
    {   // create animation for the flappy bird
        rendererindex++ ;
        if (rendererindex >= birdsprites.Length)
        {
            rendererindex = 0;
        }
         birdrenderer.sprite = birdsprites[rendererindex];
    }

}
