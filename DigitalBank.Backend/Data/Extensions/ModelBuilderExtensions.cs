using Microsoft.EntityFrameworkCore;

namespace Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Exemplos de implementação..
            //modelBuilder.Entity<Campaign>()
            //    .HasData(
            //        new Campaign {
            //            Id = 1,
            //            Name = "Sorteio 1",
            //            Description = "Sorteio 1",
            //            StartDate = new DateTime(2018, 10, 16),
            //            EndDate = new DateTime(2018, 11, 15, 23, 59, 59, 999),
            //            DrawDate = new DateTime(2018, 11, 17),
            //            CreateDate = DateTime.Now, ModifyDate = null,
            //            TotalDrawNumbers = 16,
            //            StartSerie = 1,
            //            EndSerie = 200,
            //            DrawNumber = null,
            //            DrawSerie = null,
            //            Status = Domain.Enum.CampaignStatus.NotPerformed
            //        }
            //    );

            /*
            modelBuilder.Entity<Role>()
                .HasData(
                    new Role
                    {
                        Id = 1,
                        Name = "Blacklist:Read",
                        Description = "Leitura Blacklist",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    },
                    new Role
                    {
                        Id = 2,
                        Name = "Blacklist:Write",
                        Description = "Escrita Blacklist",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    },
                    new Role
                    {
                        Id = 3,
                        Name = "Moderation:Read",
                        Description = "Leitura Moderação",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    },
                    new Role
                    {
                        Id = 4,
                        Name = "Moderation:Write",
                        Description = "Escrita Moderação",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    },
                    new Role
                    {
                        Id = 5,
                        Name = "Participant:Write",
                        Description = "Escrita Participante",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    },
                    new Role
                    {
                        Id = 6,
                        Name = "Participant:Read",
                        Description = "Leitura Participante",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    },
                    new Role
                    {
                        Id = 7,
                        Name = "Bonus:Read",
                        Description = "Leitura de Bonificação",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    },
                    new Role
                    {
                        Id = 8,
                        Name = "Bonus:Write",
                        Description = "Escrita de Bonificação",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    },
                    new Role
                    {
                        Id = 9,
                        Name = "Coupon:Read",
                        Description = "Leitura de Cupom",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    },
                    new Role
                    {
                        Id = 10,
                        Name = "Coupon:Write",
                        Description = "Escrita de Cupom",
                        CreateDate = DateTime.Now,
                        ModifyDate = null
                    }
                );*/
        }
    }
}
