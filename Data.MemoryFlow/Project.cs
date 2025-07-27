// File: Data.MemoryFlow/Entities/Project.cs
namespace Data.MemoryFlow.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Session> Sessions { get; set; } = new();
    }
}
