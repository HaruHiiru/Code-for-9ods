using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndScene2 : MonoBehaviour
{
    [SerializeField] GameObject screen;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;
    [SerializeField] GameObject other;
    bool hover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hover && Input.GetMouseButtonDown(0))
        {
            screen.GetComponent<SpriteRenderer>().material.color = new Color(0, 0, 0, 1);
            source.Stop();
            source.PlayOneShot(clip);
            gameObject.transform.position = new Vector3(100, 100, 0);
            other.transform.position = new Vector3(-100, -100, 0);
            DoSomething();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hover = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hover = false;
    }

    async void DoSomething()
    {
        await Task.Delay((int)clip.length * 1000);
        SceneManager.LoadScene("Ambulance");
    }
}
