using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{

    public GameObject settingsMenu;

    public AudioMixer audioMixer;

    public Slider volumeSlider;
    public Slider sensSlider;
    public Dropdown qualityDropdown;

    public float sens;
    public float volume;
    public int _qualityIndex;

    public Dropdown resolutionDropdown;
    Resolution[] resolutions;

    private void Awake()
    {

        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();

        QualitySettings.vSyncCount = 0;

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        LoadResolutionSettings(currentResolutionIndex);

        LoadSettings();
    }

    private void Start()
    {

        audioMixer.SetFloat("volume", PlayerPrefs.GetFloat("Volume", volume));
    }

    public void OpenSettingsMenu()
    {
        settingsMenu.SetActive(true);
    }

    public void BackToMenu()
    {
        settingsMenu.SetActive(false);
        SaveSettings();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume()
    {
        volume = volumeSlider.value;
        audioMixer.SetFloat("volume", volume);
    }

    public void SetSens()
    {
        sens = sensSlider.value;
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("ResolutionPreference", resolutionDropdown.value);
        PlayerPrefs.SetFloat("VolumeSlider", volumeSlider.value);
        PlayerPrefs.SetFloat("Volume", volume);
        PlayerPrefs.SetFloat("Sens", sens);
        PlayerPrefs.SetFloat("SensSlider", sensSlider.value);
        PlayerPrefs.SetInt("Quality", _qualityIndex);
        PlayerPrefs.SetInt("QualityDropdown", qualityDropdown.value);
    }

    public void LoadSettings()
    {
        if (PlayerPrefs.HasKey("Quality"))
            _qualityIndex = PlayerPrefs.GetInt("Quality");
        else
            PlayerPrefs.SetInt("Quality", 1);

        if (PlayerPrefs.HasKey("QualityDropdown"))
            qualityDropdown.value = PlayerPrefs.GetInt("QualityDropdown");
        else
            PlayerPrefs.SetInt("QualityDropdown", 1);

        if (PlayerPrefs.HasKey("Sens"))
            sens = PlayerPrefs.GetFloat("Sens");
        else
            PlayerPrefs.SetFloat("Sens", 3.5f);

        if (PlayerPrefs.HasKey("SensSlider"))
            sensSlider.value = PlayerPrefs.GetFloat("SensSlider");
        else
            PlayerPrefs.SetFloat("SensSlider", 3.5f);

        if (PlayerPrefs.HasKey("VolumeSlider"))
            volumeSlider.value = PlayerPrefs.GetFloat("VolumeSlider");
        else
            PlayerPrefs.SetFloat("VolumeSlider", 1);
    }

    void LoadResolutionSettings(int currentResolutionIndex)
    {
        if (PlayerPrefs.HasKey("ResolutionPreference"))
            resolutionDropdown.value = PlayerPrefs.GetInt("ResolutionPreference");
        else
            resolutionDropdown.value = currentResolutionIndex;
    }

    public void SetQuality(int qualityIndex)
    {
        _qualityIndex = qualityIndex;
        Debug.Log(_qualityIndex);
        QualitySettings.SetQualityLevel(_qualityIndex);
    }

}
