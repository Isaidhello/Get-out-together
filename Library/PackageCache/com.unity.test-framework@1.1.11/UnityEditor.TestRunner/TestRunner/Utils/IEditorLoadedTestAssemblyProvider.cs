<<<<<<< HEAD
using System.Collections.Generic;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface IEditorLoadedTestAssemblyProvider
    {
        List<IAssemblyWrapper> GetAssembliesGroupedByType(TestPlatform mode);
        IEnumerator<IDictionary<TestPlatform, List<IAssemblyWrapper>>> GetAssembliesGroupedByTypeAsync(TestPlatform mode);
    }
=======
using System.Collections.Generic;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface IEditorLoadedTestAssemblyProvider
    {
        List<IAssemblyWrapper> GetAssembliesGroupedByType(TestPlatform mode);
        IEnumerator<IDictionary<TestPlatform, List<IAssemblyWrapper>>> GetAssembliesGroupedByTypeAsync(TestPlatform mode);
    }
>>>>>>> parent of 7474897... purge
}