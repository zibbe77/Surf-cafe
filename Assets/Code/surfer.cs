using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class surfer : MonoBehaviour
{
    // Ui
    VisualElement ui;
    GameObject uiController;

    VisualElement life1;
    VisualElement life2;
    VisualElement life3;
    int hp = 3;


    // Movment 
    Rigidbody2D rigB;
    [SerializeField] float moveSpeed = 10;

    private void Awake()
    {
        uiController = GameObject.FindGameObjectWithTag("UiControler");
        ui = uiController.GetComponent<UIDocument>().rootVisualElement;
    }
    private void OnEnable()
    {
        life1 = ui.Q<VisualElement>("life1");
        life2 = ui.Q<VisualElement>("life2");
        life3 = ui.Q<VisualElement>("life3");
    }

    void Start()
    {
        rigB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        rigB.velocity = new Vector2(1 * moveSpeed * Time.deltaTime, rigB.velocity.y);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "PickupSpot")
        {

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SurferDie")
        {
            switch (hp)
            {
                case 3:
                    life1.style.display = DisplayStyle.None;
                    break;
                case 2:
                    life2.style.display = DisplayStyle.None;
                    break;
                case 1:
                    life3.style.display = DisplayStyle.None;
                    break;
                case 0:
                    SceneManager.LoadScene(1);
                    break;

            }

            // clean up
            Destroy(gameObject);
        }
    }

}
