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
    public class sp_update_RecommendShirtColor_UnitTest : SqlDatabaseTestClass
    {

        public sp_update_RecommendShirtColor_UnitTest()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_sp_update_RecommendShirtColorTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sp_update_RecommendShirtColor_UnitTest));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_sp_update_RecommendShirtColorTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            this.dbo_sp_update_RecommendShirtColorTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_sp_update_RecommendShirtColorTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_sp_update_RecommendShirtColorTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_sp_update_RecommendShirtColorTest_TestAction
            // 
            dbo_sp_update_RecommendShirtColorTest_TestAction.Conditions.Add(scalarValueCondition1);
            dbo_sp_update_RecommendShirtColorTest_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(dbo_sp_update_RecommendShirtColorTest_TestAction, "dbo_sp_update_RecommendShirtColorTest_TestAction");
            // 
            // dbo_sp_update_RecommendShirtColorTestData
            // 
            this.dbo_sp_update_RecommendShirtColorTestData.PosttestAction = null;
            this.dbo_sp_update_RecommendShirtColorTestData.PretestAction = dbo_sp_update_RecommendShirtColorTest_PretestAction;
            this.dbo_sp_update_RecommendShirtColorTestData.TestAction = dbo_sp_update_RecommendShirtColorTest_TestAction;
            // 
            // dbo_sp_update_RecommendShirtColorTest_PretestAction
            // 
            resources.ApplyResources(dbo_sp_update_RecommendShirtColorTest_PretestAction, "dbo_sp_update_RecommendShirtColorTest_PretestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "red";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 2;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "orange";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
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
        public void dbo_sp_update_RecommendShirtColorTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_sp_update_RecommendShirtColorTestData;
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
        private SqlDatabaseTestActions dbo_sp_update_RecommendShirtColorTestData;
    }
}
