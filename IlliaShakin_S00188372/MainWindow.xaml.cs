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

namespace IlliaShakin_S00188372
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global List of games
        List<Game> AllGames;

        GameData db = new GameData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Games_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from g in db.Games
                        select g;

            AllGames = query.ToList();
            lbxGames.ItemsSource = AllGames;

            rAll.IsChecked = true;

        }

        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selectedGame = lbxGames.SelectedItem as Game;

            if(selectedGame != null)
            {
                imgGame.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
                tblkName.Text = selectedGame.Name;
                tblkMeta.Text = selectedGame.Metacritic.ToString();
                tblkPlatform.Text = selectedGame.Platform;
                tblkPrice.Text = $"{selectedGame.Price:C}";
                tblkDesc.Text = selectedGame.Description;
            }
        }

        private void rPC_Click(object sender, RoutedEventArgs e)
        {
            if(rPC.IsChecked == true)
            {
                var query = from g in db.Games
                            where g.Platform == "PC"
                            select g;
                AllGames = query.ToList();
                lbxGames.ItemsSource = AllGames;
            }
            else if(rXbox.IsChecked == true)
            {
                var query = from g in db.Games
                            where g.Platform == "Xbox"
                            select g;
                AllGames = query.ToList();
                lbxGames.ItemsSource = AllGames;
            }
            else if (rSwitch.IsChecked == true)
            {
                var query = from g in db.Games
                            where g.Platform == "Switch"
                            select g;
                AllGames = query.ToList();
                lbxGames.ItemsSource = AllGames;
            }
            else if (rPS.IsChecked == true)
            {
                var query = from g in db.Games
                            where g.Platform == "PS"
                            select g;
                AllGames = query.ToList();
                lbxGames.ItemsSource = AllGames;
            }
            else if(rAll.IsChecked == true)
            {
                var query = from g in db.Games
                            select g;

                AllGames = query.ToList();
                lbxGames.ItemsSource = AllGames;
            }




        }
    }
}
