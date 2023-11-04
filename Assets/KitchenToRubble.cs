using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class KitchenToRubble : MonoBehaviour
{

    void Start()
    {
        DoSomething2();
    }
    
    
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;
    async void DoSomething()
    {
        await Task.Delay(3000 * 60);
        source.PlayOneShot(clip);
        
    }

    async void DoSomething2()
    {
        await Task.Delay(30000);
        SceneManager.LoadScene("Rubble");
    }
}