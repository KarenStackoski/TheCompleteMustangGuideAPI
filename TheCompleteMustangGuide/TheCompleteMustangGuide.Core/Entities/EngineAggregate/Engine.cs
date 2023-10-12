using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCompleteMustangGuide.Core.Entities.MustangModelsAggregate;
using TheCompleteMustangGuide.SharedKernel;
using TheCompleteMustangGuide.SharedKernel.Interfaces;

namespace TheCompleteMustangGuide.Core.Entities.EngineAggregate
{
    public class Engine : BaseEntity<int>, IAggregateRoot
    {
        public int IdEngine { get; protected set; }
        public string Name { get; protected set; }

        public virtual ICollection<MustangModels> Engines { get; protected set; } //This will be a foreign key

        protected Engine() { }

        private Engine(int idEngine, string name)
        {
            IdEngine = Guard.Against.NegativeOrZero(idEngine, nameof(idEngine));
            Name = Guard.Against.NullOrWhiteSpace(name, nameof(name));
        }

        public static Engine NewEngine(int idEngine, string name) 
        {
            return new Engine(idEngine, name);
        }
    }
}
