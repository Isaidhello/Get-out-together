<<<<<<< HEAD
using NUnit.Framework.Constraints;

namespace UnityEngine.TestTools.Constraints
{
    public static class ConstraintExtensions
    {
        public static AllocatingGCMemoryConstraint AllocatingGCMemory(this ConstraintExpression chain)
        {
            var constraint = new AllocatingGCMemoryConstraint();
            chain.Append(constraint);
            return constraint;
        }
    }
}
=======
using NUnit.Framework.Constraints;

namespace UnityEngine.TestTools.Constraints
{
    public static class ConstraintExtensions
    {
        public static AllocatingGCMemoryConstraint AllocatingGCMemory(this ConstraintExpression chain)
        {
            var constraint = new AllocatingGCMemoryConstraint();
            chain.Append(constraint);
            return constraint;
        }
    }
}
>>>>>>> parent of 7474897... purge
