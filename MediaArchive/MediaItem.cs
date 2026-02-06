using System;

namespace MediaArchive
{
    public class MediaItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public int Year { get; set; } = DateTime.Now.Year;
        public string Genre { get; set; } = "Другое";
        public int Rating { get; set; } = 1;
        public string Description { get; set; } = "";
        public string ImagePath { get; set; } = "";
    }
}