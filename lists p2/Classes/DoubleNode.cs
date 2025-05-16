namespace lists_p2.Classes;
#nullable disable

internal class DoubleNode
{
    public readonly int? Info;
    public DoubleNode Next;
    public DoubleNode Prev;

    /// <summary>
    /// Создание узла с ссылками на существующие узлы.
    /// </summary>
    /// <param name="info">Число.</param>
    /// <param name="next">Ссылка на следующий узел.</param>
    /// <param name="prev">Ссылка на предыдущий узел.</param>
    public DoubleNode(int? info, DoubleNode next, DoubleNode prev)
    {
        Info = info;
        Next = next;
        Prev = prev;
    }

    /// <summary>
    /// Создание элементарного кольца.
    /// </summary>
    public DoubleNode()
    {
        Info = null;
        Next = this;
        Prev = this;
    }
}
