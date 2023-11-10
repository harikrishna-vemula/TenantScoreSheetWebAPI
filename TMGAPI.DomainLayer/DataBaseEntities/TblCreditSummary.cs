using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblCreditSummary
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public bool? CreditLines { get; set; }

    public int? CreditScore { get; set; }

    public int? CreditScorePoints { get; set; }

    public bool? CreditScoreAvailable { get; set; }

    public int? CreditScoreAvailablePoints { get; set; }

    public int? AccountPastDue60Days { get; set; }

    public int? CollectionAccounts { get; set; }

    public int? CollectionAccountsPoints { get; set; }

    public int? MedicalCollections { get; set; }

    public bool? PropertyRelatedHousingRecord { get; set; }

    public int? PropertyRelatedHousingRecordPoints { get; set; }

    public bool? BankRuptyActive { get; set; }

    public bool? BankRuptyActivePoints { get; set; }

    public int? LiensRepossessions { get; set; }

    public int? LiensRepossessionsPoints { get; set; }

    public byte[]? EvectionHistory { get; set; }

    public int? EvectionHistoryPoints { get; set; }

    public bool? Class1Felonies { get; set; }

    public int? Class1FeloniesPoints { get; set; }

    public DateTime? Class2Felonies { get; set; }

    public int? Class2FeloniesPoints { get; set; }

    public DateTime? Class1Misdemeaners { get; set; }

    public int? Class1MisdemeanersPoints { get; set; }

    public DateTime? Class2Misdemeaners { get; set; }

    public int? Class2MisdemeanersPoints { get; set; }

    public bool? DepositApproved { get; set; }

    public int? DepositToHold { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual TblTenantInfo? Tenant { get; set; }
}
