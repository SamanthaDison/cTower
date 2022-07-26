using System;
using cTower.Interfaces;

namespace cTower.Models
{
    public class TowerEvent : IRepoItem<int>, ICreated<Profile>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverImg { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Profile Creator { get; set; }
        public string CreatorId { get; set; }
    }
}