using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wymiana_Kart_TCG.Models;

namespace Wymiana_Kart_TCG.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardCategory> CardCategories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<CardCategory>().HasData(new CardCategory { CardCategoryId = 1, CardCategoryName = "Pokemon" });
            modelBuilder.Entity<CardCategory>().HasData(new CardCategory { CardCategoryId = 2, CardCategoryName = "MTG" });
            modelBuilder.Entity<CardCategory>().HasData(new CardCategory { CardCategoryId = 3, CardCategoryName = "Yugioh", });

            //seed Cards

            modelBuilder.Entity<Card>().HasData(new Card
            {
                CardId = 1,
                CardName = "Alakazam",
                CardPrice = 12,
                CardShortDescription = "Our famous Alakazam Cards!",
                CardLongDescription = "Long description AlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazam",
                CardCategoryId = 1,
                CardImgUrl = "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces",
                IsCardAvailableToTrade = true,
                IsCardDealOfTheWeek = true,
                CardImgThumbnailUrl = "https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg",

            });

            modelBuilder.Entity<Card>().HasData(new Card
            {
                CardId = 2,
                CardName = "Blastoise",
                CardPrice = 18,
                CardShortDescription = "Our famous Blastoise Cards!",
                CardLongDescription = "Long description BlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoise",
                CardCategoryId = 2,
                CardImgUrl = "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces",
                IsCardAvailableToTrade = true,
                IsCardDealOfTheWeek = false,
                CardImgThumbnailUrl = "https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg",

            });

            modelBuilder.Entity<Card>().HasData(new Card
            {
                CardId = 3,
                CardName = "Venusaur",
                CardPrice = 18,
                CardShortDescription = "Our famous Venusaur Cards!",
                CardLongDescription = " Long description VenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaur",
                CardCategoryId = 3,
                CardImgUrl = "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces",
                IsCardAvailableToTrade = true,
                IsCardDealOfTheWeek = false,
                CardImgThumbnailUrl = "https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg",

            });
        }
    }
}
