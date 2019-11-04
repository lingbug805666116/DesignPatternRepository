using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    class Program
    {
        /// <summary>
        /// 责任链模式：
        /// 在日常生活中，我们经常见到一种情况，就是不同的情况需要不同的对待
        ///
        /// 例如：
        /// 你需要请假，提交了请假申请后，
        /// 如果你请假时间是1-3天，你的部门主管同意就可以了，
        /// 如果你请假时间是3-7天，那你的部门主管同意后还不行，还需要你的部门总监同意才可以，
        /// 如果你请假时间大于7天，那你的部门主管和部门总监同意都还不行，必须需要老板同意才可以
        /// 上面的这种模式，就是一个很明显的责任链模式
        ///
        /// 当然我们最基础的实现， 就是使用if else不停的去判断，
        /// 这样会导致后期很难维护，并且每个模块之间的耦合性太高，使得程序没有扩展性
        ///
        /// 使用责任链模式，就可以进行解耦，并且还易于扩展
        ///
        /// 当然责任链模式也不是说没有缺点：
        /// 缺点就是导致可能会有性能的问题，还有就是有可能请求不会被处理（这个很少见）
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //初始化请假申请
            LeaveApply apply1 = new LeaveApply("张三", 1);
            LeaveApply apply2 = new LeaveApply("小明", 5);
            LeaveApply apply3 = new LeaveApply("王五", 10);
            LeaveApply apply4 = new LeaveApply("王五", 15);
            //初始化审批人
            Approver deptManager = new DeptManager("部门主管");
            Approver deptInspector = new DeptInspector("部门总监");
            Approver boss = new Boss("老板");

            Console.WriteLine("-------------------------------------------------");
            //设置责任链
            deptManager.NextApprover = deptInspector;
            deptInspector.NextApprover = boss;

            Console.WriteLine("-------------------------------------------------");
            //开始审批
            deptManager.ApproveApply(apply1);
            Console.WriteLine("-------------------------------------------------");
            deptManager.ApproveApply(apply2);
            Console.WriteLine("-------------------------------------------------");
            deptManager.ApproveApply(apply3);
            Console.WriteLine("-------------------------------------------------");
            deptManager.ApproveApply(apply4);

            Console.ReadKey();
        }
    }
}
