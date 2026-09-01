using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelClear : MonoBehaviour
{
 
    [SerializeField] private GameObject _player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void ClearLevel()
    {
        Debug.Log("Level Cleared!");
        // Add logic to handle level clear, such as loading the next level or displaying a message
        SceneManager.LoadScene("Hard Mode");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _player)
        {
            ClearLevel();
        }
    }
}
