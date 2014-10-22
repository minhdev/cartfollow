using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cartfolo.Models;

namespace cartfolo.Services
{
    public interface IGuestbookService
    {
        IList<GuestbookEntry> GetGuestbookEntries();
        IList<GuestbookEntry> GetGuestbookEntriesByName(string name);
        void AddEntry(GuestbookEntry entry);
    }
}
