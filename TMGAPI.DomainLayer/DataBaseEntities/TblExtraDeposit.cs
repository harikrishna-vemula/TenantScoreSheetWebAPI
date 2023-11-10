using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblExtraDeposit
{
    public int Id { get; set; }

    public int? PropertyTypeId { get; set; }

    public int? TenantTypeId { get; set; }

    public int? StartValue { get; set; }

    public int? EndValue { get; set; }

    public int? Calculation { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual TblPropertyType? PropertyType { get; set; }

    public virtual TblTenantType? TenantType { get; set; }
}
