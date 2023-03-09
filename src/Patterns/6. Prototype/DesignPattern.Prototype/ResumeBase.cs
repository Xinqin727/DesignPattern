using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{


    //1.第一步，先创建基本的简历
    public abstract class ResumeBase
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 期望薪资
        /// </summary>
        public string ExpectedSalary { get; set; }

        public abstract void Display();
    }
}
