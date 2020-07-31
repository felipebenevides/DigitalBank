using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Data.Repository
{
    public class PhysicalPersonRepository: Repository<PhysicalPerson>, IPhysicalPersonRepository
    {
        public PhysicalPersonRepository(DigitalBankDBContext ctx) : base(ctx)
        {

        }
    }
}
