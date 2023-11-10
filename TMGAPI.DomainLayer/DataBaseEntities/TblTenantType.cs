using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblTenantType
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual ICollection<TblCreditScore> TblCreditScores { get; set; } = new List<TblCreditScore>();

    public virtual ICollection<TblExtraDeposit> TblExtraDeposits { get; set; } = new List<TblExtraDeposit>();
}
