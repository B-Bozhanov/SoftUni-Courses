using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Repositories
{
    class PilotRepository : IRepository<IPilot>
    {
        private readonly ICollection<IPilot> models;

        public PilotRepository()
        {
            this.models = new List<IPilot>();
        }
        public IReadOnlyCollection<IPilot> Models
        {
            get => this.models as IReadOnlyCollection<IPilot>;
        }

        public void Add(IPilot pilot)
        {
            this.models.Add(pilot);
        }

        public IPilot FindByName(string name)
        {
            return this.models.FirstOrDefault(m => m.FullName == name);
        }

        public bool Remove(IPilot pilot)
        {
            return this.models.Remove(pilot);
        }
    }
}
