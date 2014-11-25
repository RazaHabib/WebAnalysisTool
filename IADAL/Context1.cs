


using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using SubSonic.Linq.Structure;
using SubSonic.Query;
using SubSonic.Schema;
using System.Data.Common;
using System.Collections.Generic;

namespace IADAL
{
    public partial class InfoArchDB : IQuerySurface
    {

        public IDataProvider DataProvider;
        public DbQueryProvider provider;
        
        public bool TestMode
		{
            get
			{
                return DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public InfoArchDB() 
        { 
            DataProvider = ProviderFactory.GetProvider("InfoArch");
            Init();
        }

        public InfoArchDB(string connectionStringName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionStringName);
            Init();
        }

		public InfoArchDB(string connectionString, string providerName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionString,providerName);
            Init();
        }

		public ITable FindByPrimaryKey(string pkName)
        {
            return DataProvider.Schema.Tables.SingleOrDefault(x => x.PrimaryKey.Name.Equals(pkName, StringComparison.InvariantCultureIgnoreCase));
        }

        public Query<T> GetQuery<T>()
        {
            return new Query<T>(provider);
        }
        
        public ITable FindTable(string tableName)
        {
            return DataProvider.FindTable(tableName);
        }
               
        public IDataProvider Provider
        {
            get { return DataProvider; }
            set {DataProvider=value;}
        }
        
        public DbQueryProvider QueryProvider
        {
            get { return provider; }
        }
        
        BatchQuery _batch = null;
        public void Queue<T>(IQueryable<T> qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void Queue(ISqlQuery qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void ExecuteTransaction(IList<DbCommand> commands)
		{
            if(!TestMode)
			{
                using(var connection = commands[0].Connection)
				{
                   if (connection.State == ConnectionState.Closed)
                        connection.Open();
                   
                   using (var trans = connection.BeginTransaction()) 
				   {
                        foreach (var cmd in commands) 
						{
                            cmd.Transaction = trans;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    connection.Close();
                }
            }
        }

        public IDataReader ExecuteBatch()
        {
            if (_batch == null)
                throw new InvalidOperationException("There's nothing in the queue");
            if(!TestMode)
                return _batch.ExecuteReader();
            return null;
        }
			
        public Query<TemplateOfLinks_Cosine> TemplateOfLinks_Cosines { get; set; }
        public Query<WebPage> WebPages { get; set; }
        public Query<Heading> Headings { get; set; }
        public Query<LinkWithHeading> LinkWithHeadings { get; set; }
        public Query<Paragraph> Paragraphs { get; set; }
        public Query<WebPageTUB> WebPageTUBs { get; set; }
        public Query<LinkWithHeadingTUB> LinkWithHeadingTUBs { get; set; }
        public Query<LinkWithoutHeadingTUB> LinkWithoutHeadingTUBs { get; set; }
        public Query<TemplateOfLinksTUB> TemplateOfLinksTUBs { get; set; }
        public Query<LinkWithoutHeadingTemplateOfLinksTUB> LinkWithoutHeadingTemplateOfLinksTUBs { get; set; }
        public Query<ParagraphTUB> ParagraphTUBs { get; set; }
        public Query<Page_Visited_Unsuccessfully> Page_Visited_Unsuccessfullies { get; set; }
        public Query<LinkWithoutHeadingPathAdequacy_Cosine> LinkWithoutHeadingPathAdequacy_Cosines { get; set; }
        public Query<Goal> Goals { get; set; }
        public Query<LinkUnderHeadingPathAdequacy_Cosine> LinkUnderHeadingPathAdequacy_Cosines { get; set; }
        public Query<PageTemplate> PageTemplates { get; set; }
        public Query<LinkWithoutHeading_Cosine> LinkWithoutHeading_Cosines { get; set; }
        public Query<LinkUnderHeading_Cosine> LinkUnderHeading_Cosines { get; set; }
        public Query<Path> Paths { get; set; }
        public Query<Solution_Found> Solution_Founds { get; set; }
        public Query<HeadingModified> HeadingModifieds { get; set; }
        public Query<LinkWithHeadingTUBSModified> LinkWithHeadingTUBSModifieds { get; set; }
        public Query<LinkWithoutHeadingTUBSModified> LinkWithoutHeadingTUBSModifieds { get; set; }
        public Query<CosineLinkLinkWithHeadingTUB> CosineLinkLinkWithHeadingTUBs { get; set; }
        public Query<HeadingvsHeadinginSamePageCosinesTUB> HeadingvsHeadinginSamePageCosinesTUBs { get; set; }
        public Query<HeadingTUBSTVL> HeadingTUBSTVLs { get; set; }
        public Query<HeadingvsHeadinginSamePageCosine> HeadingvsHeadinginSamePageCosines { get; set; }
        public Query<CosineLinkLinkWithoutHeadingTUB> CosineLinkLinkWithoutHeadingTUBs { get; set; }
        public Query<Paragraph_Cosine> Paragraph_Cosines { get; set; }
        public Query<HeadingPathAdequacy_Cosine> HeadingPathAdequacy_Cosines { get; set; }
        public Query<LinkLinkTemplateOfLink> LinkLinkTemplateOfLinks { get; set; }
        public Query<LinkWithoutHeadingTemplateOfLink> LinkWithoutHeadingTemplateOfLinks { get; set; }
        public Query<TemplateOfLink> TemplateOfLinks { get; set; }
        public Query<AnImage> AnImages { get; set; }
        public Query<AnImageWithoutHeading> AnImageWithoutHeadings { get; set; }
        public Query<CosineImageImageUnderSameHeading> CosineImageImageUnderSameHeadings { get; set; }
        public Query<CosineImageImageWithoutHeading> CosineImageImageWithoutHeadings { get; set; }
        public Query<CosineLinkLinkWithoutHeading> CosineLinkLinkWithoutHeadings { get; set; }
        public Query<CosineLinkLinkWithHeading> CosineLinkLinkWithHeadings { get; set; }
        public Query<WebSite> WebSites { get; set; }
        public Query<Heading_Cosine> Heading_Cosines { get; set; }
        public Query<LinkWithoutHeading> LinkWithoutHeadings { get; set; }

			

        #region ' Aggregates and SubSonic Queries '
        public Select SelectColumns(params string[] columns)
        {
            return new Select(DataProvider, columns);
        }

        public Select Select
        {
            get { return new Select(this.Provider); }
        }

        public Insert Insert
		{
            get { return new Insert(this.Provider); }
        }

        public Update<T> Update<T>() where T:new()
		{
            return new Update<T>(this.Provider);
        }

        public SqlQuery Delete<T>(Expression<Func<T,bool>> column) where T:new()
        {
            LambdaExpression lamda = column;
            SqlQuery result = new Delete<T>(this.Provider);
            result = result.From<T>();
            result.Constraints=lamda.ParseConstraints().ToList();
            return result;
        }

        public SqlQuery Max<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = DataProvider.FindTable(objectName).Name;
            return new Select(DataProvider, new Aggregate(colName, AggregateFunction.Max)).From(tableName);
        }

        public SqlQuery Min<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Min)).From(tableName);
        }

