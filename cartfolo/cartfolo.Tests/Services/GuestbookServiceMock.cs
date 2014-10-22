using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cartfolo.Models;
using cartfolo.Services;

namespace cartfolo.Tests.Services
{
    class GuestbookServiceMock : IGuestbookService
    {
        private List<GuestbookEntry> Entries = new List<GuestbookEntry>();

        public GuestbookServiceMock()
        {
            GuestbookEntry first = new GuestbookEntry();
            first.Name = "minh";
            first.Message = "test";
            first.Id = 1;
            first.DateAdded = new DateTime(2014, 10, 12);

            Entries.Add(first);
        }

        public IList<GuestbookEntry> GetGuestbookEntries()
        {
            return Entries;
        }

        public IList<GuestbookEntry> GetGuestbookEntriesByName(string name)
        {
            return Entries.Where(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void AddEntry(GuestbookEntry entry)
        {
            entry.DateAdded = DateTime.Now;
            Entries.Add(entry);
        }
    }
}
