using Base.Entities;

namespace Org.Entities;

public class Role : EntityBase
{
  public Boolean IsActive { get; set; }

  public int? RoleTypeId { get; set; }
  public RoleType? RoleType { get; set; }

  // Overrides RoleType.Title
  public string? Title { get; set; }

  public int PersonId { get; set; }
  public Person Person { get; set; } = null!;

  public DateTimeOffset StartDate { get; set; }
  public DateTimeOffset? EndDate { get; set; }

  public virtual List<Function> Functions { get; set; } = new();
}