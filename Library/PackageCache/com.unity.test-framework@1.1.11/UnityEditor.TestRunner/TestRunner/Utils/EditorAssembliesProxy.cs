<<<<<<< HEAD
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
=======
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
>>>>>>> parent of 7474897... purge
