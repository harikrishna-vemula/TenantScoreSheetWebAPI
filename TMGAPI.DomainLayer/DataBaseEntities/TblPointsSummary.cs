using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblPointsSummary
{
    public int Id { get; set; }

    public int? TotalPoints { get; set; }

    public bool? FinalApproval { get; set; }

    public int? TotalDeposit { get; set; }

    public int? DepositToHoldpaid { get; set; }

    public int? PetDeposit { get; set; }

    public int? AdditionalDeposit { get; set; }

    public int? BalanceDepositDue { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }
}
