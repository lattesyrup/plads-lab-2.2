namespace lists_p2.Classes;
#nullable disable

internal class CycledDoubleLinkedList()
{
    private DoubleNode head = new();

    #region create/add methods

    public void Create(int[] data)
    {
        Destroy();
        for (int i = 0; i < data.Length; i++)
            InsertAfterLast(data[i]);
    }

    public void InsertBeforeFirst(int data)
    {
        DoubleNode newNode = new(data, head.Next, head);
        head.Next.Prev = newNode;
        head.Next = newNode;
    }

    public void InsertAfterLast(int data)
    {
        DoubleNode newNode = new(data, head, head.Prev);
        head.Prev.Next = newNode;
        head.Prev = newNode;
    }

    public void InsertAt(int index, int data)
    {
        DoubleNode p = head.Next;
        for (int i = 0; p != head && i < index; i++) p = p.Next;
        if (p == head)
            MessageBox.Show($"Узла с номером {index} не существует.", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            DoubleNode newNode = new(data, p.Next, p);
            p.Next.Prev = newNode;
            p.Next = newNode;
        }
    }

    #endregion

    #region delete methods

    public void Destroy() => head = new();

    public void DeleteFirst()
    {
        head.Next = head.Next.Next;
        head.Next.Prev = head;
    }

    public void DeleteLast()
    {
        head.Prev = head.Prev.Prev;
        head.Prev.Next = head;
    }

    // сделано: else -- сказать, что нет узла
    public void DeleteAt(int index)
    {
        DoubleNode p = head.Next;
        for (int i = 0; p != head && i < index; i++) p = p.Next;
        if (p != head)
        {
            p.Next.Prev = p.Prev;
            p.Prev.Next = p.Next;
        }
        else MessageBox.Show($"Узла с номером {index} не существует.", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    #endregion

    #region applied methods

    // сделано: вывод сразу в листбокс без массива
    public void FillListBox(ListBox lb)
    {
        DoubleNode p = head.Next;
        while (p != head)
        {
            lb.Items.Add(p.Info.ToString());
            p = p.Next;
        }
    }

    // сделано: копировать сразу из списка в список
    public CycledDoubleLinkedList GetCopy()
    {
        CycledDoubleLinkedList copy = new();
        
        DoubleNode p = head.Next;
        while (p != head)
        {
            copy.InsertAfterLast((int)p.Info);
            p = p.Next;
        }

        return copy;
    }

    private void InsertListBetween(DoubleNode left, DoubleNode right,
        CycledDoubleLinkedList insert)
    {
        if (insert.head.Next != insert.head)
        {
            DoubleNode p = insert.head.Next;
            while (p.Next != insert.head) p = p.Next;
            p.Next = right;
            right.Prev = p;

            left.Next = insert.head.Next;
            left.Next.Prev = left;
        }
    }

    public bool IsFilled() => head.Next != head;

    #endregion

    #region task performing

    public void Replace(CycledDoubleLinkedList find, CycledDoubleLinkedList replace)
    {
        if (find.IsFilled())
        {
            DoubleNode cur = head.Next,     // current
               finder = find.head.Next,     // finder -- current in find insert
               cp = head;                   // checkpoint

            while (cur != head)
            {
                if (cur.Info == finder.Info)
                {
                    cur = cur.Next;
                    finder = finder.Next;

                    if (finder == find.head)
                    {
                        InsertListBetween(cp, cur, replace.GetCopy());
                        cp = cur.Prev;
                        finder = find.head.Next;
                    }
                }
                else
                {
                    cp = cp.Next;
                    finder = find.head.Next;
                    cur = cp.Next;
                }
            }
        }
    }

    #endregion
}
