using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblApplicantInfo
{
    public int Id { get; set; }

    public string? ApplicantName { get; set; }

    public string? Property { get; set; }

    public string? TenantStatus { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public int? MonthlyRent { get; set; }

    public string? Section8Rent { get; set; }

    public string? StandardDepositProperty { get; set; }

    public string? PetDeposit { get; set; }

    public int? PropertyTypeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual ICollection<TblTenantInfo> TblTenantInfos { get; set; } = new List<TblTenantInfo>();
}
