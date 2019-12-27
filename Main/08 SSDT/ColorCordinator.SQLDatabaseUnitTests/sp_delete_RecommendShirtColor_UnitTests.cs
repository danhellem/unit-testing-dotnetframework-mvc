using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorCordinator.SQLDatabaseUnitTests
{
    [TestClass()]
    public class sp_delete_RecommendShirtColor_UnitTests : SqlDatabaseTestClass
    {

        public sp_delete_RecommendShirtColor_UnitTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_delete_RecommendShirtColorTest_RowCount_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sp_delete_RecommendShirtColor_UnitTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_delete_RecommendShirtColorTest_RowCount_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            this.sp_delete_RecommendShirtColorTest_RowCountData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            sp_delete_RecommendShirtColorTest_RowCount_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sp_delete_RecommendShirtColorTest_RowCount_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // sp_delete_RecommendShirtColorTest_RowCount_TestAction
            // 
            sp_delete_RecommendShirtColorTest_RowCount_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(sp_delete_RecommendShirtColorTest_RowCount_TestAction, "sp_delete_RecommendShirtColorTest_RowCount_TestAction");
            // 
            // sp_delete_RecommendShirtColorTest_RowCount_PretestAction
            // 
            resources.ApplyResources(sp_delete_RecommendShirtColorTest_RowCount_PretestAction, "sp_delete_RecommendShirtColorTest_RowCount_PretestAction");
            // 
            // sp_delete_RecommendShirtColorTest_RowCountData
            // 
            this.sp_delete_RecommendShirtColorTest_RowCountData.PosttestAction = null;
            this.sp_delete_RecommendShirtColorTest_RowCountData.PretestAction = sp_delete_RecommendShirtColorTest_RowCount_PretestAction;
            this.sp_delete_RecommendShirtColorTest_RowCountData.TestAction = sp_delete_RecommendShirtColorTest_RowCount_TestAction;
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 2;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        [TestCategory("SQL Unit Tests")]
        public void sp_delete_RecommendShirtColorTest_RowCount()
        {
            SqlDatabaseTestActions testActions = this.sp_delete_RecommendShirtColorTest_RowCountData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        private SqlDatabaseTestActions sp_delete_RecommendShirtColorTest_RowCountData;
    }
}
