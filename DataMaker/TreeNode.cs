using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaker
{
    //结点类
    class TreeNode
    {
        //成员变量
        public int data;//数据
        public TreeNode left;//左结点
        public TreeNode right;//右结点
        public Boolean hasData = false;//结点是否初始化

        //构造函数
        public TreeNode() {
            data = 0;
            left = null;
            right = null;
        }

        public TreeNode(int i, TreeNode l, TreeNode r) {
            data = i;
            left = l;
            right = r;
        }

        public TreeNode(int val) {
            data = val;
        }

    }
}
