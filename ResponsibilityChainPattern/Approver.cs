using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    /// <summary>
    /// 审批人对象（抽象）
    /// </summary>
    public abstract class Approver
    {
        public Approver(string approveName)
        {
            this.ApproveName = approveName;
        }

        private Approver _NextApprover;

        /// <summary>
        /// 下一级审批人
        /// </summary>
        public Approver NextApprover
        {
            get { return _NextApprover; }
            set
            {
                Console.WriteLine("将{0}的下一级审批人设置为{1}", this.ApproveName, value.ApproveName);
                _NextApprover = value;
            }
        }

        /// <summary>
        /// 审批人姓名
        /// </summary>
        public string ApproveName { get; set; }

        /// <summary>
        /// 审批的方法，不同实现类责任不同，所以交给实现类去实现
        /// </summary>
        /// <param name="leaveApply"></param>
        public abstract void ApproveApply(LeaveApply leaveApply);
    }
}
