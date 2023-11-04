using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class EndScene1 : MonoBehaviour
{
    [SerializeField] GameObject[] Check;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource Source;
    [SerializeField] GameObject Transition;
    bool start = false;
    float i = 0;

    bool End = true;
    // Start is called before the first frame update
    void Start()
    {
        Transition.GetComponent<Renderer>().material.color = new Color(0, 0, 0, i);
    }

    // Update is called once per frame
    void Update()
    {
        if(Check[0].GetComponent<BoxCollider2D>().isTrigger == false && Check[1].GetComponent<BoxCollider2D>().isTrigger == false && Check[2].GetComponent<BoxCollider2D>().isTrigger == false)
        {
            if (End)
            {
                End = false;
                Source.Stop();
                Source.PlayOneShot(clip);
                DoSomething();
            }

            if (start == true)
            {
                if (i < 1)
                    i += 0.0005f;
                else
                    SceneManager.LoadScene("News");
                Transition.GetComponent<SpriteRenderer>().material.color = new Color(0, 0, 0, i);
                
            }
        }
    }
    async void DoSomething()
    {
        await Task.Delay((int)clip.length * 1000 + 1000);
        start = true;
    }
}
