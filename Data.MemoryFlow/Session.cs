// File: Data.MemoryFlow/Entities/Session.cs
namespace Data.MemoryFlow.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public List<MemoryEntry> Entries { get; set; } = new();
    }
}
