using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    /// <summary>
    /// 请假申请对象
    /// </summary>
    public class LeaveApply
    {
        public LeaveApply(string applyUserName, int applyDays)
        {
            this.ApplyUserName = applyUserName;
            this.ApplyDays = applyDays;
            Console.WriteLine("{0}申请请假{1}天！", applyUserName, applyDays);
            this.ApproverRecords = new List<ApproverRecord>();
        }

        /// <summary>
        /// 请假人姓名
        /// </summary>
        public string ApplyUserName { get; set; }

        /// <summary>
        /// 请假时长（单位：天）
        /// </summary>
        public int ApplyDays { get; set; }

        /// <summary>
        /// 审批记录
        /// </summary>
        public List<ApproverRecord> ApproverRecords { get; set; }

        /// <summary>
        /// 审批结果
        /// </summary>
        public bool? ApproveResult { get; set; }
    }
}
