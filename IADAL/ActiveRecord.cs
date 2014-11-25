


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Data;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using System.Linq.Expressions;
using SubSonic.Schema;
using System.Collections;
using SubSonic;
using SubSonic.Repository;
using System.ComponentModel;
using System.Data.Common;

namespace IADAL
{
    
    
    /// <summary>
    /// A class which represents the TemplateOfLinks_Cosine table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class TemplateOfLinks_Cosine: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<TemplateOfLinks_Cosine> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<TemplateOfLinks_Cosine>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<TemplateOfLinks_Cosine> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(TemplateOfLinks_Cosine item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                TemplateOfLinks_Cosine item=new TemplateOfLinks_Cosine();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<TemplateOfLinks_Cosine> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public TemplateOfLinks_Cosine(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                TemplateOfLinks_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<TemplateOfLinks_Cosine>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public TemplateOfLinks_Cosine(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public TemplateOfLinks_Cosine(Expression<Func<TemplateOfLinks_Cosine, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<TemplateOfLinks_Cosine> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<TemplateOfLinks_Cosine> _repo;
            
            if(db.TestMode){
                TemplateOfLinks_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<TemplateOfLinks_Cosine>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<TemplateOfLinks_Cosine> GetRepo(){
            return GetRepo("","");
        }
        
        public static TemplateOfLinks_Cosine SingleOrDefault(Expression<Func<TemplateOfLinks_Cosine, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            TemplateOfLinks_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static TemplateOfLinks_Cosine SingleOrDefault(Expression<Func<TemplateOfLinks_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            TemplateOfLinks_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<TemplateOfLinks_Cosine, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<TemplateOfLinks_Cosine, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<TemplateOfLinks_Cosine> Find(Expression<Func<TemplateOfLinks_Cosine, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<TemplateOfLinks_Cosine> Find(Expression<Func<TemplateOfLinks_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<TemplateOfLinks_Cosine> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<TemplateOfLinks_Cosine> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<TemplateOfLinks_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<TemplateOfLinks_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<TemplateOfLinks_Cosine> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<TemplateOfLinks_Cosine> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkTemplateId";
        }

        public object KeyValue()
        {
            return this.LinkTemplateId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkAnchorText.ToString();
        }

        public static TemplateOfLinks_Cosine RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkTemplateId == keyValue);
		}
		
		
		public static TemplateOfLinks_Cosine Create(string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string CosineIn, out string SError){
			SError="";
 			TemplateOfLinks_Cosine newTemplateOfLinks_Cosine = new TemplateOfLinks_Cosine();
	   		try{
				newTemplateOfLinks_Cosine.UpdateValues(LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, CosineIn);
				newTemplateOfLinks_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newTemplateOfLinks_Cosine;
		}

		public string Update(string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string CosineIn){
			this.LinkAnchorText = LinkAnchorTextIn;
			this.LinkUrl = LinkUrlIn;
			this.ToPageId = ToPageIdIn;
			this.Cosine = CosineIn;
		}
        
		public static TemplateOfLinks_Cosine Create(string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string CosineIn, out string SError){
			SError="";
			TemplateOfLinks_Cosine newTemplateOfLinks_Cosine = new TemplateOfLinks_Cosine();
    		try{
				newTemplateOfLinks_Cosine.UpdateValues(LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), CosineIn);
				newTemplateOfLinks_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newTemplateOfLinks_Cosine;
		}
				

		public string Update(string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(TemplateOfLinks_Cosine)){
                TemplateOfLinks_Cosine compare=(TemplateOfLinks_Cosine)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkTemplateId;
        }
        
        public string DescriptorValue()
        {
            return this.LinkAnchorText.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkAnchorText";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkTemplateId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkAnchorText";
        }
        
        #region ' Foreign Keys for TemplateOfLinks_Cosine '
        #endregion
        

        int _LinkTemplateId;
        [DataMember] 
		public int LinkTemplateId
        {
            get { return _LinkTemplateId; }
            set
            {
                if(_LinkTemplateId!=value){
                    _LinkTemplateId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkTemplateId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkAnchorText;
        [DataMember] 
		public string LinkAnchorText
        {
            get { return _LinkAnchorText; }
            set
            {
                if(_LinkAnchorText!=value){
                    _LinkAnchorText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkAnchorText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkUrl;
        [DataMember] 
		public string LinkUrl
        {
            get { return _LinkUrl; }
            set
            {
                if(_LinkUrl!=value){
                    _LinkUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Cosine;
        [DataMember] 
		public string Cosine
        {
            get { return _Cosine; }
            set
            {
                if(_Cosine!=value){
                    _Cosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Cosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<TemplateOfLinks_Cosine, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the WebPage table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class WebPage: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<WebPage> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<WebPage>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<WebPage> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(WebPage item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                WebPage item=new WebPage();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<WebPage> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public WebPage(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                WebPage.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<WebPage>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public WebPage(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public WebPage(Expression<Func<WebPage, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<WebPage> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<WebPage> _repo;
            
            if(db.TestMode){
                WebPage.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<WebPage>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<WebPage> GetRepo(){
            return GetRepo("","");
        }
        
        public static WebPage SingleOrDefault(Expression<Func<WebPage, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            WebPage single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static WebPage SingleOrDefault(Expression<Func<WebPage, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            WebPage single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<WebPage, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<WebPage, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<WebPage> Find(Expression<Func<WebPage, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<WebPage> Find(Expression<Func<WebPage, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<WebPage> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<WebPage> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<WebPage> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<WebPage> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<WebPage> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<WebPage> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "WebPageId";
        }

        public object KeyValue()
        {
            return this.WebPageId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Title.ToString();
        }

        public static WebPage RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.WebPageId == keyValue);
		}
		
		
		public static WebPage Create(int WebSiteIdIn,string TitleIn,int PageTemplateIn,string UrlIn,bool VisitedIn,string SourceIn,int BestRouteToTopIn,int CountToTopIn, out string SError){
			SError="";
 			WebPage newWebPage = new WebPage();
	   		try{
				newWebPage.UpdateValues(WebSiteIdIn, TitleIn, PageTemplateIn, UrlIn, VisitedIn, SourceIn, BestRouteToTopIn, CountToTopIn);
				newWebPage.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newWebPage;
		}

		public string Update(int WebSiteIdIn,string TitleIn,int PageTemplateIn,string UrlIn,bool VisitedIn,string SourceIn,int BestRouteToTopIn,int CountToTopIn){
     		string SError = "";
			try{
				UpdateValues(WebSiteIdIn, TitleIn, PageTemplateIn, UrlIn, VisitedIn, SourceIn, BestRouteToTopIn, CountToTopIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebSiteIdIn,string TitleIn,int PageTemplateIn,string UrlIn,bool VisitedIn,string SourceIn,int BestRouteToTopIn,int CountToTopIn){
			this.WebSiteId = WebSiteIdIn;
			this.Title = TitleIn;
			this.PageTemplate = PageTemplateIn;
			this.Url = UrlIn;
			this.Visited = VisitedIn;
			this.Source = SourceIn;
			this.BestRouteToTop = BestRouteToTopIn;
			this.CountToTop = CountToTopIn;
		}
        
		public static WebPage Create(string WebSiteIdIn,string TitleIn,string PageTemplateIn,string UrlIn,string VisitedIn,string SourceIn,string BestRouteToTopIn,string CountToTopIn, out string SError){
			SError="";
			WebPage newWebPage = new WebPage();
    		try{
				newWebPage.UpdateValues(int.Parse(WebSiteIdIn), TitleIn, int.Parse(PageTemplateIn), UrlIn, bool.Parse(VisitedIn), SourceIn, int.Parse(BestRouteToTopIn), int.Parse(CountToTopIn));
				newWebPage.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newWebPage;
		}
				

		public string Update(string WebSiteIdIn,string TitleIn,string PageTemplateIn,string UrlIn,string VisitedIn,string SourceIn,string BestRouteToTopIn,string CountToTopIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebSiteIdIn), TitleIn, int.Parse(PageTemplateIn), UrlIn, bool.Parse(VisitedIn), SourceIn, int.Parse(BestRouteToTopIn), int.Parse(CountToTopIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(WebPage)){
                WebPage compare=(WebPage)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.WebPageId;
        }
        
        public string DescriptorValue()
        {
            return this.Title.ToString();
        }

        public string DescriptorColumn() {
           	return "Title";
        }
			

        public static string GetKeyColumn()
        {
            return "WebPageId";
        }        
        public static string GetDescriptorColumn()
        {
            return "Title";
        }
        
        #region ' Foreign Keys for WebPage '
        public IQueryable<LinkWithHeading> LinkWithHeadings // Has many
        {
            get
            {
                
                  var repo=IADAL.LinkWithHeading.GetRepo();
                  return from items in repo.GetAll()
                       where items.WebPageId == _WebPageId
                       select items;
            }
        }

        public IQueryable<LinkWithoutHeading> LinkWithoutHeadings // Has many
        {
            get
            {
                
                  var repo=IADAL.LinkWithoutHeading.GetRepo();
                  return from items in repo.GetAll()
                       where items.WebPageId == _WebPageId
                       select items;
            }
        }

        #endregion
        

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebSiteId;
        [DataMember] 
		public int WebSiteId
        {
            get { return _WebSiteId; }
            set
            {
                if(_WebSiteId!=value){
                    _WebSiteId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebSiteId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Title;
        [DataMember] 
		public string Title
        {
            get { return _Title; }
            set
            {
                if(_Title!=value){
                    _Title=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Title");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _PageTemplate;
        [DataMember] 
		public int? PageTemplate
        {
            get { return _PageTemplate; }
            set
            {
                if(_PageTemplate!=value){
                    _PageTemplate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PageTemplate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Url;
        [DataMember] 
		public string Url
        {
            get { return _Url; }
            set
            {
                if(_Url!=value){
                    _Url=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Url");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _Visited;
        [DataMember] 
		public bool Visited
        {
            get { return _Visited; }
            set
            {
                if(_Visited!=value){
                    _Visited=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Visited");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Source;
        [DataMember] 
		public string Source
        {
            get { return _Source; }
            set
            {
                if(_Source!=value){
                    _Source=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Source");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _BestRouteToTop;
        [DataMember] 
		public int BestRouteToTop
        {
            get { return _BestRouteToTop; }
            set
            {
                if(_BestRouteToTop!=value){
                    _BestRouteToTop=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="BestRouteToTop");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _CountToTop;
        [DataMember] 
		public int CountToTop
        {
            get { return _CountToTop; }
            set
            {
                if(_CountToTop!=value){
                    _CountToTop=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CountToTop");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<WebPage, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Heading table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class Heading: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Heading> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Heading>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Heading> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Heading item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Heading item=new Heading();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Heading> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public Heading(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Heading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Heading>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Heading(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Heading(Expression<Func<Heading, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Heading> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<Heading> _repo;
            
            if(db.TestMode){
                Heading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Heading>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Heading> GetRepo(){
            return GetRepo("","");
        }
        
        public static Heading SingleOrDefault(Expression<Func<Heading, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Heading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Heading SingleOrDefault(Expression<Func<Heading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Heading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Heading, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Heading, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Heading> Find(Expression<Func<Heading, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Heading> Find(Expression<Func<Heading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<Heading> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<Heading> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<Heading> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Heading> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Heading> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Heading> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "HeadingId";
        }

        public object KeyValue()
        {
            return this.HeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.HeadingText.ToString();
        }

        public static Heading RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.HeadingId == keyValue);
		}
		
		
		public static Heading Create(int WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn, out string SError){
			SError="";
 			Heading newHeading = new Heading();
	   		try{
				newHeading.UpdateValues(WebPageIdIn, HeadingTextIn, VectorTermLengthIn);
				newHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeading;
		}

		public string Update(int WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, HeadingTextIn, VectorTermLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn){
			this.WebPageId = WebPageIdIn;
			this.HeadingText = HeadingTextIn;
			this.VectorTermLength = VectorTermLengthIn;
		}
        
		public static Heading Create(string WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn, out string SError){
			SError="";
			Heading newHeading = new Heading();
    		try{
				newHeading.UpdateValues(int.Parse(WebPageIdIn), HeadingTextIn, VectorTermLengthIn);
				newHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeading;
		}
				

		public string Update(string WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), HeadingTextIn, VectorTermLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(Heading)){
                Heading compare=(Heading)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.HeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.HeadingText.ToString();
        }

        public string DescriptorColumn() {
           	return "HeadingText";
        }
			

        public static string GetKeyColumn()
        {
            return "HeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "HeadingText";
        }
        
        #region ' Foreign Keys for Heading '
        public IQueryable<LinkWithHeading> LinkWithHeadings // Has many
        {
            get
            {
                
                  var repo=IADAL.LinkWithHeading.GetRepo();
                  return from items in repo.GetAll()
                       where items.HeadingId == _HeadingId
                       select items;
            }
        }

        #endregion
        

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _HeadingText;
        [DataMember] 
		public string HeadingText
        {
            get { return _HeadingText; }
            set
            {
                if(_HeadingText!=value){
                    _HeadingText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLength;
        [DataMember] 
		public string VectorTermLength
        {
            get { return _VectorTermLength; }
            set
            {
                if(_VectorTermLength!=value){
                    _VectorTermLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Heading, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithHeading table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithHeading: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithHeading> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithHeading>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithHeading> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithHeading item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithHeading item=new LinkWithHeading();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithHeading> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithHeading(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithHeading>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithHeading(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithHeading(Expression<Func<LinkWithHeading, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithHeading> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithHeading> _repo;
            
            if(db.TestMode){
                LinkWithHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithHeading>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithHeading> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithHeading SingleOrDefault(Expression<Func<LinkWithHeading, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithHeading SingleOrDefault(Expression<Func<LinkWithHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithHeading, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithHeading, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithHeading> Find(Expression<Func<LinkWithHeading, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithHeading> Find(Expression<Func<LinkWithHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithHeading> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithHeading> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithHeading> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithHeading> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithHeading> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithHeading> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkId";
        }

        public object KeyValue()
        {
            return this.LinkId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkAnchorText.ToString();
        }

        public static LinkWithHeading RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkId == keyValue);
		}
		
		
		public static LinkWithHeading Create(int WebPageIdIn,int HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn, out string SError){
			SError="";
 			LinkWithHeading newLinkWithHeading = new LinkWithHeading();
	   		try{
				newLinkWithHeading.UpdateValues(WebPageIdIn, HeadingIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, CosineValueLinkHeadingIn);
				newLinkWithHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithHeading;
		}

		public string Update(int WebPageIdIn,int HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, HeadingIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, CosineValueLinkHeadingIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,int HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn){
			this.WebPageId = WebPageIdIn;
			this.HeadingId = HeadingIdIn;
			this.LinkAnchorText = LinkAnchorTextIn;
			this.LinkUrl = LinkUrlIn;
			this.ToPageId = ToPageIdIn;
			this.VectorTermLength = VectorTermLengthIn;
			this.CosineValueLinkHeading = CosineValueLinkHeadingIn;
		}
        
		public static LinkWithHeading Create(string WebPageIdIn,string HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn, out string SError){
			SError="";
			LinkWithHeading newLinkWithHeading = new LinkWithHeading();
    		try{
				newLinkWithHeading.UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, CosineValueLinkHeadingIn);
				newLinkWithHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithHeading;
		}
				

		public string Update(string WebPageIdIn,string HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, CosineValueLinkHeadingIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithHeading)){
                LinkWithHeading compare=(LinkWithHeading)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkId;
        }
        
        public string DescriptorValue()
        {
            return this.LinkAnchorText.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkAnchorText";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkAnchorText";
        }
        
        #region ' Foreign Keys for LinkWithHeading '
        public Heading HeadingIdAsHeading // Has One
        {
            get
            {
                
                  var repo=IADAL.Heading.GetRepo();
                  return repo.Find(x => x.HeadingId  == _HeadingId).SingleOrDefault();
            }
        }

        public WebPage WebPageIdAsWebPage // Has One
        {
            get
            {
                
                  var repo=IADAL.WebPage.GetRepo();
                  return repo.Find(x => x.WebPageId  == _WebPageId).SingleOrDefault();
            }
        }

        #endregion
        

        int _LinkId;
        [DataMember] 
		public int LinkId
        {
            get { return _LinkId; }
            set
            {
                if(_LinkId!=value){
                    _LinkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkAnchorText;
        [DataMember] 
		public string LinkAnchorText
        {
            get { return _LinkAnchorText; }
            set
            {
                if(_LinkAnchorText!=value){
                    _LinkAnchorText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkAnchorText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkUrl;
        [DataMember] 
		public string LinkUrl
        {
            get { return _LinkUrl; }
            set
            {
                if(_LinkUrl!=value){
                    _LinkUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLength;
        [DataMember] 
		public string VectorTermLength
        {
            get { return _VectorTermLength; }
            set
            {
                if(_VectorTermLength!=value){
                    _VectorTermLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueLinkHeading;
        [DataMember] 
		public string CosineValueLinkHeading
        {
            get { return _CosineValueLinkHeading; }
            set
            {
                if(_CosineValueLinkHeading!=value){
                    _CosineValueLinkHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueLinkHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithHeading, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Paragraph table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class Paragraph: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Paragraph> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Paragraph>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Paragraph> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Paragraph item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Paragraph item=new Paragraph();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Paragraph> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public Paragraph(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Paragraph.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Paragraph>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Paragraph(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Paragraph(Expression<Func<Paragraph, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Paragraph> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<Paragraph> _repo;
            
            if(db.TestMode){
                Paragraph.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Paragraph>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Paragraph> GetRepo(){
            return GetRepo("","");
        }
        
        public static Paragraph SingleOrDefault(Expression<Func<Paragraph, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Paragraph single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Paragraph SingleOrDefault(Expression<Func<Paragraph, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Paragraph single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Paragraph, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Paragraph, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Paragraph> Find(Expression<Func<Paragraph, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Paragraph> Find(Expression<Func<Paragraph, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<Paragraph> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<Paragraph> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<Paragraph> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Paragraph> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Paragraph> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Paragraph> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ParaId";
        }

        public object KeyValue()
        {
            return this.ParaId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.ParaText.ToString();
        }

        public static Paragraph RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.ParaId == keyValue);
		}
		
		
		public static Paragraph Create(int WebPageIdIn,int HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn, out string SError){
			SError="";
 			Paragraph newParagraph = new Paragraph();
	   		try{
				newParagraph.UpdateValues(WebPageIdIn, HeadingIdIn, ParaTextIn, CosineValueParagraphHeadingIn, HeadingTextIn);
				newParagraph.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newParagraph;
		}

		public string Update(int WebPageIdIn,int HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, HeadingIdIn, ParaTextIn, CosineValueParagraphHeadingIn, HeadingTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,int HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn){
			this.WebPageId = WebPageIdIn;
			this.HeadingId = HeadingIdIn;
			this.ParaText = ParaTextIn;
			this.CosineValueParagraphHeading = CosineValueParagraphHeadingIn;
			this.HeadingText = HeadingTextIn;
		}
        
		public static Paragraph Create(string WebPageIdIn,string HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn, out string SError){
			SError="";
			Paragraph newParagraph = new Paragraph();
    		try{
				newParagraph.UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), ParaTextIn, CosineValueParagraphHeadingIn, HeadingTextIn);
				newParagraph.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newParagraph;
		}
				

		public string Update(string WebPageIdIn,string HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), ParaTextIn, CosineValueParagraphHeadingIn, HeadingTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(Paragraph)){
                Paragraph compare=(Paragraph)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ParaId;
        }
        
        public string DescriptorValue()
        {
            return this.ParaText.ToString();
        }

        public string DescriptorColumn() {
           	return "ParaText";
        }
			

        public static string GetKeyColumn()
        {
            return "ParaId";
        }        
        public static string GetDescriptorColumn()
        {
            return "ParaText";
        }
        
        #region ' Foreign Keys for Paragraph '
        #endregion
        

        int _ParaId;
        [DataMember] 
		public int ParaId
        {
            get { return _ParaId; }
            set
            {
                if(_ParaId!=value){
                    _ParaId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ParaId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ParaText;
        [DataMember] 
		public string ParaText
        {
            get { return _ParaText; }
            set
            {
                if(_ParaText!=value){
                    _ParaText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ParaText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueParagraphHeading;
        [DataMember] 
		public string CosineValueParagraphHeading
        {
            get { return _CosineValueParagraphHeading; }
            set
            {
                if(_CosineValueParagraphHeading!=value){
                    _CosineValueParagraphHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueParagraphHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _HeadingText;
        [DataMember] 
		public string HeadingText
        {
            get { return _HeadingText; }
            set
            {
                if(_HeadingText!=value){
                    _HeadingText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Paragraph, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the WebPageTUBS table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class WebPageTUB: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<WebPageTUB> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<WebPageTUB>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<WebPageTUB> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(WebPageTUB item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                WebPageTUB item=new WebPageTUB();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<WebPageTUB> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public WebPageTUB(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                WebPageTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<WebPageTUB>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public WebPageTUB(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public WebPageTUB(Expression<Func<WebPageTUB, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<WebPageTUB> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<WebPageTUB> _repo;
            
            if(db.TestMode){
                WebPageTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<WebPageTUB>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<WebPageTUB> GetRepo(){
            return GetRepo("","");
        }
        
        public static WebPageTUB SingleOrDefault(Expression<Func<WebPageTUB, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            WebPageTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static WebPageTUB SingleOrDefault(Expression<Func<WebPageTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            WebPageTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<WebPageTUB, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<WebPageTUB, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<WebPageTUB> Find(Expression<Func<WebPageTUB, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<WebPageTUB> Find(Expression<Func<WebPageTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<WebPageTUB> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<WebPageTUB> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<WebPageTUB> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<WebPageTUB> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<WebPageTUB> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<WebPageTUB> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "WebPageId";
        }

        public object KeyValue()
        {
            return this.WebPageId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Title.ToString();
        }

        public static WebPageTUB RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.WebPageId == keyValue);
		}
		
		
		public static WebPageTUB Create(int WebSiteIdIn,string TitleIn,int PageTemplateIn,string UrlIn,bool VisitedIn,string LwhORLwohIn,int BestRouteToTopIn,int CountToTopIn, out string SError){
			SError="";
 			WebPageTUB newWebPageTUB = new WebPageTUB();
	   		try{
				newWebPageTUB.UpdateValues(WebSiteIdIn, TitleIn, PageTemplateIn, UrlIn, VisitedIn, LwhORLwohIn, BestRouteToTopIn, CountToTopIn);
				newWebPageTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newWebPageTUB;
		}

		public string Update(int WebSiteIdIn,string TitleIn,int PageTemplateIn,string UrlIn,bool VisitedIn,string LwhORLwohIn,int BestRouteToTopIn,int CountToTopIn){
     		string SError = "";
			try{
				UpdateValues(WebSiteIdIn, TitleIn, PageTemplateIn, UrlIn, VisitedIn, LwhORLwohIn, BestRouteToTopIn, CountToTopIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebSiteIdIn,string TitleIn,int PageTemplateIn,string UrlIn,bool VisitedIn,string LwhORLwohIn,int BestRouteToTopIn,int CountToTopIn){
			this.WebSiteId = WebSiteIdIn;
			this.Title = TitleIn;
			this.PageTemplate = PageTemplateIn;
			this.Url = UrlIn;
			this.Visited = VisitedIn;
			this.LwhORLwoh = LwhORLwohIn;
			this.BestRouteToTop = BestRouteToTopIn;
			this.CountToTop = CountToTopIn;
		}
        
		public static WebPageTUB Create(string WebSiteIdIn,string TitleIn,string PageTemplateIn,string UrlIn,string VisitedIn,string LwhORLwohIn,string BestRouteToTopIn,string CountToTopIn, out string SError){
			SError="";
			WebPageTUB newWebPageTUB = new WebPageTUB();
    		try{
				newWebPageTUB.UpdateValues(int.Parse(WebSiteIdIn), TitleIn, int.Parse(PageTemplateIn), UrlIn, bool.Parse(VisitedIn), LwhORLwohIn, int.Parse(BestRouteToTopIn), int.Parse(CountToTopIn));
				newWebPageTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newWebPageTUB;
		}
				

		public string Update(string WebSiteIdIn,string TitleIn,string PageTemplateIn,string UrlIn,string VisitedIn,string LwhORLwohIn,string BestRouteToTopIn,string CountToTopIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebSiteIdIn), TitleIn, int.Parse(PageTemplateIn), UrlIn, bool.Parse(VisitedIn), LwhORLwohIn, int.Parse(BestRouteToTopIn), int.Parse(CountToTopIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(WebPageTUB)){
                WebPageTUB compare=(WebPageTUB)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.WebPageId;
        }
        
        public string DescriptorValue()
        {
            return this.Title.ToString();
        }

        public string DescriptorColumn() {
           	return "Title";
        }
			

        public static string GetKeyColumn()
        {
            return "WebPageId";
        }        
        public static string GetDescriptorColumn()
        {
            return "Title";
        }
        
        #region ' Foreign Keys for WebPageTUB '
        #endregion
        

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebSiteId;
        [DataMember] 
		public int WebSiteId
        {
            get { return _WebSiteId; }
            set
            {
                if(_WebSiteId!=value){
                    _WebSiteId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebSiteId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Title;
        [DataMember] 
		public string Title
        {
            get { return _Title; }
            set
            {
                if(_Title!=value){
                    _Title=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Title");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _PageTemplate;
        [DataMember] 
		public int? PageTemplate
        {
            get { return _PageTemplate; }
            set
            {
                if(_PageTemplate!=value){
                    _PageTemplate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PageTemplate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Url;
        [DataMember] 
		public string Url
        {
            get { return _Url; }
            set
            {
                if(_Url!=value){
                    _Url=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Url");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool _Visited;
        [DataMember] 
		public bool Visited
        {
            get { return _Visited; }
            set
            {
                if(_Visited!=value){
                    _Visited=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Visited");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LwhORLwoh;
        [DataMember] 
		public string LwhORLwoh
        {
            get { return _LwhORLwoh; }
            set
            {
                if(_LwhORLwoh!=value){
                    _LwhORLwoh=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LwhORLwoh");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _BestRouteToTop;
        [DataMember] 
		public int BestRouteToTop
        {
            get { return _BestRouteToTop; }
            set
            {
                if(_BestRouteToTop!=value){
                    _BestRouteToTop=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="BestRouteToTop");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _CountToTop;
        [DataMember] 
		public int CountToTop
        {
            get { return _CountToTop; }
            set
            {
                if(_CountToTop!=value){
                    _CountToTop=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CountToTop");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<WebPageTUB, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithHeadingTUBS table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithHeadingTUB: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithHeadingTUB> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithHeadingTUB>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithHeadingTUB> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithHeadingTUB item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithHeadingTUB item=new LinkWithHeadingTUB();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithHeadingTUB> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithHeadingTUB(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithHeadingTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithHeadingTUB>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithHeadingTUB(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithHeadingTUB(Expression<Func<LinkWithHeadingTUB, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithHeadingTUB> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithHeadingTUB> _repo;
            
            if(db.TestMode){
                LinkWithHeadingTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithHeadingTUB>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithHeadingTUB> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithHeadingTUB SingleOrDefault(Expression<Func<LinkWithHeadingTUB, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithHeadingTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithHeadingTUB SingleOrDefault(Expression<Func<LinkWithHeadingTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithHeadingTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithHeadingTUB, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithHeadingTUB, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithHeadingTUB> Find(Expression<Func<LinkWithHeadingTUB, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithHeadingTUB> Find(Expression<Func<LinkWithHeadingTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithHeadingTUB> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithHeadingTUB> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithHeadingTUB> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithHeadingTUB> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithHeadingTUB> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithHeadingTUB> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkId";
        }

        public object KeyValue()
        {
            return this.LinkId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkAnchorText.ToString();
        }

        public static LinkWithHeadingTUB RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkId == keyValue);
		}
		
		
		public static LinkWithHeadingTUB Create(int WebPageIdIn,int HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,bool VisitedIn, out string SError){
			SError="";
 			LinkWithHeadingTUB newLinkWithHeadingTUB = new LinkWithHeadingTUB();
	   		try{
				newLinkWithHeadingTUB.UpdateValues(WebPageIdIn, HeadingIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, CosineValueLinkHeadingIn, VisitedIn);
				newLinkWithHeadingTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithHeadingTUB;
		}

		public string Update(int WebPageIdIn,int HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,bool VisitedIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, HeadingIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, CosineValueLinkHeadingIn, VisitedIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,int HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,bool VisitedIn){
			this.WebPageId = WebPageIdIn;
			this.HeadingId = HeadingIdIn;
			this.LinkAnchorText = LinkAnchorTextIn;
			this.LinkUrl = LinkUrlIn;
			this.ToPageId = ToPageIdIn;
			this.VectorTermLength = VectorTermLengthIn;
			this.CosineValueLinkHeading = CosineValueLinkHeadingIn;
			this.Visited = VisitedIn;
		}
        
		public static LinkWithHeadingTUB Create(string WebPageIdIn,string HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,string VisitedIn, out string SError){
			SError="";
			LinkWithHeadingTUB newLinkWithHeadingTUB = new LinkWithHeadingTUB();
    		try{
				newLinkWithHeadingTUB.UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, CosineValueLinkHeadingIn, bool.Parse(VisitedIn));
				newLinkWithHeadingTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithHeadingTUB;
		}
				

		public string Update(string WebPageIdIn,string HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,string VisitedIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, CosineValueLinkHeadingIn, bool.Parse(VisitedIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithHeadingTUB)){
                LinkWithHeadingTUB compare=(LinkWithHeadingTUB)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkId;
        }
        
        public string DescriptorValue()
        {
            return this.LinkAnchorText.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkAnchorText";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkAnchorText";
        }
        
        #region ' Foreign Keys for LinkWithHeadingTUB '
        #endregion
        

        int _LinkId;
        [DataMember] 
		public int LinkId
        {
            get { return _LinkId; }
            set
            {
                if(_LinkId!=value){
                    _LinkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkAnchorText;
        [DataMember] 
		public string LinkAnchorText
        {
            get { return _LinkAnchorText; }
            set
            {
                if(_LinkAnchorText!=value){
                    _LinkAnchorText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkAnchorText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkUrl;
        [DataMember] 
		public string LinkUrl
        {
            get { return _LinkUrl; }
            set
            {
                if(_LinkUrl!=value){
                    _LinkUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLength;
        [DataMember] 
		public string VectorTermLength
        {
            get { return _VectorTermLength; }
            set
            {
                if(_VectorTermLength!=value){
                    _VectorTermLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueLinkHeading;
        [DataMember] 
		public string CosineValueLinkHeading
        {
            get { return _CosineValueLinkHeading; }
            set
            {
                if(_CosineValueLinkHeading!=value){
                    _CosineValueLinkHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueLinkHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Visited;
        [DataMember] 
		public bool? Visited
        {
            get { return _Visited; }
            set
            {
                if(_Visited!=value){
                    _Visited=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Visited");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithHeadingTUB, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithoutHeadingTUBS table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithoutHeadingTUB: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithoutHeadingTUB> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithoutHeadingTUB>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithoutHeadingTUB> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithoutHeadingTUB item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithoutHeadingTUB item=new LinkWithoutHeadingTUB();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithoutHeadingTUB> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithoutHeadingTUB(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithoutHeadingTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingTUB>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithoutHeadingTUB(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithoutHeadingTUB(Expression<Func<LinkWithoutHeadingTUB, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithoutHeadingTUB> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithoutHeadingTUB> _repo;
            
            if(db.TestMode){
                LinkWithoutHeadingTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingTUB>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithoutHeadingTUB> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithoutHeadingTUB SingleOrDefault(Expression<Func<LinkWithoutHeadingTUB, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithoutHeadingTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithoutHeadingTUB SingleOrDefault(Expression<Func<LinkWithoutHeadingTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithoutHeadingTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithoutHeadingTUB, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithoutHeadingTUB, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithoutHeadingTUB> Find(Expression<Func<LinkWithoutHeadingTUB, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithoutHeadingTUB> Find(Expression<Func<LinkWithoutHeadingTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithoutHeadingTUB> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithoutHeadingTUB> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithoutHeadingTUB> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithoutHeadingTUB> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithoutHeadingTUB> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithoutHeadingTUB> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkId";
        }

        public object KeyValue()
        {
            return this.LinkId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkAnchorText.ToString();
        }

        public static LinkWithoutHeadingTUB RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkId == keyValue);
		}
		
		
		public static LinkWithoutHeadingTUB Create(int WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,bool VisitedIn, out string SError){
			SError="";
 			LinkWithoutHeadingTUB newLinkWithoutHeadingTUB = new LinkWithoutHeadingTUB();
	   		try{
				newLinkWithoutHeadingTUB.UpdateValues(WebPageIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, VisitedIn);
				newLinkWithoutHeadingTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingTUB;
		}

		public string Update(int WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,bool VisitedIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, VisitedIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,bool VisitedIn){
			this.WebPageId = WebPageIdIn;
			this.LinkAnchorText = LinkAnchorTextIn;
			this.LinkUrl = LinkUrlIn;
			this.ToPageId = ToPageIdIn;
			this.VectorTermLength = VectorTermLengthIn;
			this.Visited = VisitedIn;
		}
        
		public static LinkWithoutHeadingTUB Create(string WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string VisitedIn, out string SError){
			SError="";
			LinkWithoutHeadingTUB newLinkWithoutHeadingTUB = new LinkWithoutHeadingTUB();
    		try{
				newLinkWithoutHeadingTUB.UpdateValues(int.Parse(WebPageIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, bool.Parse(VisitedIn));
				newLinkWithoutHeadingTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingTUB;
		}
				

		public string Update(string WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string VisitedIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, bool.Parse(VisitedIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithoutHeadingTUB)){
                LinkWithoutHeadingTUB compare=(LinkWithoutHeadingTUB)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkId;
        }
        
        public string DescriptorValue()
        {
            return this.LinkAnchorText.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkAnchorText";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkAnchorText";
        }
        
        #region ' Foreign Keys for LinkWithoutHeadingTUB '
        #endregion
        

        int _LinkId;
        [DataMember] 
		public int LinkId
        {
            get { return _LinkId; }
            set
            {
                if(_LinkId!=value){
                    _LinkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkAnchorText;
        [DataMember] 
		public string LinkAnchorText
        {
            get { return _LinkAnchorText; }
            set
            {
                if(_LinkAnchorText!=value){
                    _LinkAnchorText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkAnchorText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkUrl;
        [DataMember] 
		public string LinkUrl
        {
            get { return _LinkUrl; }
            set
            {
                if(_LinkUrl!=value){
                    _LinkUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLength;
        [DataMember] 
		public string VectorTermLength
        {
            get { return _VectorTermLength; }
            set
            {
                if(_VectorTermLength!=value){
                    _VectorTermLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Visited;
        [DataMember] 
		public bool? Visited
        {
            get { return _Visited; }
            set
            {
                if(_Visited!=value){
                    _Visited=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Visited");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithoutHeadingTUB, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the TemplateOfLinksTUBS table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class TemplateOfLinksTUB: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<TemplateOfLinksTUB> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<TemplateOfLinksTUB>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<TemplateOfLinksTUB> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(TemplateOfLinksTUB item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                TemplateOfLinksTUB item=new TemplateOfLinksTUB();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<TemplateOfLinksTUB> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public TemplateOfLinksTUB(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                TemplateOfLinksTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<TemplateOfLinksTUB>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public TemplateOfLinksTUB(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public TemplateOfLinksTUB(Expression<Func<TemplateOfLinksTUB, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<TemplateOfLinksTUB> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<TemplateOfLinksTUB> _repo;
            
            if(db.TestMode){
                TemplateOfLinksTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<TemplateOfLinksTUB>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<TemplateOfLinksTUB> GetRepo(){
            return GetRepo("","");
        }
        
        public static TemplateOfLinksTUB SingleOrDefault(Expression<Func<TemplateOfLinksTUB, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            TemplateOfLinksTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static TemplateOfLinksTUB SingleOrDefault(Expression<Func<TemplateOfLinksTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            TemplateOfLinksTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<TemplateOfLinksTUB, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<TemplateOfLinksTUB, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<TemplateOfLinksTUB> Find(Expression<Func<TemplateOfLinksTUB, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<TemplateOfLinksTUB> Find(Expression<Func<TemplateOfLinksTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<TemplateOfLinksTUB> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<TemplateOfLinksTUB> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<TemplateOfLinksTUB> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<TemplateOfLinksTUB> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<TemplateOfLinksTUB> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<TemplateOfLinksTUB> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkTemplateId";
        }

        public object KeyValue()
        {
            return this.LinkTemplateId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkAnchorText.ToString();
        }

        public static TemplateOfLinksTUB RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkTemplateId == keyValue);
		}
		
		
		public static TemplateOfLinksTUB Create(string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string TermVectorLengthLinkTemplateIn, out string SError){
			SError="";
 			TemplateOfLinksTUB newTemplateOfLinksTUB = new TemplateOfLinksTUB();
	   		try{
				newTemplateOfLinksTUB.UpdateValues(LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, TermVectorLengthLinkTemplateIn);
				newTemplateOfLinksTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newTemplateOfLinksTUB;
		}

		public string Update(string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string TermVectorLengthLinkTemplateIn){
     		string SError = "";
			try{
				UpdateValues(LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, TermVectorLengthLinkTemplateIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string TermVectorLengthLinkTemplateIn){
			this.LinkAnchorText = LinkAnchorTextIn;
			this.LinkUrl = LinkUrlIn;
			this.ToPageId = ToPageIdIn;
			this.TermVectorLengthLinkTemplate = TermVectorLengthLinkTemplateIn;
		}
        
		public static TemplateOfLinksTUB Create(string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string TermVectorLengthLinkTemplateIn, out string SError){
			SError="";
			TemplateOfLinksTUB newTemplateOfLinksTUB = new TemplateOfLinksTUB();
    		try{
				newTemplateOfLinksTUB.UpdateValues(LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), TermVectorLengthLinkTemplateIn);
				newTemplateOfLinksTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newTemplateOfLinksTUB;
		}
				

		public string Update(string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string TermVectorLengthLinkTemplateIn){
     		string SError = "";
			try{
				UpdateValues(LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), TermVectorLengthLinkTemplateIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(TemplateOfLinksTUB)){
                TemplateOfLinksTUB compare=(TemplateOfLinksTUB)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkTemplateId;
        }
        
        public string DescriptorValue()
        {
            return this.LinkAnchorText.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkAnchorText";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkTemplateId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkAnchorText";
        }
        
        #region ' Foreign Keys for TemplateOfLinksTUB '
        #endregion
        

        int _LinkTemplateId;
        [DataMember] 
		public int LinkTemplateId
        {
            get { return _LinkTemplateId; }
            set
            {
                if(_LinkTemplateId!=value){
                    _LinkTemplateId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkTemplateId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkAnchorText;
        [DataMember] 
		public string LinkAnchorText
        {
            get { return _LinkAnchorText; }
            set
            {
                if(_LinkAnchorText!=value){
                    _LinkAnchorText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkAnchorText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkUrl;
        [DataMember] 
		public string LinkUrl
        {
            get { return _LinkUrl; }
            set
            {
                if(_LinkUrl!=value){
                    _LinkUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _TermVectorLengthLinkTemplate;
        [DataMember] 
		public string TermVectorLengthLinkTemplate
        {
            get { return _TermVectorLengthLinkTemplate; }
            set
            {
                if(_TermVectorLengthLinkTemplate!=value){
                    _TermVectorLengthLinkTemplate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TermVectorLengthLinkTemplate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<TemplateOfLinksTUB, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithoutHeadingTemplateOfLinksTUBS table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithoutHeadingTemplateOfLinksTUB: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithoutHeadingTemplateOfLinksTUB> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithoutHeadingTemplateOfLinksTUB>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithoutHeadingTemplateOfLinksTUB> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithoutHeadingTemplateOfLinksTUB item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithoutHeadingTemplateOfLinksTUB item=new LinkWithoutHeadingTemplateOfLinksTUB();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithoutHeadingTemplateOfLinksTUB> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithoutHeadingTemplateOfLinksTUB(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithoutHeadingTemplateOfLinksTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingTemplateOfLinksTUB>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithoutHeadingTemplateOfLinksTUB(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithoutHeadingTemplateOfLinksTUB(Expression<Func<LinkWithoutHeadingTemplateOfLinksTUB, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithoutHeadingTemplateOfLinksTUB> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithoutHeadingTemplateOfLinksTUB> _repo;
            
            if(db.TestMode){
                LinkWithoutHeadingTemplateOfLinksTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingTemplateOfLinksTUB>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithoutHeadingTemplateOfLinksTUB> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithoutHeadingTemplateOfLinksTUB SingleOrDefault(Expression<Func<LinkWithoutHeadingTemplateOfLinksTUB, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithoutHeadingTemplateOfLinksTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithoutHeadingTemplateOfLinksTUB SingleOrDefault(Expression<Func<LinkWithoutHeadingTemplateOfLinksTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithoutHeadingTemplateOfLinksTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithoutHeadingTemplateOfLinksTUB, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithoutHeadingTemplateOfLinksTUB, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithoutHeadingTemplateOfLinksTUB> Find(Expression<Func<LinkWithoutHeadingTemplateOfLinksTUB, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithoutHeadingTemplateOfLinksTUB> Find(Expression<Func<LinkWithoutHeadingTemplateOfLinksTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithoutHeadingTemplateOfLinksTUB> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithoutHeadingTemplateOfLinksTUB> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithoutHeadingTemplateOfLinksTUB> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithoutHeadingTemplateOfLinksTUB> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithoutHeadingTemplateOfLinksTUB> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithoutHeadingTemplateOfLinksTUB> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkWithoutHeadingTemplateOfLinksId";
        }

        public object KeyValue()
        {
            return this.LinkWithoutHeadingTemplateOfLinksId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.AllLinksOfTemplate.ToString();
        }

        public static LinkWithoutHeadingTemplateOfLinksTUB RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkWithoutHeadingTemplateOfLinksId == keyValue);
		}
		
		
		public static LinkWithoutHeadingTemplateOfLinksTUB Create(int WebPageIdIn,string AllLinksOfTemplateIn, out string SError){
			SError="";
 			LinkWithoutHeadingTemplateOfLinksTUB newLinkWithoutHeadingTemplateOfLinksTUB = new LinkWithoutHeadingTemplateOfLinksTUB();
	   		try{
				newLinkWithoutHeadingTemplateOfLinksTUB.UpdateValues(WebPageIdIn, AllLinksOfTemplateIn);
				newLinkWithoutHeadingTemplateOfLinksTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingTemplateOfLinksTUB;
		}

		public string Update(int WebPageIdIn,string AllLinksOfTemplateIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, AllLinksOfTemplateIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,string AllLinksOfTemplateIn){
			this.WebPageId = WebPageIdIn;
			this.AllLinksOfTemplate = AllLinksOfTemplateIn;
		}
        
		public static LinkWithoutHeadingTemplateOfLinksTUB Create(string WebPageIdIn,string AllLinksOfTemplateIn, out string SError){
			SError="";
			LinkWithoutHeadingTemplateOfLinksTUB newLinkWithoutHeadingTemplateOfLinksTUB = new LinkWithoutHeadingTemplateOfLinksTUB();
    		try{
				newLinkWithoutHeadingTemplateOfLinksTUB.UpdateValues(int.Parse(WebPageIdIn), AllLinksOfTemplateIn);
				newLinkWithoutHeadingTemplateOfLinksTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingTemplateOfLinksTUB;
		}
				

		public string Update(string WebPageIdIn,string AllLinksOfTemplateIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), AllLinksOfTemplateIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithoutHeadingTemplateOfLinksTUB)){
                LinkWithoutHeadingTemplateOfLinksTUB compare=(LinkWithoutHeadingTemplateOfLinksTUB)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkWithoutHeadingTemplateOfLinksId;
        }
        
        public string DescriptorValue()
        {
            return this.AllLinksOfTemplate.ToString();
        }

        public string DescriptorColumn() {
           	return "AllLinksOfTemplate";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkWithoutHeadingTemplateOfLinksId";
        }        
        public static string GetDescriptorColumn()
        {
            return "AllLinksOfTemplate";
        }
        
        #region ' Foreign Keys for LinkWithoutHeadingTemplateOfLinksTUB '
        #endregion
        

        int _LinkWithoutHeadingTemplateOfLinksId;
        [DataMember] 
		public int LinkWithoutHeadingTemplateOfLinksId
        {
            get { return _LinkWithoutHeadingTemplateOfLinksId; }
            set
            {
                if(_LinkWithoutHeadingTemplateOfLinksId!=value){
                    _LinkWithoutHeadingTemplateOfLinksId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkWithoutHeadingTemplateOfLinksId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _AllLinksOfTemplate;
        [DataMember] 
		public string AllLinksOfTemplate
        {
            get { return _AllLinksOfTemplate; }
            set
            {
                if(_AllLinksOfTemplate!=value){
                    _AllLinksOfTemplate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="AllLinksOfTemplate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithoutHeadingTemplateOfLinksTUB, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the ParagraphTUBS table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class ParagraphTUB: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<ParagraphTUB> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<ParagraphTUB>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<ParagraphTUB> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(ParagraphTUB item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                ParagraphTUB item=new ParagraphTUB();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<ParagraphTUB> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public ParagraphTUB(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                ParagraphTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ParagraphTUB>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public ParagraphTUB(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public ParagraphTUB(Expression<Func<ParagraphTUB, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<ParagraphTUB> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<ParagraphTUB> _repo;
            
            if(db.TestMode){
                ParagraphTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<ParagraphTUB>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<ParagraphTUB> GetRepo(){
            return GetRepo("","");
        }
        
        public static ParagraphTUB SingleOrDefault(Expression<Func<ParagraphTUB, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            ParagraphTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static ParagraphTUB SingleOrDefault(Expression<Func<ParagraphTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            ParagraphTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<ParagraphTUB, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<ParagraphTUB, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<ParagraphTUB> Find(Expression<Func<ParagraphTUB, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<ParagraphTUB> Find(Expression<Func<ParagraphTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<ParagraphTUB> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<ParagraphTUB> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<ParagraphTUB> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<ParagraphTUB> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<ParagraphTUB> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<ParagraphTUB> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ParaId";
        }

        public object KeyValue()
        {
            return this.ParaId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.ParaText.ToString();
        }

        public static ParagraphTUB RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.ParaId == keyValue);
		}
		
		
		public static ParagraphTUB Create(int WebPageIdIn,int HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn, out string SError){
			SError="";
 			ParagraphTUB newParagraphTUB = new ParagraphTUB();
	   		try{
				newParagraphTUB.UpdateValues(WebPageIdIn, HeadingIdIn, ParaTextIn, CosineValueParagraphHeadingIn, HeadingTextIn);
				newParagraphTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newParagraphTUB;
		}

		public string Update(int WebPageIdIn,int HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, HeadingIdIn, ParaTextIn, CosineValueParagraphHeadingIn, HeadingTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,int HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn){
			this.WebPageId = WebPageIdIn;
			this.HeadingId = HeadingIdIn;
			this.ParaText = ParaTextIn;
			this.CosineValueParagraphHeading = CosineValueParagraphHeadingIn;
			this.HeadingText = HeadingTextIn;
		}
        
		public static ParagraphTUB Create(string WebPageIdIn,string HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn, out string SError){
			SError="";
			ParagraphTUB newParagraphTUB = new ParagraphTUB();
    		try{
				newParagraphTUB.UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), ParaTextIn, CosineValueParagraphHeadingIn, HeadingTextIn);
				newParagraphTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newParagraphTUB;
		}
				

		public string Update(string WebPageIdIn,string HeadingIdIn,string ParaTextIn,string CosineValueParagraphHeadingIn,string HeadingTextIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), ParaTextIn, CosineValueParagraphHeadingIn, HeadingTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(ParagraphTUB)){
                ParagraphTUB compare=(ParagraphTUB)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ParaId;
        }
        
        public string DescriptorValue()
        {
            return this.ParaText.ToString();
        }

        public string DescriptorColumn() {
           	return "ParaText";
        }
			

        public static string GetKeyColumn()
        {
            return "ParaId";
        }        
        public static string GetDescriptorColumn()
        {
            return "ParaText";
        }
        
        #region ' Foreign Keys for ParagraphTUB '
        #endregion
        

        int _ParaId;
        [DataMember] 
		public int ParaId
        {
            get { return _ParaId; }
            set
            {
                if(_ParaId!=value){
                    _ParaId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ParaId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ParaText;
        [DataMember] 
		public string ParaText
        {
            get { return _ParaText; }
            set
            {
                if(_ParaText!=value){
                    _ParaText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ParaText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueParagraphHeading;
        [DataMember] 
		public string CosineValueParagraphHeading
        {
            get { return _CosineValueParagraphHeading; }
            set
            {
                if(_CosineValueParagraphHeading!=value){
                    _CosineValueParagraphHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueParagraphHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _HeadingText;
        [DataMember] 
		public string HeadingText
        {
            get { return _HeadingText; }
            set
            {
                if(_HeadingText!=value){
                    _HeadingText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<ParagraphTUB, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Page_Visited_Unsuccessfully table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class Page_Visited_Unsuccessfully: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Page_Visited_Unsuccessfully> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Page_Visited_Unsuccessfully>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Page_Visited_Unsuccessfully> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Page_Visited_Unsuccessfully item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Page_Visited_Unsuccessfully item=new Page_Visited_Unsuccessfully();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Page_Visited_Unsuccessfully> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public Page_Visited_Unsuccessfully(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Page_Visited_Unsuccessfully.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Page_Visited_Unsuccessfully>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Page_Visited_Unsuccessfully(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Page_Visited_Unsuccessfully(Expression<Func<Page_Visited_Unsuccessfully, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Page_Visited_Unsuccessfully> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<Page_Visited_Unsuccessfully> _repo;
            
            if(db.TestMode){
                Page_Visited_Unsuccessfully.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Page_Visited_Unsuccessfully>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Page_Visited_Unsuccessfully> GetRepo(){
            return GetRepo("","");
        }
        
        public static Page_Visited_Unsuccessfully SingleOrDefault(Expression<Func<Page_Visited_Unsuccessfully, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Page_Visited_Unsuccessfully single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Page_Visited_Unsuccessfully SingleOrDefault(Expression<Func<Page_Visited_Unsuccessfully, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Page_Visited_Unsuccessfully single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Page_Visited_Unsuccessfully, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Page_Visited_Unsuccessfully, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Page_Visited_Unsuccessfully> Find(Expression<Func<Page_Visited_Unsuccessfully, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Page_Visited_Unsuccessfully> Find(Expression<Func<Page_Visited_Unsuccessfully, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<Page_Visited_Unsuccessfully> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<Page_Visited_Unsuccessfully> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<Page_Visited_Unsuccessfully> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Page_Visited_Unsuccessfully> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Page_Visited_Unsuccessfully> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Page_Visited_Unsuccessfully> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "pageId";
        }

        public object KeyValue()
        {
            return this.pageId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.pageId.ToString();
        }

        public static Page_Visited_Unsuccessfully RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.pageId == keyValue);
		}
		
		
		public static Page_Visited_Unsuccessfully Create(int pageIdIn, out string SError){
			SError="";
 			Page_Visited_Unsuccessfully newPage_Visited_Unsuccessfully = new Page_Visited_Unsuccessfully();
	   		try{
				newPage_Visited_Unsuccessfully.UpdateValues(pageIdIn);
				newPage_Visited_Unsuccessfully.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newPage_Visited_Unsuccessfully;
		}

		public string Update(int pageIdIn){
     		string SError = "";
			try{
				UpdateValues(pageIdIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int pageIdIn){
			this.pageId = pageIdIn;
		}
        
		public static Page_Visited_Unsuccessfully Create(string pageIdIn, out string SError){
			SError="";
			Page_Visited_Unsuccessfully newPage_Visited_Unsuccessfully = new Page_Visited_Unsuccessfully();
    		try{
				newPage_Visited_Unsuccessfully.UpdateValues(int.Parse(pageIdIn));
				newPage_Visited_Unsuccessfully.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newPage_Visited_Unsuccessfully;
		}
				

		public string Update(string pageIdIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(pageIdIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(Page_Visited_Unsuccessfully)){
                Page_Visited_Unsuccessfully compare=(Page_Visited_Unsuccessfully)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.pageId;
        }
        
        public string DescriptorValue()
        {
            return this.pageId.ToString();
        }

        public string DescriptorColumn() {
           	return "pageId";
        }
			

        public static string GetKeyColumn()
        {
            return "pageId";
        }        
        public static string GetDescriptorColumn()
        {
            return "pageId";
        }
        
        #region ' Foreign Keys for Page_Visited_Unsuccessfully '
        #endregion
        

        int _pageId;
        [DataMember] 
		public int pageId
        {
            get { return _pageId; }
            set
            {
                if(_pageId!=value){
                    _pageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Page_Visited_Unsuccessfully, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithoutHeadingPathAdequacy_Cosine table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithoutHeadingPathAdequacy_Cosine: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithoutHeadingPathAdequacy_Cosine> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithoutHeadingPathAdequacy_Cosine>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithoutHeadingPathAdequacy_Cosine> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithoutHeadingPathAdequacy_Cosine item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithoutHeadingPathAdequacy_Cosine item=new LinkWithoutHeadingPathAdequacy_Cosine();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithoutHeadingPathAdequacy_Cosine> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithoutHeadingPathAdequacy_Cosine(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithoutHeadingPathAdequacy_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingPathAdequacy_Cosine>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithoutHeadingPathAdequacy_Cosine(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithoutHeadingPathAdequacy_Cosine(Expression<Func<LinkWithoutHeadingPathAdequacy_Cosine, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithoutHeadingPathAdequacy_Cosine> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithoutHeadingPathAdequacy_Cosine> _repo;
            
            if(db.TestMode){
                LinkWithoutHeadingPathAdequacy_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingPathAdequacy_Cosine>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithoutHeadingPathAdequacy_Cosine> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithoutHeadingPathAdequacy_Cosine SingleOrDefault(Expression<Func<LinkWithoutHeadingPathAdequacy_Cosine, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithoutHeadingPathAdequacy_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithoutHeadingPathAdequacy_Cosine SingleOrDefault(Expression<Func<LinkWithoutHeadingPathAdequacy_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithoutHeadingPathAdequacy_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithoutHeadingPathAdequacy_Cosine, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithoutHeadingPathAdequacy_Cosine, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithoutHeadingPathAdequacy_Cosine> Find(Expression<Func<LinkWithoutHeadingPathAdequacy_Cosine, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithoutHeadingPathAdequacy_Cosine> Find(Expression<Func<LinkWithoutHeadingPathAdequacy_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithoutHeadingPathAdequacy_Cosine> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithoutHeadingPathAdequacy_Cosine> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithoutHeadingPathAdequacy_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithoutHeadingPathAdequacy_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithoutHeadingPathAdequacy_Cosine> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithoutHeadingPathAdequacy_Cosine> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "linkWithoutHeadingPathAdequacyCosineID";
        }

        public object KeyValue()
        {
            return this.linkWithoutHeadingPathAdequacyCosineID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.pAString.ToString();
        }

        public static LinkWithoutHeadingPathAdequacy_Cosine RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.linkWithoutHeadingPathAdequacyCosineID == keyValue);
		}
		
		
		public static LinkWithoutHeadingPathAdequacy_Cosine Create(int pageIdIn,int ToPageIdIn,string pAStringIn,int linkIdIn,string CosineIn, out string SError){
			SError="";
 			LinkWithoutHeadingPathAdequacy_Cosine newLinkWithoutHeadingPathAdequacy_Cosine = new LinkWithoutHeadingPathAdequacy_Cosine();
	   		try{
				newLinkWithoutHeadingPathAdequacy_Cosine.UpdateValues(pageIdIn, ToPageIdIn, pAStringIn, linkIdIn, CosineIn);
				newLinkWithoutHeadingPathAdequacy_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingPathAdequacy_Cosine;
		}

		public string Update(int pageIdIn,int ToPageIdIn,string pAStringIn,int linkIdIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(pageIdIn, ToPageIdIn, pAStringIn, linkIdIn, CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int pageIdIn,int ToPageIdIn,string pAStringIn,int linkIdIn,string CosineIn){
			this.pageId = pageIdIn;
			this.ToPageId = ToPageIdIn;
			this.pAString = pAStringIn;
			this.linkId = linkIdIn;
			this.Cosine = CosineIn;
		}
        
		public static LinkWithoutHeadingPathAdequacy_Cosine Create(string pageIdIn,string ToPageIdIn,string pAStringIn,string linkIdIn,string CosineIn, out string SError){
			SError="";
			LinkWithoutHeadingPathAdequacy_Cosine newLinkWithoutHeadingPathAdequacy_Cosine = new LinkWithoutHeadingPathAdequacy_Cosine();
    		try{
				newLinkWithoutHeadingPathAdequacy_Cosine.UpdateValues(int.Parse(pageIdIn), int.Parse(ToPageIdIn), pAStringIn, int.Parse(linkIdIn), CosineIn);
				newLinkWithoutHeadingPathAdequacy_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingPathAdequacy_Cosine;
		}
				

		public string Update(string pageIdIn,string ToPageIdIn,string pAStringIn,string linkIdIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(pageIdIn), int.Parse(ToPageIdIn), pAStringIn, int.Parse(linkIdIn), CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithoutHeadingPathAdequacy_Cosine)){
                LinkWithoutHeadingPathAdequacy_Cosine compare=(LinkWithoutHeadingPathAdequacy_Cosine)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.linkWithoutHeadingPathAdequacyCosineID;
        }
        
        public string DescriptorValue()
        {
            return this.pAString.ToString();
        }

        public string DescriptorColumn() {
           	return "pAString";
        }
			

        public static string GetKeyColumn()
        {
            return "linkWithoutHeadingPathAdequacyCosineID";
        }        
        public static string GetDescriptorColumn()
        {
            return "pAString";
        }
        
        #region ' Foreign Keys for LinkWithoutHeadingPathAdequacy_Cosine '
        #endregion
        

        int _linkWithoutHeadingPathAdequacyCosineID;
        [DataMember] 
		public int linkWithoutHeadingPathAdequacyCosineID
        {
            get { return _linkWithoutHeadingPathAdequacyCosineID; }
            set
            {
                if(_linkWithoutHeadingPathAdequacyCosineID!=value){
                    _linkWithoutHeadingPathAdequacyCosineID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="linkWithoutHeadingPathAdequacyCosineID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _pageId;
        [DataMember] 
		public int pageId
        {
            get { return _pageId; }
            set
            {
                if(_pageId!=value){
                    _pageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _ToPageId;
        [DataMember] 
		public int? ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _pAString;
        [DataMember] 
		public string pAString
        {
            get { return _pAString; }
            set
            {
                if(_pAString!=value){
                    _pAString=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pAString");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _linkId;
        [DataMember] 
		public int linkId
        {
            get { return _linkId; }
            set
            {
                if(_linkId!=value){
                    _linkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="linkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Cosine;
        [DataMember] 
		public string Cosine
        {
            get { return _Cosine; }
            set
            {
                if(_Cosine!=value){
                    _Cosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Cosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithoutHeadingPathAdequacy_Cosine, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Goal table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class Goal: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Goal> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Goal>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Goal> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Goal item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Goal item=new Goal();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Goal> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public Goal(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Goal.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Goal>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Goal(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Goal(Expression<Func<Goal, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Goal> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<Goal> _repo;
            
            if(db.TestMode){
                Goal.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Goal>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Goal> GetRepo(){
            return GetRepo("","");
        }
        
        public static Goal SingleOrDefault(Expression<Func<Goal, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Goal single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Goal SingleOrDefault(Expression<Func<Goal, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Goal single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Goal, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Goal, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Goal> Find(Expression<Func<Goal, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Goal> Find(Expression<Func<Goal, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<Goal> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<Goal> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<Goal> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Goal> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Goal> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Goal> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "text";
        }

        public object KeyValue()
        {
            return this.text;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<string>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.text.ToString();
        }

        public static Goal RetrieveByKey(string keyValue){
     		return SingleOrDefault(x=>x.text == keyValue);
		}
		
		
		public static Goal Create(string textIn, out string SError){
			SError="";
 			Goal newGoal = new Goal();
	   		try{
				newGoal.UpdateValues(textIn);
				newGoal.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newGoal;
		}

		public string Update(string textIn){
     		string SError = "";
			try{
				UpdateValues(textIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(string textIn){
			this.text = textIn;
		}
        
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(Goal)){
                Goal compare=(Goal)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        public string DescriptorValue()
        {
            return this.text.ToString();
        }

        public string DescriptorColumn() {
           	return "text";
        }
			

        public static string GetKeyColumn()
        {
            return "text";
        }        
        public static string GetDescriptorColumn()
        {
            return "text";
        }
        
        #region ' Foreign Keys for Goal '
        #endregion
        

        string _text;
        [DataMember] 
		public string text
        {
            get { return _text; }
            set
            {
                if(_text!=value){
                    _text=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="text");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Goal, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkUnderHeadingPathAdequacy_Cosine table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkUnderHeadingPathAdequacy_Cosine: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkUnderHeadingPathAdequacy_Cosine> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkUnderHeadingPathAdequacy_Cosine>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkUnderHeadingPathAdequacy_Cosine> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkUnderHeadingPathAdequacy_Cosine item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkUnderHeadingPathAdequacy_Cosine item=new LinkUnderHeadingPathAdequacy_Cosine();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkUnderHeadingPathAdequacy_Cosine> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkUnderHeadingPathAdequacy_Cosine(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkUnderHeadingPathAdequacy_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkUnderHeadingPathAdequacy_Cosine>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkUnderHeadingPathAdequacy_Cosine(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkUnderHeadingPathAdequacy_Cosine(Expression<Func<LinkUnderHeadingPathAdequacy_Cosine, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkUnderHeadingPathAdequacy_Cosine> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkUnderHeadingPathAdequacy_Cosine> _repo;
            
            if(db.TestMode){
                LinkUnderHeadingPathAdequacy_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkUnderHeadingPathAdequacy_Cosine>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkUnderHeadingPathAdequacy_Cosine> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkUnderHeadingPathAdequacy_Cosine SingleOrDefault(Expression<Func<LinkUnderHeadingPathAdequacy_Cosine, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkUnderHeadingPathAdequacy_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkUnderHeadingPathAdequacy_Cosine SingleOrDefault(Expression<Func<LinkUnderHeadingPathAdequacy_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkUnderHeadingPathAdequacy_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkUnderHeadingPathAdequacy_Cosine, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkUnderHeadingPathAdequacy_Cosine, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkUnderHeadingPathAdequacy_Cosine> Find(Expression<Func<LinkUnderHeadingPathAdequacy_Cosine, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkUnderHeadingPathAdequacy_Cosine> Find(Expression<Func<LinkUnderHeadingPathAdequacy_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkUnderHeadingPathAdequacy_Cosine> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkUnderHeadingPathAdequacy_Cosine> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkUnderHeadingPathAdequacy_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkUnderHeadingPathAdequacy_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkUnderHeadingPathAdequacy_Cosine> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkUnderHeadingPathAdequacy_Cosine> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "linkUnderHeadingPathAdequacyCosineID";
        }

        public object KeyValue()
        {
            return this.linkUnderHeadingPathAdequacyCosineID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.pAString.ToString();
        }

        public static LinkUnderHeadingPathAdequacy_Cosine RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.linkUnderHeadingPathAdequacyCosineID == keyValue);
		}
		
		
		public static LinkUnderHeadingPathAdequacy_Cosine Create(int pageIdIn,int ToPageIdIn,string pAStringIn,int headingIdIn,int linkIdIn,string CosineIn, out string SError){
			SError="";
 			LinkUnderHeadingPathAdequacy_Cosine newLinkUnderHeadingPathAdequacy_Cosine = new LinkUnderHeadingPathAdequacy_Cosine();
	   		try{
				newLinkUnderHeadingPathAdequacy_Cosine.UpdateValues(pageIdIn, ToPageIdIn, pAStringIn, headingIdIn, linkIdIn, CosineIn);
				newLinkUnderHeadingPathAdequacy_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkUnderHeadingPathAdequacy_Cosine;
		}

		public string Update(int pageIdIn,int ToPageIdIn,string pAStringIn,int headingIdIn,int linkIdIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(pageIdIn, ToPageIdIn, pAStringIn, headingIdIn, linkIdIn, CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int pageIdIn,int ToPageIdIn,string pAStringIn,int headingIdIn,int linkIdIn,string CosineIn){
			this.pageId = pageIdIn;
			this.ToPageId = ToPageIdIn;
			this.pAString = pAStringIn;
			this.headingId = headingIdIn;
			this.linkId = linkIdIn;
			this.Cosine = CosineIn;
		}
        
		public static LinkUnderHeadingPathAdequacy_Cosine Create(string pageIdIn,string ToPageIdIn,string pAStringIn,string headingIdIn,string linkIdIn,string CosineIn, out string SError){
			SError="";
			LinkUnderHeadingPathAdequacy_Cosine newLinkUnderHeadingPathAdequacy_Cosine = new LinkUnderHeadingPathAdequacy_Cosine();
    		try{
				newLinkUnderHeadingPathAdequacy_Cosine.UpdateValues(int.Parse(pageIdIn), int.Parse(ToPageIdIn), pAStringIn, int.Parse(headingIdIn), int.Parse(linkIdIn), CosineIn);
				newLinkUnderHeadingPathAdequacy_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkUnderHeadingPathAdequacy_Cosine;
		}
				

		public string Update(string pageIdIn,string ToPageIdIn,string pAStringIn,string headingIdIn,string linkIdIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(pageIdIn), int.Parse(ToPageIdIn), pAStringIn, int.Parse(headingIdIn), int.Parse(linkIdIn), CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkUnderHeadingPathAdequacy_Cosine)){
                LinkUnderHeadingPathAdequacy_Cosine compare=(LinkUnderHeadingPathAdequacy_Cosine)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.linkUnderHeadingPathAdequacyCosineID;
        }
        
        public string DescriptorValue()
        {
            return this.pAString.ToString();
        }

        public string DescriptorColumn() {
           	return "pAString";
        }
			

        public static string GetKeyColumn()
        {
            return "linkUnderHeadingPathAdequacyCosineID";
        }        
        public static string GetDescriptorColumn()
        {
            return "pAString";
        }
        
        #region ' Foreign Keys for LinkUnderHeadingPathAdequacy_Cosine '
        #endregion
        

        int _linkUnderHeadingPathAdequacyCosineID;
        [DataMember] 
		public int linkUnderHeadingPathAdequacyCosineID
        {
            get { return _linkUnderHeadingPathAdequacyCosineID; }
            set
            {
                if(_linkUnderHeadingPathAdequacyCosineID!=value){
                    _linkUnderHeadingPathAdequacyCosineID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="linkUnderHeadingPathAdequacyCosineID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _pageId;
        [DataMember] 
		public int pageId
        {
            get { return _pageId; }
            set
            {
                if(_pageId!=value){
                    _pageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _pAString;
        [DataMember] 
		public string pAString
        {
            get { return _pAString; }
            set
            {
                if(_pAString!=value){
                    _pAString=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pAString");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _headingId;
        [DataMember] 
		public int headingId
        {
            get { return _headingId; }
            set
            {
                if(_headingId!=value){
                    _headingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _linkId;
        [DataMember] 
		public int linkId
        {
            get { return _linkId; }
            set
            {
                if(_linkId!=value){
                    _linkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="linkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Cosine;
        [DataMember] 
		public string Cosine
        {
            get { return _Cosine; }
            set
            {
                if(_Cosine!=value){
                    _Cosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Cosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkUnderHeadingPathAdequacy_Cosine, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the PageTemplate table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class PageTemplate: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<PageTemplate> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<PageTemplate>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<PageTemplate> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(PageTemplate item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                PageTemplate item=new PageTemplate();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<PageTemplate> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public PageTemplate(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                PageTemplate.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<PageTemplate>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public PageTemplate(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public PageTemplate(Expression<Func<PageTemplate, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<PageTemplate> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<PageTemplate> _repo;
            
            if(db.TestMode){
                PageTemplate.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<PageTemplate>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<PageTemplate> GetRepo(){
            return GetRepo("","");
        }
        
        public static PageTemplate SingleOrDefault(Expression<Func<PageTemplate, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            PageTemplate single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static PageTemplate SingleOrDefault(Expression<Func<PageTemplate, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            PageTemplate single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<PageTemplate, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<PageTemplate, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<PageTemplate> Find(Expression<Func<PageTemplate, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<PageTemplate> Find(Expression<Func<PageTemplate, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<PageTemplate> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<PageTemplate> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<PageTemplate> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<PageTemplate> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<PageTemplate> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<PageTemplate> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "PageTemplateId";
        }

        public object KeyValue()
        {
            return this.PageTemplateId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.Pattern.ToString();
        }

        public static PageTemplate RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.PageTemplateId == keyValue);
		}
		
		
		public static PageTemplate Create(string PatternIn,string NameIn, out string SError){
			SError="";
 			PageTemplate newPageTemplate = new PageTemplate();
	   		try{
				newPageTemplate.UpdateValues(PatternIn, NameIn);
				newPageTemplate.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newPageTemplate;
		}

		public string Update(string PatternIn,string NameIn){
     		string SError = "";
			try{
				UpdateValues(PatternIn, NameIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(string PatternIn,string NameIn){
			this.Pattern = PatternIn;
			this.Name = NameIn;
		}
        
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(PageTemplate)){
                PageTemplate compare=(PageTemplate)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.PageTemplateId;
        }
        
        public string DescriptorValue()
        {
            return this.Pattern.ToString();
        }

        public string DescriptorColumn() {
           	return "Pattern";
        }
			

        public static string GetKeyColumn()
        {
            return "PageTemplateId";
        }        
        public static string GetDescriptorColumn()
        {
            return "Pattern";
        }
        
        #region ' Foreign Keys for PageTemplate '
        #endregion
        

        int _PageTemplateId;
        [DataMember] 
		public int PageTemplateId
        {
            get { return _PageTemplateId; }
            set
            {
                if(_PageTemplateId!=value){
                    _PageTemplateId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PageTemplateId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Pattern;
        [DataMember] 
		public string Pattern
        {
            get { return _Pattern; }
            set
            {
                if(_Pattern!=value){
                    _Pattern=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Pattern");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Name;
        [DataMember] 
		public string Name
        {
            get { return _Name; }
            set
            {
                if(_Name!=value){
                    _Name=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Name");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<PageTemplate, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithoutHeading_Cosine table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithoutHeading_Cosine: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithoutHeading_Cosine> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithoutHeading_Cosine>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithoutHeading_Cosine> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithoutHeading_Cosine item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithoutHeading_Cosine item=new LinkWithoutHeading_Cosine();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithoutHeading_Cosine> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithoutHeading_Cosine(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithoutHeading_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeading_Cosine>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithoutHeading_Cosine(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithoutHeading_Cosine(Expression<Func<LinkWithoutHeading_Cosine, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithoutHeading_Cosine> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithoutHeading_Cosine> _repo;
            
            if(db.TestMode){
                LinkWithoutHeading_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeading_Cosine>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithoutHeading_Cosine> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithoutHeading_Cosine SingleOrDefault(Expression<Func<LinkWithoutHeading_Cosine, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithoutHeading_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithoutHeading_Cosine SingleOrDefault(Expression<Func<LinkWithoutHeading_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithoutHeading_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithoutHeading_Cosine, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithoutHeading_Cosine, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithoutHeading_Cosine> Find(Expression<Func<LinkWithoutHeading_Cosine, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithoutHeading_Cosine> Find(Expression<Func<LinkWithoutHeading_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithoutHeading_Cosine> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithoutHeading_Cosine> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithoutHeading_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithoutHeading_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithoutHeading_Cosine> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithoutHeading_Cosine> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "linkWithoutHeadingCosineID";
        }

        public object KeyValue()
        {
            return this.linkWithoutHeadingCosineID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkName.ToString();
        }

        public static LinkWithoutHeading_Cosine RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.linkWithoutHeadingCosineID == keyValue);
		}
		
		
		public static LinkWithoutHeading_Cosine Create(int pageIdIn,int ToPageIdIn,int linkIdIn,string LinkNameIn,string CosineIn, out string SError){
			SError="";
 			LinkWithoutHeading_Cosine newLinkWithoutHeading_Cosine = new LinkWithoutHeading_Cosine();
	   		try{
				newLinkWithoutHeading_Cosine.UpdateValues(pageIdIn, ToPageIdIn, linkIdIn, LinkNameIn, CosineIn);
				newLinkWithoutHeading_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeading_Cosine;
		}

		public string Update(int pageIdIn,int ToPageIdIn,int linkIdIn,string LinkNameIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(pageIdIn, ToPageIdIn, linkIdIn, LinkNameIn, CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int pageIdIn,int ToPageIdIn,int linkIdIn,string LinkNameIn,string CosineIn){
			this.pageId = pageIdIn;
			this.ToPageId = ToPageIdIn;
			this.linkId = linkIdIn;
			this.LinkName = LinkNameIn;
			this.Cosine = CosineIn;
		}
        
		public static LinkWithoutHeading_Cosine Create(string pageIdIn,string ToPageIdIn,string linkIdIn,string LinkNameIn,string CosineIn, out string SError){
			SError="";
			LinkWithoutHeading_Cosine newLinkWithoutHeading_Cosine = new LinkWithoutHeading_Cosine();
    		try{
				newLinkWithoutHeading_Cosine.UpdateValues(int.Parse(pageIdIn), int.Parse(ToPageIdIn), int.Parse(linkIdIn), LinkNameIn, CosineIn);
				newLinkWithoutHeading_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeading_Cosine;
		}
				

		public string Update(string pageIdIn,string ToPageIdIn,string linkIdIn,string LinkNameIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(pageIdIn), int.Parse(ToPageIdIn), int.Parse(linkIdIn), LinkNameIn, CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithoutHeading_Cosine)){
                LinkWithoutHeading_Cosine compare=(LinkWithoutHeading_Cosine)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.linkWithoutHeadingCosineID;
        }
        
        public string DescriptorValue()
        {
            return this.LinkName.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkName";
        }
			

        public static string GetKeyColumn()
        {
            return "linkWithoutHeadingCosineID";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkName";
        }
        
        #region ' Foreign Keys for LinkWithoutHeading_Cosine '
        #endregion
        

        int _linkWithoutHeadingCosineID;
        [DataMember] 
		public int linkWithoutHeadingCosineID
        {
            get { return _linkWithoutHeadingCosineID; }
            set
            {
                if(_linkWithoutHeadingCosineID!=value){
                    _linkWithoutHeadingCosineID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="linkWithoutHeadingCosineID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _pageId;
        [DataMember] 
		public int pageId
        {
            get { return _pageId; }
            set
            {
                if(_pageId!=value){
                    _pageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _ToPageId;
        [DataMember] 
		public int? ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _linkId;
        [DataMember] 
		public int linkId
        {
            get { return _linkId; }
            set
            {
                if(_linkId!=value){
                    _linkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="linkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkName;
        [DataMember] 
		public string LinkName
        {
            get { return _LinkName; }
            set
            {
                if(_LinkName!=value){
                    _LinkName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Cosine;
        [DataMember] 
		public string Cosine
        {
            get { return _Cosine; }
            set
            {
                if(_Cosine!=value){
                    _Cosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Cosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithoutHeading_Cosine, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkUnderHeading_Cosine table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkUnderHeading_Cosine: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkUnderHeading_Cosine> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkUnderHeading_Cosine>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkUnderHeading_Cosine> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkUnderHeading_Cosine item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkUnderHeading_Cosine item=new LinkUnderHeading_Cosine();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkUnderHeading_Cosine> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkUnderHeading_Cosine(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkUnderHeading_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkUnderHeading_Cosine>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkUnderHeading_Cosine(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkUnderHeading_Cosine(Expression<Func<LinkUnderHeading_Cosine, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkUnderHeading_Cosine> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkUnderHeading_Cosine> _repo;
            
            if(db.TestMode){
                LinkUnderHeading_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkUnderHeading_Cosine>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkUnderHeading_Cosine> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkUnderHeading_Cosine SingleOrDefault(Expression<Func<LinkUnderHeading_Cosine, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkUnderHeading_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkUnderHeading_Cosine SingleOrDefault(Expression<Func<LinkUnderHeading_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkUnderHeading_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkUnderHeading_Cosine, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkUnderHeading_Cosine, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkUnderHeading_Cosine> Find(Expression<Func<LinkUnderHeading_Cosine, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkUnderHeading_Cosine> Find(Expression<Func<LinkUnderHeading_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkUnderHeading_Cosine> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkUnderHeading_Cosine> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkUnderHeading_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkUnderHeading_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkUnderHeading_Cosine> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkUnderHeading_Cosine> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "linkUnderHeadingCosineID";
        }

        public object KeyValue()
        {
            return this.linkUnderHeadingCosineID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.headingText.ToString();
        }

        public static LinkUnderHeading_Cosine RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.linkUnderHeadingCosineID == keyValue);
		}
		
		
		public static LinkUnderHeading_Cosine Create(int pageIdIn,int ToPageIdIn,int headingIdIn,string headingTextIn,int linkIdIn,string LinkNameIn,string CosineIn, out string SError){
			SError="";
 			LinkUnderHeading_Cosine newLinkUnderHeading_Cosine = new LinkUnderHeading_Cosine();
	   		try{
				newLinkUnderHeading_Cosine.UpdateValues(pageIdIn, ToPageIdIn, headingIdIn, headingTextIn, linkIdIn, LinkNameIn, CosineIn);
				newLinkUnderHeading_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkUnderHeading_Cosine;
		}

		public string Update(int pageIdIn,int ToPageIdIn,int headingIdIn,string headingTextIn,int linkIdIn,string LinkNameIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(pageIdIn, ToPageIdIn, headingIdIn, headingTextIn, linkIdIn, LinkNameIn, CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int pageIdIn,int ToPageIdIn,int headingIdIn,string headingTextIn,int linkIdIn,string LinkNameIn,string CosineIn){
			this.pageId = pageIdIn;
			this.ToPageId = ToPageIdIn;
			this.headingId = headingIdIn;
			this.headingText = headingTextIn;
			this.linkId = linkIdIn;
			this.LinkName = LinkNameIn;
			this.Cosine = CosineIn;
		}
        
		public static LinkUnderHeading_Cosine Create(string pageIdIn,string ToPageIdIn,string headingIdIn,string headingTextIn,string linkIdIn,string LinkNameIn,string CosineIn, out string SError){
			SError="";
			LinkUnderHeading_Cosine newLinkUnderHeading_Cosine = new LinkUnderHeading_Cosine();
    		try{
				newLinkUnderHeading_Cosine.UpdateValues(int.Parse(pageIdIn), int.Parse(ToPageIdIn), int.Parse(headingIdIn), headingTextIn, int.Parse(linkIdIn), LinkNameIn, CosineIn);
				newLinkUnderHeading_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkUnderHeading_Cosine;
		}
				

		public string Update(string pageIdIn,string ToPageIdIn,string headingIdIn,string headingTextIn,string linkIdIn,string LinkNameIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(pageIdIn), int.Parse(ToPageIdIn), int.Parse(headingIdIn), headingTextIn, int.Parse(linkIdIn), LinkNameIn, CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkUnderHeading_Cosine)){
                LinkUnderHeading_Cosine compare=(LinkUnderHeading_Cosine)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.linkUnderHeadingCosineID;
        }
        
        public string DescriptorValue()
        {
            return this.headingText.ToString();
        }

        public string DescriptorColumn() {
           	return "headingText";
        }
			

        public static string GetKeyColumn()
        {
            return "linkUnderHeadingCosineID";
        }        
        public static string GetDescriptorColumn()
        {
            return "headingText";
        }
        
        #region ' Foreign Keys for LinkUnderHeading_Cosine '
        #endregion
        

        int _linkUnderHeadingCosineID;
        [DataMember] 
		public int linkUnderHeadingCosineID
        {
            get { return _linkUnderHeadingCosineID; }
            set
            {
                if(_linkUnderHeadingCosineID!=value){
                    _linkUnderHeadingCosineID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="linkUnderHeadingCosineID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _pageId;
        [DataMember] 
		public int pageId
        {
            get { return _pageId; }
            set
            {
                if(_pageId!=value){
                    _pageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _ToPageId;
        [DataMember] 
		public int? ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _headingId;
        [DataMember] 
		public int headingId
        {
            get { return _headingId; }
            set
            {
                if(_headingId!=value){
                    _headingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _headingText;
        [DataMember] 
		public string headingText
        {
            get { return _headingText; }
            set
            {
                if(_headingText!=value){
                    _headingText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _linkId;
        [DataMember] 
		public int linkId
        {
            get { return _linkId; }
            set
            {
                if(_linkId!=value){
                    _linkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="linkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkName;
        [DataMember] 
		public string LinkName
        {
            get { return _LinkName; }
            set
            {
                if(_LinkName!=value){
                    _LinkName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Cosine;
        [DataMember] 
		public string Cosine
        {
            get { return _Cosine; }
            set
            {
                if(_Cosine!=value){
                    _Cosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Cosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkUnderHeading_Cosine, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Path table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class Path: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Path> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Path>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Path> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Path item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Path item=new Path();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Path> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public Path(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Path.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Path>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Path(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Path(Expression<Func<Path, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Path> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<Path> _repo;
            
            if(db.TestMode){
                Path.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Path>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Path> GetRepo(){
            return GetRepo("","");
        }
        
        public static Path SingleOrDefault(Expression<Func<Path, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Path single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Path SingleOrDefault(Expression<Func<Path, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Path single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Path, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Path, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Path> Find(Expression<Func<Path, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Path> Find(Expression<Func<Path, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<Path> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<Path> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<Path> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Path> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Path> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Path> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "pathId";
        }

        public object KeyValue()
        {
            return this.pathId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.PreviousCosine.ToString();
        }

        public static Path RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.pathId == keyValue);
		}
		
		
		public static Path Create(int headingIdIn,int linkIdIn,int ThisPageIdIn,int ToPageIdIn,string PreviousCosineIn,string NewCosineIn,string PathChoosenIn,int PreviousRowIn, out string SError){
			SError="";
 			Path newPath = new Path();
	   		try{
				newPath.UpdateValues(headingIdIn, linkIdIn, ThisPageIdIn, ToPageIdIn, PreviousCosineIn, NewCosineIn, PathChoosenIn, PreviousRowIn);
				newPath.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newPath;
		}

		public string Update(int headingIdIn,int linkIdIn,int ThisPageIdIn,int ToPageIdIn,string PreviousCosineIn,string NewCosineIn,string PathChoosenIn,int PreviousRowIn){
     		string SError = "";
			try{
				UpdateValues(headingIdIn, linkIdIn, ThisPageIdIn, ToPageIdIn, PreviousCosineIn, NewCosineIn, PathChoosenIn, PreviousRowIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int headingIdIn,int linkIdIn,int ThisPageIdIn,int ToPageIdIn,string PreviousCosineIn,string NewCosineIn,string PathChoosenIn,int PreviousRowIn){
			this.headingId = headingIdIn;
			this.linkId = linkIdIn;
			this.ThisPageId = ThisPageIdIn;
			this.ToPageId = ToPageIdIn;
			this.PreviousCosine = PreviousCosineIn;
			this.NewCosine = NewCosineIn;
			this.PathChoosen = PathChoosenIn;
			this.PreviousRow = PreviousRowIn;
		}
        
		public static Path Create(string headingIdIn,string linkIdIn,string ThisPageIdIn,string ToPageIdIn,string PreviousCosineIn,string NewCosineIn,string PathChoosenIn,string PreviousRowIn, out string SError){
			SError="";
			Path newPath = new Path();
    		try{
				newPath.UpdateValues(int.Parse(headingIdIn), int.Parse(linkIdIn), int.Parse(ThisPageIdIn), int.Parse(ToPageIdIn), PreviousCosineIn, NewCosineIn, PathChoosenIn, int.Parse(PreviousRowIn));
				newPath.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newPath;
		}
				

		public string Update(string headingIdIn,string linkIdIn,string ThisPageIdIn,string ToPageIdIn,string PreviousCosineIn,string NewCosineIn,string PathChoosenIn,string PreviousRowIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(headingIdIn), int.Parse(linkIdIn), int.Parse(ThisPageIdIn), int.Parse(ToPageIdIn), PreviousCosineIn, NewCosineIn, PathChoosenIn, int.Parse(PreviousRowIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(Path)){
                Path compare=(Path)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.pathId;
        }
        
        public string DescriptorValue()
        {
            return this.PreviousCosine.ToString();
        }

        public string DescriptorColumn() {
           	return "PreviousCosine";
        }
			

        public static string GetKeyColumn()
        {
            return "pathId";
        }        
        public static string GetDescriptorColumn()
        {
            return "PreviousCosine";
        }
        
        #region ' Foreign Keys for Path '
        #endregion
        

        int _pathId;
        [DataMember] 
		public int pathId
        {
            get { return _pathId; }
            set
            {
                if(_pathId!=value){
                    _pathId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pathId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _headingId;
        [DataMember] 
		public int? headingId
        {
            get { return _headingId; }
            set
            {
                if(_headingId!=value){
                    _headingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _linkId;
        [DataMember] 
		public int? linkId
        {
            get { return _linkId; }
            set
            {
                if(_linkId!=value){
                    _linkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="linkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _ThisPageId;
        [DataMember] 
		public int? ThisPageId
        {
            get { return _ThisPageId; }
            set
            {
                if(_ThisPageId!=value){
                    _ThisPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ThisPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _ToPageId;
        [DataMember] 
		public int? ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _PreviousCosine;
        [DataMember] 
		public string PreviousCosine
        {
            get { return _PreviousCosine; }
            set
            {
                if(_PreviousCosine!=value){
                    _PreviousCosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PreviousCosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _NewCosine;
        [DataMember] 
		public string NewCosine
        {
            get { return _NewCosine; }
            set
            {
                if(_NewCosine!=value){
                    _NewCosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="NewCosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _PathChoosen;
        [DataMember] 
		public string PathChoosen
        {
            get { return _PathChoosen; }
            set
            {
                if(_PathChoosen!=value){
                    _PathChoosen=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PathChoosen");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int? _PreviousRow;
        [DataMember] 
		public int? PreviousRow
        {
            get { return _PreviousRow; }
            set
            {
                if(_PreviousRow!=value){
                    _PreviousRow=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="PreviousRow");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Path, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Solution_Found table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class Solution_Found: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Solution_Found> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Solution_Found>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Solution_Found> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Solution_Found item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Solution_Found item=new Solution_Found();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Solution_Found> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public Solution_Found(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Solution_Found.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Solution_Found>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Solution_Found(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Solution_Found(Expression<Func<Solution_Found, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Solution_Found> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<Solution_Found> _repo;
            
            if(db.TestMode){
                Solution_Found.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Solution_Found>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Solution_Found> GetRepo(){
            return GetRepo("","");
        }
        
        public static Solution_Found SingleOrDefault(Expression<Func<Solution_Found, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Solution_Found single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Solution_Found SingleOrDefault(Expression<Func<Solution_Found, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Solution_Found single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Solution_Found, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Solution_Found, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Solution_Found> Find(Expression<Func<Solution_Found, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Solution_Found> Find(Expression<Func<Solution_Found, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<Solution_Found> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<Solution_Found> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<Solution_Found> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Solution_Found> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Solution_Found> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Solution_Found> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "solutionFoundId";
        }

        public object KeyValue()
        {
            return this.solutionFoundId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.paragraphText.ToString();
        }

        public static Solution_Found RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.solutionFoundId == keyValue);
		}
		
		
		public static Solution_Found Create(int pageIdIn,int topageIdIn,int headingIdIn,int pathIdinPathTableIn,int paragraphIdIn,string paragraphTextIn,string cosineIn, out string SError){
			SError="";
 			Solution_Found newSolution_Found = new Solution_Found();
	   		try{
				newSolution_Found.UpdateValues(pageIdIn, topageIdIn, headingIdIn, pathIdinPathTableIn, paragraphIdIn, paragraphTextIn, cosineIn);
				newSolution_Found.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newSolution_Found;
		}

		public string Update(int pageIdIn,int topageIdIn,int headingIdIn,int pathIdinPathTableIn,int paragraphIdIn,string paragraphTextIn,string cosineIn){
     		string SError = "";
			try{
				UpdateValues(pageIdIn, topageIdIn, headingIdIn, pathIdinPathTableIn, paragraphIdIn, paragraphTextIn, cosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int pageIdIn,int topageIdIn,int headingIdIn,int pathIdinPathTableIn,int paragraphIdIn,string paragraphTextIn,string cosineIn){
			this.pageId = pageIdIn;
			this.topageId = topageIdIn;
			this.headingId = headingIdIn;
			this.pathIdinPathTable = pathIdinPathTableIn;
			this.paragraphId = paragraphIdIn;
			this.paragraphText = paragraphTextIn;
			this.cosine = cosineIn;
		}
        
		public static Solution_Found Create(string pageIdIn,string topageIdIn,string headingIdIn,string pathIdinPathTableIn,string paragraphIdIn,string paragraphTextIn,string cosineIn, out string SError){
			SError="";
			Solution_Found newSolution_Found = new Solution_Found();
    		try{
				newSolution_Found.UpdateValues(int.Parse(pageIdIn), int.Parse(topageIdIn), int.Parse(headingIdIn), int.Parse(pathIdinPathTableIn), int.Parse(paragraphIdIn), paragraphTextIn, cosineIn);
				newSolution_Found.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newSolution_Found;
		}
				

		public string Update(string pageIdIn,string topageIdIn,string headingIdIn,string pathIdinPathTableIn,string paragraphIdIn,string paragraphTextIn,string cosineIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(pageIdIn), int.Parse(topageIdIn), int.Parse(headingIdIn), int.Parse(pathIdinPathTableIn), int.Parse(paragraphIdIn), paragraphTextIn, cosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(Solution_Found)){
                Solution_Found compare=(Solution_Found)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.solutionFoundId;
        }
        
        public string DescriptorValue()
        {
            return this.paragraphText.ToString();
        }

        public string DescriptorColumn() {
           	return "paragraphText";
        }
			

        public static string GetKeyColumn()
        {
            return "solutionFoundId";
        }        
        public static string GetDescriptorColumn()
        {
            return "paragraphText";
        }
        
        #region ' Foreign Keys for Solution_Found '
        #endregion
        

        int _solutionFoundId;
        [DataMember] 
		public int solutionFoundId
        {
            get { return _solutionFoundId; }
            set
            {
                if(_solutionFoundId!=value){
                    _solutionFoundId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="solutionFoundId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _pageId;
        [DataMember] 
		public int pageId
        {
            get { return _pageId; }
            set
            {
                if(_pageId!=value){
                    _pageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _topageId;
        [DataMember] 
		public int topageId
        {
            get { return _topageId; }
            set
            {
                if(_topageId!=value){
                    _topageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="topageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _headingId;
        [DataMember] 
		public int headingId
        {
            get { return _headingId; }
            set
            {
                if(_headingId!=value){
                    _headingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _pathIdinPathTable;
        [DataMember] 
		public int pathIdinPathTable
        {
            get { return _pathIdinPathTable; }
            set
            {
                if(_pathIdinPathTable!=value){
                    _pathIdinPathTable=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pathIdinPathTable");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _paragraphId;
        [DataMember] 
		public int paragraphId
        {
            get { return _paragraphId; }
            set
            {
                if(_paragraphId!=value){
                    _paragraphId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="paragraphId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _paragraphText;
        [DataMember] 
		public string paragraphText
        {
            get { return _paragraphText; }
            set
            {
                if(_paragraphText!=value){
                    _paragraphText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="paragraphText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _cosine;
        [DataMember] 
		public string cosine
        {
            get { return _cosine; }
            set
            {
                if(_cosine!=value){
                    _cosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="cosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Solution_Found, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the HeadingModified table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class HeadingModified: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<HeadingModified> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<HeadingModified>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<HeadingModified> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(HeadingModified item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                HeadingModified item=new HeadingModified();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<HeadingModified> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public HeadingModified(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                HeadingModified.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingModified>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public HeadingModified(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public HeadingModified(Expression<Func<HeadingModified, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<HeadingModified> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<HeadingModified> _repo;
            
            if(db.TestMode){
                HeadingModified.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingModified>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<HeadingModified> GetRepo(){
            return GetRepo("","");
        }
        
        public static HeadingModified SingleOrDefault(Expression<Func<HeadingModified, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            HeadingModified single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static HeadingModified SingleOrDefault(Expression<Func<HeadingModified, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            HeadingModified single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<HeadingModified, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<HeadingModified, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<HeadingModified> Find(Expression<Func<HeadingModified, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<HeadingModified> Find(Expression<Func<HeadingModified, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<HeadingModified> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<HeadingModified> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<HeadingModified> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<HeadingModified> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<HeadingModified> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<HeadingModified> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "HeadingId";
        }

        public object KeyValue()
        {
            return this.HeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.HeadingText.ToString();
        }

        public static HeadingModified RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.HeadingId == keyValue);
		}
		
		
		public static HeadingModified Create(int WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn, out string SError){
			SError="";
 			HeadingModified newHeadingModified = new HeadingModified();
	   		try{
				newHeadingModified.UpdateValues(WebPageIdIn, HeadingTextIn, VectorTermLengthIn);
				newHeadingModified.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingModified;
		}

		public string Update(int WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, HeadingTextIn, VectorTermLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn){
			this.WebPageId = WebPageIdIn;
			this.HeadingText = HeadingTextIn;
			this.VectorTermLength = VectorTermLengthIn;
		}
        
		public static HeadingModified Create(string WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn, out string SError){
			SError="";
			HeadingModified newHeadingModified = new HeadingModified();
    		try{
				newHeadingModified.UpdateValues(int.Parse(WebPageIdIn), HeadingTextIn, VectorTermLengthIn);
				newHeadingModified.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingModified;
		}
				

		public string Update(string WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), HeadingTextIn, VectorTermLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(HeadingModified)){
                HeadingModified compare=(HeadingModified)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.HeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.HeadingText.ToString();
        }

        public string DescriptorColumn() {
           	return "HeadingText";
        }
			

        public static string GetKeyColumn()
        {
            return "HeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "HeadingText";
        }
        
        #region ' Foreign Keys for HeadingModified '
        #endregion
        

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _HeadingText;
        [DataMember] 
		public string HeadingText
        {
            get { return _HeadingText; }
            set
            {
                if(_HeadingText!=value){
                    _HeadingText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLength;
        [DataMember] 
		public string VectorTermLength
        {
            get { return _VectorTermLength; }
            set
            {
                if(_VectorTermLength!=value){
                    _VectorTermLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<HeadingModified, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithHeadingTUBSModified table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithHeadingTUBSModified: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithHeadingTUBSModified> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithHeadingTUBSModified>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithHeadingTUBSModified> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithHeadingTUBSModified item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithHeadingTUBSModified item=new LinkWithHeadingTUBSModified();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithHeadingTUBSModified> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithHeadingTUBSModified(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithHeadingTUBSModified.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithHeadingTUBSModified>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithHeadingTUBSModified(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithHeadingTUBSModified(Expression<Func<LinkWithHeadingTUBSModified, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithHeadingTUBSModified> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithHeadingTUBSModified> _repo;
            
            if(db.TestMode){
                LinkWithHeadingTUBSModified.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithHeadingTUBSModified>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithHeadingTUBSModified> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithHeadingTUBSModified SingleOrDefault(Expression<Func<LinkWithHeadingTUBSModified, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithHeadingTUBSModified single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithHeadingTUBSModified SingleOrDefault(Expression<Func<LinkWithHeadingTUBSModified, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithHeadingTUBSModified single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithHeadingTUBSModified, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithHeadingTUBSModified, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithHeadingTUBSModified> Find(Expression<Func<LinkWithHeadingTUBSModified, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithHeadingTUBSModified> Find(Expression<Func<LinkWithHeadingTUBSModified, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithHeadingTUBSModified> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithHeadingTUBSModified> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithHeadingTUBSModified> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithHeadingTUBSModified> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithHeadingTUBSModified> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithHeadingTUBSModified> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkId";
        }

        public object KeyValue()
        {
            return this.LinkId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkAnchorText.ToString();
        }

        public static LinkWithHeadingTUBSModified RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkId == keyValue);
		}
		
		
		public static LinkWithHeadingTUBSModified Create(int WebPageIdIn,int HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,bool VisitedIn, out string SError){
			SError="";
 			LinkWithHeadingTUBSModified newLinkWithHeadingTUBSModified = new LinkWithHeadingTUBSModified();
	   		try{
				newLinkWithHeadingTUBSModified.UpdateValues(WebPageIdIn, HeadingIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, CosineValueLinkHeadingIn, VisitedIn);
				newLinkWithHeadingTUBSModified.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithHeadingTUBSModified;
		}

		public string Update(int WebPageIdIn,int HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,bool VisitedIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, HeadingIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, CosineValueLinkHeadingIn, VisitedIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,int HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,bool VisitedIn){
			this.WebPageId = WebPageIdIn;
			this.HeadingId = HeadingIdIn;
			this.LinkAnchorText = LinkAnchorTextIn;
			this.LinkUrl = LinkUrlIn;
			this.ToPageId = ToPageIdIn;
			this.VectorTermLength = VectorTermLengthIn;
			this.CosineValueLinkHeading = CosineValueLinkHeadingIn;
			this.Visited = VisitedIn;
		}
        
		public static LinkWithHeadingTUBSModified Create(string WebPageIdIn,string HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,string VisitedIn, out string SError){
			SError="";
			LinkWithHeadingTUBSModified newLinkWithHeadingTUBSModified = new LinkWithHeadingTUBSModified();
    		try{
				newLinkWithHeadingTUBSModified.UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, CosineValueLinkHeadingIn, bool.Parse(VisitedIn));
				newLinkWithHeadingTUBSModified.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithHeadingTUBSModified;
		}
				

		public string Update(string WebPageIdIn,string HeadingIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string CosineValueLinkHeadingIn,string VisitedIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, CosineValueLinkHeadingIn, bool.Parse(VisitedIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithHeadingTUBSModified)){
                LinkWithHeadingTUBSModified compare=(LinkWithHeadingTUBSModified)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkId;
        }
        
        public string DescriptorValue()
        {
            return this.LinkAnchorText.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkAnchorText";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkAnchorText";
        }
        
        #region ' Foreign Keys for LinkWithHeadingTUBSModified '
        #endregion
        

        int _LinkId;
        [DataMember] 
		public int LinkId
        {
            get { return _LinkId; }
            set
            {
                if(_LinkId!=value){
                    _LinkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkAnchorText;
        [DataMember] 
		public string LinkAnchorText
        {
            get { return _LinkAnchorText; }
            set
            {
                if(_LinkAnchorText!=value){
                    _LinkAnchorText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkAnchorText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkUrl;
        [DataMember] 
		public string LinkUrl
        {
            get { return _LinkUrl; }
            set
            {
                if(_LinkUrl!=value){
                    _LinkUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLength;
        [DataMember] 
		public string VectorTermLength
        {
            get { return _VectorTermLength; }
            set
            {
                if(_VectorTermLength!=value){
                    _VectorTermLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueLinkHeading;
        [DataMember] 
		public string CosineValueLinkHeading
        {
            get { return _CosineValueLinkHeading; }
            set
            {
                if(_CosineValueLinkHeading!=value){
                    _CosineValueLinkHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueLinkHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Visited;
        [DataMember] 
		public bool? Visited
        {
            get { return _Visited; }
            set
            {
                if(_Visited!=value){
                    _Visited=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Visited");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithHeadingTUBSModified, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithoutHeadingTUBSModified table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithoutHeadingTUBSModified: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithoutHeadingTUBSModified> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithoutHeadingTUBSModified>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithoutHeadingTUBSModified> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithoutHeadingTUBSModified item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithoutHeadingTUBSModified item=new LinkWithoutHeadingTUBSModified();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithoutHeadingTUBSModified> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithoutHeadingTUBSModified(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithoutHeadingTUBSModified.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingTUBSModified>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithoutHeadingTUBSModified(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithoutHeadingTUBSModified(Expression<Func<LinkWithoutHeadingTUBSModified, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithoutHeadingTUBSModified> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithoutHeadingTUBSModified> _repo;
            
            if(db.TestMode){
                LinkWithoutHeadingTUBSModified.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingTUBSModified>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithoutHeadingTUBSModified> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithoutHeadingTUBSModified SingleOrDefault(Expression<Func<LinkWithoutHeadingTUBSModified, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithoutHeadingTUBSModified single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithoutHeadingTUBSModified SingleOrDefault(Expression<Func<LinkWithoutHeadingTUBSModified, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithoutHeadingTUBSModified single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithoutHeadingTUBSModified, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithoutHeadingTUBSModified, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithoutHeadingTUBSModified> Find(Expression<Func<LinkWithoutHeadingTUBSModified, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithoutHeadingTUBSModified> Find(Expression<Func<LinkWithoutHeadingTUBSModified, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithoutHeadingTUBSModified> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithoutHeadingTUBSModified> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithoutHeadingTUBSModified> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithoutHeadingTUBSModified> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithoutHeadingTUBSModified> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithoutHeadingTUBSModified> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkId";
        }

        public object KeyValue()
        {
            return this.LinkId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkAnchorText.ToString();
        }

        public static LinkWithoutHeadingTUBSModified RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkId == keyValue);
		}
		
		
		public static LinkWithoutHeadingTUBSModified Create(int WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,bool VisitedIn, out string SError){
			SError="";
 			LinkWithoutHeadingTUBSModified newLinkWithoutHeadingTUBSModified = new LinkWithoutHeadingTUBSModified();
	   		try{
				newLinkWithoutHeadingTUBSModified.UpdateValues(WebPageIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, VisitedIn);
				newLinkWithoutHeadingTUBSModified.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingTUBSModified;
		}

		public string Update(int WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,bool VisitedIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn, VisitedIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn,bool VisitedIn){
			this.WebPageId = WebPageIdIn;
			this.LinkAnchorText = LinkAnchorTextIn;
			this.LinkUrl = LinkUrlIn;
			this.ToPageId = ToPageIdIn;
			this.VectorTermLength = VectorTermLengthIn;
			this.Visited = VisitedIn;
		}
        
		public static LinkWithoutHeadingTUBSModified Create(string WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string VisitedIn, out string SError){
			SError="";
			LinkWithoutHeadingTUBSModified newLinkWithoutHeadingTUBSModified = new LinkWithoutHeadingTUBSModified();
    		try{
				newLinkWithoutHeadingTUBSModified.UpdateValues(int.Parse(WebPageIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, bool.Parse(VisitedIn));
				newLinkWithoutHeadingTUBSModified.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingTUBSModified;
		}
				

		public string Update(string WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn,string VisitedIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn, bool.Parse(VisitedIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithoutHeadingTUBSModified)){
                LinkWithoutHeadingTUBSModified compare=(LinkWithoutHeadingTUBSModified)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkId;
        }
        
        public string DescriptorValue()
        {
            return this.LinkAnchorText.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkAnchorText";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkAnchorText";
        }
        
        #region ' Foreign Keys for LinkWithoutHeadingTUBSModified '
        #endregion
        

        int _LinkId;
        [DataMember] 
		public int LinkId
        {
            get { return _LinkId; }
            set
            {
                if(_LinkId!=value){
                    _LinkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkAnchorText;
        [DataMember] 
		public string LinkAnchorText
        {
            get { return _LinkAnchorText; }
            set
            {
                if(_LinkAnchorText!=value){
                    _LinkAnchorText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkAnchorText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkUrl;
        [DataMember] 
		public string LinkUrl
        {
            get { return _LinkUrl; }
            set
            {
                if(_LinkUrl!=value){
                    _LinkUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLength;
        [DataMember] 
		public string VectorTermLength
        {
            get { return _VectorTermLength; }
            set
            {
                if(_VectorTermLength!=value){
                    _VectorTermLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        bool? _Visited;
        [DataMember] 
		public bool? Visited
        {
            get { return _Visited; }
            set
            {
                if(_Visited!=value){
                    _Visited=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Visited");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithoutHeadingTUBSModified, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CosineLinkLinkWithHeadingTUBS table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class CosineLinkLinkWithHeadingTUB: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CosineLinkLinkWithHeadingTUB> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CosineLinkLinkWithHeadingTUB>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CosineLinkLinkWithHeadingTUB> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CosineLinkLinkWithHeadingTUB item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CosineLinkLinkWithHeadingTUB item=new CosineLinkLinkWithHeadingTUB();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CosineLinkLinkWithHeadingTUB> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public CosineLinkLinkWithHeadingTUB(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CosineLinkLinkWithHeadingTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineLinkLinkWithHeadingTUB>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CosineLinkLinkWithHeadingTUB(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CosineLinkLinkWithHeadingTUB(Expression<Func<CosineLinkLinkWithHeadingTUB, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CosineLinkLinkWithHeadingTUB> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<CosineLinkLinkWithHeadingTUB> _repo;
            
            if(db.TestMode){
                CosineLinkLinkWithHeadingTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineLinkLinkWithHeadingTUB>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CosineLinkLinkWithHeadingTUB> GetRepo(){
            return GetRepo("","");
        }
        
        public static CosineLinkLinkWithHeadingTUB SingleOrDefault(Expression<Func<CosineLinkLinkWithHeadingTUB, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CosineLinkLinkWithHeadingTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CosineLinkLinkWithHeadingTUB SingleOrDefault(Expression<Func<CosineLinkLinkWithHeadingTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CosineLinkLinkWithHeadingTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CosineLinkLinkWithHeadingTUB, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CosineLinkLinkWithHeadingTUB, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CosineLinkLinkWithHeadingTUB> Find(Expression<Func<CosineLinkLinkWithHeadingTUB, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CosineLinkLinkWithHeadingTUB> Find(Expression<Func<CosineLinkLinkWithHeadingTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<CosineLinkLinkWithHeadingTUB> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<CosineLinkLinkWithHeadingTUB> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<CosineLinkLinkWithHeadingTUB> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CosineLinkLinkWithHeadingTUB> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CosineLinkLinkWithHeadingTUB> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CosineLinkLinkWithHeadingTUB> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CosineLinkLinkWithHeadingId";
        }

        public object KeyValue()
        {
            return this.CosineLinkLinkWithHeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CosineValueLinkLinkWithHeading.ToString();
        }

        public static CosineLinkLinkWithHeadingTUB RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.CosineLinkLinkWithHeadingId == keyValue);
		}
		
		
		public static CosineLinkLinkWithHeadingTUB Create(int CosineLinkLinkWithHeadingIdIn,int HeadingIdIn,int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,int WebpageIdIn,string LinkXTextIn,string LinkYTextIn, out string SError){
			SError="";
 			CosineLinkLinkWithHeadingTUB newCosineLinkLinkWithHeadingTUB = new CosineLinkLinkWithHeadingTUB();
	   		try{
				newCosineLinkLinkWithHeadingTUB.UpdateValues(CosineLinkLinkWithHeadingIdIn, HeadingIdIn, LinkXIdIn, LinkYIdIn, CosineValueLinkLinkWithHeadingIn, WebpageIdIn, LinkXTextIn, LinkYTextIn);
				newCosineLinkLinkWithHeadingTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineLinkLinkWithHeadingTUB;
		}

		public string Update(int CosineLinkLinkWithHeadingIdIn,int HeadingIdIn,int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,int WebpageIdIn,string LinkXTextIn,string LinkYTextIn){
     		string SError = "";
			try{
				UpdateValues(CosineLinkLinkWithHeadingIdIn, HeadingIdIn, LinkXIdIn, LinkYIdIn, CosineValueLinkLinkWithHeadingIn, WebpageIdIn, LinkXTextIn, LinkYTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int CosineLinkLinkWithHeadingIdIn,int HeadingIdIn,int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,int WebpageIdIn,string LinkXTextIn,string LinkYTextIn){
			this.CosineLinkLinkWithHeadingId = CosineLinkLinkWithHeadingIdIn;
			this.HeadingId = HeadingIdIn;
			this.LinkXId = LinkXIdIn;
			this.LinkYId = LinkYIdIn;
			this.CosineValueLinkLinkWithHeading = CosineValueLinkLinkWithHeadingIn;
			this.WebpageId = WebpageIdIn;
			this.LinkXText = LinkXTextIn;
			this.LinkYText = LinkYTextIn;
		}
        
		public static CosineLinkLinkWithHeadingTUB Create(string CosineLinkLinkWithHeadingIdIn,string HeadingIdIn,string LinkXIdIn,string LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,string WebpageIdIn,string LinkXTextIn,string LinkYTextIn, out string SError){
			SError="";
			CosineLinkLinkWithHeadingTUB newCosineLinkLinkWithHeadingTUB = new CosineLinkLinkWithHeadingTUB();
    		try{
				newCosineLinkLinkWithHeadingTUB.UpdateValues(int.Parse(CosineLinkLinkWithHeadingIdIn), int.Parse(HeadingIdIn), int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineValueLinkLinkWithHeadingIn, int.Parse(WebpageIdIn), LinkXTextIn, LinkYTextIn);
				newCosineLinkLinkWithHeadingTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineLinkLinkWithHeadingTUB;
		}
				

		public string Update(string CosineLinkLinkWithHeadingIdIn,string HeadingIdIn,string LinkXIdIn,string LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,string WebpageIdIn,string LinkXTextIn,string LinkYTextIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(CosineLinkLinkWithHeadingIdIn), int.Parse(HeadingIdIn), int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineValueLinkLinkWithHeadingIn, int.Parse(WebpageIdIn), LinkXTextIn, LinkYTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(CosineLinkLinkWithHeadingTUB)){
                CosineLinkLinkWithHeadingTUB compare=(CosineLinkLinkWithHeadingTUB)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.CosineLinkLinkWithHeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.CosineValueLinkLinkWithHeading.ToString();
        }

        public string DescriptorColumn() {
           	return "CosineValueLinkLinkWithHeading";
        }
			

        public static string GetKeyColumn()
        {
            return "CosineLinkLinkWithHeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CosineValueLinkLinkWithHeading";
        }
        
        #region ' Foreign Keys for CosineLinkLinkWithHeadingTUB '
        #endregion
        

        int _CosineLinkLinkWithHeadingId;
        [DataMember] 
		public int CosineLinkLinkWithHeadingId
        {
            get { return _CosineLinkLinkWithHeadingId; }
            set
            {
                if(_CosineLinkLinkWithHeadingId!=value){
                    _CosineLinkLinkWithHeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineLinkLinkWithHeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkXId;
        [DataMember] 
		public int LinkXId
        {
            get { return _LinkXId; }
            set
            {
                if(_LinkXId!=value){
                    _LinkXId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkXId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkYId;
        [DataMember] 
		public int LinkYId
        {
            get { return _LinkYId; }
            set
            {
                if(_LinkYId!=value){
                    _LinkYId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkYId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueLinkLinkWithHeading;
        [DataMember] 
		public string CosineValueLinkLinkWithHeading
        {
            get { return _CosineValueLinkLinkWithHeading; }
            set
            {
                if(_CosineValueLinkLinkWithHeading!=value){
                    _CosineValueLinkLinkWithHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueLinkLinkWithHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebpageId;
        [DataMember] 
		public int WebpageId
        {
            get { return _WebpageId; }
            set
            {
                if(_WebpageId!=value){
                    _WebpageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebpageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkXText;
        [DataMember] 
		public string LinkXText
        {
            get { return _LinkXText; }
            set
            {
                if(_LinkXText!=value){
                    _LinkXText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkXText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkYText;
        [DataMember] 
		public string LinkYText
        {
            get { return _LinkYText; }
            set
            {
                if(_LinkYText!=value){
                    _LinkYText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkYText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CosineLinkLinkWithHeadingTUB, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the HeadingvsHeadinginSamePageCosinesTUBS table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class HeadingvsHeadinginSamePageCosinesTUB: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<HeadingvsHeadinginSamePageCosinesTUB> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<HeadingvsHeadinginSamePageCosinesTUB>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<HeadingvsHeadinginSamePageCosinesTUB> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(HeadingvsHeadinginSamePageCosinesTUB item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                HeadingvsHeadinginSamePageCosinesTUB item=new HeadingvsHeadinginSamePageCosinesTUB();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<HeadingvsHeadinginSamePageCosinesTUB> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public HeadingvsHeadinginSamePageCosinesTUB(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                HeadingvsHeadinginSamePageCosinesTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingvsHeadinginSamePageCosinesTUB>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public HeadingvsHeadinginSamePageCosinesTUB(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public HeadingvsHeadinginSamePageCosinesTUB(Expression<Func<HeadingvsHeadinginSamePageCosinesTUB, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<HeadingvsHeadinginSamePageCosinesTUB> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<HeadingvsHeadinginSamePageCosinesTUB> _repo;
            
            if(db.TestMode){
                HeadingvsHeadinginSamePageCosinesTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingvsHeadinginSamePageCosinesTUB>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<HeadingvsHeadinginSamePageCosinesTUB> GetRepo(){
            return GetRepo("","");
        }
        
        public static HeadingvsHeadinginSamePageCosinesTUB SingleOrDefault(Expression<Func<HeadingvsHeadinginSamePageCosinesTUB, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            HeadingvsHeadinginSamePageCosinesTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static HeadingvsHeadinginSamePageCosinesTUB SingleOrDefault(Expression<Func<HeadingvsHeadinginSamePageCosinesTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            HeadingvsHeadinginSamePageCosinesTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<HeadingvsHeadinginSamePageCosinesTUB, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<HeadingvsHeadinginSamePageCosinesTUB, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<HeadingvsHeadinginSamePageCosinesTUB> Find(Expression<Func<HeadingvsHeadinginSamePageCosinesTUB, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<HeadingvsHeadinginSamePageCosinesTUB> Find(Expression<Func<HeadingvsHeadinginSamePageCosinesTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<HeadingvsHeadinginSamePageCosinesTUB> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<HeadingvsHeadinginSamePageCosinesTUB> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<HeadingvsHeadinginSamePageCosinesTUB> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<HeadingvsHeadinginSamePageCosinesTUB> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<HeadingvsHeadinginSamePageCosinesTUB> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<HeadingvsHeadinginSamePageCosinesTUB> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "headingvsheadingId";
        }

        public object KeyValue()
        {
            return this.headingvsheadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CosineValueHeadingvsHeading.ToString();
        }

        public static HeadingvsHeadinginSamePageCosinesTUB RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.headingvsheadingId == keyValue);
		}
		
		
		public static HeadingvsHeadinginSamePageCosinesTUB Create(int headingvsheadingIdIn,int WebpageIdIn,int HeadingXIdIn,int HeadingYIdIn,string CosineValueHeadingvsHeadingIn, out string SError){
			SError="";
 			HeadingvsHeadinginSamePageCosinesTUB newHeadingvsHeadinginSamePageCosinesTUB = new HeadingvsHeadinginSamePageCosinesTUB();
	   		try{
				newHeadingvsHeadinginSamePageCosinesTUB.UpdateValues(headingvsheadingIdIn, WebpageIdIn, HeadingXIdIn, HeadingYIdIn, CosineValueHeadingvsHeadingIn);
				newHeadingvsHeadinginSamePageCosinesTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingvsHeadinginSamePageCosinesTUB;
		}

		public string Update(int headingvsheadingIdIn,int WebpageIdIn,int HeadingXIdIn,int HeadingYIdIn,string CosineValueHeadingvsHeadingIn){
     		string SError = "";
			try{
				UpdateValues(headingvsheadingIdIn, WebpageIdIn, HeadingXIdIn, HeadingYIdIn, CosineValueHeadingvsHeadingIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int headingvsheadingIdIn,int WebpageIdIn,int HeadingXIdIn,int HeadingYIdIn,string CosineValueHeadingvsHeadingIn){
			this.headingvsheadingId = headingvsheadingIdIn;
			this.WebpageId = WebpageIdIn;
			this.HeadingXId = HeadingXIdIn;
			this.HeadingYId = HeadingYIdIn;
			this.CosineValueHeadingvsHeading = CosineValueHeadingvsHeadingIn;
		}
        
		public static HeadingvsHeadinginSamePageCosinesTUB Create(string headingvsheadingIdIn,string WebpageIdIn,string HeadingXIdIn,string HeadingYIdIn,string CosineValueHeadingvsHeadingIn, out string SError){
			SError="";
			HeadingvsHeadinginSamePageCosinesTUB newHeadingvsHeadinginSamePageCosinesTUB = new HeadingvsHeadinginSamePageCosinesTUB();
    		try{
				newHeadingvsHeadinginSamePageCosinesTUB.UpdateValues(int.Parse(headingvsheadingIdIn), int.Parse(WebpageIdIn), int.Parse(HeadingXIdIn), int.Parse(HeadingYIdIn), CosineValueHeadingvsHeadingIn);
				newHeadingvsHeadinginSamePageCosinesTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingvsHeadinginSamePageCosinesTUB;
		}
				

		public string Update(string headingvsheadingIdIn,string WebpageIdIn,string HeadingXIdIn,string HeadingYIdIn,string CosineValueHeadingvsHeadingIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(headingvsheadingIdIn), int.Parse(WebpageIdIn), int.Parse(HeadingXIdIn), int.Parse(HeadingYIdIn), CosineValueHeadingvsHeadingIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(HeadingvsHeadinginSamePageCosinesTUB)){
                HeadingvsHeadinginSamePageCosinesTUB compare=(HeadingvsHeadinginSamePageCosinesTUB)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.headingvsheadingId;
        }
        
        public string DescriptorValue()
        {
            return this.CosineValueHeadingvsHeading.ToString();
        }

        public string DescriptorColumn() {
           	return "CosineValueHeadingvsHeading";
        }
			

        public static string GetKeyColumn()
        {
            return "headingvsheadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CosineValueHeadingvsHeading";
        }
        
        #region ' Foreign Keys for HeadingvsHeadinginSamePageCosinesTUB '
        #endregion
        

        int _headingvsheadingId;
        [DataMember] 
		public int headingvsheadingId
        {
            get { return _headingvsheadingId; }
            set
            {
                if(_headingvsheadingId!=value){
                    _headingvsheadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingvsheadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebpageId;
        [DataMember] 
		public int WebpageId
        {
            get { return _WebpageId; }
            set
            {
                if(_WebpageId!=value){
                    _WebpageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebpageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingXId;
        [DataMember] 
		public int HeadingXId
        {
            get { return _HeadingXId; }
            set
            {
                if(_HeadingXId!=value){
                    _HeadingXId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingXId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingYId;
        [DataMember] 
		public int HeadingYId
        {
            get { return _HeadingYId; }
            set
            {
                if(_HeadingYId!=value){
                    _HeadingYId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingYId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueHeadingvsHeading;
        [DataMember] 
		public string CosineValueHeadingvsHeading
        {
            get { return _CosineValueHeadingvsHeading; }
            set
            {
                if(_CosineValueHeadingvsHeading!=value){
                    _CosineValueHeadingvsHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueHeadingvsHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<HeadingvsHeadinginSamePageCosinesTUB, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the HeadingTUBSTVL table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class HeadingTUBSTVL: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<HeadingTUBSTVL> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<HeadingTUBSTVL>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<HeadingTUBSTVL> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(HeadingTUBSTVL item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                HeadingTUBSTVL item=new HeadingTUBSTVL();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<HeadingTUBSTVL> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public HeadingTUBSTVL(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                HeadingTUBSTVL.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingTUBSTVL>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public HeadingTUBSTVL(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public HeadingTUBSTVL(Expression<Func<HeadingTUBSTVL, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<HeadingTUBSTVL> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<HeadingTUBSTVL> _repo;
            
            if(db.TestMode){
                HeadingTUBSTVL.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingTUBSTVL>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<HeadingTUBSTVL> GetRepo(){
            return GetRepo("","");
        }
        
        public static HeadingTUBSTVL SingleOrDefault(Expression<Func<HeadingTUBSTVL, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            HeadingTUBSTVL single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static HeadingTUBSTVL SingleOrDefault(Expression<Func<HeadingTUBSTVL, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            HeadingTUBSTVL single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<HeadingTUBSTVL, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<HeadingTUBSTVL, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<HeadingTUBSTVL> Find(Expression<Func<HeadingTUBSTVL, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<HeadingTUBSTVL> Find(Expression<Func<HeadingTUBSTVL, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<HeadingTUBSTVL> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<HeadingTUBSTVL> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<HeadingTUBSTVL> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<HeadingTUBSTVL> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<HeadingTUBSTVL> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<HeadingTUBSTVL> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "HeadingId";
        }

        public object KeyValue()
        {
            return this.HeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.HeadingText.ToString();
        }

        public static HeadingTUBSTVL RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.HeadingId == keyValue);
		}
		
		
		public static HeadingTUBSTVL Create(int HeadingIdIn,int WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn, out string SError){
			SError="";
 			HeadingTUBSTVL newHeadingTUBSTVL = new HeadingTUBSTVL();
	   		try{
				newHeadingTUBSTVL.UpdateValues(HeadingIdIn, WebPageIdIn, HeadingTextIn, VectorTermLengthIn);
				newHeadingTUBSTVL.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingTUBSTVL;
		}

		public string Update(int HeadingIdIn,int WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn){
     		string SError = "";
			try{
				UpdateValues(HeadingIdIn, WebPageIdIn, HeadingTextIn, VectorTermLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int HeadingIdIn,int WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn){
			this.HeadingId = HeadingIdIn;
			this.WebPageId = WebPageIdIn;
			this.HeadingText = HeadingTextIn;
			this.VectorTermLength = VectorTermLengthIn;
		}
        
		public static HeadingTUBSTVL Create(string HeadingIdIn,string WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn, out string SError){
			SError="";
			HeadingTUBSTVL newHeadingTUBSTVL = new HeadingTUBSTVL();
    		try{
				newHeadingTUBSTVL.UpdateValues(int.Parse(HeadingIdIn), int.Parse(WebPageIdIn), HeadingTextIn, VectorTermLengthIn);
				newHeadingTUBSTVL.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingTUBSTVL;
		}
				

		public string Update(string HeadingIdIn,string WebPageIdIn,string HeadingTextIn,string VectorTermLengthIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(HeadingIdIn), int.Parse(WebPageIdIn), HeadingTextIn, VectorTermLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(HeadingTUBSTVL)){
                HeadingTUBSTVL compare=(HeadingTUBSTVL)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.HeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.HeadingText.ToString();
        }

        public string DescriptorColumn() {
           	return "HeadingText";
        }
			

        public static string GetKeyColumn()
        {
            return "HeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "HeadingText";
        }
        
        #region ' Foreign Keys for HeadingTUBSTVL '
        #endregion
        

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _HeadingText;
        [DataMember] 
		public string HeadingText
        {
            get { return _HeadingText; }
            set
            {
                if(_HeadingText!=value){
                    _HeadingText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLength;
        [DataMember] 
		public string VectorTermLength
        {
            get { return _VectorTermLength; }
            set
            {
                if(_VectorTermLength!=value){
                    _VectorTermLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<HeadingTUBSTVL, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the HeadingvsHeadinginSamePageCosines table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class HeadingvsHeadinginSamePageCosine: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<HeadingvsHeadinginSamePageCosine> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<HeadingvsHeadinginSamePageCosine>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<HeadingvsHeadinginSamePageCosine> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(HeadingvsHeadinginSamePageCosine item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                HeadingvsHeadinginSamePageCosine item=new HeadingvsHeadinginSamePageCosine();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<HeadingvsHeadinginSamePageCosine> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public HeadingvsHeadinginSamePageCosine(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                HeadingvsHeadinginSamePageCosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingvsHeadinginSamePageCosine>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public HeadingvsHeadinginSamePageCosine(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public HeadingvsHeadinginSamePageCosine(Expression<Func<HeadingvsHeadinginSamePageCosine, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<HeadingvsHeadinginSamePageCosine> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<HeadingvsHeadinginSamePageCosine> _repo;
            
            if(db.TestMode){
                HeadingvsHeadinginSamePageCosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingvsHeadinginSamePageCosine>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<HeadingvsHeadinginSamePageCosine> GetRepo(){
            return GetRepo("","");
        }
        
        public static HeadingvsHeadinginSamePageCosine SingleOrDefault(Expression<Func<HeadingvsHeadinginSamePageCosine, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            HeadingvsHeadinginSamePageCosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static HeadingvsHeadinginSamePageCosine SingleOrDefault(Expression<Func<HeadingvsHeadinginSamePageCosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            HeadingvsHeadinginSamePageCosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<HeadingvsHeadinginSamePageCosine, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<HeadingvsHeadinginSamePageCosine, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<HeadingvsHeadinginSamePageCosine> Find(Expression<Func<HeadingvsHeadinginSamePageCosine, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<HeadingvsHeadinginSamePageCosine> Find(Expression<Func<HeadingvsHeadinginSamePageCosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<HeadingvsHeadinginSamePageCosine> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<HeadingvsHeadinginSamePageCosine> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<HeadingvsHeadinginSamePageCosine> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<HeadingvsHeadinginSamePageCosine> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<HeadingvsHeadinginSamePageCosine> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<HeadingvsHeadinginSamePageCosine> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "headingvsheadingId";
        }

        public object KeyValue()
        {
            return this.headingvsheadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CosineValueHeadingvsHeading.ToString();
        }

        public static HeadingvsHeadinginSamePageCosine RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.headingvsheadingId == keyValue);
		}
		
		
		public static HeadingvsHeadinginSamePageCosine Create(int WebpageIdIn,int HeadingXIdIn,int HeadingYIdIn,string CosineValueHeadingvsHeadingIn,string HeadingXLinkTextIn,string HeadingYLInkTextIn, out string SError){
			SError="";
 			HeadingvsHeadinginSamePageCosine newHeadingvsHeadinginSamePageCosine = new HeadingvsHeadinginSamePageCosine();
	   		try{
				newHeadingvsHeadinginSamePageCosine.UpdateValues(WebpageIdIn, HeadingXIdIn, HeadingYIdIn, CosineValueHeadingvsHeadingIn, HeadingXLinkTextIn, HeadingYLInkTextIn);
				newHeadingvsHeadinginSamePageCosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingvsHeadinginSamePageCosine;
		}

		public string Update(int WebpageIdIn,int HeadingXIdIn,int HeadingYIdIn,string CosineValueHeadingvsHeadingIn,string HeadingXLinkTextIn,string HeadingYLInkTextIn){
     		string SError = "";
			try{
				UpdateValues(WebpageIdIn, HeadingXIdIn, HeadingYIdIn, CosineValueHeadingvsHeadingIn, HeadingXLinkTextIn, HeadingYLInkTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebpageIdIn,int HeadingXIdIn,int HeadingYIdIn,string CosineValueHeadingvsHeadingIn,string HeadingXLinkTextIn,string HeadingYLInkTextIn){
			this.WebpageId = WebpageIdIn;
			this.HeadingXId = HeadingXIdIn;
			this.HeadingYId = HeadingYIdIn;
			this.CosineValueHeadingvsHeading = CosineValueHeadingvsHeadingIn;
			this.HeadingXLinkText = HeadingXLinkTextIn;
			this.HeadingYLInkText = HeadingYLInkTextIn;
		}
        
		public static HeadingvsHeadinginSamePageCosine Create(string WebpageIdIn,string HeadingXIdIn,string HeadingYIdIn,string CosineValueHeadingvsHeadingIn,string HeadingXLinkTextIn,string HeadingYLInkTextIn, out string SError){
			SError="";
			HeadingvsHeadinginSamePageCosine newHeadingvsHeadinginSamePageCosine = new HeadingvsHeadinginSamePageCosine();
    		try{
				newHeadingvsHeadinginSamePageCosine.UpdateValues(int.Parse(WebpageIdIn), int.Parse(HeadingXIdIn), int.Parse(HeadingYIdIn), CosineValueHeadingvsHeadingIn, HeadingXLinkTextIn, HeadingYLInkTextIn);
				newHeadingvsHeadinginSamePageCosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingvsHeadinginSamePageCosine;
		}
				

		public string Update(string WebpageIdIn,string HeadingXIdIn,string HeadingYIdIn,string CosineValueHeadingvsHeadingIn,string HeadingXLinkTextIn,string HeadingYLInkTextIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebpageIdIn), int.Parse(HeadingXIdIn), int.Parse(HeadingYIdIn), CosineValueHeadingvsHeadingIn, HeadingXLinkTextIn, HeadingYLInkTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(HeadingvsHeadinginSamePageCosine)){
                HeadingvsHeadinginSamePageCosine compare=(HeadingvsHeadinginSamePageCosine)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.headingvsheadingId;
        }
        
        public string DescriptorValue()
        {
            return this.CosineValueHeadingvsHeading.ToString();
        }

        public string DescriptorColumn() {
           	return "CosineValueHeadingvsHeading";
        }
			

        public static string GetKeyColumn()
        {
            return "headingvsheadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CosineValueHeadingvsHeading";
        }
        
        #region ' Foreign Keys for HeadingvsHeadinginSamePageCosine '
        #endregion
        

        int _headingvsheadingId;
        [DataMember] 
		public int headingvsheadingId
        {
            get { return _headingvsheadingId; }
            set
            {
                if(_headingvsheadingId!=value){
                    _headingvsheadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingvsheadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebpageId;
        [DataMember] 
		public int WebpageId
        {
            get { return _WebpageId; }
            set
            {
                if(_WebpageId!=value){
                    _WebpageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebpageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingXId;
        [DataMember] 
		public int HeadingXId
        {
            get { return _HeadingXId; }
            set
            {
                if(_HeadingXId!=value){
                    _HeadingXId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingXId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingYId;
        [DataMember] 
		public int HeadingYId
        {
            get { return _HeadingYId; }
            set
            {
                if(_HeadingYId!=value){
                    _HeadingYId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingYId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueHeadingvsHeading;
        [DataMember] 
		public string CosineValueHeadingvsHeading
        {
            get { return _CosineValueHeadingvsHeading; }
            set
            {
                if(_CosineValueHeadingvsHeading!=value){
                    _CosineValueHeadingvsHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueHeadingvsHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _HeadingXLinkText;
        [DataMember] 
		public string HeadingXLinkText
        {
            get { return _HeadingXLinkText; }
            set
            {
                if(_HeadingXLinkText!=value){
                    _HeadingXLinkText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingXLinkText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _HeadingYLInkText;
        [DataMember] 
		public string HeadingYLInkText
        {
            get { return _HeadingYLInkText; }
            set
            {
                if(_HeadingYLInkText!=value){
                    _HeadingYLInkText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingYLInkText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<HeadingvsHeadinginSamePageCosine, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CosineLinkLinkWithoutHeadingTUBS table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class CosineLinkLinkWithoutHeadingTUB: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CosineLinkLinkWithoutHeadingTUB> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CosineLinkLinkWithoutHeadingTUB>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CosineLinkLinkWithoutHeadingTUB> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CosineLinkLinkWithoutHeadingTUB item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CosineLinkLinkWithoutHeadingTUB item=new CosineLinkLinkWithoutHeadingTUB();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CosineLinkLinkWithoutHeadingTUB> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public CosineLinkLinkWithoutHeadingTUB(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CosineLinkLinkWithoutHeadingTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineLinkLinkWithoutHeadingTUB>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CosineLinkLinkWithoutHeadingTUB(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CosineLinkLinkWithoutHeadingTUB(Expression<Func<CosineLinkLinkWithoutHeadingTUB, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CosineLinkLinkWithoutHeadingTUB> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<CosineLinkLinkWithoutHeadingTUB> _repo;
            
            if(db.TestMode){
                CosineLinkLinkWithoutHeadingTUB.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineLinkLinkWithoutHeadingTUB>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CosineLinkLinkWithoutHeadingTUB> GetRepo(){
            return GetRepo("","");
        }
        
        public static CosineLinkLinkWithoutHeadingTUB SingleOrDefault(Expression<Func<CosineLinkLinkWithoutHeadingTUB, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CosineLinkLinkWithoutHeadingTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CosineLinkLinkWithoutHeadingTUB SingleOrDefault(Expression<Func<CosineLinkLinkWithoutHeadingTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CosineLinkLinkWithoutHeadingTUB single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CosineLinkLinkWithoutHeadingTUB, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CosineLinkLinkWithoutHeadingTUB, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CosineLinkLinkWithoutHeadingTUB> Find(Expression<Func<CosineLinkLinkWithoutHeadingTUB, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CosineLinkLinkWithoutHeadingTUB> Find(Expression<Func<CosineLinkLinkWithoutHeadingTUB, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<CosineLinkLinkWithoutHeadingTUB> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<CosineLinkLinkWithoutHeadingTUB> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<CosineLinkLinkWithoutHeadingTUB> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CosineLinkLinkWithoutHeadingTUB> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CosineLinkLinkWithoutHeadingTUB> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CosineLinkLinkWithoutHeadingTUB> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CosineLinkLinkWithoutHeadingId";
        }

        public object KeyValue()
        {
            return this.CosineLinkLinkWithoutHeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CosineValueLinkLinkWithoutHeading.ToString();
        }

        public static CosineLinkLinkWithoutHeadingTUB RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.CosineLinkLinkWithoutHeadingId == keyValue);
		}
		
		
		public static CosineLinkLinkWithoutHeadingTUB Create(int CosineLinkLinkWithoutHeadingIdIn,int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,int WebPageIdIn, out string SError){
			SError="";
 			CosineLinkLinkWithoutHeadingTUB newCosineLinkLinkWithoutHeadingTUB = new CosineLinkLinkWithoutHeadingTUB();
	   		try{
				newCosineLinkLinkWithoutHeadingTUB.UpdateValues(CosineLinkLinkWithoutHeadingIdIn, LinkXIdIn, LinkYIdIn, CosineValueLinkLinkWithoutHeadingIn, WebPageIdIn);
				newCosineLinkLinkWithoutHeadingTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineLinkLinkWithoutHeadingTUB;
		}

		public string Update(int CosineLinkLinkWithoutHeadingIdIn,int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,int WebPageIdIn){
     		string SError = "";
			try{
				UpdateValues(CosineLinkLinkWithoutHeadingIdIn, LinkXIdIn, LinkYIdIn, CosineValueLinkLinkWithoutHeadingIn, WebPageIdIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int CosineLinkLinkWithoutHeadingIdIn,int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,int WebPageIdIn){
			this.CosineLinkLinkWithoutHeadingId = CosineLinkLinkWithoutHeadingIdIn;
			this.LinkXId = LinkXIdIn;
			this.LinkYId = LinkYIdIn;
			this.CosineValueLinkLinkWithoutHeading = CosineValueLinkLinkWithoutHeadingIn;
			this.WebPageId = WebPageIdIn;
		}
        
		public static CosineLinkLinkWithoutHeadingTUB Create(string CosineLinkLinkWithoutHeadingIdIn,string LinkXIdIn,string LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,string WebPageIdIn, out string SError){
			SError="";
			CosineLinkLinkWithoutHeadingTUB newCosineLinkLinkWithoutHeadingTUB = new CosineLinkLinkWithoutHeadingTUB();
    		try{
				newCosineLinkLinkWithoutHeadingTUB.UpdateValues(int.Parse(CosineLinkLinkWithoutHeadingIdIn), int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineValueLinkLinkWithoutHeadingIn, int.Parse(WebPageIdIn));
				newCosineLinkLinkWithoutHeadingTUB.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineLinkLinkWithoutHeadingTUB;
		}
				

		public string Update(string CosineLinkLinkWithoutHeadingIdIn,string LinkXIdIn,string LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,string WebPageIdIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(CosineLinkLinkWithoutHeadingIdIn), int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineValueLinkLinkWithoutHeadingIn, int.Parse(WebPageIdIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(CosineLinkLinkWithoutHeadingTUB)){
                CosineLinkLinkWithoutHeadingTUB compare=(CosineLinkLinkWithoutHeadingTUB)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.CosineLinkLinkWithoutHeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.CosineValueLinkLinkWithoutHeading.ToString();
        }

        public string DescriptorColumn() {
           	return "CosineValueLinkLinkWithoutHeading";
        }
			

        public static string GetKeyColumn()
        {
            return "CosineLinkLinkWithoutHeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CosineValueLinkLinkWithoutHeading";
        }
        
        #region ' Foreign Keys for CosineLinkLinkWithoutHeadingTUB '
        #endregion
        

        int _CosineLinkLinkWithoutHeadingId;
        [DataMember] 
		public int CosineLinkLinkWithoutHeadingId
        {
            get { return _CosineLinkLinkWithoutHeadingId; }
            set
            {
                if(_CosineLinkLinkWithoutHeadingId!=value){
                    _CosineLinkLinkWithoutHeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineLinkLinkWithoutHeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkXId;
        [DataMember] 
		public int LinkXId
        {
            get { return _LinkXId; }
            set
            {
                if(_LinkXId!=value){
                    _LinkXId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkXId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkYId;
        [DataMember] 
		public int LinkYId
        {
            get { return _LinkYId; }
            set
            {
                if(_LinkYId!=value){
                    _LinkYId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkYId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueLinkLinkWithoutHeading;
        [DataMember] 
		public string CosineValueLinkLinkWithoutHeading
        {
            get { return _CosineValueLinkLinkWithoutHeading; }
            set
            {
                if(_CosineValueLinkLinkWithoutHeading!=value){
                    _CosineValueLinkLinkWithoutHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueLinkLinkWithoutHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CosineLinkLinkWithoutHeadingTUB, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Paragraph_Cosine table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class Paragraph_Cosine: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Paragraph_Cosine> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Paragraph_Cosine>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Paragraph_Cosine> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Paragraph_Cosine item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Paragraph_Cosine item=new Paragraph_Cosine();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Paragraph_Cosine> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public Paragraph_Cosine(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Paragraph_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Paragraph_Cosine>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Paragraph_Cosine(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Paragraph_Cosine(Expression<Func<Paragraph_Cosine, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Paragraph_Cosine> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<Paragraph_Cosine> _repo;
            
            if(db.TestMode){
                Paragraph_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Paragraph_Cosine>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Paragraph_Cosine> GetRepo(){
            return GetRepo("","");
        }
        
        public static Paragraph_Cosine SingleOrDefault(Expression<Func<Paragraph_Cosine, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Paragraph_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Paragraph_Cosine SingleOrDefault(Expression<Func<Paragraph_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Paragraph_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Paragraph_Cosine, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Paragraph_Cosine, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Paragraph_Cosine> Find(Expression<Func<Paragraph_Cosine, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Paragraph_Cosine> Find(Expression<Func<Paragraph_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<Paragraph_Cosine> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<Paragraph_Cosine> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<Paragraph_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Paragraph_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Paragraph_Cosine> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Paragraph_Cosine> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ParagraphCosineId";
        }

        public object KeyValue()
        {
            return this.ParagraphCosineId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.ParaText.ToString();
        }

        public static Paragraph_Cosine RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.ParagraphCosineId == keyValue);
		}
		
		
		public static Paragraph_Cosine Create(int WebPageIdIn,int ParaIdIn,int HeadingIdIn,string ParaTextIn,string CosineParaAgainstGoalIn, out string SError){
			SError="";
 			Paragraph_Cosine newParagraph_Cosine = new Paragraph_Cosine();
	   		try{
				newParagraph_Cosine.UpdateValues(WebPageIdIn, ParaIdIn, HeadingIdIn, ParaTextIn, CosineParaAgainstGoalIn);
				newParagraph_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newParagraph_Cosine;
		}

		public string Update(int WebPageIdIn,int ParaIdIn,int HeadingIdIn,string ParaTextIn,string CosineParaAgainstGoalIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, ParaIdIn, HeadingIdIn, ParaTextIn, CosineParaAgainstGoalIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,int ParaIdIn,int HeadingIdIn,string ParaTextIn,string CosineParaAgainstGoalIn){
			this.WebPageId = WebPageIdIn;
			this.ParaId = ParaIdIn;
			this.HeadingId = HeadingIdIn;
			this.ParaText = ParaTextIn;
			this.CosineParaAgainstGoal = CosineParaAgainstGoalIn;
		}
        
		public static Paragraph_Cosine Create(string WebPageIdIn,string ParaIdIn,string HeadingIdIn,string ParaTextIn,string CosineParaAgainstGoalIn, out string SError){
			SError="";
			Paragraph_Cosine newParagraph_Cosine = new Paragraph_Cosine();
    		try{
				newParagraph_Cosine.UpdateValues(int.Parse(WebPageIdIn), int.Parse(ParaIdIn), int.Parse(HeadingIdIn), ParaTextIn, CosineParaAgainstGoalIn);
				newParagraph_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newParagraph_Cosine;
		}
				

		public string Update(string WebPageIdIn,string ParaIdIn,string HeadingIdIn,string ParaTextIn,string CosineParaAgainstGoalIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), int.Parse(ParaIdIn), int.Parse(HeadingIdIn), ParaTextIn, CosineParaAgainstGoalIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(Paragraph_Cosine)){
                Paragraph_Cosine compare=(Paragraph_Cosine)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ParagraphCosineId;
        }
        
        public string DescriptorValue()
        {
            return this.ParaText.ToString();
        }

        public string DescriptorColumn() {
           	return "ParaText";
        }
			

        public static string GetKeyColumn()
        {
            return "ParagraphCosineId";
        }        
        public static string GetDescriptorColumn()
        {
            return "ParaText";
        }
        
        #region ' Foreign Keys for Paragraph_Cosine '
        #endregion
        

        int _ParagraphCosineId;
        [DataMember] 
		public int ParagraphCosineId
        {
            get { return _ParagraphCosineId; }
            set
            {
                if(_ParagraphCosineId!=value){
                    _ParagraphCosineId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ParagraphCosineId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ParaId;
        [DataMember] 
		public int ParaId
        {
            get { return _ParaId; }
            set
            {
                if(_ParaId!=value){
                    _ParaId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ParaId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ParaText;
        [DataMember] 
		public string ParaText
        {
            get { return _ParaText; }
            set
            {
                if(_ParaText!=value){
                    _ParaText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ParaText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineParaAgainstGoal;
        [DataMember] 
		public string CosineParaAgainstGoal
        {
            get { return _CosineParaAgainstGoal; }
            set
            {
                if(_CosineParaAgainstGoal!=value){
                    _CosineParaAgainstGoal=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineParaAgainstGoal");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Paragraph_Cosine, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the HeadingPathAdequacy_Cosine table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class HeadingPathAdequacy_Cosine: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<HeadingPathAdequacy_Cosine> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<HeadingPathAdequacy_Cosine>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<HeadingPathAdequacy_Cosine> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(HeadingPathAdequacy_Cosine item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                HeadingPathAdequacy_Cosine item=new HeadingPathAdequacy_Cosine();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<HeadingPathAdequacy_Cosine> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public HeadingPathAdequacy_Cosine(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                HeadingPathAdequacy_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingPathAdequacy_Cosine>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public HeadingPathAdequacy_Cosine(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public HeadingPathAdequacy_Cosine(Expression<Func<HeadingPathAdequacy_Cosine, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<HeadingPathAdequacy_Cosine> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<HeadingPathAdequacy_Cosine> _repo;
            
            if(db.TestMode){
                HeadingPathAdequacy_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<HeadingPathAdequacy_Cosine>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<HeadingPathAdequacy_Cosine> GetRepo(){
            return GetRepo("","");
        }
        
        public static HeadingPathAdequacy_Cosine SingleOrDefault(Expression<Func<HeadingPathAdequacy_Cosine, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            HeadingPathAdequacy_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static HeadingPathAdequacy_Cosine SingleOrDefault(Expression<Func<HeadingPathAdequacy_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            HeadingPathAdequacy_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<HeadingPathAdequacy_Cosine, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<HeadingPathAdequacy_Cosine, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<HeadingPathAdequacy_Cosine> Find(Expression<Func<HeadingPathAdequacy_Cosine, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<HeadingPathAdequacy_Cosine> Find(Expression<Func<HeadingPathAdequacy_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<HeadingPathAdequacy_Cosine> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<HeadingPathAdequacy_Cosine> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<HeadingPathAdequacy_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<HeadingPathAdequacy_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<HeadingPathAdequacy_Cosine> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<HeadingPathAdequacy_Cosine> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "headingPathAdequacyCosineID";
        }

        public object KeyValue()
        {
            return this.headingPathAdequacyCosineID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.pAString.ToString();
        }

        public static HeadingPathAdequacy_Cosine RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.headingPathAdequacyCosineID == keyValue);
		}
		
		
		public static HeadingPathAdequacy_Cosine Create(string pAStringIn,int pageIdIn,int headingIdIn,string CosineIn, out string SError){
			SError="";
 			HeadingPathAdequacy_Cosine newHeadingPathAdequacy_Cosine = new HeadingPathAdequacy_Cosine();
	   		try{
				newHeadingPathAdequacy_Cosine.UpdateValues(pAStringIn, pageIdIn, headingIdIn, CosineIn);
				newHeadingPathAdequacy_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingPathAdequacy_Cosine;
		}

		public string Update(string pAStringIn,int pageIdIn,int headingIdIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(pAStringIn, pageIdIn, headingIdIn, CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(string pAStringIn,int pageIdIn,int headingIdIn,string CosineIn){
			this.pAString = pAStringIn;
			this.pageId = pageIdIn;
			this.headingId = headingIdIn;
			this.Cosine = CosineIn;
		}
        
		public static HeadingPathAdequacy_Cosine Create(string pAStringIn,string pageIdIn,string headingIdIn,string CosineIn, out string SError){
			SError="";
			HeadingPathAdequacy_Cosine newHeadingPathAdequacy_Cosine = new HeadingPathAdequacy_Cosine();
    		try{
				newHeadingPathAdequacy_Cosine.UpdateValues(pAStringIn, int.Parse(pageIdIn), int.Parse(headingIdIn), CosineIn);
				newHeadingPathAdequacy_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeadingPathAdequacy_Cosine;
		}
				

		public string Update(string pAStringIn,string pageIdIn,string headingIdIn,string CosineIn){
     		string SError = "";
			try{
				UpdateValues(pAStringIn, int.Parse(pageIdIn), int.Parse(headingIdIn), CosineIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(HeadingPathAdequacy_Cosine)){
                HeadingPathAdequacy_Cosine compare=(HeadingPathAdequacy_Cosine)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.headingPathAdequacyCosineID;
        }
        
        public string DescriptorValue()
        {
            return this.pAString.ToString();
        }

        public string DescriptorColumn() {
           	return "pAString";
        }
			

        public static string GetKeyColumn()
        {
            return "headingPathAdequacyCosineID";
        }        
        public static string GetDescriptorColumn()
        {
            return "pAString";
        }
        
        #region ' Foreign Keys for HeadingPathAdequacy_Cosine '
        #endregion
        

        int _headingPathAdequacyCosineID;
        [DataMember] 
		public int headingPathAdequacyCosineID
        {
            get { return _headingPathAdequacyCosineID; }
            set
            {
                if(_headingPathAdequacyCosineID!=value){
                    _headingPathAdequacyCosineID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingPathAdequacyCosineID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _pAString;
        [DataMember] 
		public string pAString
        {
            get { return _pAString; }
            set
            {
                if(_pAString!=value){
                    _pAString=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pAString");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _pageId;
        [DataMember] 
		public int pageId
        {
            get { return _pageId; }
            set
            {
                if(_pageId!=value){
                    _pageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _headingId;
        [DataMember] 
		public int headingId
        {
            get { return _headingId; }
            set
            {
                if(_headingId!=value){
                    _headingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Cosine;
        [DataMember] 
		public string Cosine
        {
            get { return _Cosine; }
            set
            {
                if(_Cosine!=value){
                    _Cosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Cosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<HeadingPathAdequacy_Cosine, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkLinkTemplateOfLinks table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkLinkTemplateOfLink: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkLinkTemplateOfLink> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkLinkTemplateOfLink>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkLinkTemplateOfLink> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkLinkTemplateOfLink item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkLinkTemplateOfLink item=new LinkLinkTemplateOfLink();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkLinkTemplateOfLink> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkLinkTemplateOfLink(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkLinkTemplateOfLink.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkLinkTemplateOfLink>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkLinkTemplateOfLink(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkLinkTemplateOfLink(Expression<Func<LinkLinkTemplateOfLink, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkLinkTemplateOfLink> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkLinkTemplateOfLink> _repo;
            
            if(db.TestMode){
                LinkLinkTemplateOfLink.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkLinkTemplateOfLink>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkLinkTemplateOfLink> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkLinkTemplateOfLink SingleOrDefault(Expression<Func<LinkLinkTemplateOfLink, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkLinkTemplateOfLink single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkLinkTemplateOfLink SingleOrDefault(Expression<Func<LinkLinkTemplateOfLink, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkLinkTemplateOfLink single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkLinkTemplateOfLink, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkLinkTemplateOfLink, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkLinkTemplateOfLink> Find(Expression<Func<LinkLinkTemplateOfLink, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkLinkTemplateOfLink> Find(Expression<Func<LinkLinkTemplateOfLink, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkLinkTemplateOfLink> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkLinkTemplateOfLink> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkLinkTemplateOfLink> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkLinkTemplateOfLink> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkLinkTemplateOfLink> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkLinkTemplateOfLink> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkLinkTemplateOfLinksId";
        }

        public object KeyValue()
        {
            return this.LinkLinkTemplateOfLinksId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CosineLinkLinkTemplateOfLinks.ToString();
        }

        public static LinkLinkTemplateOfLink RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkLinkTemplateOfLinksId == keyValue);
		}
		
		
		public static LinkLinkTemplateOfLink Create(int LinkXIdIn,int LinkYIdIn,string CosineLinkLinkTemplateOfLinksIn,int WebPageIdIn, out string SError){
			SError="";
 			LinkLinkTemplateOfLink newLinkLinkTemplateOfLink = new LinkLinkTemplateOfLink();
	   		try{
				newLinkLinkTemplateOfLink.UpdateValues(LinkXIdIn, LinkYIdIn, CosineLinkLinkTemplateOfLinksIn, WebPageIdIn);
				newLinkLinkTemplateOfLink.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkLinkTemplateOfLink;
		}

		public string Update(int LinkXIdIn,int LinkYIdIn,string CosineLinkLinkTemplateOfLinksIn,int WebPageIdIn){
     		string SError = "";
			try{
				UpdateValues(LinkXIdIn, LinkYIdIn, CosineLinkLinkTemplateOfLinksIn, WebPageIdIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int LinkXIdIn,int LinkYIdIn,string CosineLinkLinkTemplateOfLinksIn,int WebPageIdIn){
			this.LinkXId = LinkXIdIn;
			this.LinkYId = LinkYIdIn;
			this.CosineLinkLinkTemplateOfLinks = CosineLinkLinkTemplateOfLinksIn;
			this.WebPageId = WebPageIdIn;
		}
        
		public static LinkLinkTemplateOfLink Create(string LinkXIdIn,string LinkYIdIn,string CosineLinkLinkTemplateOfLinksIn,string WebPageIdIn, out string SError){
			SError="";
			LinkLinkTemplateOfLink newLinkLinkTemplateOfLink = new LinkLinkTemplateOfLink();
    		try{
				newLinkLinkTemplateOfLink.UpdateValues(int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineLinkLinkTemplateOfLinksIn, int.Parse(WebPageIdIn));
				newLinkLinkTemplateOfLink.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkLinkTemplateOfLink;
		}
				

		public string Update(string LinkXIdIn,string LinkYIdIn,string CosineLinkLinkTemplateOfLinksIn,string WebPageIdIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineLinkLinkTemplateOfLinksIn, int.Parse(WebPageIdIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkLinkTemplateOfLink)){
                LinkLinkTemplateOfLink compare=(LinkLinkTemplateOfLink)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkLinkTemplateOfLinksId;
        }
        
        public string DescriptorValue()
        {
            return this.CosineLinkLinkTemplateOfLinks.ToString();
        }

        public string DescriptorColumn() {
           	return "CosineLinkLinkTemplateOfLinks";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkLinkTemplateOfLinksId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CosineLinkLinkTemplateOfLinks";
        }
        
        #region ' Foreign Keys for LinkLinkTemplateOfLink '
        #endregion
        

        int _LinkLinkTemplateOfLinksId;
        [DataMember] 
		public int LinkLinkTemplateOfLinksId
        {
            get { return _LinkLinkTemplateOfLinksId; }
            set
            {
                if(_LinkLinkTemplateOfLinksId!=value){
                    _LinkLinkTemplateOfLinksId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkLinkTemplateOfLinksId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkXId;
        [DataMember] 
		public int LinkXId
        {
            get { return _LinkXId; }
            set
            {
                if(_LinkXId!=value){
                    _LinkXId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkXId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkYId;
        [DataMember] 
		public int LinkYId
        {
            get { return _LinkYId; }
            set
            {
                if(_LinkYId!=value){
                    _LinkYId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkYId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineLinkLinkTemplateOfLinks;
        [DataMember] 
		public string CosineLinkLinkTemplateOfLinks
        {
            get { return _CosineLinkLinkTemplateOfLinks; }
            set
            {
                if(_CosineLinkLinkTemplateOfLinks!=value){
                    _CosineLinkLinkTemplateOfLinks=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineLinkLinkTemplateOfLinks");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkLinkTemplateOfLink, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithoutHeadingTemplateOfLinks table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithoutHeadingTemplateOfLink: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithoutHeadingTemplateOfLink> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithoutHeadingTemplateOfLink>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithoutHeadingTemplateOfLink> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithoutHeadingTemplateOfLink item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithoutHeadingTemplateOfLink item=new LinkWithoutHeadingTemplateOfLink();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithoutHeadingTemplateOfLink> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithoutHeadingTemplateOfLink(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithoutHeadingTemplateOfLink.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingTemplateOfLink>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithoutHeadingTemplateOfLink(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithoutHeadingTemplateOfLink(Expression<Func<LinkWithoutHeadingTemplateOfLink, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithoutHeadingTemplateOfLink> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithoutHeadingTemplateOfLink> _repo;
            
            if(db.TestMode){
                LinkWithoutHeadingTemplateOfLink.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeadingTemplateOfLink>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithoutHeadingTemplateOfLink> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithoutHeadingTemplateOfLink SingleOrDefault(Expression<Func<LinkWithoutHeadingTemplateOfLink, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithoutHeadingTemplateOfLink single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithoutHeadingTemplateOfLink SingleOrDefault(Expression<Func<LinkWithoutHeadingTemplateOfLink, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithoutHeadingTemplateOfLink single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithoutHeadingTemplateOfLink, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithoutHeadingTemplateOfLink, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithoutHeadingTemplateOfLink> Find(Expression<Func<LinkWithoutHeadingTemplateOfLink, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithoutHeadingTemplateOfLink> Find(Expression<Func<LinkWithoutHeadingTemplateOfLink, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithoutHeadingTemplateOfLink> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithoutHeadingTemplateOfLink> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithoutHeadingTemplateOfLink> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithoutHeadingTemplateOfLink> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithoutHeadingTemplateOfLink> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithoutHeadingTemplateOfLink> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkWithoutHeadingTemplateOfLinksId";
        }

        public object KeyValue()
        {
            return this.LinkWithoutHeadingTemplateOfLinksId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.AllLinksOfTemplate.ToString();
        }

        public static LinkWithoutHeadingTemplateOfLink RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkWithoutHeadingTemplateOfLinksId == keyValue);
		}
		
		
		public static LinkWithoutHeadingTemplateOfLink Create(int WebPageIdIn,string AllLinksOfTemplateIn, out string SError){
			SError="";
 			LinkWithoutHeadingTemplateOfLink newLinkWithoutHeadingTemplateOfLink = new LinkWithoutHeadingTemplateOfLink();
	   		try{
				newLinkWithoutHeadingTemplateOfLink.UpdateValues(WebPageIdIn, AllLinksOfTemplateIn);
				newLinkWithoutHeadingTemplateOfLink.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingTemplateOfLink;
		}

		public string Update(int WebPageIdIn,string AllLinksOfTemplateIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, AllLinksOfTemplateIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,string AllLinksOfTemplateIn){
			this.WebPageId = WebPageIdIn;
			this.AllLinksOfTemplate = AllLinksOfTemplateIn;
		}
        
		public static LinkWithoutHeadingTemplateOfLink Create(string WebPageIdIn,string AllLinksOfTemplateIn, out string SError){
			SError="";
			LinkWithoutHeadingTemplateOfLink newLinkWithoutHeadingTemplateOfLink = new LinkWithoutHeadingTemplateOfLink();
    		try{
				newLinkWithoutHeadingTemplateOfLink.UpdateValues(int.Parse(WebPageIdIn), AllLinksOfTemplateIn);
				newLinkWithoutHeadingTemplateOfLink.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeadingTemplateOfLink;
		}
				

		public string Update(string WebPageIdIn,string AllLinksOfTemplateIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), AllLinksOfTemplateIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithoutHeadingTemplateOfLink)){
                LinkWithoutHeadingTemplateOfLink compare=(LinkWithoutHeadingTemplateOfLink)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkWithoutHeadingTemplateOfLinksId;
        }
        
        public string DescriptorValue()
        {
            return this.AllLinksOfTemplate.ToString();
        }

        public string DescriptorColumn() {
           	return "AllLinksOfTemplate";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkWithoutHeadingTemplateOfLinksId";
        }        
        public static string GetDescriptorColumn()
        {
            return "AllLinksOfTemplate";
        }
        
        #region ' Foreign Keys for LinkWithoutHeadingTemplateOfLink '
        #endregion
        

        int _LinkWithoutHeadingTemplateOfLinksId;
        [DataMember] 
		public int LinkWithoutHeadingTemplateOfLinksId
        {
            get { return _LinkWithoutHeadingTemplateOfLinksId; }
            set
            {
                if(_LinkWithoutHeadingTemplateOfLinksId!=value){
                    _LinkWithoutHeadingTemplateOfLinksId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkWithoutHeadingTemplateOfLinksId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _AllLinksOfTemplate;
        [DataMember] 
		public string AllLinksOfTemplate
        {
            get { return _AllLinksOfTemplate; }
            set
            {
                if(_AllLinksOfTemplate!=value){
                    _AllLinksOfTemplate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="AllLinksOfTemplate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithoutHeadingTemplateOfLink, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the TemplateOfLinks table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class TemplateOfLink: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<TemplateOfLink> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<TemplateOfLink>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<TemplateOfLink> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(TemplateOfLink item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                TemplateOfLink item=new TemplateOfLink();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<TemplateOfLink> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public TemplateOfLink(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                TemplateOfLink.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<TemplateOfLink>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public TemplateOfLink(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public TemplateOfLink(Expression<Func<TemplateOfLink, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<TemplateOfLink> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<TemplateOfLink> _repo;
            
            if(db.TestMode){
                TemplateOfLink.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<TemplateOfLink>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<TemplateOfLink> GetRepo(){
            return GetRepo("","");
        }
        
        public static TemplateOfLink SingleOrDefault(Expression<Func<TemplateOfLink, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            TemplateOfLink single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static TemplateOfLink SingleOrDefault(Expression<Func<TemplateOfLink, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            TemplateOfLink single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<TemplateOfLink, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<TemplateOfLink, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<TemplateOfLink> Find(Expression<Func<TemplateOfLink, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<TemplateOfLink> Find(Expression<Func<TemplateOfLink, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<TemplateOfLink> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<TemplateOfLink> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<TemplateOfLink> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<TemplateOfLink> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<TemplateOfLink> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<TemplateOfLink> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkTemplateId";
        }

        public object KeyValue()
        {
            return this.LinkTemplateId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkAnchorText.ToString();
        }

        public static TemplateOfLink RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkTemplateId == keyValue);
		}
		
		
		public static TemplateOfLink Create(string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string TermVectorLengthLinkTemplateIn, out string SError){
			SError="";
 			TemplateOfLink newTemplateOfLink = new TemplateOfLink();
	   		try{
				newTemplateOfLink.UpdateValues(LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, TermVectorLengthLinkTemplateIn);
				newTemplateOfLink.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newTemplateOfLink;
		}

		public string Update(string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string TermVectorLengthLinkTemplateIn){
     		string SError = "";
			try{
				UpdateValues(LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, TermVectorLengthLinkTemplateIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string TermVectorLengthLinkTemplateIn){
			this.LinkAnchorText = LinkAnchorTextIn;
			this.LinkUrl = LinkUrlIn;
			this.ToPageId = ToPageIdIn;
			this.TermVectorLengthLinkTemplate = TermVectorLengthLinkTemplateIn;
		}
        
		public static TemplateOfLink Create(string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string TermVectorLengthLinkTemplateIn, out string SError){
			SError="";
			TemplateOfLink newTemplateOfLink = new TemplateOfLink();
    		try{
				newTemplateOfLink.UpdateValues(LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), TermVectorLengthLinkTemplateIn);
				newTemplateOfLink.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newTemplateOfLink;
		}
				

		public string Update(string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string TermVectorLengthLinkTemplateIn){
     		string SError = "";
			try{
				UpdateValues(LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), TermVectorLengthLinkTemplateIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(TemplateOfLink)){
                TemplateOfLink compare=(TemplateOfLink)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkTemplateId;
        }
        
        public string DescriptorValue()
        {
            return this.LinkAnchorText.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkAnchorText";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkTemplateId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkAnchorText";
        }
        
        #region ' Foreign Keys for TemplateOfLink '
        #endregion
        

        int _LinkTemplateId;
        [DataMember] 
		public int LinkTemplateId
        {
            get { return _LinkTemplateId; }
            set
            {
                if(_LinkTemplateId!=value){
                    _LinkTemplateId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkTemplateId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkAnchorText;
        [DataMember] 
		public string LinkAnchorText
        {
            get { return _LinkAnchorText; }
            set
            {
                if(_LinkAnchorText!=value){
                    _LinkAnchorText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkAnchorText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkUrl;
        [DataMember] 
		public string LinkUrl
        {
            get { return _LinkUrl; }
            set
            {
                if(_LinkUrl!=value){
                    _LinkUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _TermVectorLengthLinkTemplate;
        [DataMember] 
		public string TermVectorLengthLinkTemplate
        {
            get { return _TermVectorLengthLinkTemplate; }
            set
            {
                if(_TermVectorLengthLinkTemplate!=value){
                    _TermVectorLengthLinkTemplate=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TermVectorLengthLinkTemplate");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<TemplateOfLink, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the AnImage table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class AnImage: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<AnImage> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<AnImage>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<AnImage> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(AnImage item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                AnImage item=new AnImage();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<AnImage> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public AnImage(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                AnImage.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<AnImage>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public AnImage(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public AnImage(Expression<Func<AnImage, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<AnImage> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<AnImage> _repo;
            
            if(db.TestMode){
                AnImage.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<AnImage>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<AnImage> GetRepo(){
            return GetRepo("","");
        }
        
        public static AnImage SingleOrDefault(Expression<Func<AnImage, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            AnImage single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static AnImage SingleOrDefault(Expression<Func<AnImage, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            AnImage single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<AnImage, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<AnImage, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<AnImage> Find(Expression<Func<AnImage, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<AnImage> Find(Expression<Func<AnImage, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<AnImage> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<AnImage> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<AnImage> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<AnImage> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<AnImage> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<AnImage> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ImgId";
        }

        public object KeyValue()
        {
            return this.ImgId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.ImageAltText.ToString();
        }

        public static AnImage RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.ImgId == keyValue);
		}
		
		
		public static AnImage Create(int WebPageIdIn,int HeadingIdIn,string ImageAltTextIn,string ImageUrlIn,string ImagePictureIn,string CosienValueImageHeadingIn,string TermVectorLengthIn, out string SError){
			SError="";
 			AnImage newAnImage = new AnImage();
	   		try{
				newAnImage.UpdateValues(WebPageIdIn, HeadingIdIn, ImageAltTextIn, ImageUrlIn, ImagePictureIn, CosienValueImageHeadingIn, TermVectorLengthIn);
				newAnImage.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newAnImage;
		}

		public string Update(int WebPageIdIn,int HeadingIdIn,string ImageAltTextIn,string ImageUrlIn,string ImagePictureIn,string CosienValueImageHeadingIn,string TermVectorLengthIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, HeadingIdIn, ImageAltTextIn, ImageUrlIn, ImagePictureIn, CosienValueImageHeadingIn, TermVectorLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,int HeadingIdIn,string ImageAltTextIn,string ImageUrlIn,string ImagePictureIn,string CosienValueImageHeadingIn,string TermVectorLengthIn){
			this.WebPageId = WebPageIdIn;
			this.HeadingId = HeadingIdIn;
			this.ImageAltText = ImageAltTextIn;
			this.ImageUrl = ImageUrlIn;
			this.ImagePicture = ImagePictureIn;
			this.CosienValueImageHeading = CosienValueImageHeadingIn;
			this.TermVectorLength = TermVectorLengthIn;
		}
        
		public static AnImage Create(string WebPageIdIn,string HeadingIdIn,string ImageAltTextIn,string ImageUrlIn,string ImagePictureIn,string CosienValueImageHeadingIn,string TermVectorLengthIn, out string SError){
			SError="";
			AnImage newAnImage = new AnImage();
    		try{
				newAnImage.UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), ImageAltTextIn, ImageUrlIn, ImagePictureIn, CosienValueImageHeadingIn, TermVectorLengthIn);
				newAnImage.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newAnImage;
		}
				

		public string Update(string WebPageIdIn,string HeadingIdIn,string ImageAltTextIn,string ImageUrlIn,string ImagePictureIn,string CosienValueImageHeadingIn,string TermVectorLengthIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), int.Parse(HeadingIdIn), ImageAltTextIn, ImageUrlIn, ImagePictureIn, CosienValueImageHeadingIn, TermVectorLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(AnImage)){
                AnImage compare=(AnImage)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ImgId;
        }
        
        public string DescriptorValue()
        {
            return this.ImageAltText.ToString();
        }

        public string DescriptorColumn() {
           	return "ImageAltText";
        }
			

        public static string GetKeyColumn()
        {
            return "ImgId";
        }        
        public static string GetDescriptorColumn()
        {
            return "ImageAltText";
        }
        
        #region ' Foreign Keys for AnImage '
        #endregion
        

        int _ImgId;
        [DataMember] 
		public int ImgId
        {
            get { return _ImgId; }
            set
            {
                if(_ImgId!=value){
                    _ImgId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImgId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ImageAltText;
        [DataMember] 
		public string ImageAltText
        {
            get { return _ImageAltText; }
            set
            {
                if(_ImageAltText!=value){
                    _ImageAltText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImageAltText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ImageUrl;
        [DataMember] 
		public string ImageUrl
        {
            get { return _ImageUrl; }
            set
            {
                if(_ImageUrl!=value){
                    _ImageUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImageUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ImagePicture;
        [DataMember] 
		public string ImagePicture
        {
            get { return _ImagePicture; }
            set
            {
                if(_ImagePicture!=value){
                    _ImagePicture=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImagePicture");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosienValueImageHeading;
        [DataMember] 
		public string CosienValueImageHeading
        {
            get { return _CosienValueImageHeading; }
            set
            {
                if(_CosienValueImageHeading!=value){
                    _CosienValueImageHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosienValueImageHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _TermVectorLength;
        [DataMember] 
		public string TermVectorLength
        {
            get { return _TermVectorLength; }
            set
            {
                if(_TermVectorLength!=value){
                    _TermVectorLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="TermVectorLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<AnImage, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the AnImageWithoutHeading table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class AnImageWithoutHeading: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<AnImageWithoutHeading> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<AnImageWithoutHeading>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<AnImageWithoutHeading> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(AnImageWithoutHeading item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                AnImageWithoutHeading item=new AnImageWithoutHeading();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<AnImageWithoutHeading> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public AnImageWithoutHeading(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                AnImageWithoutHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<AnImageWithoutHeading>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public AnImageWithoutHeading(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public AnImageWithoutHeading(Expression<Func<AnImageWithoutHeading, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<AnImageWithoutHeading> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<AnImageWithoutHeading> _repo;
            
            if(db.TestMode){
                AnImageWithoutHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<AnImageWithoutHeading>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<AnImageWithoutHeading> GetRepo(){
            return GetRepo("","");
        }
        
        public static AnImageWithoutHeading SingleOrDefault(Expression<Func<AnImageWithoutHeading, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            AnImageWithoutHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static AnImageWithoutHeading SingleOrDefault(Expression<Func<AnImageWithoutHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            AnImageWithoutHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<AnImageWithoutHeading, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<AnImageWithoutHeading, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<AnImageWithoutHeading> Find(Expression<Func<AnImageWithoutHeading, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<AnImageWithoutHeading> Find(Expression<Func<AnImageWithoutHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<AnImageWithoutHeading> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<AnImageWithoutHeading> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<AnImageWithoutHeading> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<AnImageWithoutHeading> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<AnImageWithoutHeading> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<AnImageWithoutHeading> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "ImageWithoutHeadingId";
        }

        public object KeyValue()
        {
            return this.ImageWithoutHeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.ImageUrl.ToString();
        }

        public static AnImageWithoutHeading RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.ImageWithoutHeadingId == keyValue);
		}
		
		
		public static AnImageWithoutHeading Create(int WebPageIdIn,string ImageUrlIn,string VectorTermLegnthIn,string ImageAltTextIn, out string SError){
			SError="";
 			AnImageWithoutHeading newAnImageWithoutHeading = new AnImageWithoutHeading();
	   		try{
				newAnImageWithoutHeading.UpdateValues(WebPageIdIn, ImageUrlIn, VectorTermLegnthIn, ImageAltTextIn);
				newAnImageWithoutHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newAnImageWithoutHeading;
		}

		public string Update(int WebPageIdIn,string ImageUrlIn,string VectorTermLegnthIn,string ImageAltTextIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, ImageUrlIn, VectorTermLegnthIn, ImageAltTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,string ImageUrlIn,string VectorTermLegnthIn,string ImageAltTextIn){
			this.WebPageId = WebPageIdIn;
			this.ImageUrl = ImageUrlIn;
			this.VectorTermLegnth = VectorTermLegnthIn;
			this.ImageAltText = ImageAltTextIn;
		}
        
		public static AnImageWithoutHeading Create(string WebPageIdIn,string ImageUrlIn,string VectorTermLegnthIn,string ImageAltTextIn, out string SError){
			SError="";
			AnImageWithoutHeading newAnImageWithoutHeading = new AnImageWithoutHeading();
    		try{
				newAnImageWithoutHeading.UpdateValues(int.Parse(WebPageIdIn), ImageUrlIn, VectorTermLegnthIn, ImageAltTextIn);
				newAnImageWithoutHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newAnImageWithoutHeading;
		}
				

		public string Update(string WebPageIdIn,string ImageUrlIn,string VectorTermLegnthIn,string ImageAltTextIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), ImageUrlIn, VectorTermLegnthIn, ImageAltTextIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(AnImageWithoutHeading)){
                AnImageWithoutHeading compare=(AnImageWithoutHeading)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.ImageWithoutHeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.ImageUrl.ToString();
        }

        public string DescriptorColumn() {
           	return "ImageUrl";
        }
			

        public static string GetKeyColumn()
        {
            return "ImageWithoutHeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "ImageUrl";
        }
        
        #region ' Foreign Keys for AnImageWithoutHeading '
        #endregion
        

        int _ImageWithoutHeadingId;
        [DataMember] 
		public int ImageWithoutHeadingId
        {
            get { return _ImageWithoutHeadingId; }
            set
            {
                if(_ImageWithoutHeadingId!=value){
                    _ImageWithoutHeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImageWithoutHeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ImageUrl;
        [DataMember] 
		public string ImageUrl
        {
            get { return _ImageUrl; }
            set
            {
                if(_ImageUrl!=value){
                    _ImageUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImageUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLegnth;
        [DataMember] 
		public string VectorTermLegnth
        {
            get { return _VectorTermLegnth; }
            set
            {
                if(_VectorTermLegnth!=value){
                    _VectorTermLegnth=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLegnth");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _ImageAltText;
        [DataMember] 
		public string ImageAltText
        {
            get { return _ImageAltText; }
            set
            {
                if(_ImageAltText!=value){
                    _ImageAltText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImageAltText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<AnImageWithoutHeading, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CosineImageImageUnderSameHeading table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class CosineImageImageUnderSameHeading: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CosineImageImageUnderSameHeading> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CosineImageImageUnderSameHeading>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CosineImageImageUnderSameHeading> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CosineImageImageUnderSameHeading item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CosineImageImageUnderSameHeading item=new CosineImageImageUnderSameHeading();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CosineImageImageUnderSameHeading> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public CosineImageImageUnderSameHeading(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CosineImageImageUnderSameHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineImageImageUnderSameHeading>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CosineImageImageUnderSameHeading(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CosineImageImageUnderSameHeading(Expression<Func<CosineImageImageUnderSameHeading, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CosineImageImageUnderSameHeading> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<CosineImageImageUnderSameHeading> _repo;
            
            if(db.TestMode){
                CosineImageImageUnderSameHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineImageImageUnderSameHeading>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CosineImageImageUnderSameHeading> GetRepo(){
            return GetRepo("","");
        }
        
        public static CosineImageImageUnderSameHeading SingleOrDefault(Expression<Func<CosineImageImageUnderSameHeading, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CosineImageImageUnderSameHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CosineImageImageUnderSameHeading SingleOrDefault(Expression<Func<CosineImageImageUnderSameHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CosineImageImageUnderSameHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CosineImageImageUnderSameHeading, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CosineImageImageUnderSameHeading, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CosineImageImageUnderSameHeading> Find(Expression<Func<CosineImageImageUnderSameHeading, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CosineImageImageUnderSameHeading> Find(Expression<Func<CosineImageImageUnderSameHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<CosineImageImageUnderSameHeading> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<CosineImageImageUnderSameHeading> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<CosineImageImageUnderSameHeading> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CosineImageImageUnderSameHeading> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CosineImageImageUnderSameHeading> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CosineImageImageUnderSameHeading> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CosineImageImageUnderHeadingId";
        }

        public object KeyValue()
        {
            return this.CosineImageImageUnderHeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CosineValueImageImageWithHeading.ToString();
        }

        public static CosineImageImageUnderSameHeading RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.CosineImageImageUnderHeadingId == keyValue);
		}
		
		
		public static CosineImageImageUnderSameHeading Create(int HeadingIdIn,int ImageXIdIn,int ImageYIdIn,string CosineValueImageImageWithHeadingIn,int WebpageIdIn, out string SError){
			SError="";
 			CosineImageImageUnderSameHeading newCosineImageImageUnderSameHeading = new CosineImageImageUnderSameHeading();
	   		try{
				newCosineImageImageUnderSameHeading.UpdateValues(HeadingIdIn, ImageXIdIn, ImageYIdIn, CosineValueImageImageWithHeadingIn, WebpageIdIn);
				newCosineImageImageUnderSameHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineImageImageUnderSameHeading;
		}

		public string Update(int HeadingIdIn,int ImageXIdIn,int ImageYIdIn,string CosineValueImageImageWithHeadingIn,int WebpageIdIn){
     		string SError = "";
			try{
				UpdateValues(HeadingIdIn, ImageXIdIn, ImageYIdIn, CosineValueImageImageWithHeadingIn, WebpageIdIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int HeadingIdIn,int ImageXIdIn,int ImageYIdIn,string CosineValueImageImageWithHeadingIn,int WebpageIdIn){
			this.HeadingId = HeadingIdIn;
			this.ImageXId = ImageXIdIn;
			this.ImageYId = ImageYIdIn;
			this.CosineValueImageImageWithHeading = CosineValueImageImageWithHeadingIn;
			this.WebpageId = WebpageIdIn;
		}
        
		public static CosineImageImageUnderSameHeading Create(string HeadingIdIn,string ImageXIdIn,string ImageYIdIn,string CosineValueImageImageWithHeadingIn,string WebpageIdIn, out string SError){
			SError="";
			CosineImageImageUnderSameHeading newCosineImageImageUnderSameHeading = new CosineImageImageUnderSameHeading();
    		try{
				newCosineImageImageUnderSameHeading.UpdateValues(int.Parse(HeadingIdIn), int.Parse(ImageXIdIn), int.Parse(ImageYIdIn), CosineValueImageImageWithHeadingIn, int.Parse(WebpageIdIn));
				newCosineImageImageUnderSameHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineImageImageUnderSameHeading;
		}
				

		public string Update(string HeadingIdIn,string ImageXIdIn,string ImageYIdIn,string CosineValueImageImageWithHeadingIn,string WebpageIdIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(HeadingIdIn), int.Parse(ImageXIdIn), int.Parse(ImageYIdIn), CosineValueImageImageWithHeadingIn, int.Parse(WebpageIdIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(CosineImageImageUnderSameHeading)){
                CosineImageImageUnderSameHeading compare=(CosineImageImageUnderSameHeading)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.CosineImageImageUnderHeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.CosineValueImageImageWithHeading.ToString();
        }

        public string DescriptorColumn() {
           	return "CosineValueImageImageWithHeading";
        }
			

        public static string GetKeyColumn()
        {
            return "CosineImageImageUnderHeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CosineValueImageImageWithHeading";
        }
        
        #region ' Foreign Keys for CosineImageImageUnderSameHeading '
        #endregion
        

        int _CosineImageImageUnderHeadingId;
        [DataMember] 
		public int CosineImageImageUnderHeadingId
        {
            get { return _CosineImageImageUnderHeadingId; }
            set
            {
                if(_CosineImageImageUnderHeadingId!=value){
                    _CosineImageImageUnderHeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineImageImageUnderHeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ImageXId;
        [DataMember] 
		public int ImageXId
        {
            get { return _ImageXId; }
            set
            {
                if(_ImageXId!=value){
                    _ImageXId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImageXId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ImageYId;
        [DataMember] 
		public int ImageYId
        {
            get { return _ImageYId; }
            set
            {
                if(_ImageYId!=value){
                    _ImageYId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImageYId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueImageImageWithHeading;
        [DataMember] 
		public string CosineValueImageImageWithHeading
        {
            get { return _CosineValueImageImageWithHeading; }
            set
            {
                if(_CosineValueImageImageWithHeading!=value){
                    _CosineValueImageImageWithHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueImageImageWithHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebpageId;
        [DataMember] 
		public int WebpageId
        {
            get { return _WebpageId; }
            set
            {
                if(_WebpageId!=value){
                    _WebpageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebpageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CosineImageImageUnderSameHeading, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CosineImageImageWithoutHeading table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class CosineImageImageWithoutHeading: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CosineImageImageWithoutHeading> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CosineImageImageWithoutHeading>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CosineImageImageWithoutHeading> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CosineImageImageWithoutHeading item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CosineImageImageWithoutHeading item=new CosineImageImageWithoutHeading();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CosineImageImageWithoutHeading> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public CosineImageImageWithoutHeading(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CosineImageImageWithoutHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineImageImageWithoutHeading>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CosineImageImageWithoutHeading(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CosineImageImageWithoutHeading(Expression<Func<CosineImageImageWithoutHeading, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CosineImageImageWithoutHeading> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<CosineImageImageWithoutHeading> _repo;
            
            if(db.TestMode){
                CosineImageImageWithoutHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineImageImageWithoutHeading>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CosineImageImageWithoutHeading> GetRepo(){
            return GetRepo("","");
        }
        
        public static CosineImageImageWithoutHeading SingleOrDefault(Expression<Func<CosineImageImageWithoutHeading, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CosineImageImageWithoutHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CosineImageImageWithoutHeading SingleOrDefault(Expression<Func<CosineImageImageWithoutHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CosineImageImageWithoutHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CosineImageImageWithoutHeading, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CosineImageImageWithoutHeading, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CosineImageImageWithoutHeading> Find(Expression<Func<CosineImageImageWithoutHeading, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CosineImageImageWithoutHeading> Find(Expression<Func<CosineImageImageWithoutHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<CosineImageImageWithoutHeading> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<CosineImageImageWithoutHeading> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<CosineImageImageWithoutHeading> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CosineImageImageWithoutHeading> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CosineImageImageWithoutHeading> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CosineImageImageWithoutHeading> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CosineImageImageWithoutHeadingId";
        }

        public object KeyValue()
        {
            return this.CosineImageImageWithoutHeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CosineValueImageImageWithoutHeading.ToString();
        }

        public static CosineImageImageWithoutHeading RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.CosineImageImageWithoutHeadingId == keyValue);
		}
		
		
		public static CosineImageImageWithoutHeading Create(int ImageXIdIn,int ImageYIdIn,string CosineValueImageImageWithoutHeadingIn,int WebPageIdIn, out string SError){
			SError="";
 			CosineImageImageWithoutHeading newCosineImageImageWithoutHeading = new CosineImageImageWithoutHeading();
	   		try{
				newCosineImageImageWithoutHeading.UpdateValues(ImageXIdIn, ImageYIdIn, CosineValueImageImageWithoutHeadingIn, WebPageIdIn);
				newCosineImageImageWithoutHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineImageImageWithoutHeading;
		}

		public string Update(int ImageXIdIn,int ImageYIdIn,string CosineValueImageImageWithoutHeadingIn,int WebPageIdIn){
     		string SError = "";
			try{
				UpdateValues(ImageXIdIn, ImageYIdIn, CosineValueImageImageWithoutHeadingIn, WebPageIdIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int ImageXIdIn,int ImageYIdIn,string CosineValueImageImageWithoutHeadingIn,int WebPageIdIn){
			this.ImageXId = ImageXIdIn;
			this.ImageYId = ImageYIdIn;
			this.CosineValueImageImageWithoutHeading = CosineValueImageImageWithoutHeadingIn;
			this.WebPageId = WebPageIdIn;
		}
        
		public static CosineImageImageWithoutHeading Create(string ImageXIdIn,string ImageYIdIn,string CosineValueImageImageWithoutHeadingIn,string WebPageIdIn, out string SError){
			SError="";
			CosineImageImageWithoutHeading newCosineImageImageWithoutHeading = new CosineImageImageWithoutHeading();
    		try{
				newCosineImageImageWithoutHeading.UpdateValues(int.Parse(ImageXIdIn), int.Parse(ImageYIdIn), CosineValueImageImageWithoutHeadingIn, int.Parse(WebPageIdIn));
				newCosineImageImageWithoutHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineImageImageWithoutHeading;
		}
				

		public string Update(string ImageXIdIn,string ImageYIdIn,string CosineValueImageImageWithoutHeadingIn,string WebPageIdIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(ImageXIdIn), int.Parse(ImageYIdIn), CosineValueImageImageWithoutHeadingIn, int.Parse(WebPageIdIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(CosineImageImageWithoutHeading)){
                CosineImageImageWithoutHeading compare=(CosineImageImageWithoutHeading)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.CosineImageImageWithoutHeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.CosineValueImageImageWithoutHeading.ToString();
        }

        public string DescriptorColumn() {
           	return "CosineValueImageImageWithoutHeading";
        }
			

        public static string GetKeyColumn()
        {
            return "CosineImageImageWithoutHeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CosineValueImageImageWithoutHeading";
        }
        
        #region ' Foreign Keys for CosineImageImageWithoutHeading '
        #endregion
        

        int _CosineImageImageWithoutHeadingId;
        [DataMember] 
		public int CosineImageImageWithoutHeadingId
        {
            get { return _CosineImageImageWithoutHeadingId; }
            set
            {
                if(_CosineImageImageWithoutHeadingId!=value){
                    _CosineImageImageWithoutHeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineImageImageWithoutHeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ImageXId;
        [DataMember] 
		public int ImageXId
        {
            get { return _ImageXId; }
            set
            {
                if(_ImageXId!=value){
                    _ImageXId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImageXId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ImageYId;
        [DataMember] 
		public int ImageYId
        {
            get { return _ImageYId; }
            set
            {
                if(_ImageYId!=value){
                    _ImageYId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ImageYId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueImageImageWithoutHeading;
        [DataMember] 
		public string CosineValueImageImageWithoutHeading
        {
            get { return _CosineValueImageImageWithoutHeading; }
            set
            {
                if(_CosineValueImageImageWithoutHeading!=value){
                    _CosineValueImageImageWithoutHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueImageImageWithoutHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CosineImageImageWithoutHeading, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CosineLinkLinkWithoutHeading table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class CosineLinkLinkWithoutHeading: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CosineLinkLinkWithoutHeading> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CosineLinkLinkWithoutHeading>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CosineLinkLinkWithoutHeading> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CosineLinkLinkWithoutHeading item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CosineLinkLinkWithoutHeading item=new CosineLinkLinkWithoutHeading();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CosineLinkLinkWithoutHeading> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public CosineLinkLinkWithoutHeading(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CosineLinkLinkWithoutHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineLinkLinkWithoutHeading>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CosineLinkLinkWithoutHeading(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CosineLinkLinkWithoutHeading(Expression<Func<CosineLinkLinkWithoutHeading, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CosineLinkLinkWithoutHeading> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<CosineLinkLinkWithoutHeading> _repo;
            
            if(db.TestMode){
                CosineLinkLinkWithoutHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineLinkLinkWithoutHeading>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CosineLinkLinkWithoutHeading> GetRepo(){
            return GetRepo("","");
        }
        
        public static CosineLinkLinkWithoutHeading SingleOrDefault(Expression<Func<CosineLinkLinkWithoutHeading, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CosineLinkLinkWithoutHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CosineLinkLinkWithoutHeading SingleOrDefault(Expression<Func<CosineLinkLinkWithoutHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CosineLinkLinkWithoutHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CosineLinkLinkWithoutHeading, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CosineLinkLinkWithoutHeading, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CosineLinkLinkWithoutHeading> Find(Expression<Func<CosineLinkLinkWithoutHeading, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CosineLinkLinkWithoutHeading> Find(Expression<Func<CosineLinkLinkWithoutHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<CosineLinkLinkWithoutHeading> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<CosineLinkLinkWithoutHeading> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<CosineLinkLinkWithoutHeading> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CosineLinkLinkWithoutHeading> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CosineLinkLinkWithoutHeading> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CosineLinkLinkWithoutHeading> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CosineLinkLinkWithoutHeadingId";
        }

        public object KeyValue()
        {
            return this.CosineLinkLinkWithoutHeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CosineValueLinkLinkWithoutHeading.ToString();
        }

        public static CosineLinkLinkWithoutHeading RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.CosineLinkLinkWithoutHeadingId == keyValue);
		}
		
		
		public static CosineLinkLinkWithoutHeading Create(int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,int WebPageIdIn, out string SError){
			SError="";
 			CosineLinkLinkWithoutHeading newCosineLinkLinkWithoutHeading = new CosineLinkLinkWithoutHeading();
	   		try{
				newCosineLinkLinkWithoutHeading.UpdateValues(LinkXIdIn, LinkYIdIn, CosineValueLinkLinkWithoutHeadingIn, WebPageIdIn);
				newCosineLinkLinkWithoutHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineLinkLinkWithoutHeading;
		}

		public string Update(int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,int WebPageIdIn){
     		string SError = "";
			try{
				UpdateValues(LinkXIdIn, LinkYIdIn, CosineValueLinkLinkWithoutHeadingIn, WebPageIdIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,int WebPageIdIn){
			this.LinkXId = LinkXIdIn;
			this.LinkYId = LinkYIdIn;
			this.CosineValueLinkLinkWithoutHeading = CosineValueLinkLinkWithoutHeadingIn;
			this.WebPageId = WebPageIdIn;
		}
        
		public static CosineLinkLinkWithoutHeading Create(string LinkXIdIn,string LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,string WebPageIdIn, out string SError){
			SError="";
			CosineLinkLinkWithoutHeading newCosineLinkLinkWithoutHeading = new CosineLinkLinkWithoutHeading();
    		try{
				newCosineLinkLinkWithoutHeading.UpdateValues(int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineValueLinkLinkWithoutHeadingIn, int.Parse(WebPageIdIn));
				newCosineLinkLinkWithoutHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineLinkLinkWithoutHeading;
		}
				

		public string Update(string LinkXIdIn,string LinkYIdIn,string CosineValueLinkLinkWithoutHeadingIn,string WebPageIdIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineValueLinkLinkWithoutHeadingIn, int.Parse(WebPageIdIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(CosineLinkLinkWithoutHeading)){
                CosineLinkLinkWithoutHeading compare=(CosineLinkLinkWithoutHeading)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.CosineLinkLinkWithoutHeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.CosineValueLinkLinkWithoutHeading.ToString();
        }

        public string DescriptorColumn() {
           	return "CosineValueLinkLinkWithoutHeading";
        }
			

        public static string GetKeyColumn()
        {
            return "CosineLinkLinkWithoutHeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CosineValueLinkLinkWithoutHeading";
        }
        
        #region ' Foreign Keys for CosineLinkLinkWithoutHeading '
        #endregion
        

        int _CosineLinkLinkWithoutHeadingId;
        [DataMember] 
		public int CosineLinkLinkWithoutHeadingId
        {
            get { return _CosineLinkLinkWithoutHeadingId; }
            set
            {
                if(_CosineLinkLinkWithoutHeadingId!=value){
                    _CosineLinkLinkWithoutHeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineLinkLinkWithoutHeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkXId;
        [DataMember] 
		public int LinkXId
        {
            get { return _LinkXId; }
            set
            {
                if(_LinkXId!=value){
                    _LinkXId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkXId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkYId;
        [DataMember] 
		public int LinkYId
        {
            get { return _LinkYId; }
            set
            {
                if(_LinkYId!=value){
                    _LinkYId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkYId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueLinkLinkWithoutHeading;
        [DataMember] 
		public string CosineValueLinkLinkWithoutHeading
        {
            get { return _CosineValueLinkLinkWithoutHeading; }
            set
            {
                if(_CosineValueLinkLinkWithoutHeading!=value){
                    _CosineValueLinkLinkWithoutHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueLinkLinkWithoutHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CosineLinkLinkWithoutHeading, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the CosineLinkLinkWithHeading table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class CosineLinkLinkWithHeading: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<CosineLinkLinkWithHeading> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<CosineLinkLinkWithHeading>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<CosineLinkLinkWithHeading> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(CosineLinkLinkWithHeading item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                CosineLinkLinkWithHeading item=new CosineLinkLinkWithHeading();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<CosineLinkLinkWithHeading> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public CosineLinkLinkWithHeading(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                CosineLinkLinkWithHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineLinkLinkWithHeading>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public CosineLinkLinkWithHeading(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public CosineLinkLinkWithHeading(Expression<Func<CosineLinkLinkWithHeading, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<CosineLinkLinkWithHeading> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<CosineLinkLinkWithHeading> _repo;
            
            if(db.TestMode){
                CosineLinkLinkWithHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<CosineLinkLinkWithHeading>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<CosineLinkLinkWithHeading> GetRepo(){
            return GetRepo("","");
        }
        
        public static CosineLinkLinkWithHeading SingleOrDefault(Expression<Func<CosineLinkLinkWithHeading, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            CosineLinkLinkWithHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static CosineLinkLinkWithHeading SingleOrDefault(Expression<Func<CosineLinkLinkWithHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            CosineLinkLinkWithHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<CosineLinkLinkWithHeading, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<CosineLinkLinkWithHeading, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<CosineLinkLinkWithHeading> Find(Expression<Func<CosineLinkLinkWithHeading, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<CosineLinkLinkWithHeading> Find(Expression<Func<CosineLinkLinkWithHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<CosineLinkLinkWithHeading> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<CosineLinkLinkWithHeading> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<CosineLinkLinkWithHeading> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<CosineLinkLinkWithHeading> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<CosineLinkLinkWithHeading> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<CosineLinkLinkWithHeading> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "CosineLinkLinkWithHeadingId";
        }

        public object KeyValue()
        {
            return this.CosineLinkLinkWithHeadingId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.CosineValueLinkLinkWithHeading.ToString();
        }

        public static CosineLinkLinkWithHeading RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.CosineLinkLinkWithHeadingId == keyValue);
		}
		
		
		public static CosineLinkLinkWithHeading Create(int HeadingIdIn,int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,int WebpageIdIn, out string SError){
			SError="";
 			CosineLinkLinkWithHeading newCosineLinkLinkWithHeading = new CosineLinkLinkWithHeading();
	   		try{
				newCosineLinkLinkWithHeading.UpdateValues(HeadingIdIn, LinkXIdIn, LinkYIdIn, CosineValueLinkLinkWithHeadingIn, WebpageIdIn);
				newCosineLinkLinkWithHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineLinkLinkWithHeading;
		}

		public string Update(int HeadingIdIn,int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,int WebpageIdIn){
     		string SError = "";
			try{
				UpdateValues(HeadingIdIn, LinkXIdIn, LinkYIdIn, CosineValueLinkLinkWithHeadingIn, WebpageIdIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int HeadingIdIn,int LinkXIdIn,int LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,int WebpageIdIn){
			this.HeadingId = HeadingIdIn;
			this.LinkXId = LinkXIdIn;
			this.LinkYId = LinkYIdIn;
			this.CosineValueLinkLinkWithHeading = CosineValueLinkLinkWithHeadingIn;
			this.WebpageId = WebpageIdIn;
		}
        
		public static CosineLinkLinkWithHeading Create(string HeadingIdIn,string LinkXIdIn,string LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,string WebpageIdIn, out string SError){
			SError="";
			CosineLinkLinkWithHeading newCosineLinkLinkWithHeading = new CosineLinkLinkWithHeading();
    		try{
				newCosineLinkLinkWithHeading.UpdateValues(int.Parse(HeadingIdIn), int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineValueLinkLinkWithHeadingIn, int.Parse(WebpageIdIn));
				newCosineLinkLinkWithHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newCosineLinkLinkWithHeading;
		}
				

		public string Update(string HeadingIdIn,string LinkXIdIn,string LinkYIdIn,string CosineValueLinkLinkWithHeadingIn,string WebpageIdIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(HeadingIdIn), int.Parse(LinkXIdIn), int.Parse(LinkYIdIn), CosineValueLinkLinkWithHeadingIn, int.Parse(WebpageIdIn));
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(CosineLinkLinkWithHeading)){
                CosineLinkLinkWithHeading compare=(CosineLinkLinkWithHeading)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.CosineLinkLinkWithHeadingId;
        }
        
        public string DescriptorValue()
        {
            return this.CosineValueLinkLinkWithHeading.ToString();
        }

        public string DescriptorColumn() {
           	return "CosineValueLinkLinkWithHeading";
        }
			

        public static string GetKeyColumn()
        {
            return "CosineLinkLinkWithHeadingId";
        }        
        public static string GetDescriptorColumn()
        {
            return "CosineValueLinkLinkWithHeading";
        }
        
        #region ' Foreign Keys for CosineLinkLinkWithHeading '
        #endregion
        

        int _CosineLinkLinkWithHeadingId;
        [DataMember] 
		public int CosineLinkLinkWithHeadingId
        {
            get { return _CosineLinkLinkWithHeadingId; }
            set
            {
                if(_CosineLinkLinkWithHeadingId!=value){
                    _CosineLinkLinkWithHeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineLinkLinkWithHeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _HeadingId;
        [DataMember] 
		public int HeadingId
        {
            get { return _HeadingId; }
            set
            {
                if(_HeadingId!=value){
                    _HeadingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="HeadingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkXId;
        [DataMember] 
		public int LinkXId
        {
            get { return _LinkXId; }
            set
            {
                if(_LinkXId!=value){
                    _LinkXId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkXId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _LinkYId;
        [DataMember] 
		public int LinkYId
        {
            get { return _LinkYId; }
            set
            {
                if(_LinkYId!=value){
                    _LinkYId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkYId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _CosineValueLinkLinkWithHeading;
        [DataMember] 
		public string CosineValueLinkLinkWithHeading
        {
            get { return _CosineValueLinkLinkWithHeading; }
            set
            {
                if(_CosineValueLinkLinkWithHeading!=value){
                    _CosineValueLinkLinkWithHeading=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="CosineValueLinkLinkWithHeading");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebpageId;
        [DataMember] 
		public int WebpageId
        {
            get { return _WebpageId; }
            set
            {
                if(_WebpageId!=value){
                    _WebpageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebpageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<CosineLinkLinkWithHeading, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the WebSite table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class WebSite: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<WebSite> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<WebSite>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<WebSite> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(WebSite item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                WebSite item=new WebSite();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<WebSite> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public WebSite(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                WebSite.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<WebSite>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public WebSite(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public WebSite(Expression<Func<WebSite, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<WebSite> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<WebSite> _repo;
            
            if(db.TestMode){
                WebSite.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<WebSite>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<WebSite> GetRepo(){
            return GetRepo("","");
        }
        
        public static WebSite SingleOrDefault(Expression<Func<WebSite, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            WebSite single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static WebSite SingleOrDefault(Expression<Func<WebSite, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            WebSite single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<WebSite, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<WebSite, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<WebSite> Find(Expression<Func<WebSite, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<WebSite> Find(Expression<Func<WebSite, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<WebSite> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<WebSite> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<WebSite> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<WebSite> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<WebSite> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<WebSite> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "WebSiteId";
        }

        public object KeyValue()
        {
            return this.WebSiteId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.WebSiteName.ToString();
        }

        public static WebSite RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.WebSiteId == keyValue);
		}
		
		
		public static WebSite Create(string WebSiteNameIn, out string SError){
			SError="";
 			WebSite newWebSite = new WebSite();
	   		try{
				newWebSite.UpdateValues(WebSiteNameIn);
				newWebSite.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newWebSite;
		}

		public string Update(string WebSiteNameIn){
     		string SError = "";
			try{
				UpdateValues(WebSiteNameIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(string WebSiteNameIn){
			this.WebSiteName = WebSiteNameIn;
		}
        
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(WebSite)){
                WebSite compare=(WebSite)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.WebSiteId;
        }
        
        public string DescriptorValue()
        {
            return this.WebSiteName.ToString();
        }

        public string DescriptorColumn() {
           	return "WebSiteName";
        }
			

        public static string GetKeyColumn()
        {
            return "WebSiteId";
        }        
        public static string GetDescriptorColumn()
        {
            return "WebSiteName";
        }
        
        #region ' Foreign Keys for WebSite '
        #endregion
        

        int _WebSiteId;
        [DataMember] 
		public int WebSiteId
        {
            get { return _WebSiteId; }
            set
            {
                if(_WebSiteId!=value){
                    _WebSiteId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebSiteId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _WebSiteName;
        [DataMember] 
		public string WebSiteName
        {
            get { return _WebSiteName; }
            set
            {
                if(_WebSiteName!=value){
                    _WebSiteName=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebSiteName");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<WebSite, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the Heading_Cosine table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class Heading_Cosine: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<Heading_Cosine> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<Heading_Cosine>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<Heading_Cosine> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(Heading_Cosine item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                Heading_Cosine item=new Heading_Cosine();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<Heading_Cosine> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public Heading_Cosine(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                Heading_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Heading_Cosine>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public Heading_Cosine(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public Heading_Cosine(Expression<Func<Heading_Cosine, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<Heading_Cosine> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<Heading_Cosine> _repo;
            
            if(db.TestMode){
                Heading_Cosine.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<Heading_Cosine>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<Heading_Cosine> GetRepo(){
            return GetRepo("","");
        }
        
        public static Heading_Cosine SingleOrDefault(Expression<Func<Heading_Cosine, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            Heading_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static Heading_Cosine SingleOrDefault(Expression<Func<Heading_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            Heading_Cosine single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<Heading_Cosine, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<Heading_Cosine, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<Heading_Cosine> Find(Expression<Func<Heading_Cosine, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<Heading_Cosine> Find(Expression<Func<Heading_Cosine, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<Heading_Cosine> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<Heading_Cosine> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<Heading_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<Heading_Cosine> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<Heading_Cosine> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<Heading_Cosine> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "headingCosineID";
        }

        public object KeyValue()
        {
            return this.headingCosineID;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.headingText.ToString();
        }

        public static Heading_Cosine RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.headingCosineID == keyValue);
		}
		
		
		public static Heading_Cosine Create(int pageIdIn,int headingIdIn,string headingTextIn,string CosineIn,string SelectedRowIn, out string SError){
			SError="";
 			Heading_Cosine newHeading_Cosine = new Heading_Cosine();
	   		try{
				newHeading_Cosine.UpdateValues(pageIdIn, headingIdIn, headingTextIn, CosineIn, SelectedRowIn);
				newHeading_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeading_Cosine;
		}

		public string Update(int pageIdIn,int headingIdIn,string headingTextIn,string CosineIn,string SelectedRowIn){
     		string SError = "";
			try{
				UpdateValues(pageIdIn, headingIdIn, headingTextIn, CosineIn, SelectedRowIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int pageIdIn,int headingIdIn,string headingTextIn,string CosineIn,string SelectedRowIn){
			this.pageId = pageIdIn;
			this.headingId = headingIdIn;
			this.headingText = headingTextIn;
			this.Cosine = CosineIn;
			this.SelectedRow = SelectedRowIn;
		}
        
		public static Heading_Cosine Create(string pageIdIn,string headingIdIn,string headingTextIn,string CosineIn,string SelectedRowIn, out string SError){
			SError="";
			Heading_Cosine newHeading_Cosine = new Heading_Cosine();
    		try{
				newHeading_Cosine.UpdateValues(int.Parse(pageIdIn), int.Parse(headingIdIn), headingTextIn, CosineIn, SelectedRowIn);
				newHeading_Cosine.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newHeading_Cosine;
		}
				

		public string Update(string pageIdIn,string headingIdIn,string headingTextIn,string CosineIn,string SelectedRowIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(pageIdIn), int.Parse(headingIdIn), headingTextIn, CosineIn, SelectedRowIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(Heading_Cosine)){
                Heading_Cosine compare=(Heading_Cosine)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.headingCosineID;
        }
        
        public string DescriptorValue()
        {
            return this.headingText.ToString();
        }

        public string DescriptorColumn() {
           	return "headingText";
        }
			

        public static string GetKeyColumn()
        {
            return "headingCosineID";
        }        
        public static string GetDescriptorColumn()
        {
            return "headingText";
        }
        
        #region ' Foreign Keys for Heading_Cosine '
        #endregion
        

        int _headingCosineID;
        [DataMember] 
		public int headingCosineID
        {
            get { return _headingCosineID; }
            set
            {
                if(_headingCosineID!=value){
                    _headingCosineID=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingCosineID");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _pageId;
        [DataMember] 
		public int pageId
        {
            get { return _pageId; }
            set
            {
                if(_pageId!=value){
                    _pageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="pageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _headingId;
        [DataMember] 
		public int headingId
        {
            get { return _headingId; }
            set
            {
                if(_headingId!=value){
                    _headingId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _headingText;
        [DataMember] 
		public string headingText
        {
            get { return _headingText; }
            set
            {
                if(_headingText!=value){
                    _headingText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="headingText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _Cosine;
        [DataMember] 
		public string Cosine
        {
            get { return _Cosine; }
            set
            {
                if(_Cosine!=value){
                    _Cosine=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="Cosine");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _SelectedRow;
        [DataMember] 
		public string SelectedRow
        {
            get { return _SelectedRow; }
            set
            {
                if(_SelectedRow!=value){
                    _SelectedRow=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="SelectedRow");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<Heading_Cosine, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
    
    
    /// <summary>
    /// A class which represents the LinkWithoutHeading table in the InfoArch Database.
    /// </summary>
	[DataContract]
    public partial class LinkWithoutHeading: IActiveRecord
    {
    
        #region Built-in testing
        static TestRepository<LinkWithoutHeading> _testRepo;
        

        
        static void SetTestRepo(){
            _testRepo = _testRepo ?? new TestRepository<LinkWithoutHeading>(new IADAL.InfoArchDB());
        }
        public static void ResetTestRepo(){
            _testRepo = null;
            SetTestRepo();
        }
        public static void Setup(List<LinkWithoutHeading> testlist){
            SetTestRepo();
            _testRepo._items = testlist;
        }
        public static void Setup(LinkWithoutHeading item) {
            SetTestRepo();
            _testRepo._items.Add(item);
        }
        public static void Setup(int testItems) {
            SetTestRepo();
            for(int i=0;i<testItems;i++){
                LinkWithoutHeading item=new LinkWithoutHeading();
                _testRepo._items.Add(item);
            }
        }
        
        public bool TestMode = false;


        #endregion

        IRepository<LinkWithoutHeading> _repo;
        ITable tbl;
        bool _isNew;
        public bool IsNew(){
            return _isNew;
        }
        
        public void SetIsLoaded(bool isLoaded){
            _isLoaded=isLoaded;
            if(isLoaded)
                OnLoaded();
        }
        
        public void SetIsNew(bool isNew){
            _isNew=isNew;
        }
        bool _isLoaded;
        public bool IsLoaded(){
            return _isLoaded;
        }
                
        List<IColumn> _dirtyColumns;
        public bool IsDirty(){
            return _dirtyColumns.Count>0;
        }
        
        public List<IColumn> GetDirtyColumns (){
            return _dirtyColumns;
        }

        IADAL.InfoArchDB _db;
        public LinkWithoutHeading(string connectionString, string providerName) {

            _db=new IADAL.InfoArchDB(connectionString, providerName);
            Init();            
         }
        void Init(){
            TestMode=this._db.DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            _dirtyColumns=new List<IColumn>();
            if(TestMode){
                LinkWithoutHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeading>(_db);
            }
            tbl=_repo.GetTable();
            SetIsNew(true);
            OnCreated();       

        }
        
        public LinkWithoutHeading(){
             _db=new IADAL.InfoArchDB();
            Init();            
        }
        
       
        partial void OnCreated();
            
        partial void OnLoaded();
        
        partial void OnSaved();
        
        partial void OnChanged();
        
        public IList<IColumn> Columns{
            get{
                return tbl.Columns;
            }
        }

        public LinkWithoutHeading(Expression<Func<LinkWithoutHeading, bool>> expression):this() {

            SetIsLoaded(_repo.Load(this,expression));
        }
        
       
        
        internal static IRepository<LinkWithoutHeading> GetRepo(string connectionString, string providerName){
            IADAL.InfoArchDB db;
            if(String.IsNullOrEmpty(connectionString)){
                db=new IADAL.InfoArchDB();
            }else{
                db=new IADAL.InfoArchDB(connectionString, providerName);
            }
            IRepository<LinkWithoutHeading> _repo;
            
            if(db.TestMode){
                LinkWithoutHeading.SetTestRepo();
                _repo=_testRepo;
            }else{
                _repo = new SubSonicRepository<LinkWithoutHeading>(db);
            }
            return _repo;        
        }       
        
        internal static IRepository<LinkWithoutHeading> GetRepo(){
            return GetRepo("","");
        }
        
        public static LinkWithoutHeading SingleOrDefault(Expression<Func<LinkWithoutHeading, bool>> expression) {

            var repo = GetRepo();
            var results=repo.Find(expression);
            LinkWithoutHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
                single.OnLoaded();
                single.SetIsLoaded(true);
                single.SetIsNew(false);
            }

            return single;
        }      
        
        public static LinkWithoutHeading SingleOrDefault(Expression<Func<LinkWithoutHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            var results=repo.Find(expression);
            LinkWithoutHeading single=null;
            if(results.Count() > 0){
                single=results.ToList()[0];
            }

            return single;


        }
        
        
        public static bool Exists(Expression<Func<LinkWithoutHeading, bool>> expression,string connectionString, string providerName) {
           
            return All(connectionString,providerName).Any(expression);
        }        
        public static bool Exists(Expression<Func<LinkWithoutHeading, bool>> expression) {
           
            return All().Any(expression);
        }        

        public static IList<LinkWithoutHeading> Find(Expression<Func<LinkWithoutHeading, bool>> expression) {
            
            var repo = GetRepo();
            return repo.Find(expression).ToList();
        }
        
        public static IList<LinkWithoutHeading> Find(Expression<Func<LinkWithoutHeading, bool>> expression,string connectionString, string providerName) {
            var repo = GetRepo(connectionString,providerName);
            return repo.Find(expression).ToList();
        }
		
		public static IQueryable<LinkWithoutHeading> All(string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetAll();
        }
		
        public static IQueryable<LinkWithoutHeading> All() {
            return GetRepo().GetAll();
        }
                
                public static PagedList<LinkWithoutHeading> GetPaged(string sortBy, int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(sortBy, pageIndex, pageSize);
        }
      
        public static PagedList<LinkWithoutHeading> GetPaged(string sortBy, int pageIndex, int pageSize) {
            return GetRepo().GetPaged(sortBy, pageIndex, pageSize);
        }

        public static PagedList<LinkWithoutHeading> GetPaged(int pageIndex, int pageSize,string connectionString, string providerName) {
            return GetRepo(connectionString,providerName).GetPaged(pageIndex, pageSize);
            
        }


        public static PagedList<LinkWithoutHeading> GetPaged(int pageIndex, int pageSize) {
            return GetRepo().GetPaged(pageIndex, pageSize);
            
        }

        public string KeyName()
        {
            return "LinkId";
        }

        public object KeyValue()
        {
            return this.LinkId;
        }
        
        public void SetKeyValue(object value) {
            if (value != null && value!=DBNull.Value) {
                var settable = value.ChangeTypeTo<int>();
                this.GetType().GetProperty(this.KeyName()).SetValue(this, settable, null);
            }
        }
        
        public override string ToString(){
            return this.LinkAnchorText.ToString();
        }

        public static LinkWithoutHeading RetrieveByKey(int keyValue){
     		return SingleOrDefault(x=>x.LinkId == keyValue);
		}
		
		
		public static LinkWithoutHeading Create(int WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn, out string SError){
			SError="";
 			LinkWithoutHeading newLinkWithoutHeading = new LinkWithoutHeading();
	   		try{
				newLinkWithoutHeading.UpdateValues(WebPageIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn);
				newLinkWithoutHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeading;
		}

		public string Update(int WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn){
     		string SError = "";
			try{
				UpdateValues(WebPageIdIn, LinkAnchorTextIn, LinkUrlIn, ToPageIdIn, VectorTermLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public void UpdateValues(int WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,int ToPageIdIn,string VectorTermLengthIn){
			this.WebPageId = WebPageIdIn;
			this.LinkAnchorText = LinkAnchorTextIn;
			this.LinkUrl = LinkUrlIn;
			this.ToPageId = ToPageIdIn;
			this.VectorTermLength = VectorTermLengthIn;
		}
        
		public static LinkWithoutHeading Create(string WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn, out string SError){
			SError="";
			LinkWithoutHeading newLinkWithoutHeading = new LinkWithoutHeading();
    		try{
				newLinkWithoutHeading.UpdateValues(int.Parse(WebPageIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn);
				newLinkWithoutHeading.Save();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return newLinkWithoutHeading;
		}
				

		public string Update(string WebPageIdIn,string LinkAnchorTextIn,string LinkUrlIn,string ToPageIdIn,string VectorTermLengthIn){
     		string SError = "";
			try{
				UpdateValues(int.Parse(WebPageIdIn), LinkAnchorTextIn, LinkUrlIn, int.Parse(ToPageIdIn), VectorTermLengthIn);
				this.Update();
			}
			catch (Exception ex){
				SError = ex.Message;
			}
			return SError;
		}
		
		public override bool Equals(object obj){
            if(obj.GetType()==typeof(LinkWithoutHeading)){
                LinkWithoutHeading compare=(LinkWithoutHeading)obj;
                return compare.KeyValue()==this.KeyValue();
            }else{
                return base.Equals(obj);
            }
        }

        
        public override int GetHashCode() {
            return this.LinkId;
        }
        
        public string DescriptorValue()
        {
            return this.LinkAnchorText.ToString();
        }

        public string DescriptorColumn() {
           	return "LinkAnchorText";
        }
			

        public static string GetKeyColumn()
        {
            return "LinkId";
        }        
        public static string GetDescriptorColumn()
        {
            return "LinkAnchorText";
        }
        
        #region ' Foreign Keys for LinkWithoutHeading '
        public WebPage WebPageIdAsWebPage // Has One
        {
            get
            {
                
                  var repo=IADAL.WebPage.GetRepo();
                  return repo.Find(x => x.WebPageId  == _WebPageId).SingleOrDefault();
            }
        }

        #endregion
        

        int _LinkId;
        [DataMember] 
		public int LinkId
        {
            get { return _LinkId; }
            set
            {
                if(_LinkId!=value){
                    _LinkId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _WebPageId;
        [DataMember] 
		public int WebPageId
        {
            get { return _WebPageId; }
            set
            {
                if(_WebPageId!=value){
                    _WebPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="WebPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkAnchorText;
        [DataMember] 
		public string LinkAnchorText
        {
            get { return _LinkAnchorText; }
            set
            {
                if(_LinkAnchorText!=value){
                    _LinkAnchorText=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkAnchorText");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _LinkUrl;
        [DataMember] 
		public string LinkUrl
        {
            get { return _LinkUrl; }
            set
            {
                if(_LinkUrl!=value){
                    _LinkUrl=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="LinkUrl");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        int _ToPageId;
        [DataMember] 
		public int ToPageId
        {
            get { return _ToPageId; }
            set
            {
                if(_ToPageId!=value){
                    _ToPageId=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="ToPageId");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }

        string _VectorTermLength;
        [DataMember] 
		public string VectorTermLength
        {
            get { return _VectorTermLength; }
            set
            {
                if(_VectorTermLength!=value){
                    _VectorTermLength=value;
                    var col=tbl.Columns.SingleOrDefault(x=>x.Name=="VectorTermLength");
                    if(col!=null){
                        if(!_dirtyColumns.Any(x=>x.Name==col.Name) && _isLoaded){
                            _dirtyColumns.Add(col);
                        }
                    }
                    OnChanged();
                }
            }
        }



        public DbCommand GetUpdateCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToUpdateQuery(_db.Provider).GetCommand().ToDbCommand();
            
        }
        public DbCommand GetInsertCommand() {
 
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToInsertQuery(_db.Provider).GetCommand().ToDbCommand();
        }
        
        public DbCommand GetDeleteCommand() {
            if(TestMode)
                return _db.DataProvider.CreateCommand();
            else
                return this.ToDeleteQuery(_db.Provider).GetCommand().ToDbCommand();
        }
       
        
        public void Update(){
            Update(_db.DataProvider);
        }
        
        public void Update(IDataProvider provider){
        
            
            if(this._dirtyColumns.Count>0)
                _repo.Update(this,provider);
            OnSaved();
       }
 
        public void Add(){
            Add(_db.DataProvider);
        }
        
        
       
        public void Add(IDataProvider provider){

            
            var key=KeyValue();
            if(key==null){
                var newKey=_repo.Add(this,provider);
                this.SetKeyValue(newKey);
            }else{
                _repo.Add(this,provider);
            }
            SetIsNew(false);
            OnSaved();
        }
        
                
        
        public void Save() {
            Save(_db.DataProvider);
        }      
        public void Save(IDataProvider provider) {
            
           
            if (_isNew) {
                Add(provider);
                
            } else {
                Update(provider);
            }
            
        }

        

        public void Delete(IDataProvider provider) {
                   
                 
            _repo.Delete(KeyValue());
            
                    }


        public void Delete() {
            Delete(_db.DataProvider);
        }


        public static void Delete(Expression<Func<LinkWithoutHeading, bool>> expression) {
            var repo = GetRepo();
            
       
            
            repo.DeleteMany(expression);
            
        }

        

        public void Load(IDataReader rdr) {
            Load(rdr, true);
        }
        public void Load(IDataReader rdr, bool closeReader) {
            if (rdr.Read()) {

                try {
                    rdr.Load(this, null);
                    SetIsNew(false);
                    SetIsLoaded(true);
                } catch {
                    SetIsLoaded(false);
                    throw;
                }
            }else{
                SetIsLoaded(false);
            }

            if (closeReader)
                rdr.Dispose();
        }
        

    } 
	

	
	[DataContract]
	public partial class TemplateOfLinks_Cosine_Columns {
        [DataMember] 
	    public string LinkTemplateId {
           	get{return "LinkTemplateId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkAnchorText {
           	get{return "LinkAnchorText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkUrl {
           	get{return "LinkUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string Cosine {
           	get{return "Cosine";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class WebPage_Columns {
        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebSiteId {
           	get{return "WebSiteId";}
//			set{}
        }
			

        [DataMember] 
	    public string Title {
           	get{return "Title";}
//			set{}
        }
			

        [DataMember] 
	    public string PageTemplate {
           	get{return "PageTemplate";}
//			set{}
        }
			

        [DataMember] 
	    public string Url {
           	get{return "Url";}
//			set{}
        }
			

        [DataMember] 
	    public string Visited {
           	get{return "Visited";}
//			set{}
        }
			

        [DataMember] 
	    public string Source {
           	get{return "Source";}
//			set{}
        }
			

        [DataMember] 
	    public string BestRouteToTop {
           	get{return "BestRouteToTop";}
//			set{}
        }
			

        [DataMember] 
	    public string CountToTop {
           	get{return "CountToTop";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class Heading_Columns {
        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingText {
           	get{return "HeadingText";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLength {
           	get{return "VectorTermLength";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithHeading_Columns {
        [DataMember] 
	    public string LinkId {
           	get{return "LinkId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkAnchorText {
           	get{return "LinkAnchorText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkUrl {
           	get{return "LinkUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLength {
           	get{return "VectorTermLength";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueLinkHeading {
           	get{return "CosineValueLinkHeading";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class Paragraph_Columns {
        [DataMember] 
	    public string ParaId {
           	get{return "ParaId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string ParaText {
           	get{return "ParaText";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueParagraphHeading {
           	get{return "CosineValueParagraphHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingText {
           	get{return "HeadingText";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class WebPageTUB_Columns {
        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebSiteId {
           	get{return "WebSiteId";}
//			set{}
        }
			

        [DataMember] 
	    public string Title {
           	get{return "Title";}
//			set{}
        }
			

        [DataMember] 
	    public string PageTemplate {
           	get{return "PageTemplate";}
//			set{}
        }
			

        [DataMember] 
	    public string Url {
           	get{return "Url";}
//			set{}
        }
			

        [DataMember] 
	    public string Visited {
           	get{return "Visited";}
//			set{}
        }
			

        [DataMember] 
	    public string LwhORLwoh {
           	get{return "LwhORLwoh";}
//			set{}
        }
			

        [DataMember] 
	    public string BestRouteToTop {
           	get{return "BestRouteToTop";}
//			set{}
        }
			

        [DataMember] 
	    public string CountToTop {
           	get{return "CountToTop";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithHeadingTUB_Columns {
        [DataMember] 
	    public string LinkId {
           	get{return "LinkId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkAnchorText {
           	get{return "LinkAnchorText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkUrl {
           	get{return "LinkUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLength {
           	get{return "VectorTermLength";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueLinkHeading {
           	get{return "CosineValueLinkHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string Visited {
           	get{return "Visited";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithoutHeadingTUB_Columns {
        [DataMember] 
	    public string LinkId {
           	get{return "LinkId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkAnchorText {
           	get{return "LinkAnchorText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkUrl {
           	get{return "LinkUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLength {
           	get{return "VectorTermLength";}
//			set{}
        }
			

        [DataMember] 
	    public string Visited {
           	get{return "Visited";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class TemplateOfLinksTUB_Columns {
        [DataMember] 
	    public string LinkTemplateId {
           	get{return "LinkTemplateId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkAnchorText {
           	get{return "LinkAnchorText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkUrl {
           	get{return "LinkUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string TermVectorLengthLinkTemplate {
           	get{return "TermVectorLengthLinkTemplate";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithoutHeadingTemplateOfLinksTUB_Columns {
        [DataMember] 
	    public string LinkWithoutHeadingTemplateOfLinksId {
           	get{return "LinkWithoutHeadingTemplateOfLinksId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string AllLinksOfTemplate {
           	get{return "AllLinksOfTemplate";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class ParagraphTUB_Columns {
        [DataMember] 
	    public string ParaId {
           	get{return "ParaId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string ParaText {
           	get{return "ParaText";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueParagraphHeading {
           	get{return "CosineValueParagraphHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingText {
           	get{return "HeadingText";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class Page_Visited_Unsuccessfully_Columns {
        [DataMember] 
	    public string pageId {
           	get{return "pageId";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithoutHeadingPathAdequacy_Cosine_Columns {
        [DataMember] 
	    public string linkWithoutHeadingPathAdequacyCosineID {
           	get{return "linkWithoutHeadingPathAdequacyCosineID";}
//			set{}
        }
			

        [DataMember] 
	    public string pageId {
           	get{return "pageId";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string pAString {
           	get{return "pAString";}
//			set{}
        }
			

        [DataMember] 
	    public string linkId {
           	get{return "linkId";}
//			set{}
        }
			

        [DataMember] 
	    public string Cosine {
           	get{return "Cosine";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class Goal_Columns {
        [DataMember] 
	    public string text {
           	get{return "text";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkUnderHeadingPathAdequacy_Cosine_Columns {
        [DataMember] 
	    public string linkUnderHeadingPathAdequacyCosineID {
           	get{return "linkUnderHeadingPathAdequacyCosineID";}
//			set{}
        }
			

        [DataMember] 
	    public string pageId {
           	get{return "pageId";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string pAString {
           	get{return "pAString";}
//			set{}
        }
			

        [DataMember] 
	    public string headingId {
           	get{return "headingId";}
//			set{}
        }
			

        [DataMember] 
	    public string linkId {
           	get{return "linkId";}
//			set{}
        }
			

        [DataMember] 
	    public string Cosine {
           	get{return "Cosine";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class PageTemplate_Columns {
        [DataMember] 
	    public string PageTemplateId {
           	get{return "PageTemplateId";}
//			set{}
        }
			

        [DataMember] 
	    public string Pattern {
           	get{return "Pattern";}
//			set{}
        }
			

        [DataMember] 
	    public string Name {
           	get{return "Name";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithoutHeading_Cosine_Columns {
        [DataMember] 
	    public string linkWithoutHeadingCosineID {
           	get{return "linkWithoutHeadingCosineID";}
//			set{}
        }
			

        [DataMember] 
	    public string pageId {
           	get{return "pageId";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string linkId {
           	get{return "linkId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkName {
           	get{return "LinkName";}
//			set{}
        }
			

        [DataMember] 
	    public string Cosine {
           	get{return "Cosine";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkUnderHeading_Cosine_Columns {
        [DataMember] 
	    public string linkUnderHeadingCosineID {
           	get{return "linkUnderHeadingCosineID";}
//			set{}
        }
			

        [DataMember] 
	    public string pageId {
           	get{return "pageId";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string headingId {
           	get{return "headingId";}
//			set{}
        }
			

        [DataMember] 
	    public string headingText {
           	get{return "headingText";}
//			set{}
        }
			

        [DataMember] 
	    public string linkId {
           	get{return "linkId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkName {
           	get{return "LinkName";}
//			set{}
        }
			

        [DataMember] 
	    public string Cosine {
           	get{return "Cosine";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class Path_Columns {
        [DataMember] 
	    public string pathId {
           	get{return "pathId";}
//			set{}
        }
			

        [DataMember] 
	    public string headingId {
           	get{return "headingId";}
//			set{}
        }
			

        [DataMember] 
	    public string linkId {
           	get{return "linkId";}
//			set{}
        }
			

        [DataMember] 
	    public string ThisPageId {
           	get{return "ThisPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string PreviousCosine {
           	get{return "PreviousCosine";}
//			set{}
        }
			

        [DataMember] 
	    public string NewCosine {
           	get{return "NewCosine";}
//			set{}
        }
			

        [DataMember] 
	    public string PathChoosen {
           	get{return "PathChoosen";}
//			set{}
        }
			

        [DataMember] 
	    public string PreviousRow {
           	get{return "PreviousRow";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class Solution_Found_Columns {
        [DataMember] 
	    public string solutionFoundId {
           	get{return "solutionFoundId";}
//			set{}
        }
			

        [DataMember] 
	    public string pageId {
           	get{return "pageId";}
//			set{}
        }
			

        [DataMember] 
	    public string topageId {
           	get{return "topageId";}
//			set{}
        }
			

        [DataMember] 
	    public string headingId {
           	get{return "headingId";}
//			set{}
        }
			

        [DataMember] 
	    public string pathIdinPathTable {
           	get{return "pathIdinPathTable";}
//			set{}
        }
			

        [DataMember] 
	    public string paragraphId {
           	get{return "paragraphId";}
//			set{}
        }
			

        [DataMember] 
	    public string paragraphText {
           	get{return "paragraphText";}
//			set{}
        }
			

        [DataMember] 
	    public string cosine {
           	get{return "cosine";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class HeadingModified_Columns {
        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingText {
           	get{return "HeadingText";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLength {
           	get{return "VectorTermLength";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithHeadingTUBSModified_Columns {
        [DataMember] 
	    public string LinkId {
           	get{return "LinkId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkAnchorText {
           	get{return "LinkAnchorText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkUrl {
           	get{return "LinkUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLength {
           	get{return "VectorTermLength";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueLinkHeading {
           	get{return "CosineValueLinkHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string Visited {
           	get{return "Visited";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithoutHeadingTUBSModified_Columns {
        [DataMember] 
	    public string LinkId {
           	get{return "LinkId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkAnchorText {
           	get{return "LinkAnchorText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkUrl {
           	get{return "LinkUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLength {
           	get{return "VectorTermLength";}
//			set{}
        }
			

        [DataMember] 
	    public string Visited {
           	get{return "Visited";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class CosineLinkLinkWithHeadingTUB_Columns {
        [DataMember] 
	    public string CosineLinkLinkWithHeadingId {
           	get{return "CosineLinkLinkWithHeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkXId {
           	get{return "LinkXId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkYId {
           	get{return "LinkYId";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueLinkLinkWithHeading {
           	get{return "CosineValueLinkLinkWithHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string WebpageId {
           	get{return "WebpageId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkXText {
           	get{return "LinkXText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkYText {
           	get{return "LinkYText";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class HeadingvsHeadinginSamePageCosinesTUB_Columns {
        [DataMember] 
	    public string headingvsheadingId {
           	get{return "headingvsheadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebpageId {
           	get{return "WebpageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingXId {
           	get{return "HeadingXId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingYId {
           	get{return "HeadingYId";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueHeadingvsHeading {
           	get{return "CosineValueHeadingvsHeading";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class HeadingTUBSTVL_Columns {
        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingText {
           	get{return "HeadingText";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLength {
           	get{return "VectorTermLength";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class HeadingvsHeadinginSamePageCosine_Columns {
        [DataMember] 
	    public string headingvsheadingId {
           	get{return "headingvsheadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebpageId {
           	get{return "WebpageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingXId {
           	get{return "HeadingXId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingYId {
           	get{return "HeadingYId";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueHeadingvsHeading {
           	get{return "CosineValueHeadingvsHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingXLinkText {
           	get{return "HeadingXLinkText";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingYLInkText {
           	get{return "HeadingYLInkText";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class CosineLinkLinkWithoutHeadingTUB_Columns {
        [DataMember] 
	    public string CosineLinkLinkWithoutHeadingId {
           	get{return "CosineLinkLinkWithoutHeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkXId {
           	get{return "LinkXId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkYId {
           	get{return "LinkYId";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueLinkLinkWithoutHeading {
           	get{return "CosineValueLinkLinkWithoutHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class Paragraph_Cosine_Columns {
        [DataMember] 
	    public string ParagraphCosineId {
           	get{return "ParagraphCosineId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string ParaId {
           	get{return "ParaId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string ParaText {
           	get{return "ParaText";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineParaAgainstGoal {
           	get{return "CosineParaAgainstGoal";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class HeadingPathAdequacy_Cosine_Columns {
        [DataMember] 
	    public string headingPathAdequacyCosineID {
           	get{return "headingPathAdequacyCosineID";}
//			set{}
        }
			

        [DataMember] 
	    public string pAString {
           	get{return "pAString";}
//			set{}
        }
			

        [DataMember] 
	    public string pageId {
           	get{return "pageId";}
//			set{}
        }
			

        [DataMember] 
	    public string headingId {
           	get{return "headingId";}
//			set{}
        }
			

        [DataMember] 
	    public string Cosine {
           	get{return "Cosine";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkLinkTemplateOfLink_Columns {
        [DataMember] 
	    public string LinkLinkTemplateOfLinksId {
           	get{return "LinkLinkTemplateOfLinksId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkXId {
           	get{return "LinkXId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkYId {
           	get{return "LinkYId";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineLinkLinkTemplateOfLinks {
           	get{return "CosineLinkLinkTemplateOfLinks";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithoutHeadingTemplateOfLink_Columns {
        [DataMember] 
	    public string LinkWithoutHeadingTemplateOfLinksId {
           	get{return "LinkWithoutHeadingTemplateOfLinksId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string AllLinksOfTemplate {
           	get{return "AllLinksOfTemplate";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class TemplateOfLink_Columns {
        [DataMember] 
	    public string LinkTemplateId {
           	get{return "LinkTemplateId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkAnchorText {
           	get{return "LinkAnchorText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkUrl {
           	get{return "LinkUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string TermVectorLengthLinkTemplate {
           	get{return "TermVectorLengthLinkTemplate";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class AnImage_Columns {
        [DataMember] 
	    public string ImgId {
           	get{return "ImgId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string ImageAltText {
           	get{return "ImageAltText";}
//			set{}
        }
			

        [DataMember] 
	    public string ImageUrl {
           	get{return "ImageUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ImagePicture {
           	get{return "ImagePicture";}
//			set{}
        }
			

        [DataMember] 
	    public string CosienValueImageHeading {
           	get{return "CosienValueImageHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string TermVectorLength {
           	get{return "TermVectorLength";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class AnImageWithoutHeading_Columns {
        [DataMember] 
	    public string ImageWithoutHeadingId {
           	get{return "ImageWithoutHeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string ImageUrl {
           	get{return "ImageUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLegnth {
           	get{return "VectorTermLegnth";}
//			set{}
        }
			

        [DataMember] 
	    public string ImageAltText {
           	get{return "ImageAltText";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class CosineImageImageUnderSameHeading_Columns {
        [DataMember] 
	    public string CosineImageImageUnderHeadingId {
           	get{return "CosineImageImageUnderHeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string ImageXId {
           	get{return "ImageXId";}
//			set{}
        }
			

        [DataMember] 
	    public string ImageYId {
           	get{return "ImageYId";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueImageImageWithHeading {
           	get{return "CosineValueImageImageWithHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string WebpageId {
           	get{return "WebpageId";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class CosineImageImageWithoutHeading_Columns {
        [DataMember] 
	    public string CosineImageImageWithoutHeadingId {
           	get{return "CosineImageImageWithoutHeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string ImageXId {
           	get{return "ImageXId";}
//			set{}
        }
			

        [DataMember] 
	    public string ImageYId {
           	get{return "ImageYId";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueImageImageWithoutHeading {
           	get{return "CosineValueImageImageWithoutHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class CosineLinkLinkWithoutHeading_Columns {
        [DataMember] 
	    public string CosineLinkLinkWithoutHeadingId {
           	get{return "CosineLinkLinkWithoutHeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkXId {
           	get{return "LinkXId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkYId {
           	get{return "LinkYId";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueLinkLinkWithoutHeading {
           	get{return "CosineValueLinkLinkWithoutHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class CosineLinkLinkWithHeading_Columns {
        [DataMember] 
	    public string CosineLinkLinkWithHeadingId {
           	get{return "CosineLinkLinkWithHeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string HeadingId {
           	get{return "HeadingId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkXId {
           	get{return "LinkXId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkYId {
           	get{return "LinkYId";}
//			set{}
        }
			

        [DataMember] 
	    public string CosineValueLinkLinkWithHeading {
           	get{return "CosineValueLinkLinkWithHeading";}
//			set{}
        }
			

        [DataMember] 
	    public string WebpageId {
           	get{return "WebpageId";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class WebSite_Columns {
        [DataMember] 
	    public string WebSiteId {
           	get{return "WebSiteId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebSiteName {
           	get{return "WebSiteName";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class Heading_Cosine_Columns {
        [DataMember] 
	    public string headingCosineID {
           	get{return "headingCosineID";}
//			set{}
        }
			

        [DataMember] 
	    public string pageId {
           	get{return "pageId";}
//			set{}
        }
			

        [DataMember] 
	    public string headingId {
           	get{return "headingId";}
//			set{}
        }
			

        [DataMember] 
	    public string headingText {
           	get{return "headingText";}
//			set{}
        }
			

        [DataMember] 
	    public string Cosine {
           	get{return "Cosine";}
//			set{}
        }
			

        [DataMember] 
	    public string SelectedRow {
           	get{return "SelectedRow";}
//			set{}
        }
			

}	
	[DataContract]
	public partial class LinkWithoutHeading_Columns {
        [DataMember] 
	    public string LinkId {
           	get{return "LinkId";}
//			set{}
        }
			

        [DataMember] 
	    public string WebPageId {
           	get{return "WebPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkAnchorText {
           	get{return "LinkAnchorText";}
//			set{}
        }
			

        [DataMember] 
	    public string LinkUrl {
           	get{return "LinkUrl";}
//			set{}
        }
			

        [DataMember] 
	    public string ToPageId {
           	get{return "ToPageId";}
//			set{}
        }
			

        [DataMember] 
	    public string VectorTermLength {
           	get{return "VectorTermLength";}
//			set{}
        }
			

}	
}