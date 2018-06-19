using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Baidu.Aip.Speech;//baidu SDK
using System.Media;
/*
 * Author: Pdone
 * Create Date: 2017-12-13
 * GitHub: https://github.com/pdone/Text2Voice
 * Weibo: https://weibo.com/pdone/
*/
namespace Text2Voice
{
    public partial class Main : Form
    {
        /*0x000000*/
        //string APP_ID = "10523072";
        string API_KEY = "0Qr6nHXmGtCFD31ygXYWMAZG";
        string SECRET_KEY = "3a68f4475b803651ac3517459f690093";
        Color success = Color.SeaGreen;
        Color error = Color.Crimson;
        public Main()
        {
            InitializeComponent();
            _asrClient = new Asr(API_KEY, SECRET_KEY);
            _ttsClient = new Tts(API_KEY, SECRET_KEY);
        }

        private readonly Asr _asrClient;
        private readonly Tts _ttsClient;

        // 识别本地文件
        public void AsrData()
        {
            var data = File.ReadAllBytes("语音pcm文件地址");
            var result = _asrClient.Recognize(data, "pcm", 16000);
            Console.Write(result);
        }

        // 识别URL中的语音文件
        public void AsrUrl()
        {
            var result = _asrClient.Recoginze(
                "http://xxx.com/待识别的pcm文件地址",
                "http://xxx.com/识别结果回调地址",
                "pcm",
                16000);
            Console.WriteLine(result);
        }

        // 合成
        public void Tts(string text)
        {
            // 可选参数
            var option = new Dictionary<string, object>()
            {
                {"spd", 4}, // 语速
                {"vol", 7}, // 音量
                {"per", 4}  // 发音人，4：情感度丫丫童声
            };
            var result = _ttsClient.Synthesis(text, option);

            if (result.ErrorCode == 0)  // 或 result.Success
            {
                if (!Directory.Exists(@"E:\Text2Voice\"))
                {
                    Directory.CreateDirectory(@"E:\Text2Voice\");
                }
                string fileName = DateTime.Now.ToString("yyyyMMddHHmmss");
                string filePath = @"E:\Text2Voice\" + fileName + ".mp3";
                this.filePath = filePath;
                File.WriteAllBytes(filePath, result.Data);
                SetTipInfo(success, "Success");
            }
            else
            {
                SetTipInfo(error, "Error request");
            }
        }

        private void Conversion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
                    Tts(richTextBox1.Text.Trim());
                else
                    SetTipInfo(error, "Input something, please");
            }
            catch (Exception ex)
            {
                SetTipInfo(error, ex.Message);
            }
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(@"E:\Text2Voice\"))
                {
                    SetTipInfo(error, "Folder not exist");
                }
                else
                    System.Diagnostics.Process.Start(@"E:\Text2Voice");
            }
            catch (Exception ex)
            {
                SetTipInfo(error, ex.Message);
            }
        }

        public void PlaySound(string filePath = null)
        {
            try
            {
                filePath = this.filePath;
                if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath))
                {
                    MP3Player mp3 = new MP3Player(filePath);
                    mp3.Play();
                }
            }
            catch (Exception ex)
            {
                SetTipInfo(error, ex.Message);
            }
        }

        public string filePath { get; set; }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaySound_Click(object sender, EventArgs e)
        {
            try
            {
                PlaySound();
            }
            catch (Exception ex)
            {
                SetTipInfo(error, ex.Message);
            }
        }

        public void SetTipInfo(Color color, string info)
        {
            tipInfo.ForeColor = color;
            tipInfo.Text = info;
        }
    }
}
