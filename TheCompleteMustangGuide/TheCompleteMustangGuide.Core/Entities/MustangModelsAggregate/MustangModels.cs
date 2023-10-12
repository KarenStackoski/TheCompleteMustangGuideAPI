using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCompleteMustangGuide.Core.Entities.EngineAggregate;
using TheCompleteMustangGuide.Core.Entities.EngineLitterAggregate;
using TheCompleteMustangGuide.Core.Entities.ModelNameAggregate;
using TheCompleteMustangGuide.Core.Entities.ModelYearAggregate;
using TheCompleteMustangGuide.SharedKernel;
using TheCompleteMustangGuide.SharedKernel.Interfaces;

namespace TheCompleteMustangGuide.Core.Entities.MustangModelsAggregate
{
    public class MustangModels : BaseEntity<int>, IAggregateRoot
    {
        public int IdMustangModels { get; protected set; }
        public int HorsePower { get; protected set; }
        public int ModelId { get; protected set; }
        public int YearId { get; protected set; }
        public int EngineId { get; protected set; }
        public int EngineLitterId { get; protected set; }
        public virtual ModelName Model { get; protected set; }
        public virtual ModelYear Year { get; protected set; }
        public virtual Engine Engine { get; protected set; }
        public virtual EngineLitter EngineLitter { get; protected set; }

        protected MustangModels() { }

        private MustangModels(int idMustangModels, int horsePower, ModelName model, ModelYear year, Engine engine, EngineLitter engineLitter)
        {
            IdMustangModels = Guard.Against.NegativeOrZero(idMustangModels, nameof(idMustangModels));
            HorsePower = Guard.Against.NegativeOrZero(horsePower, nameof(horsePower));
            ModelId = Guard.Against.NegativeOrZero(model.Id, nameof(model.Id));
            YearId = Guard.Against.NegativeOrZero(year.Id, nameof(year.Id));
            EngineId = Guard.Against.NegativeOrZero(engine.Id, nameof(engine.Id));
            EngineLitterId = Guard.Against.NegativeOrZero(engineLitter.Id, nameof(engine.Id));
        }

        public static MustangModels NewMustangModel(int idMustangModels, int horsePower, ModelName model, ModelYear year, Engine engine, EngineLitter engineLitter) 
        { 
            return new MustangModels(idMustangModels, horsePower, model, year, engine, engineLitter); 
        }
    }
}
