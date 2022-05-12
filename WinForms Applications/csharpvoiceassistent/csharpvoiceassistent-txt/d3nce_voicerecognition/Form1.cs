using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using System.Net;
using AudioSwitcher.AudioApi.CoreAudio;
using Newtonsoft.Json;
using OpenWeatherMap;

namespace d3nce_voicerecognition
{
    public partial class Form1 : MaterialForm
    {
        #region Deklaration der Engine und variablen
        SpeechRecognitionEngine h = new SpeechRecognitionEngine();
        SpeechSynthesizer s = new SpeechSynthesizer();

        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        //Boolean für den Ruhemodus
        public Boolean hören = true;

        //Boolean für die Google suche
        public Boolean suche = false;

        //Boolean für die Wikipedia suche
        public Boolean wasist = false;

        //Verzeichnis URI
        public string vuri = "C:\\Users\\***\\Visual Studio";

        #endregion

        #region Startup Configuration
        public Form1()
        {
            InitializeComponent();

            //initialisierung aller Dienste
            GetWeatherData();

            //GUI 
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red600, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        #endregion

        #region Core
        private void Form1_Load(object sender, EventArgs e)
        {
            //GUI time und date
            lbl_time.Text = DateTime.Now.ToShortTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();

            tab_control.SelectTab(tab_text);

            //commands
            Choices commands = new Choices();
            string path = Directory.GetCurrentDirectory() + "\\commands.txt";
            commands.Add(File.ReadAllLines(path));

            //grammar
            GrammarBuilder gbuilder = new GrammarBuilder();
            gbuilder.Append(commands);

            //grammar (nicht genutzt in dieser version)
            Grammar grammar = new Grammar(gbuilder);
            DictationGrammar dgrammar = new DictationGrammar();

            //laden aller Engines
            h.LoadGrammarAsync(grammar);

            h.SetInputToDefaultAudioDevice();
            h.SpeechRecognized += recEngine_SpeechRecognized;

            h.RecognizeAsync(RecognizeMode.Multiple);
            s.SelectVoiceByHints(VoiceGender.Female,VoiceAge.Adult);

            s.SpeakAsync("Wie kann ich dir helfen");
        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //bedingungen für ruhemodus
            string modus = e.Result.Text;

            if (modus == "sprich")
            {
                hören = true;
            }
            if (modus == "still")
            {
                hören = false;
            }

            #region google suche core
            //google suche
            if (suche)
            {
                tab_control.SelectTab(tab_browser);
                this.brow_main.Navigate("https://www.google.de/search?hl=de&source=hp&ei=Q4-lWrq1BIWWsAep25jwDA&q=" + modus);
                suche = false;
            }
            #endregion

            #region wikipedia suche core

            //wikipedia suche
            if (wasist)
            {
                try
                {
                s.SpeakAsync(
                    "Das Internet sagt dazu folgendes:");
                lbl_ans.Text = "Das Internet sagt dazu folgendes";

                WebClient client = new WebClient();

                using (Stream stream =
                    client.OpenRead(
                        "http://de.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles=" + modus)
                )
                using (StreamReader reader = new StreamReader(stream))
                {
                    JsonSerializer ser = new JsonSerializer();
                    Result result = ser.Deserialize<Result>(new JsonTextReader(reader));

                    foreach (Page page in result.query.pages.Values)
                        txt_info.Text = page.extract;

                    string antwort = txt_info.Text;

                    string small = antwort.Substring(0, 500);

                    s.SpeakAsync(small);
                }

                wasist = false;
                }
                catch (Exception)
                {
                    s.SpeakAsync("Nichts, es sagt nichts, komisch, sehr komisch, du musst da wohl was durcheinander gebracht haben. Ich sschüttel den Google automaten aber da kommt nur leeres klimpern! Versuch es noch einmal.");
                    wasist = false;
                }
            }
            #endregion

            if (hören == true && suche == false && wasist == false) 
            {
                lbl_quest.Text = e.Result.Text;
                switch (e.Result.Text)
                {
                    #region hallo

                    case "hallo":
                        s.SpeakAsync("hallo dence");
                        lbl_ans.Text = "hallo d3nce";
                        tab_control.SelectTab(tab_home);
                        break;

                    #endregion

                    #region wie geht es dir

                    case "wie geht es dir":
                        s.SpeakAsync("gut und dir");
                        lbl_ans.Text = "gut und dir?";
                        tab_control.SelectTab(tab_home);
                        break;

                    #endregion

                    #region welcher tag ist heute

                    case "welcher tag ist heute":
                        s.SpeakAsync("heute ist der " + DateTime.Now.ToString("d"));
                        lbl_ans.Text = "heute ist der " + DateTime.Now.ToString("d");
                        tab_control.SelectTab(tab_home);
                        break;

                    #endregion

                    #region wie spät ist es

                    case "wie spät ist es":
                        s.SpeakAsync("es ist " + DateTime.Now.ToString("HH:mm"));
                        lbl_ans.Text = "es ist " + DateTime.Now.ToString("HH:mm") + "Uhr";
                        tab_control.SelectTab(tab_home);
                        break;

                    #endregion

                    #region youtube ist da

                    case "youtube ist da":
                        s.SpeakAsync(
                            "Wunderbar, Willkommen bei einem neuen Tutorial zum Thema Artificial Intelligence. Viel Spaß dabei");
                        lbl_ans.Text = "Wunderbar, Willkommen bei einem...";
                        break;

                    #endregion

                    #region Wikipedia

                    case "was ist":
                        wasist = true;
                        tab_control.SelectTab(tab_wiki);
                        break;

                    #endregion

                    #region Verzeichnis Status

                    case "informationen verzeichnis":
                        tab_control.SelectTab(tab_browser);
                        this.brow_main.Navigate("C:\\Users\\Freddy\\Visual Studio");

                        string pfad = "C:\\Users\\Freddy\\Visual Studio";

                        var anzahlordner = Directory.GetDirectories(pfad).Length;
                        var anzahldaten = Directory.GetFiles(pfad).Length;

                        s.SpeakAsync("In dem momentan ausgewähltem verzeichnis" + brow_main.DocumentTitle +
                                     "befinden sich" + anzahlordner + "ordner und" + anzahldaten + "dateien");
                        lbl_ans.Text = "Dein Verzeichnis" + brow_main.DocumentTitle;
                        break;

                    #endregion

                    #region Ordner auflisten

                    case "welche ordner sind in meinem verzeichnis":
                        tab_control.SelectTab(tab_browser);
                        string pfad2 = Convert.ToString(brow_main.Url);
                        pfad = pfad2.Substring(8);

                        string[] ordnernamen = Directory.GetDirectories(pfad);

                        foreach (string name in ordnernamen)
                        {
                            FileInfo f = new FileInfo(name);
                            txt_info.AppendText(f.Name + "\n");
                        }

                        s.SpeakAsync("In deinem verzeichnis existieren folgende ordner" + txt_info.Text);
                        lbl_ans.Text = "Deine Ordner lauten";

                        break;

                    #endregion

                    #region Window Size
                    case "vollbild":
                        this.WindowState = FormWindowState.Maximized;
                        s.SpeakAsync(
                            "Da bin ich, ich bin groß");
                        lbl_ans.Text = "Vollbildmodus aktiviert";
                        tab_control.SelectTab(tab_text);
                        break;

                    case "verschwinde":
                        this.WindowState = FormWindowState.Minimized;
                        s.SpeakAsync(
                            "ok du willst mich wohl nichtmehr sehen");
                        lbl_ans.Text = "Vollbildmodus aktiviert";
                        tab_control.SelectTab(tab_text);
                        break;

                    case "zeig dich":
                        this.WindowState = FormWindowState.Normal;
                        s.SpeakAsync(
                            "hier bin ich wieder");
                        lbl_ans.Text = "Vollbildmodus aktiviert";
                        tab_control.SelectTab(tab_text);
                        break;
                    #endregion

                    #region Wetter
                    case "wie ist das wetter":
                        tab_control.SelectTab(tab_home);
                        GetWeather();
                        lbl_ans.Text = "Das wetter ist";
                        break;
                    #endregion
                         
                    #region lautstärke

                    //volume mute
                    case "ton ausschalten":
                        tab_control.SelectTab(tab_text);
                        defaultPlaybackDevice.Mute(true);
                        break;

                    //volume on
                    case "ton einschalten":
                        tab_control.SelectTab(tab_text);
                        defaultPlaybackDevice.Mute(false);
                        break;

                    //lautstärke hoch
                    case "lauter":
                        tab_control.SelectTab(tab_text);
                        defaultPlaybackDevice.Volume = 80;
                        break;

                    //lautstärke tief
                    case "leiser":
                        tab_control.SelectTab(tab_text);
                        defaultPlaybackDevice.Volume = 20;
                        break;
                    #endregion

                    #region google suche
                    case "suche nach":
                        suche = true;
                        break;

                    #endregion

                    #region zwischenablage vorlesen
                    case "lies mir vor":
                        tab_control.SelectTab(tab_wiki);
                        String zwischenablage = null;
                        if (Clipboard.ContainsText())
                        {
                            zwischenablage = Clipboard.GetText();
                            txt_info.Text = zwischenablage;
                            s.SpeakAsync(zwischenablage);
                        }
                        break;
                    #endregion

                    #region erzähl mir etwas über dich
                    case "wer bist du":
                        s.SpeakAsync("Ich soll dir etwas über mich erzählen? ok!");
                        s.SpeakAsync("wenn du sprichst erhalte ich" + h.AudioFormat);
                        s.SpeakAsync("im moment höre ich dich mit einer lautstärke von" + h.AudioLevel);
                        s.SpeakAsync("Mehr Infos über mich findest du unter" + h.RecognizerInfo);
                        s.SpeakAsync("Die maximale anzahl von erkennungsergebnissen für eine operation ist" + h.MaxAlternates);
                        s.SpeakAsync("Momentan bin ich auf" + h.AudioState + "geschaltet");
                        break;
                    #endregion

                    #region musik
                    case "spiel musik":
                        tab_control.SelectTab(tab_media);

                        media_main.URL = Directory.GetCurrentDirectory() + "\\music\\Instrumental 1.mp3";
                        media_main.Ctlcontrols.play();

                        break;
                    case "musik stoppen":
                        tab_control.SelectTab(tab_media);

                        media_main.Ctlcontrols.stop();

                        break;
                    case "musik pausieren":
                        tab_control.SelectTab(tab_media);

                        media_main.Ctlcontrols.pause();

                        break;
                    case "musik fortsetzten":
                        tab_control.SelectTab(tab_media);

                        media_main.Ctlcontrols.play();

                        break;
                    case "musik lauter":
                        tab_control.SelectTab(tab_media);

                        media_main.settings.volume = +80;

                        break;
                    case "musik leiser":
                        tab_control.SelectTab(tab_media);

                        media_main.settings.volume = +20;
                        break;
                    #endregion

                    #region spotify
                    case "spotify abspielen":
                        Process.Start("C:\\Users\\***\\AppData\\Roaming\\Spotify\\Spotify.exe");
                        System.Threading.Thread.Sleep(5000);
                        SendKeys.Send(" ");
                        break;

                    case "spotify pausieren":
                        Process.Start("C:\\Users\\***\\AppData\\Roaming\\Spotify\\Spotify.exe");
                        System.Threading.Thread.Sleep(5000);
                        SendKeys.Send(" ");
                        break;
                    #endregion

                    #region 3
                    case "neue whatsapp nachrichten":
                        s.SpeakAsync("Du hast neue whatsapp nachrichten");
                        s.SpeakAsync("sie lauten wie folgt");
                        break;
                        #endregion




                }

            }


        }
        #endregion

        #region Methoden für Wikipedia
        public class Result
        {
            public Query query { get; set; }
        }

        public class Query
        {
            public Dictionary<string, Page> pages { get; set;}
        }

        public class Page
        {
            public string extract { get; set;}
        }
        #endregion

        #region Methoden für Wetter
        async void GetWeather()
        {
            var client = new OpenWeatherMapClient("d912e2792e6814cb36463f2b39ee4f66");
            var currentWeather = await client.CurrentWeather.GetByName("Hamburg");

            int Temperatur = Convert.ToInt16(currentWeather.Temperature.Value / 32);

            s.SpeakAsync("der himmel ist:" + currentWeather.Weather.Value);
            s.SpeakAsync("der himmel ist:" + currentWeather.Temperature.Value);
            lbl_weather.Text = currentWeather.Weather.Value;
            s.SpeakAsync("und die aktuelle Temperatur beträgt:" + Temperatur + "Grad Celsius");
            lbl_temp.Text = Temperatur + " Grad Celsius";

        }
        async void GetWeatherData()
        {
            var client = new OpenWeatherMapClient("d912e2792e6814cb36463f2b39ee4f66");
            var currentWeather = await client.CurrentWeather.GetByName("Hamburg");

            int Temperatur = Convert.ToInt16(currentWeather.Temperature.Value / 32);
            lbl_weather.Text = Convert.ToString(currentWeather.Weather.Value);
            lbl_temp.Text = Temperatur + " Grad Celsius";
        }
        #endregion

    }
}

