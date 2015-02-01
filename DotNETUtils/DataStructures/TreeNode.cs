using System.Collections.Generic;

namespace DotNETUtils.DataStructures
{
    /// <summary>
    /// Represents a node in a tree, with content of type <typeparam name="T">T</typeparam>.
    /// </summary>
    /// <typeparam name="T">The type of content to store in this <see cref="TreeNode"/></typeparam>.
    public class TreeNode<T>
    {
        public T Content { get; set; }

        public List<TreeNode<T>> ChildNodes { get; set; }

        /// <summary>
        /// Creates a <see cref="TreeNode"/> with the provided
        /// content, and an empty set of child nodes.
        /// </summary>
        public TreeNode(T content)
        {
            Content = content;
            ChildNodes = new List<TreeNode<T>>();
        }

        /// <summary>
        /// Creates a <see cref="TreeNode"/> containing the provided
        /// content and child nodes.
        /// </summary>
        public TreeNode(T content, List<TreeNode<T>> childNodes)
        {
            Content = content;
            ChildNodes = childNodes;
        }
    }
}