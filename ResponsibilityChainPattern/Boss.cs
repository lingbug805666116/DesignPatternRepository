using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    /// <summary>
    /// 老板
    /// </summary>
    public class Boss : Approver
    {
        public Boss(string approveName) : base(approveName)
        {

        }

        public override void ApproveApply(LeaveApply leaveApply)
        {
            var record = new ApproverRecord(this);
            leaveApply.ApproverRecords.Add(record);
            if (leaveApply.ApplyDays < 15)
            {
                record.Result = true;
                leaveApply.ApproveResult = true;
                Console.WriteLine("{0}的请假时间小于15天，我审批通过，审批结束！", leaveApply.ApplyUserName);
            }
            else
            {
                Console.WriteLine("{0}请假时长超过15天，公司需要开会讨论下才能给出审批结果！", leaveApply.ApplyUserName);
            }
        }
    }
}
