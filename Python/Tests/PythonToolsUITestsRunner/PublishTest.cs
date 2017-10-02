// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRunnerInterop;

namespace PythonToolsUITestsRunner {
    [TestClass]
    public class PublishTest {
        #region UI test boilerplate
        public VsTestInvoker _vs => new VsTestInvoker(
            VsTestContext.Instance,
            // Remote container (DLL) name
            "Microsoft.PythonTools.Tests.PythonToolsUITests",
            // Remote class name
            $"PythonToolsUITests.{GetType().Name}"
        );

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize() => VsTestContext.Instance.TestInitialize(TestContext.DeploymentDirectory);
        [TestCleanup]
        public void TestCleanup() => VsTestContext.Instance.TestCleanup();
        [ClassCleanup]
        public static void ClassCleanup() => VsTestContext.Instance.Dispose();
        #endregion

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void TestPublishFiles() {
            _vs.RunTest(nameof(PythonToolsUITests.PublishTest.TestPublishFiles));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void TestPublishReadOnlyFiles() {
            _vs.RunTest(nameof(PythonToolsUITests.PublishTest.TestPublishReadOnlyFiles));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void TestPublishFilesControlled() {
            _vs.RunTest(nameof(PythonToolsUITests.PublishTest.TestPublishFilesControlled));
        }

        [TestMethod, Priority(1)]
        [TestCategory("Installed")]
        public void TestPublishFilesImpersonate() {
            _vs.RunTest(nameof(PythonToolsUITests.PublishTest.TestPublishFilesImpersonate));
        }

        [TestMethod, Priority(1)]
        [TestCategory("Installed")]
        public void TestPublishFilesImpersonateNoMachineName() {
            _vs.RunTest(nameof(PythonToolsUITests.PublishTest.TestPublishFilesImpersonateNoMachineName));
        }

        [TestMethod, Priority(1)]
        [TestCategory("Installed")]
        public void TestPublishFilesImpersonateWrongCredentials() {
            _vs.RunTest(nameof(PythonToolsUITests.PublishTest.TestPublishFilesImpersonateWrongCredentials));
        }

        [TestMethod, Priority(1)]
        [TestCategory("Installed")]
        public void TestPublishFilesImpersonateCancelCredentials() {
            _vs.RunTest(nameof(PythonToolsUITests.PublishTest.TestPublishFilesImpersonateCancelCredentials));
        }

        [TestMethod, Priority(1)]
        [TestCategory("Installed")]
        public void TestPublishFtp() {
            _vs.RunTest(nameof(PythonToolsUITests.PublishTest.TestPublishFtp));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void TestPublishVirtualEnvironment() {
            _vs.RunTest(nameof(PythonToolsUITests.PublishTest.TestPublishVirtualEnvironment));
        }
    }
}
