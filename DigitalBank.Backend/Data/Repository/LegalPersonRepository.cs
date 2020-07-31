using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Data.Repository
{
    public class LegalPersonRepository: Repository<LegalPerson>, ILegalPersonRepository
    {
        public LegalPersonRepository(DigitalBankDBContext ctx) : base(ctx)
        {

        }
    }
}
