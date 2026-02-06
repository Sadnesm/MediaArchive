using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaArchive
{
    public class LibraryManager
    {
        public List<MediaItem> Items { get; set; } = new List<MediaItem>();

        public void AddItem(MediaItem item) => Items.Add(item);

        public void RemoveItem(Guid id) => Items.RemoveAll(i => i.Id == id);

        public List<MediaItem> GetFilteredItems(string search, string genre)
        {
            var query = Items.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(i => i.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                                         i.Author.Contains(search, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(genre) && genre != "Все")
                query = query.Where(i => i.Genre == genre);

            return query.ToList();
        }
    }
}