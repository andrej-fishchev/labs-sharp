using labs.shared.data.structures;

namespace labs.shared.data.algorithms.BinaryTreeAlgorithms.bypasses;

public sealed class PreOrderTreeWalk<T> :
    ITreeWalkAlgorithm<T>
{
    public IEnumerable<T> DataWalk(TreeNode<T>? node)
    {
        if (node == null)
            yield break;
        
        yield return node.Data();
        
        foreach (var left in DataWalk(node.Left()))
            yield return left;
        
        foreach (var right in DataWalk(node.Right()))
            yield return right;
    }
    
    public IEnumerable<TreeNode<T>> NodeWalk(TreeNode<T>? node)
    {
        if (node == null)
            yield break;
        
        yield return node;
        
        foreach (var left in NodeWalk(node.Left()))
            yield return left;
        
        foreach (var right in NodeWalk(node.Right()))
            yield return right;
    }
}