using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblIncomeVerification
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public int? PaystubRecent { get; set; }

    public int? YtdEarnings { get; set; }

    public int? PaystubRecentMonthly { get; set; }

    public int? BankStatement { get; set; }

    public int? _2ndPayStub { get; set; }

    public int? BankStatementMonthly { get; set; }

    public int? XRent { get; set; }

    public bool? IncomeAdequate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual TblTenantInfo? Tenant { get; set; }
}
