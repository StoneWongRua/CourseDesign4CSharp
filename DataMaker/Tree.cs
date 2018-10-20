using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaker
{
    //树类
    class Tree
    {
        private TreeNode head;//原始头节点
        private ArrayList midOrder;//按照中序遍历读取的数据
        private ArrayList al;//随机数生成的原始顺序表

        public TreeNode Root {
        get {
                return this.head;
            }
        }

        public Tree() { }

        public Tree(int data) {
            this.head = new TreeNode(data);
        }

        //构造函数
        public Tree(TreeNode headNode)
        {
            head = headNode;
            head.hasData = true;
        }


        //Method:判断该二叉树是否是空树
        public bool IsEmpty()
        {
            return this.head == null;
        }

        Stack<TreeNode> stack = new Stack<TreeNode>();



        //创建二叉树
        public void CreateTree(ArrayList al) {
            this.al = al;//初始化对象的顺序表
            int current = 1;//当前节点设置编号为1
            insertTree(current, this.head);//插入节点
        }

        //插入节点
        public void insertTree(int current, TreeNode root) {

            if ((current - 1) < al.Count)//current-1 为顺序表下标
            {
                int item = (int)al[current - 1];
                root.data = item;//将数据插入到节点
                root.hasData = true;
            }
            else
            {
                root.hasData = false;
                return;
            }

            root.left = new TreeNode();//为节点的左子节点分配内存空间
            root.right = new TreeNode();//为节点的右子节点分配内存空间
            insertTree(2 * current, root.left);//为左子节点插入数据
            insertTree(2 * current + 1, root.right);//为右子节点插入数据

            if (root.left.hasData == false) {//若左子节点无数据，则置为null
                root.left = null;
            }
            if (root.right.hasData == false)//若右子节点无数据，则置为null
            {
                root.right = null;
            }
        }


    }
}
