using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    /// <summary>
    /// 部门主管
    /// </summary>
    public class DeptManager : Approver
    {
        public DeptManager(string approveName) : base(approveName)
        {

        }

        public override void ApproveApply(LeaveApply leaveApply)
        {
            var record = new ApproverRecord(this);
            leaveApply.ApproverRecords.Add(record);
            if (leaveApply.ApplyDays < 3)
            {
                record.Result = true;
                leaveApply.ApproveResult = true;
                Console.WriteLine("{0}的请假时间小于3天，我直接审批通过，审批结束！", leaveApply.ApplyUserName);
            }
            else
            {
                Console.WriteLine("{0}的请假时间超过3天，我审批通过，接下来交给{1}审批！", leaveApply.ApplyUserName, this.NextApprover.ApproveName);
                this.NextApprover.ApproveApply(leaveApply);
            }
        }
    }
}
