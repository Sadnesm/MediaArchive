using System.Collections.Generic;
using System.Linq;

namespace MediaArchive
{
    public class LibraryManager
    {
        public List<MediaItem> Items { get; set; } = new List<MediaItem>();

        public void AddItem(MediaItem item) => Items.Add(item);

        public void RemoveItem(Guid id) => Items.RemoveAll(i => i.Id == id);

        public List<MediaItem> Search(string query)
        {
            return Items.Where(i => i.Title.ToLower().Contains(query.ToLower()) ||
                                    i.Author.ToLower().Contains(query.ToLower())).ToList();
        }

        public List<MediaItem> FilterByGenre(string genre)
        {
            if (genre == "Все") return Items;
            return Items.Where(i => i.Genre == genre).ToList();
        }
    }
}