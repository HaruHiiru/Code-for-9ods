using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class Fade1 : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        DoSomething();
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
    }

    async void DoSomething()
    {
        await Task.Delay((int)(clip.length * 1000 - 700));
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 1);
        await Task.Delay(2000);
        SceneManager.LoadScene("Past 1");
    }
}
