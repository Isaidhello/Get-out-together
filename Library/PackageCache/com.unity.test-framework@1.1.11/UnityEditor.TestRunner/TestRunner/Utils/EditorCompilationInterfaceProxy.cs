<<<<<<< HEAD
using UnityEditor.Scripting.ScriptCompilation;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorCompilationInterfaceProxy : IEditorCompilationInterfaceProxy
    {
        public ScriptAssembly[] GetAllEditorScriptAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllEditorScriptAssemblies(EditorCompilationInterface.GetAdditionalEditorScriptCompilationOptions());
        }

        public PrecompiledAssembly[] GetAllPrecompiledAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllPrecompiledAssemblies();
        }
    }
}
=======
using UnityEditor.Scripting.ScriptCompilation;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorCompilationInterfaceProxy : IEditorCompilationInterfaceProxy
    {
        public ScriptAssembly[] GetAllEditorScriptAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllEditorScriptAssemblies(EditorCompilationInterface.GetAdditionalEditorScriptCompilationOptions());
        }

        public PrecompiledAssembly[] GetAllPrecompiledAssemblies()
        {
            return EditorCompilationInterface.Instance.GetAllPrecompiledAssemblies();
        }
    }
}
>>>>>>> parent of 7474897... purge
