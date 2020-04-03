<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools
{
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        All = 0xFF,
        EditMode = 1 << 1,
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
=======
using System;

namespace UnityEngine.TestTools
{
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        All = 0xFF,
        EditMode = 1 << 1,
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
>>>>>>> parent of 7474897... purge
