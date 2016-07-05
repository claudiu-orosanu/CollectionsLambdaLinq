using System;

namespace Collections
{
    public class Band : IComparable<Band>
    {
        public string Name { get; private set; }
        public int StudioAlbums { get; private set; }
        public string Genre { get; private set; }
        public string Country { get; private set; }

        public Band(string name, int studioAlbums, string genre, string country)
        {
            Name = name;
            StudioAlbums = studioAlbums;
            Genre = genre;
            Country = country;
        }

        // Homework
        public int CompareTo(Band band)
        {
            return StudioAlbums - band.StudioAlbums; //am sortat dupa numarul de albume
        }
    }
}
