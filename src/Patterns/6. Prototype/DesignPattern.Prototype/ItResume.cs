using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    //第三步，将基础信息和拓展部分进行一个拼接，生成最终面世的一个产品，同时，每份简历都应该有创造自己的能力，直接写基类的抽象方法里面
    public class ItResume : ResumeBase
    {
        /// <summary>
        /// 工作经历
        /// </summary>
        public WorkExperence WorkExperence { get; set; }

        public override void Display()
        {
            Console.WriteLine($"姓名:\t{this.Name}");
            Console.WriteLine($"性别:\t{this.Gender}");
            Console.WriteLine($"年龄:\t{this.Age}");
            Console.WriteLine($"期望薪资:\t{this.ExpectedSalary}");
            Console.WriteLine("--------------------------------");
            if (this.WorkExperence != null)
            {
                this.WorkExperence.Display();
            }

            Console.WriteLine("--------------------------------");
        }
    }
}
