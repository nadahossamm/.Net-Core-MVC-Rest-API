using Microsoft.EntityFrameworkCore;
namespace DockerApi.Models
{
    public class RestaurantDetails : DbContext
    {
        public RestaurantDetails(DbContextOptions<RestaurantDetails> options) : base(options)
        {

        }

        //tells the entity framework that this class, we want to replicate it in our DB
        //so that this result into a table in our DB
        public DbSet<Restaurant> RestaurantItem {get;set;}

    }
}