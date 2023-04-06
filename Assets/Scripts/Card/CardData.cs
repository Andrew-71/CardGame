using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

using TMPro;

public class CardData : MonoBehaviour, IPointerClickHandler
{
    private int cost;
    private string type;
    private string content; // TODO: String?


    [SerializeField]  private Sprite openIcon;
    [SerializeField] private Sprite closedIcon;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Camera main_camera;
    [SerializeField] private SpriteRenderer sprite;

    private SpriteRenderer ren;

    private bool isShown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Check if card clicked
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Debug.Log(Input.mousePosition);
            Ray ray = main_camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Click!");
                toggleView();
            }
        }

    }

    void SetCost(int now) {
        this.cost = now;
    }

    void SetType(string now) {
        this.type = now;
    }

    void SetContent(string now) {
        this.content = now;
    }

    void toggleView()
    {
        isShown = !isShown;
        if (isShown)
        {
            sprite.sprite = openIcon;
            this.text.SetText("Amogus sus");
        } else
        {
            sprite.sprite = closedIcon;
            this.text.SetText("Live bateman reaction");
        }

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        toggleView();
        //throw new System.NotImplementedException();
    }
}
