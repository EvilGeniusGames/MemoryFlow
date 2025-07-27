// File: Data.MemoryFlow/Entities/Setting.cs
namespace Data.MemoryFlow.Entities
{
    public class Setting
    {
        public int Id { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
