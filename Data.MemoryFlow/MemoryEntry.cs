// File: Data.MemoryFlow/Entities/MemoryEntry.cs
namespace Data.MemoryFlow.Entities
{
    public class MemoryEntry
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}
