using Application.AutoMapper;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApp.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(CardViewModelToCardMapping), typeof(CardToCardViewModelMapping));
            services.AddAutoMapper(typeof(LegalPersonViewModelToLegalPersonMapping), typeof(LegalPersonToLegalPersonViewModelMapping));
            services.AddAutoMapper(typeof(PhysicalPersonViewModelToPhysicalPersonMapping), typeof(PhysicalPersonToPhysicalPersonViewModelMapping));
            services.AddAutoMapper(typeof(TransactionViewModelToTransactionMapping), typeof(TransactionToTransactionViewModelMapping));
        }
    }
}
