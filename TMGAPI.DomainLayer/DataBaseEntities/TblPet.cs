using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblPet
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public int? PetApprovedLandlordReferance1 { get; set; }

    public int? PetApprovedLandlordReferance2 { get; set; }

    public bool? NoOfCatsCompanion { get; set; }

    public int? NoOfCatsCompanions { get; set; }

    public int? NoOfCatsCompanionPoints { get; set; }

    public bool? NoOfLargeDogsCompanion { get; set; }

    public int? NoOfLargeDogsCompanions { get; set; }

    public int? NoOfLargeDogsCompanionPoints { get; set; }

    public bool? NoOfSmallDogsCompanion { get; set; }

    public int? NoOfSmallDogsCompanions { get; set; }

    public int? NoOfSmallDogsCompanionPoints { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual TblTenantInfo? Tenant { get; set; }
}
