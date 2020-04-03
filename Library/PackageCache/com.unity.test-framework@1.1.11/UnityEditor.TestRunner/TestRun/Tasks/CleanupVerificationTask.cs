<<<<<<< HEAD
using System;
using System.Collections;
using System.IO;
using System.Linq;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class CleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        private const string k_Indent = "    ";
        
        internal Action<object> logAction = Debug.LogWarning;
        
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var currentFiles = GetAllFilesInAssetsDirectory();
            var existingFiles = testJobData.existingFiles;

            if (currentFiles.Length != existingFiles.Length)
            {
                LogWarningForFilesIfAny(currentFiles.Where(file => !testJobData.existingFiles.Contains(file)).ToArray());
            }

            yield return null;
        }
        
        private void LogWarningForFilesIfAny(string[] filePaths)
        {
            if (!filePaths.Any())
            {
                return;
            }

            var stringWriter = new StringWriter();
            stringWriter.WriteLine("Files generated by test without cleanup.");
            stringWriter.WriteLine(k_Indent + "Found {0} new files.", filePaths.Length);

            foreach (var filePath in filePaths)
            {
                stringWriter.WriteLine(k_Indent + filePath);
            }

            logAction(stringWriter.ToString());
        }
    }
=======
using System;
using System.Collections;
using System.IO;
using System.Linq;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class CleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        private const string k_Indent = "    ";
        
        internal Action<object> logAction = Debug.LogWarning;
        
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var currentFiles = GetAllFilesInAssetsDirectory();
            var existingFiles = testJobData.existingFiles;

            if (currentFiles.Length != existingFiles.Length)
            {
                LogWarningForFilesIfAny(currentFiles.Where(file => !testJobData.existingFiles.Contains(file)).ToArray());
            }

            yield return null;
        }
        
        private void LogWarningForFilesIfAny(string[] filePaths)
        {
            if (!filePaths.Any())
            {
                return;
            }

            var stringWriter = new StringWriter();
            stringWriter.WriteLine("Files generated by test without cleanup.");
            stringWriter.WriteLine(k_Indent + "Found {0} new files.", filePaths.Length);

            foreach (var filePath in filePaths)
            {
                stringWriter.WriteLine(k_Indent + filePath);
            }

            logAction(stringWriter.ToString());
        }
    }
>>>>>>> parent of 7474897... purge
}