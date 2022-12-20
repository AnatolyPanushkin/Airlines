using Microsoft.EntityFrameworkCore;

namespace Airlines.Context;

public partial class AirlinesContext:DbContext
{
    public AirlinesContext() : base()
    {
    }

    public AirlinesContext(DbContextOptions<AirlinesContext> options) : base(options)
    {
    }
        
    public virtual DbSet<AirCompany> AirCompanies { get; set; }
}