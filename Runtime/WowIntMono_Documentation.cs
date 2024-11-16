using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[HelpURL("https://github.com/EloiStree/2024_08_29_ScratchToWarcraft")]
public class WowIntgMono_Documentation : MonoBehaviour
{

    public string m_urlDocumentation = "https://github.com/EloiStree/2024_08_29_ScratchToWarcraft";
    public string m_urlPizzaLicense = "https://github.com/EloiStree/License";

    [TextArea(6, 6)]
    public string m_context = @"
    This project is a bridge between learning code and the warcraft world.
    Call 'Scratch To Warcraft' because designed for https://scratch.mit.edu at start.
    Look at WowIntegerWorkshop on GitHub if you look for other language.
    https://github.com/EloiStree
    May the code be with you.
    ";

    [ContextMenu("Open Documentation Url")]
    public void OpenDocumentationUrl()
    {
        Application.OpenURL(m_urlDocumentation);
    }
    [ContextMenu("Open License Url")]
    public void OpenLicenseUrl()
    {
        Application.OpenURL(m_urlPizzaLicense);
    }
}
