using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblTenantInfo
{
    public int Id { get; set; }

    public int? TenantSerialNumber { get; set; }

    public int? ApplicantId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblApplicantInfo? Applicant { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual ICollection<TblCreditSummary> TblCreditSummaries { get; set; } = new List<TblCreditSummary>();

    public virtual ICollection<TblIncomeVerification> TblIncomeVerifications { get; set; } = new List<TblIncomeVerification>();

    public virtual ICollection<TblLandlordReferance> TblLandlordReferances { get; set; } = new List<TblLandlordReferance>();

    public virtual ICollection<TblPet> TblPets { get; set; } = new List<TblPet>();
}
