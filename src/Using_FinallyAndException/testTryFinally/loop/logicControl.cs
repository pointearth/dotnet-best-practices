using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTryFinally.loop
{
    class logicControl
    {
        private const int _count = 10;
        private List<int> _curList = new List<int>();

        public void run()
        {
            initList(_count);
            modifyList curML = new modifyList();
            traverseList curTL = new traverseList();
            Task tTask = new Task(new Action());
            tTask.Start();
            Task mTask = new Task(new Action());
            mTask.Start();
            
        }
        private void initList(int count)
        {
            for (int i = 0; i < count; ++i)
            { 
                _curList.Add(i);
            }
        }
    }
}
