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
    public class sp_create_RecommendShirtColor_UnitTests : SqlDatabaseTestClass
    {

        public sp_create_RecommendShirtColor_UnitTests()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_create_RecommendShirtColorTest_Basic_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sp_create_RecommendShirtColor_UnitTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_create_RecommendShirtColorTest_RowCount_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_create_RecommendShirtColorTest_RowCount_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_create_RecommendShirtColorTest_Basic_PretestAction;
            this.sp_create_RecommendShirtColorTest_BasicData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.sp_create_RecommendShirtColorTest_RowCountData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            sp_create_RecommendShirtColorTest_Basic_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            sp_create_RecommendShirtColorTest_RowCount_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            sp_create_RecommendShirtColorTest_RowCount_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sp_create_RecommendShirtColorTest_Basic_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // sp_create_RecommendShirtColorTest_Basic_TestAction
            // 
            sp_create_RecommendShirtColorTest_Basic_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            resources.ApplyResources(sp_create_RecommendShirtColorTest_Basic_TestAction, "sp_create_RecommendShirtColorTest_Basic_TestAction");
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
            // 
            // sp_create_RecommendShirtColorTest_RowCount_TestAction
            // 
            sp_create_RecommendShirtColorTest_RowCount_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(sp_create_RecommendShirtColorTest_RowCount_TestAction, "sp_create_RecommendShirtColorTest_RowCount_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // sp_create_RecommendShirtColorTest_RowCount_PretestAction
            // 
            resources.ApplyResources(sp_create_RecommendShirtColorTest_RowCount_PretestAction, "sp_create_RecommendShirtColorTest_RowCount_PretestAction");
            // 
            // sp_create_RecommendShirtColorTest_Basic_PretestAction
            // 
            resources.ApplyResources(sp_create_RecommendShirtColorTest_Basic_PretestAction, "sp_create_RecommendShirtColorTest_Basic_PretestAction");
            // 
            // sp_create_RecommendShirtColorTest_BasicData
            // 
            this.sp_create_RecommendShirtColorTest_BasicData.PosttestAction = null;
            this.sp_create_RecommendShirtColorTest_BasicData.PretestAction = sp_create_RecommendShirtColorTest_Basic_PretestAction;
            this.sp_create_RecommendShirtColorTest_BasicData.TestAction = sp_create_RecommendShirtColorTest_Basic_TestAction;
            // 
            // sp_create_RecommendShirtColorTest_RowCountData
            // 
            this.sp_create_RecommendShirtColorTest_RowCountData.PosttestAction = null;
            this.sp_create_RecommendShirtColorTest_RowCountData.PretestAction = sp_create_RecommendShirtColorTest_RowCount_PretestAction;
            this.sp_create_RecommendShirtColorTest_RowCountData.TestAction = sp_create_RecommendShirtColorTest_RowCount_TestAction;
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
        public void sp_create_RecommendShirtColorTest_Basic()
        {
            SqlDatabaseTestActions testActions = this.sp_create_RecommendShirtColorTest_BasicData;
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
        [TestMethod()]
        [TestCategory("SQL Unit Tests")]
        public void sp_create_RecommendShirtColorTest_RowCount()
        {
            SqlDatabaseTestActions testActions = this.sp_create_RecommendShirtColorTest_RowCountData;
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

        private SqlDatabaseTestActions sp_create_RecommendShirtColorTest_BasicData;
        private SqlDatabaseTestActions sp_create_RecommendShirtColorTest_RowCountData;
    }
}
