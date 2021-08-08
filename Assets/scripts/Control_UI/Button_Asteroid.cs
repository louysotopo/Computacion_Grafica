using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Asteroid : MonoBehaviour
{
    // Start is called before the first frame update
    int flag = 1;
    public Button m_Asteroid, m_Planet_1, m_Planet_2,m_close,m_back;
    public GameObject m_Panel_Asteroid, m_Panel_Planet_1, m_Panel_Planet_2,m_Panel;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_Asteroid.onClick.AddListener(OpenPanelAsteroid);
        m_Planet_1.onClick.AddListener(OpenPanelPlanet1);
        m_Planet_2.onClick.AddListener(OpenPanelPlanet2);
        m_close.onClick.AddListener(CloseSimulation);
        m_back.onClick.AddListener(BackButton);
        //m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        //7m_YourThirdButton.onClick.AddListener(() => ButtonClicked(42));
        //m_YourThirdButton.onClick.AddListener(TaskOnClick);
    }
    void OpenPanelAsteroid()
    {
        Debug.Log("Panel Asteorid");
        m_Panel_Asteroid.gameObject.SetActive(true);
        m_Panel_Planet_1.gameObject.SetActive(false);
        m_Panel_Planet_2.gameObject.SetActive(false);
    }
    void OpenPanelPlanet1()
    {
        Debug.Log("Panel Planet 1");
        m_Panel_Asteroid.gameObject.SetActive(false);
        m_Panel_Planet_1.gameObject.SetActive(true);
        m_Panel_Planet_2.gameObject.SetActive(false);
    }
    void OpenPanelPlanet2()
    {
        Debug.Log("Panel Planet 2");
        m_Panel_Asteroid.gameObject.SetActive(false);
        m_Panel_Planet_1.gameObject.SetActive(false);
        m_Panel_Planet_2.gameObject.SetActive(true);
    }
    void BackButton()
    {
        SceneManager.LoadScene("Menu 1");
    }
    void CloseSimulation()
    {
        if (flag == 1)
        {
            m_Panel.gameObject.SetActive(false);
            flag = 0;
        }
        else
        {
            m_Panel.gameObject.SetActive(true);
            flag = 1;
        }
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }

}
