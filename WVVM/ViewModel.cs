using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WVVM
{
    public class ViewModel
    {
        public Student Stu { get; set; }
        public MyCommad Mcomd { get; set; }

        public ViewModel()
        {
            Stu = new Student() { Pid = 1, Pname = "张三" };
            Mcomd = new MyCommad(SetText);
        }

        private void SetText(object str)
        {
            Stu.Pname = "李四";
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private int pid;

        public int Pid
        {
            get { return pid; }
            set 
            {
                pid = value;
                
                //此处要判断是否订阅事件
                if (this.PropertyChanged != null)
                {
                    OnPropertyChanged("Pid");
                }
            }
        }

        private string pname;

        public string Pname
        {
            get { return pname; }
            set
            {
                pname = value;
                if (this.PropertyChanged != null)
                {
                    OnPropertyChanged("Pname");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
