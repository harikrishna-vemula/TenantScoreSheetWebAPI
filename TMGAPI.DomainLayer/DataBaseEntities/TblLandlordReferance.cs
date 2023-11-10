using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblLandlordReferance
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public bool? RentalReferance { get; set; }

    public int? LandlordType { get; set; }

    public bool? ProperNotice { get; set; }

    public int? ProperNoticePoints { get; set; }

    public int? Nsf { get; set; }

    public int? Nsfpoints { get; set; }

    public int? LatePayments { get; set; }

    public int? LatePaymentsPoints { get; set; }

    public int? PaymentOrVacantNotices { get; set; }

    public int? PaymentOrVacantNoticesPoints { get; set; }

    public int? _10dayComplyNotice { get; set; }

    public int? _10dayComplyNoticePoints { get; set; }

    public int? Hoaviolations { get; set; }

    public int? HoaviolationsPoints { get; set; }

    public int? PropertyCleanliness { get; set; }

    public int? PropertyCleanlinessPoints { get; set; }

    public bool? Pets { get; set; }

    public int? PetsPoints { get; set; }

    public bool? AdversePetReferance { get; set; }

    public int? AdversePetReferancePoints { get; set; }

    public bool? Rerent { get; set; }

    public int? RerentPoints { get; set; }

    public bool? RentalHistoryLength { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual TblTenantInfo? Tenant { get; set; }
}
