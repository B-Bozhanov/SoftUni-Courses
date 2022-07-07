namespace Formula1.Repositories
{
    using Formula1.Models.Contracts;
    using Formula1.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    class RaceRepository : IRepository<IRace>
    {
        private readonly ICollection<IRace> models;

        public RaceRepository()
        {
            this.models = new List<IRace>();
        }
        public IReadOnlyCollection<IRace> Models
        {
            get => this.models as IReadOnlyCollection<IRace>;
        }

        public void Add(IRace pilot)
        {
            this.models.Add(pilot);
        }

        public IRace FindByName(string name)
        {
            return this.models.FirstOrDefault(m => m.RaceName == name);
        }

        public bool Remove(IRace pilot)
        {
            return this.models.Remove(pilot);
        }
    }
}
