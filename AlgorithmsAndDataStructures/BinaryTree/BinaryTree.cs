using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _head;

        private int _count;
        public int Count => _count;

        public void Add(T value)
        {
            if (_head == null) // Первый случай: дерево пустое 
            {
                _head = new BinaryTreeNode<T>(value, null);
            }
            else //Второй случай: дерево не пустое, поэтому применяем рекурсивный алгорит для поиска места добавления узла                 
            {
                AddTo(_head, value);
            }
            _count++;
        }

        // Рекурсивный алгоритм 

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            // Первый случай: значение добавляемого узла меньше чем значение текущего. 
            if (value.CompareTo(node.Value) < 0)
            {
                // если левый потомок отсутствует - добавляем его          
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value, node);
                }
                else
                {
                    // повторная итерация               
                    AddTo(node.Left, value);
                }
            }
            // Второй случай: значение добавляемого узла равно или больше текущего значения      
            else
            {
                // Если правый потомок отсутствует - добавлем его.          
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value, node);
                }
                else
                {
                    // повторная итерация
                    AddTo(node.Right, value);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return PostOrderTraversal();
        }

        //TASK: Реализуйте алгоритм прямого(PreOrder) обхода дерева дополнив примеры из урока. 
        public IEnumerator<T> PreOrderTraversal()
        {
            if (_head == null)
                yield break;

            var current = _head; //начинаем с головы
            var stack = new Stack<BinaryTreeNode<T>>(); //тут будем хранить правые узлы

            while (true)
            {
                yield return current.Value; //возвращаем текущий узел

                if (current.Right != null) //если есть правый узел, тогда мы вернёмся к этому узлу
                    stack.Push(current.Right);

                if (current.Left != null)//если есть левый узел, следующий итерация цикла будет работать над ним
                {
                    current = current.Left;
                }
                //а если нету левого, берём последний правый узел,
                //и след. итерация цикла будет работать над ним
                else if (stack.Count > 0)
                    current = stack.Pop();
                else break;
            }
        }

        //TASK: Реализуйте алгоритм обратного(PostOrder) обхода дерева дополнив примеры из урока. 
        public IEnumerator<T> PostOrderTraversal()
        {
            if (_head == null)
                yield break;

            var stack = new Stack<Tuple<BinaryTreeNode<T>, bool>>();
            stack.Push(new Tuple<BinaryTreeNode<T>, bool>(_head, false));

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (current.Item2)
                {
                    yield return current.Item1.Value;
                }
                else
                {
                    stack.Push(new Tuple<BinaryTreeNode<T>, bool>(current.Item1, true));
                    if (current.Item1.Right != null) stack.Push(new Tuple<BinaryTreeNode<T>, bool>(current.Item1.Right, false));
                    if (current.Item1.Left != null) stack.Push(new Tuple<BinaryTreeNode<T>, bool>(current.Item1.Left, false));
                }
            }
        }

        private BinaryTreeNode<T> GetLastLeft(BinaryTreeNode<T> current)
        {
            while (true)
            {
                if (current.Left != null)
                    current = current.Left;
                else return current;
            }
        }
    }

    public class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public BinaryTreeNode<TNode> Parent { get; set; }
        public BinaryTreeNode<TNode> Left { get; set; }
        public BinaryTreeNode<TNode> Right { get; set; }
        public TNode Value { get; private set; }

        public BinaryTreeNode(TNode value, BinaryTreeNode<TNode> parent)
        {
            Value = value;
            Parent = parent;
        }

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

    }
}
