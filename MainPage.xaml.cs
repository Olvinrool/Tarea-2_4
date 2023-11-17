using Microsoft.Maui.Controls;

using System;
using System.IO;

namespace Tarea2_4
{
    public partial class MainPage : ContentPage
    {
        private string videoPath;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnRecordVideoClicked(object sender, EventArgs e)
        {
            try
            {
                var options = new MediaCaptureVideoOptions
                {
                    MaximumRecordingTime = TimeSpan.FromSeconds(30),
                };

                var result = await MediaPicker.CaptureVideoAsync(options);

                if (result != null)
                {
                    videoPath = result.FullPath;
                    videoView.Source = videoPath;
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
            }
        }
    }
}

    internal class MediaCaptureVideoOptions : MediaPickerOptions
    {
        public TimeSpan MaximumRecordingTime { get; set; }
    }
}
