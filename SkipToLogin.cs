using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using UnityEngine;
using UnityEngine.SceneManagement;

[BepInPlugin("com.staticextasy.SkipLogin", "Skip Login", "1.0.0")]
public class QuickCharacterSelect : BaseUnityPlugin
{
    private bool done = false;

    private void Update()
    {
        if (done) return;

        // Check if we are on the main menu before loading
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            SceneManager.LoadScene("LoadScene"); // <- Boom, straight to character selection!
            done = true;
            Logger.LogInfo("Directly loading LoadScene for Character Selection.");
        }
    }
}