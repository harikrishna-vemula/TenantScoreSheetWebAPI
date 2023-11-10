using System;
using System.Collections.Generic;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TblIncomeCriterion
{
    public int Id { get; set; }

    public int? ApplicantTypeId { get; set; }

    public int? PropertyTypeId { get; set; }

    public int? IncomeFactor { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblApplicantType? ApplicantType { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual TblPropertyType? PropertyType { get; set; }
}
