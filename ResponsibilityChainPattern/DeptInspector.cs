using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    /// <summary>
    /// 部门总监
    /// </summary>
    public class DeptInspector : Approver
    {
        public DeptInspector(string approveName) : base(approveName)
        {

        }

        public override void ApproveApply(LeaveApply leaveApply)
        {
            var record = new ApproverRecord(this);
            leaveApply.ApproverRecords.Add(record);
            if (leaveApply.ApplyDays < 7)
            {
                record.Result = true;
                leaveApply.ApproveResult = true;
                Console.WriteLine("{0}的请假时间小于7天，我审批通过，审批结束！", leaveApply.ApplyUserName);
            }
            else
            {
                Console.WriteLine("{0}的请假时间超过7天，我审批通过，接下来交给{1}审批！", leaveApply.ApplyUserName, this.NextApprover.ApproveName);
                this.NextApprover.ApproveApply(leaveApply);
            }
        }
    }
}