        public SqlQuery Sum<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Sum)).From(tableName);
        }

        public SqlQuery Avg<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Avg)).From(tableName);
        }

        public SqlQuery Count<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Count)).From(tableName);
        }

        public SqlQuery Variance<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Var)).From(tableName);
        }

        public SqlQuery StandardDeviation<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.StDev)).From(tableName);
        }

        #endregion

        void Init()
        {
            provider = new DbQueryProvider(this.Provider);

            #region ' Query Defs '
            TemplateOfLinks_Cosines = new Query<TemplateOfLinks_Cosine>(provider);
            WebPages = new Query<WebPage>(provider);
            Headings = new Query<Heading>(provider);
            LinkWithHeadings = new Query<LinkWithHeading>(provider);
            Paragraphs = new Query<Paragraph>(provider);
            WebPageTUBs = new Query<WebPageTUB>(provider);
            LinkWithHeadingTUBs = new Query<LinkWithHeadingTUB>(provider);
            LinkWithoutHeadingTUBs = new Query<LinkWithoutHeadingTUB>(provider);
            TemplateOfLinksTUBs = new Query<TemplateOfLinksTUB>(provider);
            LinkWithoutHeadingTemplateOfLinksTUBs = new Query<LinkWithoutHeadingTemplateOfLinksTUB>(provider);
            ParagraphTUBs = new Query<ParagraphTUB>(provider);
            Page_Visited_Unsuccessfullies = new Query<Page_Visited_Unsuccessfully>(provider);
            LinkWithoutHeadingPathAdequacy_Cosines = new Query<LinkWithoutHeadingPathAdequacy_Cosine>(provider);
            Goals = new Query<Goal>(provider);
            LinkUnderHeadingPathAdequacy_Cosines = new Query<LinkUnderHeadingPathAdequacy_Cosine>(provider);
            PageTemplates = new Query<PageTemplate>(provider);
            LinkWithoutHeading_Cosines = new Query<LinkWithoutHeading_Cosine>(provider);
            LinkUnderHeading_Cosines = new Query<LinkUnderHeading_Cosine>(provider);
            Paths = new Query<Path>(provider);
            Solution_Founds = new Query<Solution_Found>(provider);
            HeadingModifieds = new Query<HeadingModified>(provider);
            LinkWithHeadingTUBSModifieds = new Query<LinkWithHeadingTUBSModified>(provider);
            LinkWithoutHeadingTUBSModifieds = new Query<LinkWithoutHeadingTUBSModified>(provider);
            CosineLinkLinkWithHeadingTUBs = new Query<CosineLinkLinkWithHeadingTUB>(provider);
            HeadingvsHeadinginSamePageCosinesTUBs = new Query<HeadingvsHeadinginSamePageCosinesTUB>(provider);
            HeadingTUBSTVLs = new Query<HeadingTUBSTVL>(provider);
            HeadingvsHeadinginSamePageCosines = new Query<HeadingvsHeadinginSamePageCosine>(provider);
            CosineLinkLinkWithoutHeadingTUBs = new Query<CosineLinkLinkWithoutHeadingTUB>(provider);
            Paragraph_Cosines = new Query<Paragraph_Cosine>(provider);
            HeadingPathAdequacy_Cosines = new Query<HeadingPathAdequacy_Cosine>(provider);
            LinkLinkTemplateOfLinks = new Query<LinkLinkTemplateOfLink>(provider);
            LinkWithoutHeadingTemplateOfLinks = new Query<LinkWithoutHeadingTemplateOfLink>(provider);
            TemplateOfLinks = new Query<TemplateOfLink>(provider);
            AnImages = new Query<AnImage>(provider);
            AnImageWithoutHeadings = new Query<AnImageWithoutHeading>(provider);
            CosineImageImageUnderSameHeadings = new Query<CosineImageImageUnderSameHeading>(provider);
            CosineImageImageWithoutHeadings = new Query<CosineImageImageWithoutHeading>(provider);
            CosineLinkLinkWithoutHeadings = new Query<CosineLinkLinkWithoutHeading>(provider);
            CosineLinkLinkWithHeadings = new Query<CosineLinkLinkWithHeading>(provider);
            WebSites = new Query<WebSite>(provider);
            Heading_Cosines = new Query<Heading_Cosine>(provider);
            LinkWithoutHeadings = new Query<LinkWithoutHeading>(provider);
            #endregion


            #region ' Schemas '
        	if(DataProvider.Schema.Tables.Count == 0)
			{
            	DataProvider.Schema.Tables.Add(new TemplateOfLinks_CosineTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WebPageTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new HeadingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithHeadingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ParagraphTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WebPageTUBSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithHeadingTUBSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithoutHeadingTUBSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TemplateOfLinksTUBSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithoutHeadingTemplateOfLinksTUBSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ParagraphTUBSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new Page_Visited_UnsuccessfullyTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithoutHeadingPathAdequacy_CosineTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new GoalTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkUnderHeadingPathAdequacy_CosineTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PageTemplateTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithoutHeading_CosineTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkUnderHeading_CosineTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PathTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new Solution_FoundTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new HeadingModifiedTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithHeadingTUBSModifiedTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithoutHeadingTUBSModifiedTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CosineLinkLinkWithHeadingTUBSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new HeadingvsHeadinginSamePageCosinesTUBSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new HeadingTUBSTVLTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new HeadingvsHeadinginSamePageCosinesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CosineLinkLinkWithoutHeadingTUBSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new Paragraph_CosineTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new HeadingPathAdequacy_CosineTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkLinkTemplateOfLinksTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithoutHeadingTemplateOfLinksTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TemplateOfLinksTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AnImageTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AnImageWithoutHeadingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CosineImageImageUnderSameHeadingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CosineImageImageWithoutHeadingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CosineLinkLinkWithoutHeadingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CosineLinkLinkWithHeadingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WebSiteTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new Heading_CosineTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LinkWithoutHeadingTable(DataProvider));
            }
            #endregion
        }
    }
}