using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    /// <summary>
    /// 审批记录实体
    /// </summary>
    public class ApproverRecord
    {
        public ApproverRecord(Approver approver)
        {
            this.Approver = approver;
        }

        public Approver Approver { get; set; }

        public bool? Result { get; set; }
    }
}
