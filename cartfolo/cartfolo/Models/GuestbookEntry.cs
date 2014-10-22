using System;

namespace cartfolo.Models
{
    /// <summary>
    /// Class represent the Guestbook entry object
    /// </summary>
    public class GuestbookEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
    }
}