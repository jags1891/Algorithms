namespace AlgorithmsLibrary.DataStructures
{
    /// <summary>
    /// SinglyLinkedListNode
    /// </summary>
    public class SinglyLinkedList
    {
        ListNode _head;
        ListNode _tail;
        int _length = 0;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="x"></param>
        public SinglyLinkedList(int x)
        {
            _head = new ListNode(x);
            _head.Val = x;
            _head.Next = null;
            _tail = Head;
            _length = 1;

        }

        /// <summary>
        /// Head of the List
        /// </summary>
        public ListNode Head
        {
            get{return _head;}
        }

        /// <summary>
        /// Tail of the List
        /// </summary>
        public ListNode Tail
        {
            get { return _tail; }
        }

        /// <summary>
        /// Returns length
        /// </summary>
        public int Length
        {
            get { return _length; }
        }


        /// <summary>
        /// Add the element at the end
        /// </summary>
        /// <param name="val"></param>
        public void Append(int val)
        {
            ListNode newObj = createNewObj(val);
            _tail.Next = newObj;
            _tail = newObj;
            _length++;
        }

        /// <summary>
        /// Prepend the node 
        /// </summary>
        /// <param name="val"></param>
        public void Prepend(int val)
        {
            ListNode newObj = createNewObj(val);
            newObj.Next = _head;
            _head = newObj;
            _length++;
        }

        /// <summary>
        /// Insert node at the specic index
        /// </summary>
        /// <param name="ind"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Insert(int ind, int val)
        {
            if (Length > ind)
            {
                int curInd = 1;
                ListNode curr = Head;
                while (curr != null && curInd<=ind)
                {
                    if(curInd==ind)
                    {
                        ListNode newObj = createNewObj(val);
                        newObj.Next = curr.Next;
                        curr.Next = newObj;
                        return true;
                    }
                    curr = curr.Next;
                    curInd++;
                }
            }

            return false;
        }

        private ListNode createNewObj(int val)
        {
            ListNode newObj = new ListNode(val);
            newObj.Next = null;
            return newObj;
        }

    }

    /// <summary>
    /// ListNode
    /// </summary>
    public class ListNode
    {
         public int Val;
         public ListNode Next;
         public ListNode(int x) { Val = x; }
    }
}
