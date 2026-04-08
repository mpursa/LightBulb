using System;
using System.Collections.Generic;
using LightBulb.Framework;
using LightBulb.Localization;
using LightBulb.Services;

namespace LightBulb.ViewModels.Components.Settings;

public class AdvancedSettingsTabViewModel(
    SettingsService settingsService,
    LocalizationManager localizationManager
) : SettingsTabViewModelBase(settingsService, localizationManager, 2)
{
    public override string DisplayName => LocalizationManager.AdvancedTabName;

    public IReadOnlyList<string> AvailableThemes { get; } = localizationManager.ThemeEnumLocalized;

    public ThemeVariant Theme
    {
        get => SettingsService.Theme;
        set => SettingsService.Theme = value;
    }

    public string ThemeLocalized
    {
        get => LocalizationManager.LocalizeTheme(Theme);
        //set => Theme = LocalizationManager.ThemeFromLocalization(value ?? ThemeLocalized);
        set
        {
            if (value == null)
                return;
            Theme = LocalizationManager.ThemeFromLocalization(value);
        }
    }

    public IReadOnlyList<string> AvailableLanguages { get; } =
        localizationManager.LanguageEnumLocalized;

    public Language Language
    {
        get => SettingsService.Language;
        set => SettingsService.Language = value;
    }

    public string LanguageLocalized
    {
        get => LocalizationManager.LocalizeLanguage(Language);
        // set => Language = LocalizationManager.LanguageFromLocalization(value ?? LanguageLocalized);
        set
        {
            if (value == null)
                return;
            Language = LocalizationManager.LanguageFromLocalization(value);
        }
    }

    public bool IsAutoStartEnabled
    {
        get => SettingsService.IsAutoStartEnabled;
        set => SettingsService.IsAutoStartEnabled = value;
    }

    public bool IsAutoUpdateEnabled
    {
        get => SettingsService.IsAutoUpdateEnabled;
        set => SettingsService.IsAutoUpdateEnabled = value;
    }

    public bool IsDefaultToDayConfigurationEnabled
    {
        get => SettingsService.IsDefaultToDayConfigurationEnabled;
        set => SettingsService.IsDefaultToDayConfigurationEnabled = value;
    }

    public bool IsConfigurationSmoothingEnabled
    {
        get => SettingsService.IsConfigurationSmoothingEnabled;
        set => SettingsService.IsConfigurationSmoothingEnabled = value;
    }

    public bool IsPauseWhenFullScreenEnabled
    {
        get => SettingsService.IsPauseWhenFullScreenEnabled;
        set => SettingsService.IsPauseWhenFullScreenEnabled = value;
    }

    public bool IsGammaPollingEnabled
    {
        get => SettingsService.IsGammaPollingEnabled;
        set => SettingsService.IsGammaPollingEnabled = value;
    }
}
