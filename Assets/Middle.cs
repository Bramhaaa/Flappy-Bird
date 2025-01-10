using UnityEngine;

public class Middle : MonoBehaviour
{
    public LogicManager logicManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicManager = GameObject.FindWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        logicManager.addscore();
    }
}
