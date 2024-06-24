using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StandartView : View
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] GameObject _target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleClick();
        }
    }

    public override void DisplayScore(int score)
    {
        _scoreText.text = score.ToString();
    }

    private void HandleClick()
    {
        Debug.Log("Clicked");
        Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Input.GetTouch(0).position
        RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
        var target = hit.collider.GetComponent<Target>();
        if (target != null)
        {
            _presenter.OnTargetClicked();
        }
    }
}
