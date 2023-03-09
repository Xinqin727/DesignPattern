using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    /// <summary>
    /// 工作经历
    /// </summary>
        //2.在基础的简历模板上，每一份简历是不一样的，把特别的地方单拎出来
    public class WorkExperence
    {
        public string Company { get; set; }

        public string Detail { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public void Display()
        {
            Console.WriteLine("工作经历:");
            Console.WriteLine($"{this.Company}\t{this.StartDate.ToShortDateString()}-{EndDate.ToShortDateString()}");
            Console.WriteLine("工作详细:");
            Console.WriteLine(this.Detail);
        }
    }
}
