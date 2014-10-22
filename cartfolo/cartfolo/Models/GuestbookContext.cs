using System.Data.Entity;

namespace cartfolo.Models
{
    /// <summary>
    /// Abstraction over Entity framework to allow us to persist and retrieve data
    /// </summary>
    public class GuestbookContext : DbContext
    {
        /// <summary>
        /// Constructor to define database name
        /// If we dont define, EF will use default cartfolo.Models.GuestbookContext.mdf
        /// </summary>
        public GuestbookContext() : base("Guestbook")
        {
        }

        /// <summary>
        /// Provide access to table data
        /// </summary>
        public DbSet<GuestbookEntry> Entries { get; set; }
    }
}