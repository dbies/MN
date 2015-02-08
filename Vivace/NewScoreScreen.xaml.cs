using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Vivace
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewScoreScreen : Page
    {
        const int MAX_MEASURES=50;
        Score mScore;
        public NewScoreScreen()
        {
            this.InitializeComponent();
            
        }

       
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if ((ComposerTextBox.Text != "") && (ArrangerTextBox.Text != "") && (LyricistTextBox.Text != "") && (TitleTextBox.Text != "") && (CopyrightTextBox.Text != "") && (MeasureNumberTextBox.Text!="") && InstrumentListView.SelectedItems.Count>0 )
            {
               // int n;
                //bool isNumberis=int.TryParse(Convert.ToInt32(MeasureNumberTextBox.Text), out n);
                if (Convert.ToInt32(MeasureNumberTextBox.Text) > MAX_MEASURES)
                {
                    throw(new Exception());
                }
                //Check for validity, etc.
                mScore = new Score(ComposerTextBox.Text, ArrangerTextBox.Text, LyricistTextBox.Text, TitleTextBox.Text, CopyrightTextBox.Text, 4);
                List<string> instruments = new List<string>();
                for (int i = 0; i < InstrumentListView.SelectedItems.Count; i++)
                {
                    instruments.Add(InstrumentListView.SelectedItems[i].ToString());
                }
                mScore.addInstruments(instruments);
                this.Frame.Navigate(typeof(EditScore), mScore);
            }
            else
            {
                //error handle
            }
        }
    }
}
