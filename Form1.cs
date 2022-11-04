using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_11_MoreList_Enum
{
    public partial class Form1 : Form
    {
        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
            Preload();
            // Spotify
            // Album
            // Songs
            // Playlist

        } // Form1()

        public void Preload()
        {
            Album demonDays = new Album("Gorillaz", "Demon Days", Album.GENRE.HIPHOP);
            Song song1 = new Song("Feel Good Inc.", 229);
            demonDays.AddSong(song1);
            song1 = new Song("MIDDLE CHILD", 229);
            demonDays.AddSong(song1);
            demonDays.AddSong(new Song("Fire coming out of a monkeys head", 196));
            demonDays.AddSong(new Song("November Has Come", 161));

            albums.Add(demonDays);

            Album shereen = new Album("Ed Shereen", "=", Album.GENRE.HIPHOP);
            shereen.Songs.Add(new Song("Don't", 240));
            albums.Add(shereen);

            Album cole = new Album("J Cole", "MIDDLE CHILD", Album.GENRE.HIPHOP);
             song1 = new Song("MIDDLE CHILD", 229);
            cole.AddSong(song1);

            albums.Add(cole);

            DisplayAlbums(albums);
            cmbAlbum.SelectedIndex = 0;
        }

        public void DisplayAlbumTracks(List<Song> trackList)
        {
            // Clears the tracks listed on the listbox
            lbAlbumTracks.Items.Clear();

            for(int i = 0; i < trackList.Count; i++)
            {
                lbAlbumTracks.Items.Add(trackList[i].Title);
            }
        }

        public void DisplayAlbums(List<Album> albums)
        {
            // Clear combo box
            cmbAlbum.Items.Clear();

            for(int i = 0; i < albums.Count; i++)
            {
                cmbAlbum.Items.Add(albums[i].Artist + " " + albums[i].Name);
            }
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {

            int index = lbAlbumTracks.SelectedIndex;
            MessageBox.Show(index + "");
        }

        private void cmbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get index of currently selected album in combo box
            int index = cmbAlbum.SelectedIndex;

            // Assign album to currentAlbum variable
            Album currentAlbum = albums[index];

            // Display all tracks from currentAlbum in listbox
            DisplayAlbumTracks(currentAlbum.Songs);
        }

        private void btnRemoveTrack_Click(object sender, EventArgs e)
        {
            // Getting the currently selected index in listbox tracks
            int indexTrack = lbAlbumTracks.SelectedIndex;

            // Selected index of album in combo box album
            int indexAlbum = cmbAlbum.SelectedIndex;

            // Creating a link to the selected album object
            Album album = albums[indexAlbum];
            // Creating a link to the selected song object
            Song song = album.Songs[indexTrack];

            // Removes song from album
            album.RemoveSong(song);


            DisplayAlbumTracks(album.Songs);

            //MessageBox.Show(song.Title);


            //string foratted = $"" +
            //    $"Album: {indexAlbum}\n" +
            //    $"Track: {indexTrack}";

            //MessageBox.Show(foratted);



        } // btnRemoveTrack_Click()

    } // class

} // namespace
