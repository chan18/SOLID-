using MegaPricer.Data;
using Microsoft.EntityFrameworkCore;

public static class SeedData
{
   public static void Initialize(IServiceProvider serviceProvider)
  {
    using (var dbContext = new ApplicationDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
    {
      // Look for any Kitchens.
      if (dbContext.Kitchens.Any())
      {
        return;   // DB has been seeded
      }

      PopulateTestData(dbContext);
    }
  }

  public static Kitchen GetKitchen1()
  {
  }

  public static void PopulateTestData(ApplicationDbContext dbContext)
  {

  }

  public static void PopulatePricingColors(ApplicationDbContext dbContext)
  {

  }

  public static void PopulatePricingSkus(ApplicationDbContext dbContext)
  {

  }
  public static void PopulateUserMarkups(ApplicationDbContext dbContext)
  {
  }

}