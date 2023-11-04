using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class FinallyHpspital : MonoBehaviour
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
        
    }

    async void DoSomething()
    {
        await Task.Delay((int)(clip.length * 1000));
        SceneManager.LoadScene("Hospital");
    }
}
