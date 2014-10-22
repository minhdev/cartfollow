using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using cartfolo.Models;

namespace cartfolo.Services
{
    public class GuestbookServices : IGuestbookService
    {
        private GuestbookContext dbGuestbook = new GuestbookContext();
        public IList<GuestbookEntry> GetGuestbookEntries()
        {
            return dbGuestbook.Entries.ToList();
        }

        public IList<GuestbookEntry> GetGuestbookEntriesByName(string name)
        {
            var entries =
                dbGuestbook.Entries.Where(g => g.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            return entries.ToList();
        }

        public void AddEntry(GuestbookEntry entry)
        {
            entry.DateAdded = DateTime.Now;
            dbGuestbook.Entries.Add(entry);
            dbGuestbook.SaveChanges();
        }
    }
}