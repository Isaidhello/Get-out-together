<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestFinishedMessage : Message
    {
        public string name;
        public TestState state;
        public string message;
        public ulong duration; // milliseconds
        public ulong durationMicroseconds;
        public string stackTrace;

        public TestFinishedMessage()
        {
            type = "TestStatus";
            phase = "End";
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestFinishedMessage : Message
    {
        public string name;
        public TestState state;
        public string message;
        public ulong duration; // milliseconds
        public ulong durationMicroseconds;
        public string stackTrace;

        public TestFinishedMessage()
        {
            type = "TestStatus";
            phase = "End";
        }
    }
}
>>>>>>> parent of 7474897... purge
