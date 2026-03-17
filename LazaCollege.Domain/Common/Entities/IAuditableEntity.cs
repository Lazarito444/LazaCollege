namespace LazaCollege.Domain.Common.Entities;

public interface IAuditableEntity
{
    DateTime CreatedAtUtc { get; set; }
    DateTime? UpdatedAtUtc { get; set; }
    bool IsDeleted { get; set; }
}
