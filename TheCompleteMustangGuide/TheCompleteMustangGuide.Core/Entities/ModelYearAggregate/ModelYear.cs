using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCompleteMustangGuide.Core.Entities.MustangModelsAggregate;
using TheCompleteMustangGuide.SharedKernel;
using TheCompleteMustangGuide.SharedKernel.Interfaces;

namespace TheCompleteMustangGuide.Core.Entities.ModelYearAggregate
{
    public class ModelYear : BaseEntity<int>, IAggregateRoot
    {
        public int IdModelYear { get; protected set; }
        public int ReleasementYear { get; protected set; }

        public virtual ICollection<MustangModels> ModelYears { get; protected set; } //This will be a foreign key

        protected ModelYear() { }

        private ModelYear(int idModelYear, int releasementYear)
        {
            IdModelYear = Guard.Against.NegativeOrZero(idModelYear, nameof(idModelYear));
            ReleasementYear = Guard.Against.NegativeOrZero(releasementYear, nameof(releasementYear));
        }

        public static ModelYear NewModelYear(int idModelYear, int releasementYear)
        {
            return new ModelYear(idModelYear, releasementYear);
        }
    }
}
