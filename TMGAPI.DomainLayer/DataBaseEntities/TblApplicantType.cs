using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblApplicantType
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual ICollection<TblIncomeCriterion> TblIncomeCriteria { get; set; } = new List<TblIncomeCriterion>();
}
