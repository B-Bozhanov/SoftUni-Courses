using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return !this.Any();
        }
        public void AddRange(Stack<string> stack)
        {
            foreach (var item in stack.Reverse())
            {
                Push(item);
            }
        }
    }
}
