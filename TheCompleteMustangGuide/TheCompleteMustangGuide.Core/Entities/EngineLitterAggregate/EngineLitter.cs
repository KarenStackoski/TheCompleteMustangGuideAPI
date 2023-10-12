using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCompleteMustangGuide.Core.Entities.MustangModelsAggregate;
using TheCompleteMustangGuide.SharedKernel;
using TheCompleteMustangGuide.SharedKernel.Interfaces;

namespace TheCompleteMustangGuide.Core.Entities.EngineLitterAggregate
{
    public class EngineLitter : BaseEntity<int>, IAggregateRoot
    {
        public int IdEnginelitter { get; protected set; }
        public float Litters { get; protected set; }

        public virtual ICollection<MustangModels> EngineLitters { get; protected set; } //This will be a foreign key

        protected EngineLitter() { }

        private EngineLitter(int idEnginelitter, float litters)
        {
            IdEnginelitter = Guard.Against.NegativeOrZero(idEnginelitter, nameof(idEnginelitter));
            Litters = Guard.Against.NegativeOrZero(litters, nameof(litters));
        }

        public static EngineLitter NewEngineLitter(int idEnginelitter, float litters) 
        { 
            return new EngineLitter(idEnginelitter, litters); 
        }
    }
}
