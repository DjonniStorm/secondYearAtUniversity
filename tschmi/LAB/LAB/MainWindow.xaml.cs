using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, string> videoSources = new Dictionary<string, string> 
        {
            {"hl1",  @"Resources\\Video\\hl1.avi"  },
            {"hl2",  @"Resources\\Video\\hl2.avi"  },
            {"hlA",  @"Resources\\Video\\hlA.avi"  },
            {"CS2",  @"Resources\\Video\\CS2.mov"  },
            {"dota", @"Resources\\Video\\dota.avi" },
            {"tm2",  @"Resources\\Video\\tm2.avi"  },
            {"gm",   @"Resources\\Video\\gm.avi"   },
            {"WoT",  @"Resources\\Video\\WoT.avi"  },
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DescriptionButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string tag = button.Tag.ToString();
                if (videoSources.ContainsKey(tag))
                {
                    VideoElement.Source = new Uri( videoSources[tag],  UriKind.Relative );
                    VideoElement.Play();
                }
            }
        }

        private void Button_PauseVideo(object sender, RoutedEventArgs e)
        {
            VideoElement.Pause();
        }

        private void Button_PlayVideo(object sender, RoutedEventArgs e)
        {
            VideoElement.Play();
        }

        private void VideoAudioSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoElement.Volume = e.NewValue / 10;
        }
    }
}
