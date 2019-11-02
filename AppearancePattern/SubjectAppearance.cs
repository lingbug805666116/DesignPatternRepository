using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearancePattern
{
    public class SubjectAppearance
    {
        public void ChooseSubject(string subjectName)
        {
            //外观模式，将后台系统封装在这里面，客户端要调用也是统一调用外观，不会直接请求后台系统
            var validateSubject = new ValidateChooseSubject();
            var chooseSubject = new ChooseSubject();
            var notify = new SubjectNotify();
            //判断是否选满
            var isFull = validateSubject.IsFull(subjectName);
            //没选满，选课
            if (!isFull)
            {
                chooseSubject.Choose(subjectName);
            }
            //选课完毕，发送通知
            notify.Notify(subjectName, !isFull);
        }
    }
}
