using System.Collections.Generic;

namespace LightBulb.Localization;

public partial class LocalizationManager
{
    private static readonly IReadOnlyDictionary<string, string> ItalianLocalization =
        new Dictionary<string, string>
        {
            [nameof(SunsetLabel)] = "Tramonto",
            [nameof(SunriseLabel)] = "Alba",
            [nameof(SunsetTransitionTooltip)] =
                "La transizione del tramonto inizia alle **{0}** e finisce alle **{1}**",
            [nameof(SunriseTransitionTooltip)] =
                "La transizione dell'alba inizia alle **{0}** e finisce alle **{1}**",
            [nameof(OffsetTooltipHeader)] =
                "I valori di temperatura e luminosità attuali saranno compensati di:",
            [nameof(TemperatureOffsetLabel)] = "Compensazione temperatura",
            [nameof(BrightnessOffsetLabel)] = "Compensazione luminosità:",
            [nameof(ClickToResetLabel)] = "Clicca per resettare",
            [nameof(OffsetLabel)] = "compensazione",
            [nameof(ToggleLightBulbTooltip)] = "Attiva/disattiva LightBulb",
            [nameof(HideToTrayTooltip)] = "Nascondi LightBulb nell'area di notifica",
            [nameof(PreviewText)] = "ANTEPRIMA",
            [nameof(StopPreviewTooltip)] = "Interrompi anteprima",
            [nameof(StartPreviewTooltip)] = "Anteprima del ciclo giornaliero",
            [nameof(SettingsText)] = "IMPOSTAZIONI",
            [nameof(OpenSettingsTooltip)] = "Apri impostazioni",
            [nameof(ResetButton)] = "RESETTA",
            [nameof(ResetTooltip)] = "Resetta tutte le impostazioni alle predefinite",
            [nameof(CancelButton)] = "CANCELLA",
            [nameof(SaveButton)] = "SALVA",
            [nameof(GeneralTabName)] = "Generali",
            [nameof(LocationTabName)] = "Posizione",
            [nameof(AdvancedTabName)] = "Avanzate",
            [nameof(AppWhitelistTabName)] = "Lista bianca",
            [nameof(HotkeysTabName)] = "Tasti rapidi",
            [nameof(ThemeLabel)] = "Tema",
            [nameof(ThemeTooltip)] = "Tema preferito dell'interfaccia utente",
            [nameof(LanguageLabel)] = "Lingua",
            [nameof(LanguageTooltip)] = "Lingua preferita dell'interfaccia utente",
            [nameof(StartWithWindowsLabel)] = "Avvia con Windows",
            [nameof(StartWithWindowsTooltip)] = "Avvia LightBulb all'avvio di Windows",
            [nameof(AutoUpdateLabel)] = "Aggiornamento automatico",
            [nameof(AutoUpdateTooltip)] =
                "Aggiorna LightBulb installando automaticamente le nuove versioni quando diventano disponibili",
            [nameof(DefaultToDayConfigLabel)] = "Imposta la configurazione diurna come predefinita",
            [nameof(DefaultToDayConfigTooltip)] =
                "Quando LightBulb è disabilitato o in pausa, ripristina la temperatura e la luminosità diurne configurate anziché la gamma predefinita del monitor",
            [nameof(PauseWhenFullscreenLabel)] = "Interrompi quando a schermo intero",
            [nameof(PauseWhenFullscreenTooltip)] =
                "Interrompi LightBulb quando una finestra a schermo intero è in primo piano",
            [nameof(GammaSmoothingLabel)] = "Attenuazione gamma",
            [nameof(GammaSmoothingTooltip)] =
                "Attiva o disattiva LightBulb gradualmente per dare agli occhi il tempo di adattarsi.",
            [nameof(GammaPollingLabel)] = "Aggiornamento gamma",
            [nameof(GammaPollingTooltip)] =
                "Forza l'aggiornamento della gamma dello schermo a intervalli regolari per impedire ad altri programmi di sovrascriverla",
            [nameof(DayTemperatureLabel)] = "Temperatura colore diurna:",
            [nameof(DayTemperatureTooltip)] = "Temperatura del colore durante il giorno",
            [nameof(NightTemperatureLabel)] = "Temperatura colore notturna:",
            [nameof(NightTemperatureTooltip)] = "Temperatura del colore durante la notte",
            [nameof(DayBrightnessLabel)] = "Luminosità diurna:",
            [nameof(DayBrightnessTooltip)] = """
                Luminosità durante il giorno

                Nota che questa impostazione di luminosità si applica alla gamma cromatica, non alla luminosità effettiva del monitor.
                Se il tuo computer è già in grado di regolare automaticamente la luminosità dello schermo in base alle condizioni di illuminazione (come avviene comunemente nei computer portatili), si consiglia di disabilitare il controllo della luminosità di LightBulb mantenendo entrambe le impostazioni di luminosità al 100%.
                """,
            [nameof(NightBrightnessLabel)] = "Luminosità notturna:",
            [nameof(NightBrightnessTooltip)] = """
                Luminosità durante la notte

                Nota che questa impostazione di luminosità si applica alla gamma cromatica, non alla luminosità effettiva del monitor.
                Se il tuo computer è già in grado di regolare automaticamente la luminosità dello schermo in base alle condizioni di illuminazione (come avviene comunemente nei computer portatili), si consiglia di disabilitare il controllo della luminosità di LightBulb mantenendo entrambe le impostazioni di luminosità al 100%.
                """,
            [nameof(TransitionDurationLabel)] = "Durata transizione:",
            [nameof(TransitionDurationTooltip)] =
                "Durata del tempo necessario per passare dalla configurazione diurna a quella notturna",
            [nameof(TransitionOffsetLabel)] = "Compensazione transizione:",
            [nameof(TransitionOffsetTooltip)] =
                "Specifica quanto presto o tardi inizia la transizione, rispetto all'alba e al tramonto",
            [nameof(SolarConfigLabel)] = "Configurazione luce solare:",
            [nameof(ManualLabel)] = "Manuale",
            [nameof(ManualTooltip)] = "Configura orario di alba e tramonto manualmente",
            [nameof(LocationBasedLabel)] = "Basato su posizione",
            [nameof(LocationBasedTooltip)] =
                "Configura la tua posizione e utilizzala per calcolare automaticamente gli orari di alba e tramonto",
            [nameof(SunriseTimeLabel)] = "Alba:",
            [nameof(SunsetTimeLabel)] = "Tramonto:",
            [nameof(YourLocationLabel)] = "Tua posizione:",
            [nameof(AutoDetectLocationTooltip)] =
                "Prova a rilevare automaticamente la posizione in base al tuo indirizzo IP",
            [nameof(LocationQueryTooltip)] = """
                Specifica la tua posizione utilizzando le coordinate geografiche o una ricerca

                Esempi di input validi:
                **41.25, -120.9762**
                **41.25°N, 120.9762°W**
                **New York, USA**
                **Germany**
                """,
            [nameof(SetLocationTooltip)] = "Imposta posizione",
            [nameof(LocationErrorText)] = "Errore nella ricerca della posizione, prova di nuovo",
            [nameof(ToggleLightBulbHotkeyLabel)] = "Attiva/disattiva LightBulb",
            [nameof(ToggleLightBulbHotkeyTooltip)] =
                "Tasto rapido per attivare/disattivare LighBulb",
            [nameof(ToggleWindowLabel)] = "Mostra/nascondi finestra",
            [nameof(ToggleWindowHotkeyTooltip)] =
                "Tasto rapido per mostrare/nascondere la finestra principale di LightBulb",
            [nameof(IncreaseTemperatureOffsetLabel)] = "Aumenta temperatura",
            [nameof(IncreaseTemperatureOffsetTooltip)] =
                "Tasto rapido per aumentare la compensazione della temperatura attuale",
            [nameof(DecreaseTemperatureOffsetLabel)] = "Diminuisci temperatura",
            [nameof(DecreaseTemperatureOffsetTooltip)] =
                "Tasto rapido per diminuire la compensazione della temperatura attuale",
            [nameof(IncreaseBrightnessOffsetLabel)] = "Aumenta luminosità",
            [nameof(IncreaseBrightnessOffsetTooltip)] =
                "Tasto rapido per aumentare la compensazione della luminosità attuale",
            [nameof(DecreaseBrightnessOffsetLabel)] = "Diminuisci luminosità",
            [nameof(DecreaseBrightnessOffsetTooltip)] =
                "Tasto rapido per diminuire la compensazione della luminosità attuale",
            [nameof(ResetOffsetLabel)] = "Resetta compensazione",
            [nameof(ResetOffsetHotkeyTooltip)] =
                "Tasto rapido per resettare la compensazione della luminosità e temperatura attuali",
            [nameof(AppWhitelistLabel)] = "Lista bianca applicazioni",
            [nameof(RefreshAppsTooltip)] = "Aggiorna applicazioni attive",
            [nameof(PauseForWhitelistedTooltip)] =
                "Metti in pausa LightBulb quando una delle applicazioni selezionate è in primo piano",
            [nameof(TrayShowHideMenuItem)] = "Mostra/nascondi",
            [nameof(TraySettingsMenuItem)] = "Impostazioni",
            [nameof(TrayToggleMenuItem)] = "Attiva/disattiva",
            [nameof(TrayDisableMenuItem)] = "Disattiva...",
            [nameof(TrayDisableUntilSunriseMenuItem)] = "Fino all'alba",
            [nameof(TrayDisableFor1DayMenuItem)] = "Per 1 giorno",
            [nameof(TrayDisableFor12HoursMenuItem)] = "Per 12 ore",
            [nameof(TrayDisableFor6HoursMenuItem)] = "Per 6 ore",
            [nameof(TrayDisableFor3HoursMenuItem)] = "Per 3 ore",
            [nameof(TrayDisableFor1HourMenuItem)] = "Per 1 ora",
            [nameof(TrayDisableFor30MinutesMenuItem)] = "Per 30 minuti",
            [nameof(TrayDisableFor15MinutesMenuItem)] = "Per 15 minuti",
            [nameof(TrayDisableFor5MinutesMenuItem)] = "Per 5 minuti",
            [nameof(TrayDisableFor1MinuteMenuItem)] = "Per 1 minuto",
            [nameof(TrayExitMenuItem)] = "Esci",
            [nameof(UpdateAvailableTitle)] = "Aggiornamento disponibile",
            [nameof(UpdateAvailableMessage)] = """
                L'aggiornamento di {0} v{1} è stato scaricato.
                Vuoi installarlo adesso?
                """,
            [nameof(InstallButton)] = "INSTALLA",
            [nameof(CloseButton)] = "CHIUDI",
            [nameof(UkraineSupportTitle)] = "Grazie per il tuo supporto all'Ucraina!",
            [nameof(UkraineSupportMessage)] = """
                Mentre la Russia conduce una guerra genocida contro il mio paese, sono grato a tutti coloro che continuano a sostenere l'Ucraina nella nostra lotta per la libertà.

                Clicca SCOPRI DI PIÙ per scoprire come puoi aiutare.
                """,
            [nameof(LearnMoreButton)] = "SCOPRI DI PIÙ",
            [nameof(UnstableBuildTitle)] = "Avviso di versione instabile",
            [nameof(UnstableBuildMessage)] = """
                Stai utilizzando una versione di sviluppo di {0}. Queste versioni non sono state testate a fondo e potrebbero contenere bug.

                Gli aggiornamenti automatici sono disabilitati per le versioni di sviluppo. Se desideri passare a una versione stabile, scaricala manualmente.
                """,
            [nameof(SeeReleasesButton)] = "VEDI VERSIONI",
            [nameof(LimitedGammaRangeTitle)] = "Range di gamma limitato",
            [nameof(LimitedGammaRangeMessage)] = """
                {0} ha rilevato che i controlli della gamma estesa non sono abilitati su questo sistema.
                Ciò potrebbe causare il malfunzionamento di alcune configurazioni del colore.

                Premi RISOLVI per sbloccare la gamma. Potrebbero essere necessari i privilegi da amministratore.
                """,
            [nameof(FixButton)] = "RISOLVI",
            [nameof(WelcomeTitle)] = "Benvenuto!",
            [nameof(WelcomeMessage)] = """
                Grazie per aver installato {0}!
                Per un'esperienza più personalizzata, imposta la configurazione di luce solare che preferisci.

                Premi OK per aprire le impostazioni.
                """,
            [nameof(OkButton)] = "OK",
        };
}
