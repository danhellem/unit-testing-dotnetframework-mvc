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
    public class sp_list_RecommendShirtColor_UnitTests : SqlDatabaseTestClass
    {

        public sp_list_RecommendShirtColor_UnitTests()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_list_RecommendShirtColorTest_RowCount_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sp_list_RecommendShirtColor_UnitTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_list_RecommendShirtColorTest_RowCount_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_list_RecommendShirtColorTest_RowCount_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_list_RecommendShortColorTest_ExpectedSchema_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction sp_list_RecommendShortColorTest_ExpectedSchema_PretestAction;
            this.sp_list_RecommendShirtColorTest_RowCountData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.sp_list_RecommendShortColorTest_ExpectedSchemaData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            sp_list_RecommendShirtColorTest_RowCount_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            sp_list_RecommendShirtColorTest_RowCount_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sp_list_RecommendShirtColorTest_RowCount_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sp_list_RecommendShortColorTest_ExpectedSchema_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            sp_list_RecommendShortColorTest_ExpectedSchema_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // sp_list_RecommendShirtColorTest_RowCount_TestAction
            // 
            sp_list_RecommendShirtColorTest_RowCount_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            sp_list_RecommendShirtColorTest_RowCount_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(sp_list_RecommendShirtColorTest_RowCount_TestAction, "sp_list_RecommendShirtColorTest_RowCount_TestAction");
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 3;
            // 
            // sp_list_RecommendShirtColorTest_RowCount_PretestAction
            // 
            resources.ApplyResources(sp_list_RecommendShirtColorTest_RowCount_PretestAction, "sp_list_RecommendShirtColorTest_RowCount_PretestAction");
            // 
            // sp_list_RecommendShirtColorTest_RowCount_PosttestAction
            // 
            resources.ApplyResources(sp_list_RecommendShirtColorTest_RowCount_PosttestAction, "sp_list_RecommendShirtColorTest_RowCount_PosttestAction");
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // sp_list_RecommendShortColorTest_ExpectedSchema_TestAction
            // 
            sp_list_RecommendShortColorTest_ExpectedSchema_TestAction.Conditions.Add(expectedSchemaCondition1);
            resources.ApplyResources(sp_list_RecommendShortColorTest_ExpectedSchema_TestAction, "sp_list_RecommendShortColorTest_ExpectedSchema_TestAction");
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
            // 
            // sp_list_RecommendShirtColorTest_RowCountData
            // 
            this.sp_list_RecommendShirtColorTest_RowCountData.PosttestAction = sp_list_RecommendShirtColorTest_RowCount_PosttestAction;
            this.sp_list_RecommendShirtColorTest_RowCountData.PretestAction = sp_list_RecommendShirtColorTest_RowCount_PretestAction;
            this.sp_list_RecommendShirtColorTest_RowCountData.TestAction = sp_list_RecommendShirtColorTest_RowCount_TestAction;
            // 
            // sp_list_RecommendShortColorTest_ExpectedSchemaData
            // 
            this.sp_list_RecommendShortColorTest_ExpectedSchemaData.PosttestAction = null;
            this.sp_list_RecommendShortColorTest_ExpectedSchemaData.PretestAction = sp_list_RecommendShortColorTest_ExpectedSchema_PretestAction;
            this.sp_list_RecommendShortColorTest_ExpectedSchemaData.TestAction = sp_list_RecommendShortColorTest_ExpectedSchema_TestAction;
            // 
            // sp_list_RecommendShortColorTest_ExpectedSchema_PretestAction
            // 
            resources.ApplyResources(sp_list_RecommendShortColorTest_ExpectedSchema_PretestAction, "sp_list_RecommendShortColorTest_ExpectedSchema_PretestAction");
            // 
            // sp_list_RecommendShirtColor_UnitTests
            // 
            this.TestInitializeAction = testInitializeAction;
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
        public void sp_list_RecommendShirtColorTest_RowCount()
        {
            SqlDatabaseTestActions testActions = this.sp_list_RecommendShirtColorTest_RowCountData;
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
        public void sp_list_RecommendShortColorTest_ExpectedSchema()
        {
            SqlDatabaseTestActions testActions = this.sp_list_RecommendShortColorTest_ExpectedSchemaData;
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


        private SqlDatabaseTestActions sp_list_RecommendShirtColorTest_RowCountData;
        private SqlDatabaseTestActions sp_list_RecommendShortColorTest_ExpectedSchemaData;
    }
}
