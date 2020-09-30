using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ui_script : MonoBehaviour
{
    public static float musicVol = 1.0f;
    public static float sfxVol = 1.0f;
    public bool toggle;

    public void MusicSoundOff()
    {
        toggle = !toggle;

        if (toggle)
            musicVol = 0f;
    }

    public void MusicSoundOn()
    {
        toggle = !toggle;

        if (!toggle)
            musicVol = 1f;
    }
    public void SFXSoundOff()
    {
        toggle = !toggle;

        if (toggle)
            sfxVol = 0f;
    }

    public void SFXSoundOn()
    {
        toggle = !toggle;

        if (!toggle)
        sfxVol = 1f;
    }


    
    public void music_OnValueChanged( float value )
    {
        musicVol = value;
    }

    
    public void sfx_OnValueChanged(float value)
    {
        sfxVol = value;
    }

        public void ChangeScene_controls()
    {
        init_ui.menu = "controls";
        init_ui.playSfx = true;
    }

    
    public void ChangeScene_options()
    {
        init_ui.menu = "options";
        init_ui.playSfx = true;
    }

    public void ChangeScene_levelSelect()
    {
        init_ui.menu = "level";
        init_ui.playSfx = true;
    }

    public void ChangeScene_play()
    {
        SceneManager.LoadScene(1);
    }

    
    public void ChangeScene_start()
    {
        init_ui.menu = "start";
        init_ui.playSfx = true;
    }

    public void ChangeScene_shop()
    {
        init_ui.menu = "shop";
        init_ui.playSfx = true;
    }
    public void ChangeScene_audio()
    {
        init_ui.menu = "audio";
        init_ui.playSfx = true;
    }
    public void ChangeScene_difficulty()
    {
        init_ui.menu = "difficulty";
        init_ui.playSfx = true;
    }


    public void button_click()
    {
        init_ui.playSfx = true;

    }

    public void tick()
    {
        init_ui.playSfx1 = true;
    }
    public void QuitGame()
    {
        init_ui.playSfx = true;
        Application.Quit();
        Debug.Log("Quitted The game");
    }

    public void Match1 ()
    {
        init_ui.playSfx = true;
        init_ui.menu = "bug";
    }

}
