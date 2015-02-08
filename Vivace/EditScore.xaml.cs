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
    public sealed partial class EditScore : Page
    {
        Score mScore = null;
        public EditScore()
        {  
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            mScore = e.Parameter as Score;
            mScore.Initialize();
            TitleBlock.Text = mScore.Title;
            RightTextBox.Text = mScore.Composer + "\n" + mScore.Arranger + "\n" +mScore.Lyricist+"\n";;
            DrawDefaultMeasures();


            
            //for (int i = 0; i < mScore.NumberOfInstruments(); i++)
            //{
            //    break;
            //}
            //    Display();
            //if (mScore != null)
            //{
            //    System.Diagnostics.Debug.WriteLine(mScore.ToString());
            //}
            //else
            //{
            //    throw (new Exception());
            //}
        }
        public void Display()
        {
            
        }
        private void DrawDefaultMeasures() {
            int _num_staffs = 4;
            
            scoreBox.FontFamily = new FontFamily("Symbola");
            int fontSize = 70;
            scoreBox.FontSize = fontSize;
            int numStaffInLine = 12;
            scoreBox.Text += NoteType.noteMap["Single Barline"];
            for (int i = 1; i <= numStaffInLine; i++)
            {
                scoreBox.Text = scoreBox.Text + NoteType.noteMap["Five Line Staff"];

                if (i % 3 == 0)
                {
                    if (i != numStaffInLine)
                        scoreBox.Text += NoteType.noteMap["Single Barline"];
                    mScore.GetStaff(0).CreateNewMeasure();

                }
                
            }
            scoreBox.Text = scoreBox.Text + NoteType.noteMap["Final Barline"];
        }

        void AddNoteButton_Click(object sender, RoutedEventArgs e)
        {
            if (NoteListBox.Visibility == Visibility.Collapsed)
            {

                for (int i = 0; i < 10; i++)
                {
                    ListBoxItem itm = new ListBoxItem();
                    itm.Name = NoteType.noteMap.ElementAt(i).Key;
                    itm.Content = NoteType.noteMap.ElementAt(i).Value;
                    itm.HorizontalContentAlignment = HorizontalAlignment.Center;
                    NoteListBox.Items.Add(itm);
                    NoteListBox.Visibility = Windows.UI.Xaml.Visibility.Visible;

                }
            }
            else if (NoteListBox.Visibility == Visibility.Visible)
            {
                NoteListBox.Visibility = Visibility.Collapsed;
            }
        }

        String PlaceSelectedNote()
        {
            return "";
        }

        //private void scoreBox_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    if (NoteListBox.Visibility ==Visibility.Visible && NoteListBox.SelectedIndex != -1)
        //    {
        //        ListBoxItem lb = (ListBoxItem)(NoteListBox.SelectedValue);
        //        Note nt = new Note(lb.Name);
        //        Staff mStaff= mScore.GetStaff(0);
        //        if (mStaff.GetNextMeasure() != null)
        //        {
        //            mStaff.GetNextMeasure().CreateNewNote(nt);
        //        }
            
               
        //    }
        //}

        private void FifthLineBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NoteListBox.Visibility == Visibility.Visible && NoteListBox.SelectedIndex != -1)
            {
                ListBoxItem lb = (ListBoxItem)(NoteListBox.SelectedValue);
                Note nt = new Note(lb.Name);
                Staff mStaff = mScore.GetStaff(0);
                if (mStaff.GetNextMeasure() != null)
                {
                    mStaff.GetNextMeasure().CreateNewNote(nt);
                }
                FifthLineBox.Text =FifthLineBox.Text + NoteType.noteMap[lb.Name];

            }
        }

        private void FourthLineBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NoteListBox.Visibility == Visibility.Visible && NoteListBox.SelectedIndex != -1)
            {
                ListBoxItem lb = (ListBoxItem)(NoteListBox.SelectedValue);
                Note nt = new Note(lb.Name);
                Staff mStaff = mScore.GetStaff(0);
                if (mStaff.GetNextMeasure() != null)
                {
                    mStaff.GetNextMeasure().CreateNewNote(nt);
                }
                FourthLineBox.Text += NoteType.noteMap[lb.Name];

            }
        }

        private void ThirdLineBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NoteListBox.Visibility == Visibility.Visible && NoteListBox.SelectedIndex != -1)
            {
                ListBoxItem lb = (ListBoxItem)(NoteListBox.SelectedValue);
                Note nt = new Note(lb.Name);
                Staff mStaff = mScore.GetStaff(0);
                if (mStaff.GetNextMeasure() != null)
                {
                    mStaff.GetNextMeasure().CreateNewNote(nt);
                }
                ThirdLineBox.Text += NoteType.noteMap[lb.Name];

            }
        }

        private void SecondLineBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NoteListBox.Visibility == Visibility.Visible && NoteListBox.SelectedIndex != -1)
            {
                ListBoxItem lb = (ListBoxItem)(NoteListBox.SelectedValue);
                Note nt = new Note(lb.Name);
                Staff mStaff = mScore.GetStaff(0);
                if (mStaff.GetNextMeasure() != null)
                {
                    mStaff.GetNextMeasure().CreateNewNote(nt);
                }
                SecondLineBox.Text += NoteType.noteMap[lb.Name];

            }
        }

        private void FirstLineBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NoteListBox.Visibility == Visibility.Visible && NoteListBox.SelectedIndex != -1)
            {
                ListBoxItem lb = (ListBoxItem)(NoteListBox.SelectedValue);
                Note nt = new Note(lb.Name);
                Staff mStaff = mScore.GetStaff(0);
                if (mStaff.GetNextMeasure() != null)
                {
                    mStaff.GetNextMeasure().CreateNewNote(nt);
                }
                FirstLineBox.Text += NoteType.noteMap[lb.Name];

            }
        }

        private void FifthLineBox_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

     
    }
}
