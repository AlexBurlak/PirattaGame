using UnityEngine;

public class SettingsManager
{
    private static SettingsManager _settingsManager;
    public int Difficulty { get; set; }
    public static SettingsManager Instance { 
        get
        {
            if (_settingsManager == null) _settingsManager = new SettingsManager();
            return _settingsManager;
        } 
    }

    private SettingsManager()
    {

    }
}
