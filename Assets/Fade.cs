using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    [SerializeField] AudioClip Clip;
    [SerializeField] GameObject gaza;
    float i;
    bool start;
    // Start is called before the first frame update
    void Start()
    {
        i = 1;
        start = false;
        DoSomething();
        DoSomething2();
    }

    // Update is called once per frame
    void Update()
    {
        if(start == true)
        {
            if (i > 0)
                i -= 0.00005f;
            GetComponent<Renderer>().material.color = new Color(0, 0, 0, i);
        }
    }

    async void DoSomething()
    {
        await Task.Delay((int)Clip.length * 500-4000);
        start = true;
    }

    async void DoSomething2()
    {
        await Task.Delay((int)Clip.length * 1000 + 2000);
        SceneManager.LoadScene("kitchen");
    }
}
