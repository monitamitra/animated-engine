using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    private MeshRenderer myMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = GameManagerScript.myGameManager.gameSpeed / transform.localScale.x;
        myMeshRenderer.material.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }
}
