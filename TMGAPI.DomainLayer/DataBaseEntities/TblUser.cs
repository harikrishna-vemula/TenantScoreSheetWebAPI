using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblRole? Role { get; set; }

    public virtual ICollection<TblApplicantInfo> TblApplicantInfoCreatedByNavigations { get; set; } = new List<TblApplicantInfo>();

    public virtual ICollection<TblApplicantInfo> TblApplicantInfoModifiedByNavigations { get; set; } = new List<TblApplicantInfo>();

    public virtual ICollection<TblApplicantType> TblApplicantTypeCreatedByNavigations { get; set; } = new List<TblApplicantType>();

    public virtual ICollection<TblApplicantType> TblApplicantTypeModifiedByNavigations { get; set; } = new List<TblApplicantType>();

    public virtual ICollection<TblCreditScore> TblCreditScoreCreatedByNavigations { get; set; } = new List<TblCreditScore>();

    public virtual ICollection<TblCreditScore> TblCreditScoreModifiedByNavigations { get; set; } = new List<TblCreditScore>();

    public virtual ICollection<TblCreditSummary> TblCreditSummaryCreatedByNavigations { get; set; } = new List<TblCreditSummary>();

    public virtual ICollection<TblCreditSummary> TblCreditSummaryModifiedByNavigations { get; set; } = new List<TblCreditSummary>();

    public virtual ICollection<TblExtraDeposit> TblExtraDepositCreatedByNavigations { get; set; } = new List<TblExtraDeposit>();

    public virtual ICollection<TblExtraDeposit> TblExtraDepositModifiedByNavigations { get; set; } = new List<TblExtraDeposit>();

    public virtual ICollection<TblIncomeCriterion> TblIncomeCriterionCreatedByNavigations { get; set; } = new List<TblIncomeCriterion>();

    public virtual ICollection<TblIncomeCriterion> TblIncomeCriterionModifiedByNavigations { get; set; } = new List<TblIncomeCriterion>();

    public virtual ICollection<TblIncomeVerification> TblIncomeVerificationCreatedByNavigations { get; set; } = new List<TblIncomeVerification>();

    public virtual ICollection<TblIncomeVerification> TblIncomeVerificationModifiedByNavigations { get; set; } = new List<TblIncomeVerification>();

    public virtual ICollection<TblLandlordReferance> TblLandlordReferanceCreatedByNavigations { get; set; } = new List<TblLandlordReferance>();

    public virtual ICollection<TblLandlordReferance> TblLandlordReferanceModifiedByNavigations { get; set; } = new List<TblLandlordReferance>();

    public virtual ICollection<TblPet> TblPetCreatedByNavigations { get; set; } = new List<TblPet>();

    public virtual ICollection<TblPet> TblPetModifiedByNavigations { get; set; } = new List<TblPet>();

    public virtual ICollection<TblPointsSummary> TblPointsSummaryCreatedByNavigations { get; set; } = new List<TblPointsSummary>();

    public virtual ICollection<TblPointsSummary> TblPointsSummaryModifiedByNavigations { get; set; } = new List<TblPointsSummary>();

    public virtual ICollection<TblPropertyType> TblPropertyTypeCreatedByNavigations { get; set; } = new List<TblPropertyType>();

    public virtual ICollection<TblPropertyType> TblPropertyTypeModifiedByNavigations { get; set; } = new List<TblPropertyType>();

    public virtual ICollection<TblRole> TblRoleCreatedByNavigations { get; set; } = new List<TblRole>();

    public virtual ICollection<TblRole> TblRoleModifiedByNavigations { get; set; } = new List<TblRole>();

    public virtual ICollection<TblTenantInfo> TblTenantInfoCreatedByNavigations { get; set; } = new List<TblTenantInfo>();

    public virtual ICollection<TblTenantInfo> TblTenantInfoModifiedByNavigations { get; set; } = new List<TblTenantInfo>();

    public virtual ICollection<TblTenantType> TblTenantTypeCreatedByNavigations { get; set; } = new List<TblTenantType>();

    public virtual ICollection<TblTenantType> TblTenantTypeModifiedByNavigations { get; set; } = new List<TblTenantType>();
}
