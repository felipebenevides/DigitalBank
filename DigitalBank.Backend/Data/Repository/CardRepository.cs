using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Data.Repository
{
    public class CardRepository : Repository<Card>, ICardRepository
    {
        public CardRepository(DigitalBankDBContext ctx) : base(ctx)
        {
                
        }
    }

}
