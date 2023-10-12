using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCompleteMustangGuide.Core.Entities.MustangModelsAggregate;
using TheCompleteMustangGuide.SharedKernel;
using TheCompleteMustangGuide.SharedKernel.Interfaces;

namespace TheCompleteMustangGuide.Core.Entities.ModelNameAggregate
{
    public class ModelName : BaseEntity<int>, IAggregateRoot
    {
        public int IdModelName { get; private set; }
        public string Name { get; private set; }

        public virtual ICollection<MustangModels> ModelNames { get; private set; } //This will be a foreign key

        protected ModelName() { }

        private ModelName(int idModelName, string name) 
        {
            IdModelName = Guard.Against.NegativeOrZero(idModelName, nameof(idModelName));
            Name = Guard.Against.NullOrWhiteSpace(name, nameof(name));
        }

        public static ModelName NewModelName(int idModelName, string name)
        {
            return new ModelName(idModelName, name);
        }
    }
}
