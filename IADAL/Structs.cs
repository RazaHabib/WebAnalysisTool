


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace IADAL {
	
        /// <summary>
        /// Table: TemplateOfLinks_Cosine
        /// Primary Key: LinkTemplateId
        /// </summary>

        public class TemplateOfLinks_CosineTable: DatabaseTable {
            
            public TemplateOfLinks_CosineTable(IDataProvider provider):base("TemplateOfLinks_Cosine",provider){
                ClassName = "TemplateOfLinks_Cosine";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkTemplateId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkAnchorText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Cosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn LinkTemplateId{
                get{
                    return this.GetColumn("LinkTemplateId");
                }
            }
				
   			public static string LinkTemplateIdColumn{
			      get{
        			return "LinkTemplateId";
      			}
		    }
            
            public IColumn LinkAnchorText{
                get{
                    return this.GetColumn("LinkAnchorText");
                }
            }
				
   			public static string LinkAnchorTextColumn{
			      get{
        			return "LinkAnchorText";
      			}
		    }
            
            public IColumn LinkUrl{
                get{
                    return this.GetColumn("LinkUrl");
                }
            }
				
   			public static string LinkUrlColumn{
			      get{
        			return "LinkUrl";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn Cosine{
                get{
                    return this.GetColumn("Cosine");
                }
            }
				
   			public static string CosineColumn{
			      get{
        			return "Cosine";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: WebPage
        /// Primary Key: WebPageId
        /// </summary>

        public class WebPageTable: DatabaseTable {
            
            public WebPageTable(IDataProvider provider):base("WebPage",provider){
                ClassName = "WebPage";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebSiteId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("PageTemplate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Url", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Visited", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Source", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("BestRouteToTop", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountToTop", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn WebSiteId{
                get{
                    return this.GetColumn("WebSiteId");
                }
            }
				
   			public static string WebSiteIdColumn{
			      get{
        			return "WebSiteId";
      			}
		    }
            
            public IColumn Title{
                get{
                    return this.GetColumn("Title");
                }
            }
				
   			public static string TitleColumn{
			      get{
        			return "Title";
      			}
		    }
            
            public IColumn PageTemplate{
                get{
                    return this.GetColumn("PageTemplate");
                }
            }
				
   			public static string PageTemplateColumn{
			      get{
        			return "PageTemplate";
      			}
		    }
            
            public IColumn Url{
                get{
                    return this.GetColumn("Url");
                }
            }
				
   			public static string UrlColumn{
			      get{
        			return "Url";
      			}
		    }
            
            public IColumn Visited{
                get{
                    return this.GetColumn("Visited");
                }
            }
				
   			public static string VisitedColumn{
			      get{
        			return "Visited";
      			}
		    }
            
            public IColumn Source{
                get{
                    return this.GetColumn("Source");
                }
            }
				
   			public static string SourceColumn{
			      get{
        			return "Source";
      			}
		    }
            
            public IColumn BestRouteToTop{
                get{
                    return this.GetColumn("BestRouteToTop");
                }
            }
				
   			public static string BestRouteToTopColumn{
			      get{
        			return "BestRouteToTop";
      			}
		    }
            
            public IColumn CountToTop{
                get{
                    return this.GetColumn("CountToTop");
                }
            }
				
   			public static string CountToTopColumn{
			      get{
        			return "CountToTop";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Heading
        /// Primary Key: HeadingId
        /// </summary>

        public class HeadingTable: DatabaseTable {
            
            public HeadingTable(IDataProvider provider):base("Heading",provider){
                ClassName = "Heading";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("VectorTermLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn HeadingText{
                get{
                    return this.GetColumn("HeadingText");
                }
            }
				
   			public static string HeadingTextColumn{
			      get{
        			return "HeadingText";
      			}
		    }
            
            public IColumn VectorTermLength{
                get{
                    return this.GetColumn("VectorTermLength");
                }
            }
				
   			public static string VectorTermLengthColumn{
			      get{
        			return "VectorTermLength";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithHeading
        /// Primary Key: LinkId
        /// </summary>

        public class LinkWithHeadingTable: DatabaseTable {
            
            public LinkWithHeadingTable(IDataProvider provider):base("LinkWithHeading",provider){
                ClassName = "LinkWithHeading";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkAnchorText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VectorTermLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CosineValueLinkHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn LinkId{
                get{
                    return this.GetColumn("LinkId");
                }
            }
				
   			public static string LinkIdColumn{
			      get{
        			return "LinkId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn LinkAnchorText{
                get{
                    return this.GetColumn("LinkAnchorText");
                }
            }
				
   			public static string LinkAnchorTextColumn{
			      get{
        			return "LinkAnchorText";
      			}
		    }
            
            public IColumn LinkUrl{
                get{
                    return this.GetColumn("LinkUrl");
                }
            }
				
   			public static string LinkUrlColumn{
			      get{
        			return "LinkUrl";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn VectorTermLength{
                get{
                    return this.GetColumn("VectorTermLength");
                }
            }
				
   			public static string VectorTermLengthColumn{
			      get{
        			return "VectorTermLength";
      			}
		    }
            
            public IColumn CosineValueLinkHeading{
                get{
                    return this.GetColumn("CosineValueLinkHeading");
                }
            }
				
   			public static string CosineValueLinkHeadingColumn{
			      get{
        			return "CosineValueLinkHeading";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Paragraph
        /// Primary Key: ParaId
        /// </summary>

        public class ParagraphTable: DatabaseTable {
            
            public ParagraphTable(IDataProvider provider):base("Paragraph",provider){
                ClassName = "Paragraph";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ParaId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ParaText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CosineValueParagraphHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("HeadingText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn ParaId{
                get{
                    return this.GetColumn("ParaId");
                }
            }
				
   			public static string ParaIdColumn{
			      get{
        			return "ParaId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn ParaText{
                get{
                    return this.GetColumn("ParaText");
                }
            }
				
   			public static string ParaTextColumn{
			      get{
        			return "ParaText";
      			}
		    }
            
            public IColumn CosineValueParagraphHeading{
                get{
                    return this.GetColumn("CosineValueParagraphHeading");
                }
            }
				
   			public static string CosineValueParagraphHeadingColumn{
			      get{
        			return "CosineValueParagraphHeading";
      			}
		    }
            
            public IColumn HeadingText{
                get{
                    return this.GetColumn("HeadingText");
                }
            }
				
   			public static string HeadingTextColumn{
			      get{
        			return "HeadingText";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: WebPageTUBS
        /// Primary Key: WebPageId
        /// </summary>

        public class WebPageTUBSTable: DatabaseTable {
            
            public WebPageTUBSTable(IDataProvider provider):base("WebPageTUBS",provider){
                ClassName = "WebPageTUB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebSiteId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("PageTemplate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Url", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Visited", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LwhORLwoh", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("BestRouteToTop", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountToTop", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn WebSiteId{
                get{
                    return this.GetColumn("WebSiteId");
                }
            }
				
   			public static string WebSiteIdColumn{
			      get{
        			return "WebSiteId";
      			}
		    }
            
            public IColumn Title{
                get{
                    return this.GetColumn("Title");
                }
            }
				
   			public static string TitleColumn{
			      get{
        			return "Title";
      			}
		    }
            
            public IColumn PageTemplate{
                get{
                    return this.GetColumn("PageTemplate");
                }
            }
				
   			public static string PageTemplateColumn{
			      get{
        			return "PageTemplate";
      			}
		    }
            
            public IColumn Url{
                get{
                    return this.GetColumn("Url");
                }
            }
				
   			public static string UrlColumn{
			      get{
        			return "Url";
      			}
		    }
            
            public IColumn Visited{
                get{
                    return this.GetColumn("Visited");
                }
            }
				
   			public static string VisitedColumn{
			      get{
        			return "Visited";
      			}
		    }
            
            public IColumn LwhORLwoh{
                get{
                    return this.GetColumn("LwhORLwoh");
                }
            }
				
   			public static string LwhORLwohColumn{
			      get{
        			return "LwhORLwoh";
      			}
		    }
            
            public IColumn BestRouteToTop{
                get{
                    return this.GetColumn("BestRouteToTop");
                }
            }
				
   			public static string BestRouteToTopColumn{
			      get{
        			return "BestRouteToTop";
      			}
		    }
            
            public IColumn CountToTop{
                get{
                    return this.GetColumn("CountToTop");
                }
            }
				
   			public static string CountToTopColumn{
			      get{
        			return "CountToTop";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithHeadingTUBS
        /// Primary Key: LinkId
        /// </summary>

        public class LinkWithHeadingTUBSTable: DatabaseTable {
            
            public LinkWithHeadingTUBSTable(IDataProvider provider):base("LinkWithHeadingTUBS",provider){
                ClassName = "LinkWithHeadingTUB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkAnchorText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VectorTermLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CosineValueLinkHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Visited", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn LinkId{
                get{
                    return this.GetColumn("LinkId");
                }
            }
				
   			public static string LinkIdColumn{
			      get{
        			return "LinkId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn LinkAnchorText{
                get{
                    return this.GetColumn("LinkAnchorText");
                }
            }
				
   			public static string LinkAnchorTextColumn{
			      get{
        			return "LinkAnchorText";
      			}
		    }
            
            public IColumn LinkUrl{
                get{
                    return this.GetColumn("LinkUrl");
                }
            }
				
   			public static string LinkUrlColumn{
			      get{
        			return "LinkUrl";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn VectorTermLength{
                get{
                    return this.GetColumn("VectorTermLength");
                }
            }
				
   			public static string VectorTermLengthColumn{
			      get{
        			return "VectorTermLength";
      			}
		    }
            
            public IColumn CosineValueLinkHeading{
                get{
                    return this.GetColumn("CosineValueLinkHeading");
                }
            }
				
   			public static string CosineValueLinkHeadingColumn{
			      get{
        			return "CosineValueLinkHeading";
      			}
		    }
            
            public IColumn Visited{
                get{
                    return this.GetColumn("Visited");
                }
            }
				
   			public static string VisitedColumn{
			      get{
        			return "Visited";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithoutHeadingTUBS
        /// Primary Key: LinkId
        /// </summary>

        public class LinkWithoutHeadingTUBSTable: DatabaseTable {
            
            public LinkWithoutHeadingTUBSTable(IDataProvider provider):base("LinkWithoutHeadingTUBS",provider){
                ClassName = "LinkWithoutHeadingTUB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkAnchorText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VectorTermLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Visited", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn LinkId{
                get{
                    return this.GetColumn("LinkId");
                }
            }
				
   			public static string LinkIdColumn{
			      get{
        			return "LinkId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn LinkAnchorText{
                get{
                    return this.GetColumn("LinkAnchorText");
                }
            }
				
   			public static string LinkAnchorTextColumn{
			      get{
        			return "LinkAnchorText";
      			}
		    }
            
            public IColumn LinkUrl{
                get{
                    return this.GetColumn("LinkUrl");
                }
            }
				
   			public static string LinkUrlColumn{
			      get{
        			return "LinkUrl";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn VectorTermLength{
                get{
                    return this.GetColumn("VectorTermLength");
                }
            }
				
   			public static string VectorTermLengthColumn{
			      get{
        			return "VectorTermLength";
      			}
		    }
            
            public IColumn Visited{
                get{
                    return this.GetColumn("Visited");
                }
            }
				
   			public static string VisitedColumn{
			      get{
        			return "Visited";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: TemplateOfLinksTUBS
        /// Primary Key: LinkTemplateId
        /// </summary>

        public class TemplateOfLinksTUBSTable: DatabaseTable {
            
            public TemplateOfLinksTUBSTable(IDataProvider provider):base("TemplateOfLinksTUBS",provider){
                ClassName = "TemplateOfLinksTUB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkTemplateId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkAnchorText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TermVectorLengthLinkTemplate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn LinkTemplateId{
                get{
                    return this.GetColumn("LinkTemplateId");
                }
            }
				
   			public static string LinkTemplateIdColumn{
			      get{
        			return "LinkTemplateId";
      			}
		    }
            
            public IColumn LinkAnchorText{
                get{
                    return this.GetColumn("LinkAnchorText");
                }
            }
				
   			public static string LinkAnchorTextColumn{
			      get{
        			return "LinkAnchorText";
      			}
		    }
            
            public IColumn LinkUrl{
                get{
                    return this.GetColumn("LinkUrl");
                }
            }
				
   			public static string LinkUrlColumn{
			      get{
        			return "LinkUrl";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn TermVectorLengthLinkTemplate{
                get{
                    return this.GetColumn("TermVectorLengthLinkTemplate");
                }
            }
				
   			public static string TermVectorLengthLinkTemplateColumn{
			      get{
        			return "TermVectorLengthLinkTemplate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithoutHeadingTemplateOfLinksTUBS
        /// Primary Key: LinkWithoutHeadingTemplateOfLinksId
        /// </summary>

        public class LinkWithoutHeadingTemplateOfLinksTUBSTable: DatabaseTable {
            
            public LinkWithoutHeadingTemplateOfLinksTUBSTable(IDataProvider provider):base("LinkWithoutHeadingTemplateOfLinksTUBS",provider){
                ClassName = "LinkWithoutHeadingTemplateOfLinksTUB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkWithoutHeadingTemplateOfLinksId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AllLinksOfTemplate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn LinkWithoutHeadingTemplateOfLinksId{
                get{
                    return this.GetColumn("LinkWithoutHeadingTemplateOfLinksId");
                }
            }
				
   			public static string LinkWithoutHeadingTemplateOfLinksIdColumn{
			      get{
        			return "LinkWithoutHeadingTemplateOfLinksId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn AllLinksOfTemplate{
                get{
                    return this.GetColumn("AllLinksOfTemplate");
                }
            }
				
   			public static string AllLinksOfTemplateColumn{
			      get{
        			return "AllLinksOfTemplate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ParagraphTUBS
        /// Primary Key: ParaId
        /// </summary>

        public class ParagraphTUBSTable: DatabaseTable {
            
            public ParagraphTUBSTable(IDataProvider provider):base("ParagraphTUBS",provider){
                ClassName = "ParagraphTUB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ParaId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ParaText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CosineValueParagraphHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("HeadingText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn ParaId{
                get{
                    return this.GetColumn("ParaId");
                }
            }
				
   			public static string ParaIdColumn{
			      get{
        			return "ParaId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn ParaText{
                get{
                    return this.GetColumn("ParaText");
                }
            }
				
   			public static string ParaTextColumn{
			      get{
        			return "ParaText";
      			}
		    }
            
            public IColumn CosineValueParagraphHeading{
                get{
                    return this.GetColumn("CosineValueParagraphHeading");
                }
            }
				
   			public static string CosineValueParagraphHeadingColumn{
			      get{
        			return "CosineValueParagraphHeading";
      			}
		    }
            
            public IColumn HeadingText{
                get{
                    return this.GetColumn("HeadingText");
                }
            }
				
   			public static string HeadingTextColumn{
			      get{
        			return "HeadingText";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Page_Visited_Unsuccessfully
        /// Primary Key: 
        /// </summary>

        public class Page_Visited_UnsuccessfullyTable: DatabaseTable {
            
            public Page_Visited_UnsuccessfullyTable(IDataProvider provider):base("Page_Visited_Unsuccessfully",provider){
                ClassName = "Page_Visited_Unsuccessfully";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("pageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn pageId{
                get{
                    return this.GetColumn("pageId");
                }
            }
				
   			public static string pageIdColumn{
			      get{
        			return "pageId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithoutHeadingPathAdequacy_Cosine
        /// Primary Key: linkWithoutHeadingPathAdequacyCosineID
        /// </summary>

        public class LinkWithoutHeadingPathAdequacy_CosineTable: DatabaseTable {
            
            public LinkWithoutHeadingPathAdequacy_CosineTable(IDataProvider provider):base("LinkWithoutHeadingPathAdequacy_Cosine",provider){
                ClassName = "LinkWithoutHeadingPathAdequacy_Cosine";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("linkWithoutHeadingPathAdequacyCosineID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pAString", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("linkId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Cosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn linkWithoutHeadingPathAdequacyCosineID{
                get{
                    return this.GetColumn("linkWithoutHeadingPathAdequacyCosineID");
                }
            }
				
   			public static string linkWithoutHeadingPathAdequacyCosineIDColumn{
			      get{
        			return "linkWithoutHeadingPathAdequacyCosineID";
      			}
		    }
            
            public IColumn pageId{
                get{
                    return this.GetColumn("pageId");
                }
            }
				
   			public static string pageIdColumn{
			      get{
        			return "pageId";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn pAString{
                get{
                    return this.GetColumn("pAString");
                }
            }
				
   			public static string pAStringColumn{
			      get{
        			return "pAString";
      			}
		    }
            
            public IColumn linkId{
                get{
                    return this.GetColumn("linkId");
                }
            }
				
   			public static string linkIdColumn{
			      get{
        			return "linkId";
      			}
		    }
            
            public IColumn Cosine{
                get{
                    return this.GetColumn("Cosine");
                }
            }
				
   			public static string CosineColumn{
			      get{
        			return "Cosine";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Goal
        /// Primary Key: 
        /// </summary>

        public class GoalTable: DatabaseTable {
            
            public GoalTable(IDataProvider provider):base("Goal",provider){
                ClassName = "Goal";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("text", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn text{
                get{
                    return this.GetColumn("text");
                }
            }
				
   			public static string textColumn{
			      get{
        			return "text";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkUnderHeadingPathAdequacy_Cosine
        /// Primary Key: linkUnderHeadingPathAdequacyCosineID
        /// </summary>

        public class LinkUnderHeadingPathAdequacy_CosineTable: DatabaseTable {
            
            public LinkUnderHeadingPathAdequacy_CosineTable(IDataProvider provider):base("LinkUnderHeadingPathAdequacy_Cosine",provider){
                ClassName = "LinkUnderHeadingPathAdequacy_Cosine";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("linkUnderHeadingPathAdequacyCosineID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pAString", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("headingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("linkId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Cosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn linkUnderHeadingPathAdequacyCosineID{
                get{
                    return this.GetColumn("linkUnderHeadingPathAdequacyCosineID");
                }
            }
				
   			public static string linkUnderHeadingPathAdequacyCosineIDColumn{
			      get{
        			return "linkUnderHeadingPathAdequacyCosineID";
      			}
		    }
            
            public IColumn pageId{
                get{
                    return this.GetColumn("pageId");
                }
            }
				
   			public static string pageIdColumn{
			      get{
        			return "pageId";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn pAString{
                get{
                    return this.GetColumn("pAString");
                }
            }
				
   			public static string pAStringColumn{
			      get{
        			return "pAString";
      			}
		    }
            
            public IColumn headingId{
                get{
                    return this.GetColumn("headingId");
                }
            }
				
   			public static string headingIdColumn{
			      get{
        			return "headingId";
      			}
		    }
            
            public IColumn linkId{
                get{
                    return this.GetColumn("linkId");
                }
            }
				
   			public static string linkIdColumn{
			      get{
        			return "linkId";
      			}
		    }
            
            public IColumn Cosine{
                get{
                    return this.GetColumn("Cosine");
                }
            }
				
   			public static string CosineColumn{
			      get{
        			return "Cosine";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: PageTemplate
        /// Primary Key: PageTemplateId
        /// </summary>

        public class PageTemplateTable: DatabaseTable {
            
            public PageTemplateTable(IDataProvider provider):base("PageTemplate",provider){
                ClassName = "PageTemplate";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PageTemplateId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Pattern", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 4000
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }
            
            public IColumn PageTemplateId{
                get{
                    return this.GetColumn("PageTemplateId");
                }
            }
				
   			public static string PageTemplateIdColumn{
			      get{
        			return "PageTemplateId";
      			}
		    }
            
            public IColumn Pattern{
                get{
                    return this.GetColumn("Pattern");
                }
            }
				
   			public static string PatternColumn{
			      get{
        			return "Pattern";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithoutHeading_Cosine
        /// Primary Key: linkWithoutHeadingCosineID
        /// </summary>

        public class LinkWithoutHeading_CosineTable: DatabaseTable {
            
            public LinkWithoutHeading_CosineTable(IDataProvider provider):base("LinkWithoutHeading_Cosine",provider){
                ClassName = "LinkWithoutHeading_Cosine";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("linkWithoutHeadingCosineID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("linkId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Cosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn linkWithoutHeadingCosineID{
                get{
                    return this.GetColumn("linkWithoutHeadingCosineID");
                }
            }
				
   			public static string linkWithoutHeadingCosineIDColumn{
			      get{
        			return "linkWithoutHeadingCosineID";
      			}
		    }
            
            public IColumn pageId{
                get{
                    return this.GetColumn("pageId");
                }
            }
				
   			public static string pageIdColumn{
			      get{
        			return "pageId";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn linkId{
                get{
                    return this.GetColumn("linkId");
                }
            }
				
   			public static string linkIdColumn{
			      get{
        			return "linkId";
      			}
		    }
            
            public IColumn LinkName{
                get{
                    return this.GetColumn("LinkName");
                }
            }
				
   			public static string LinkNameColumn{
			      get{
        			return "LinkName";
      			}
		    }
            
            public IColumn Cosine{
                get{
                    return this.GetColumn("Cosine");
                }
            }
				
   			public static string CosineColumn{
			      get{
        			return "Cosine";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkUnderHeading_Cosine
        /// Primary Key: linkUnderHeadingCosineID
        /// </summary>

        public class LinkUnderHeading_CosineTable: DatabaseTable {
            
            public LinkUnderHeading_CosineTable(IDataProvider provider):base("LinkUnderHeading_Cosine",provider){
                ClassName = "LinkUnderHeading_Cosine";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("linkUnderHeadingCosineID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("headingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("headingText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("linkId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Cosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn linkUnderHeadingCosineID{
                get{
                    return this.GetColumn("linkUnderHeadingCosineID");
                }
            }
				
   			public static string linkUnderHeadingCosineIDColumn{
			      get{
        			return "linkUnderHeadingCosineID";
      			}
		    }
            
            public IColumn pageId{
                get{
                    return this.GetColumn("pageId");
                }
            }
				
   			public static string pageIdColumn{
			      get{
        			return "pageId";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn headingId{
                get{
                    return this.GetColumn("headingId");
                }
            }
				
   			public static string headingIdColumn{
			      get{
        			return "headingId";
      			}
		    }
            
            public IColumn headingText{
                get{
                    return this.GetColumn("headingText");
                }
            }
				
   			public static string headingTextColumn{
			      get{
        			return "headingText";
      			}
		    }
            
            public IColumn linkId{
                get{
                    return this.GetColumn("linkId");
                }
            }
				
   			public static string linkIdColumn{
			      get{
        			return "linkId";
      			}
		    }
            
            public IColumn LinkName{
                get{
                    return this.GetColumn("LinkName");
                }
            }
				
   			public static string LinkNameColumn{
			      get{
        			return "LinkName";
      			}
		    }
            
            public IColumn Cosine{
                get{
                    return this.GetColumn("Cosine");
                }
            }
				
   			public static string CosineColumn{
			      get{
        			return "Cosine";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Path
        /// Primary Key: pathId
        /// </summary>

        public class PathTable: DatabaseTable {
            
            public PathTable(IDataProvider provider):base("Path",provider){
                ClassName = "Path";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("pathId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("headingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("linkId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ThisPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PreviousCosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("NewCosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("PathChoosen", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("PreviousRow", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn pathId{
                get{
                    return this.GetColumn("pathId");
                }
            }
				
   			public static string pathIdColumn{
			      get{
        			return "pathId";
      			}
		    }
            
            public IColumn headingId{
                get{
                    return this.GetColumn("headingId");
                }
            }
				
   			public static string headingIdColumn{
			      get{
        			return "headingId";
      			}
		    }
            
            public IColumn linkId{
                get{
                    return this.GetColumn("linkId");
                }
            }
				
   			public static string linkIdColumn{
			      get{
        			return "linkId";
      			}
		    }
            
            public IColumn ThisPageId{
                get{
                    return this.GetColumn("ThisPageId");
                }
            }
				
   			public static string ThisPageIdColumn{
			      get{
        			return "ThisPageId";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn PreviousCosine{
                get{
                    return this.GetColumn("PreviousCosine");
                }
            }
				
   			public static string PreviousCosineColumn{
			      get{
        			return "PreviousCosine";
      			}
		    }
            
            public IColumn NewCosine{
                get{
                    return this.GetColumn("NewCosine");
                }
            }
				
   			public static string NewCosineColumn{
			      get{
        			return "NewCosine";
      			}
		    }
            
            public IColumn PathChoosen{
                get{
                    return this.GetColumn("PathChoosen");
                }
            }
				
   			public static string PathChoosenColumn{
			      get{
        			return "PathChoosen";
      			}
		    }
            
            public IColumn PreviousRow{
                get{
                    return this.GetColumn("PreviousRow");
                }
            }
				
   			public static string PreviousRowColumn{
			      get{
        			return "PreviousRow";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Solution_Found
        /// Primary Key: solutionFoundId
        /// </summary>

        public class Solution_FoundTable: DatabaseTable {
            
            public Solution_FoundTable(IDataProvider provider):base("Solution_Found",provider){
                ClassName = "Solution_Found";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("solutionFoundId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("topageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("headingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pathIdinPathTable", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("paragraphId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("paragraphText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("cosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn solutionFoundId{
                get{
                    return this.GetColumn("solutionFoundId");
                }
            }
				
   			public static string solutionFoundIdColumn{
			      get{
        			return "solutionFoundId";
      			}
		    }
            
            public IColumn pageId{
                get{
                    return this.GetColumn("pageId");
                }
            }
				
   			public static string pageIdColumn{
			      get{
        			return "pageId";
      			}
		    }
            
            public IColumn topageId{
                get{
                    return this.GetColumn("topageId");
                }
            }
				
   			public static string topageIdColumn{
			      get{
        			return "topageId";
      			}
		    }
            
            public IColumn headingId{
                get{
                    return this.GetColumn("headingId");
                }
            }
				
   			public static string headingIdColumn{
			      get{
        			return "headingId";
      			}
		    }
            
            public IColumn pathIdinPathTable{
                get{
                    return this.GetColumn("pathIdinPathTable");
                }
            }
				
   			public static string pathIdinPathTableColumn{
			      get{
        			return "pathIdinPathTable";
      			}
		    }
            
            public IColumn paragraphId{
                get{
                    return this.GetColumn("paragraphId");
                }
            }
				
   			public static string paragraphIdColumn{
			      get{
        			return "paragraphId";
      			}
		    }
            
            public IColumn paragraphText{
                get{
                    return this.GetColumn("paragraphText");
                }
            }
				
   			public static string paragraphTextColumn{
			      get{
        			return "paragraphText";
      			}
		    }
            
            public IColumn cosine{
                get{
                    return this.GetColumn("cosine");
                }
            }
				
   			public static string cosineColumn{
			      get{
        			return "cosine";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: HeadingModified
        /// Primary Key: HeadingId
        /// </summary>

        public class HeadingModifiedTable: DatabaseTable {
            
            public HeadingModifiedTable(IDataProvider provider):base("HeadingModified",provider){
                ClassName = "HeadingModified";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("VectorTermLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn HeadingText{
                get{
                    return this.GetColumn("HeadingText");
                }
            }
				
   			public static string HeadingTextColumn{
			      get{
        			return "HeadingText";
      			}
		    }
            
            public IColumn VectorTermLength{
                get{
                    return this.GetColumn("VectorTermLength");
                }
            }
				
   			public static string VectorTermLengthColumn{
			      get{
        			return "VectorTermLength";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithHeadingTUBSModified
        /// Primary Key: LinkId
        /// </summary>

        public class LinkWithHeadingTUBSModifiedTable: DatabaseTable {
            
            public LinkWithHeadingTUBSModifiedTable(IDataProvider provider):base("LinkWithHeadingTUBSModified",provider){
                ClassName = "LinkWithHeadingTUBSModified";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkAnchorText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VectorTermLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CosineValueLinkHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Visited", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn LinkId{
                get{
                    return this.GetColumn("LinkId");
                }
            }
				
   			public static string LinkIdColumn{
			      get{
        			return "LinkId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn LinkAnchorText{
                get{
                    return this.GetColumn("LinkAnchorText");
                }
            }
				
   			public static string LinkAnchorTextColumn{
			      get{
        			return "LinkAnchorText";
      			}
		    }
            
            public IColumn LinkUrl{
                get{
                    return this.GetColumn("LinkUrl");
                }
            }
				
   			public static string LinkUrlColumn{
			      get{
        			return "LinkUrl";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn VectorTermLength{
                get{
                    return this.GetColumn("VectorTermLength");
                }
            }
				
   			public static string VectorTermLengthColumn{
			      get{
        			return "VectorTermLength";
      			}
		    }
            
            public IColumn CosineValueLinkHeading{
                get{
                    return this.GetColumn("CosineValueLinkHeading");
                }
            }
				
   			public static string CosineValueLinkHeadingColumn{
			      get{
        			return "CosineValueLinkHeading";
      			}
		    }
            
            public IColumn Visited{
                get{
                    return this.GetColumn("Visited");
                }
            }
				
   			public static string VisitedColumn{
			      get{
        			return "Visited";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithoutHeadingTUBSModified
        /// Primary Key: LinkId
        /// </summary>

        public class LinkWithoutHeadingTUBSModifiedTable: DatabaseTable {
            
            public LinkWithoutHeadingTUBSModifiedTable(IDataProvider provider):base("LinkWithoutHeadingTUBSModified",provider){
                ClassName = "LinkWithoutHeadingTUBSModified";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkAnchorText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VectorTermLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Visited", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn LinkId{
                get{
                    return this.GetColumn("LinkId");
                }
            }
				
   			public static string LinkIdColumn{
			      get{
        			return "LinkId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn LinkAnchorText{
                get{
                    return this.GetColumn("LinkAnchorText");
                }
            }
				
   			public static string LinkAnchorTextColumn{
			      get{
        			return "LinkAnchorText";
      			}
		    }
            
            public IColumn LinkUrl{
                get{
                    return this.GetColumn("LinkUrl");
                }
            }
				
   			public static string LinkUrlColumn{
			      get{
        			return "LinkUrl";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn VectorTermLength{
                get{
                    return this.GetColumn("VectorTermLength");
                }
            }
				
   			public static string VectorTermLengthColumn{
			      get{
        			return "VectorTermLength";
      			}
		    }
            
            public IColumn Visited{
                get{
                    return this.GetColumn("Visited");
                }
            }
				
   			public static string VisitedColumn{
			      get{
        			return "Visited";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CosineLinkLinkWithHeadingTUBS
        /// Primary Key: 
        /// </summary>

        public class CosineLinkLinkWithHeadingTUBSTable: DatabaseTable {
            
            public CosineLinkLinkWithHeadingTUBSTable(IDataProvider provider):base("CosineLinkLinkWithHeadingTUBS",provider){
                ClassName = "CosineLinkLinkWithHeadingTUB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CosineLinkLinkWithHeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkXId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkYId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CosineValueLinkLinkWithHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WebpageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkXText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkYText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn CosineLinkLinkWithHeadingId{
                get{
                    return this.GetColumn("CosineLinkLinkWithHeadingId");
                }
            }
				
   			public static string CosineLinkLinkWithHeadingIdColumn{
			      get{
        			return "CosineLinkLinkWithHeadingId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn LinkXId{
                get{
                    return this.GetColumn("LinkXId");
                }
            }
				
   			public static string LinkXIdColumn{
			      get{
        			return "LinkXId";
      			}
		    }
            
            public IColumn LinkYId{
                get{
                    return this.GetColumn("LinkYId");
                }
            }
				
   			public static string LinkYIdColumn{
			      get{
        			return "LinkYId";
      			}
		    }
            
            public IColumn CosineValueLinkLinkWithHeading{
                get{
                    return this.GetColumn("CosineValueLinkLinkWithHeading");
                }
            }
				
   			public static string CosineValueLinkLinkWithHeadingColumn{
			      get{
        			return "CosineValueLinkLinkWithHeading";
      			}
		    }
            
            public IColumn WebpageId{
                get{
                    return this.GetColumn("WebpageId");
                }
            }
				
   			public static string WebpageIdColumn{
			      get{
        			return "WebpageId";
      			}
		    }
            
            public IColumn LinkXText{
                get{
                    return this.GetColumn("LinkXText");
                }
            }
				
   			public static string LinkXTextColumn{
			      get{
        			return "LinkXText";
      			}
		    }
            
            public IColumn LinkYText{
                get{
                    return this.GetColumn("LinkYText");
                }
            }
				
   			public static string LinkYTextColumn{
			      get{
        			return "LinkYText";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: HeadingvsHeadinginSamePageCosinesTUBS
        /// Primary Key: 
        /// </summary>

        public class HeadingvsHeadinginSamePageCosinesTUBSTable: DatabaseTable {
            
            public HeadingvsHeadinginSamePageCosinesTUBSTable(IDataProvider provider):base("HeadingvsHeadinginSamePageCosinesTUBS",provider){
                ClassName = "HeadingvsHeadinginSamePageCosinesTUB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("headingvsheadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebpageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingXId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingYId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CosineValueHeadingvsHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn headingvsheadingId{
                get{
                    return this.GetColumn("headingvsheadingId");
                }
            }
				
   			public static string headingvsheadingIdColumn{
			      get{
        			return "headingvsheadingId";
      			}
		    }
            
            public IColumn WebpageId{
                get{
                    return this.GetColumn("WebpageId");
                }
            }
				
   			public static string WebpageIdColumn{
			      get{
        			return "WebpageId";
      			}
		    }
            
            public IColumn HeadingXId{
                get{
                    return this.GetColumn("HeadingXId");
                }
            }
				
   			public static string HeadingXIdColumn{
			      get{
        			return "HeadingXId";
      			}
		    }
            
            public IColumn HeadingYId{
                get{
                    return this.GetColumn("HeadingYId");
                }
            }
				
   			public static string HeadingYIdColumn{
			      get{
        			return "HeadingYId";
      			}
		    }
            
            public IColumn CosineValueHeadingvsHeading{
                get{
                    return this.GetColumn("CosineValueHeadingvsHeading");
                }
            }
				
   			public static string CosineValueHeadingvsHeadingColumn{
			      get{
        			return "CosineValueHeadingvsHeading";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: HeadingTUBSTVL
        /// Primary Key: 
        /// </summary>

        public class HeadingTUBSTVLTable: DatabaseTable {
            
            public HeadingTUBSTVLTable(IDataProvider provider):base("HeadingTUBSTVL",provider){
                ClassName = "HeadingTUBSTVL";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("VectorTermLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn HeadingText{
                get{
                    return this.GetColumn("HeadingText");
                }
            }
				
   			public static string HeadingTextColumn{
			      get{
        			return "HeadingText";
      			}
		    }
            
            public IColumn VectorTermLength{
                get{
                    return this.GetColumn("VectorTermLength");
                }
            }
				
   			public static string VectorTermLengthColumn{
			      get{
        			return "VectorTermLength";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: HeadingvsHeadinginSamePageCosines
        /// Primary Key: headingvsheadingId
        /// </summary>

        public class HeadingvsHeadinginSamePageCosinesTable: DatabaseTable {
            
            public HeadingvsHeadinginSamePageCosinesTable(IDataProvider provider):base("HeadingvsHeadinginSamePageCosines",provider){
                ClassName = "HeadingvsHeadinginSamePageCosine";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("headingvsheadingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebpageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingXId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingYId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CosineValueHeadingvsHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("HeadingXLinkText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("HeadingYLInkText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn headingvsheadingId{
                get{
                    return this.GetColumn("headingvsheadingId");
                }
            }
				
   			public static string headingvsheadingIdColumn{
			      get{
        			return "headingvsheadingId";
      			}
		    }
            
            public IColumn WebpageId{
                get{
                    return this.GetColumn("WebpageId");
                }
            }
				
   			public static string WebpageIdColumn{
			      get{
        			return "WebpageId";
      			}
		    }
            
            public IColumn HeadingXId{
                get{
                    return this.GetColumn("HeadingXId");
                }
            }
				
   			public static string HeadingXIdColumn{
			      get{
        			return "HeadingXId";
      			}
		    }
            
            public IColumn HeadingYId{
                get{
                    return this.GetColumn("HeadingYId");
                }
            }
				
   			public static string HeadingYIdColumn{
			      get{
        			return "HeadingYId";
      			}
		    }
            
            public IColumn CosineValueHeadingvsHeading{
                get{
                    return this.GetColumn("CosineValueHeadingvsHeading");
                }
            }
				
   			public static string CosineValueHeadingvsHeadingColumn{
			      get{
        			return "CosineValueHeadingvsHeading";
      			}
		    }
            
            public IColumn HeadingXLinkText{
                get{
                    return this.GetColumn("HeadingXLinkText");
                }
            }
				
   			public static string HeadingXLinkTextColumn{
			      get{
        			return "HeadingXLinkText";
      			}
		    }
            
            public IColumn HeadingYLInkText{
                get{
                    return this.GetColumn("HeadingYLInkText");
                }
            }
				
   			public static string HeadingYLInkTextColumn{
			      get{
        			return "HeadingYLInkText";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CosineLinkLinkWithoutHeadingTUBS
        /// Primary Key: 
        /// </summary>

        public class CosineLinkLinkWithoutHeadingTUBSTable: DatabaseTable {
            
            public CosineLinkLinkWithoutHeadingTUBSTable(IDataProvider provider):base("CosineLinkLinkWithoutHeadingTUBS",provider){
                ClassName = "CosineLinkLinkWithoutHeadingTUB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CosineLinkLinkWithoutHeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkXId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkYId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CosineValueLinkLinkWithoutHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CosineLinkLinkWithoutHeadingId{
                get{
                    return this.GetColumn("CosineLinkLinkWithoutHeadingId");
                }
            }
				
   			public static string CosineLinkLinkWithoutHeadingIdColumn{
			      get{
        			return "CosineLinkLinkWithoutHeadingId";
      			}
		    }
            
            public IColumn LinkXId{
                get{
                    return this.GetColumn("LinkXId");
                }
            }
				
   			public static string LinkXIdColumn{
			      get{
        			return "LinkXId";
      			}
		    }
            
            public IColumn LinkYId{
                get{
                    return this.GetColumn("LinkYId");
                }
            }
				
   			public static string LinkYIdColumn{
			      get{
        			return "LinkYId";
      			}
		    }
            
            public IColumn CosineValueLinkLinkWithoutHeading{
                get{
                    return this.GetColumn("CosineValueLinkLinkWithoutHeading");
                }
            }
				
   			public static string CosineValueLinkLinkWithoutHeadingColumn{
			      get{
        			return "CosineValueLinkLinkWithoutHeading";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Paragraph_Cosine
        /// Primary Key: ParagraphCosineId
        /// </summary>

        public class Paragraph_CosineTable: DatabaseTable {
            
            public Paragraph_CosineTable(IDataProvider provider):base("Paragraph_Cosine",provider){
                ClassName = "Paragraph_Cosine";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ParagraphCosineId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ParaId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ParaText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CosineParaAgainstGoal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn ParagraphCosineId{
                get{
                    return this.GetColumn("ParagraphCosineId");
                }
            }
				
   			public static string ParagraphCosineIdColumn{
			      get{
        			return "ParagraphCosineId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn ParaId{
                get{
                    return this.GetColumn("ParaId");
                }
            }
				
   			public static string ParaIdColumn{
			      get{
        			return "ParaId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn ParaText{
                get{
                    return this.GetColumn("ParaText");
                }
            }
				
   			public static string ParaTextColumn{
			      get{
        			return "ParaText";
      			}
		    }
            
            public IColumn CosineParaAgainstGoal{
                get{
                    return this.GetColumn("CosineParaAgainstGoal");
                }
            }
				
   			public static string CosineParaAgainstGoalColumn{
			      get{
        			return "CosineParaAgainstGoal";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: HeadingPathAdequacy_Cosine
        /// Primary Key: headingPathAdequacyCosineID
        /// </summary>

        public class HeadingPathAdequacy_CosineTable: DatabaseTable {
            
            public HeadingPathAdequacy_CosineTable(IDataProvider provider):base("HeadingPathAdequacy_Cosine",provider){
                ClassName = "HeadingPathAdequacy_Cosine";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("headingPathAdequacyCosineID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pAString", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("pageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("headingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Cosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn headingPathAdequacyCosineID{
                get{
                    return this.GetColumn("headingPathAdequacyCosineID");
                }
            }
				
   			public static string headingPathAdequacyCosineIDColumn{
			      get{
        			return "headingPathAdequacyCosineID";
      			}
		    }
            
            public IColumn pAString{
                get{
                    return this.GetColumn("pAString");
                }
            }
				
   			public static string pAStringColumn{
			      get{
        			return "pAString";
      			}
		    }
            
            public IColumn pageId{
                get{
                    return this.GetColumn("pageId");
                }
            }
				
   			public static string pageIdColumn{
			      get{
        			return "pageId";
      			}
		    }
            
            public IColumn headingId{
                get{
                    return this.GetColumn("headingId");
                }
            }
				
   			public static string headingIdColumn{
			      get{
        			return "headingId";
      			}
		    }
            
            public IColumn Cosine{
                get{
                    return this.GetColumn("Cosine");
                }
            }
				
   			public static string CosineColumn{
			      get{
        			return "Cosine";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkLinkTemplateOfLinks
        /// Primary Key: LinkLinkTemplateOfLinksId
        /// </summary>

        public class LinkLinkTemplateOfLinksTable: DatabaseTable {
            
            public LinkLinkTemplateOfLinksTable(IDataProvider provider):base("LinkLinkTemplateOfLinks",provider){
                ClassName = "LinkLinkTemplateOfLink";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkLinkTemplateOfLinksId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkXId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkYId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CosineLinkLinkTemplateOfLinks", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn LinkLinkTemplateOfLinksId{
                get{
                    return this.GetColumn("LinkLinkTemplateOfLinksId");
                }
            }
				
   			public static string LinkLinkTemplateOfLinksIdColumn{
			      get{
        			return "LinkLinkTemplateOfLinksId";
      			}
		    }
            
            public IColumn LinkXId{
                get{
                    return this.GetColumn("LinkXId");
                }
            }
				
   			public static string LinkXIdColumn{
			      get{
        			return "LinkXId";
      			}
		    }
            
            public IColumn LinkYId{
                get{
                    return this.GetColumn("LinkYId");
                }
            }
				
   			public static string LinkYIdColumn{
			      get{
        			return "LinkYId";
      			}
		    }
            
            public IColumn CosineLinkLinkTemplateOfLinks{
                get{
                    return this.GetColumn("CosineLinkLinkTemplateOfLinks");
                }
            }
				
   			public static string CosineLinkLinkTemplateOfLinksColumn{
			      get{
        			return "CosineLinkLinkTemplateOfLinks";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithoutHeadingTemplateOfLinks
        /// Primary Key: LinkWithoutHeadingTemplateOfLinksId
        /// </summary>

        public class LinkWithoutHeadingTemplateOfLinksTable: DatabaseTable {
            
            public LinkWithoutHeadingTemplateOfLinksTable(IDataProvider provider):base("LinkWithoutHeadingTemplateOfLinks",provider){
                ClassName = "LinkWithoutHeadingTemplateOfLink";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkWithoutHeadingTemplateOfLinksId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AllLinksOfTemplate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn LinkWithoutHeadingTemplateOfLinksId{
                get{
                    return this.GetColumn("LinkWithoutHeadingTemplateOfLinksId");
                }
            }
				
   			public static string LinkWithoutHeadingTemplateOfLinksIdColumn{
			      get{
        			return "LinkWithoutHeadingTemplateOfLinksId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn AllLinksOfTemplate{
                get{
                    return this.GetColumn("AllLinksOfTemplate");
                }
            }
				
   			public static string AllLinksOfTemplateColumn{
			      get{
        			return "AllLinksOfTemplate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: TemplateOfLinks
        /// Primary Key: LinkTemplateId
        /// </summary>

        public class TemplateOfLinksTable: DatabaseTable {
            
            public TemplateOfLinksTable(IDataProvider provider):base("TemplateOfLinks",provider){
                ClassName = "TemplateOfLink";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkTemplateId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkAnchorText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TermVectorLengthLinkTemplate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn LinkTemplateId{
                get{
                    return this.GetColumn("LinkTemplateId");
                }
            }
				
   			public static string LinkTemplateIdColumn{
			      get{
        			return "LinkTemplateId";
      			}
		    }
            
            public IColumn LinkAnchorText{
                get{
                    return this.GetColumn("LinkAnchorText");
                }
            }
				
   			public static string LinkAnchorTextColumn{
			      get{
        			return "LinkAnchorText";
      			}
		    }
            
            public IColumn LinkUrl{
                get{
                    return this.GetColumn("LinkUrl");
                }
            }
				
   			public static string LinkUrlColumn{
			      get{
        			return "LinkUrl";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn TermVectorLengthLinkTemplate{
                get{
                    return this.GetColumn("TermVectorLengthLinkTemplate");
                }
            }
				
   			public static string TermVectorLengthLinkTemplateColumn{
			      get{
        			return "TermVectorLengthLinkTemplate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AnImage
        /// Primary Key: ImgId
        /// </summary>

        public class AnImageTable: DatabaseTable {
            
            public AnImageTable(IDataProvider provider):base("AnImage",provider){
                ClassName = "AnImage";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ImgId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImageAltText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ImageUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ImagePicture", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CosienValueImageHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("TermVectorLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn ImgId{
                get{
                    return this.GetColumn("ImgId");
                }
            }
				
   			public static string ImgIdColumn{
			      get{
        			return "ImgId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn ImageAltText{
                get{
                    return this.GetColumn("ImageAltText");
                }
            }
				
   			public static string ImageAltTextColumn{
			      get{
        			return "ImageAltText";
      			}
		    }
            
            public IColumn ImageUrl{
                get{
                    return this.GetColumn("ImageUrl");
                }
            }
				
   			public static string ImageUrlColumn{
			      get{
        			return "ImageUrl";
      			}
		    }
            
            public IColumn ImagePicture{
                get{
                    return this.GetColumn("ImagePicture");
                }
            }
				
   			public static string ImagePictureColumn{
			      get{
        			return "ImagePicture";
      			}
		    }
            
            public IColumn CosienValueImageHeading{
                get{
                    return this.GetColumn("CosienValueImageHeading");
                }
            }
				
   			public static string CosienValueImageHeadingColumn{
			      get{
        			return "CosienValueImageHeading";
      			}
		    }
            
            public IColumn TermVectorLength{
                get{
                    return this.GetColumn("TermVectorLength");
                }
            }
				
   			public static string TermVectorLengthColumn{
			      get{
        			return "TermVectorLength";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AnImageWithoutHeading
        /// Primary Key: ImageWithoutHeadingId
        /// </summary>

        public class AnImageWithoutHeadingTable: DatabaseTable {
            
            public AnImageWithoutHeadingTable(IDataProvider provider):base("AnImageWithoutHeading",provider){
                ClassName = "AnImageWithoutHeading";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ImageWithoutHeadingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImageUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("VectorTermLegnth", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ImageAltText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn ImageWithoutHeadingId{
                get{
                    return this.GetColumn("ImageWithoutHeadingId");
                }
            }
				
   			public static string ImageWithoutHeadingIdColumn{
			      get{
        			return "ImageWithoutHeadingId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn ImageUrl{
                get{
                    return this.GetColumn("ImageUrl");
                }
            }
				
   			public static string ImageUrlColumn{
			      get{
        			return "ImageUrl";
      			}
		    }
            
            public IColumn VectorTermLegnth{
                get{
                    return this.GetColumn("VectorTermLegnth");
                }
            }
				
   			public static string VectorTermLegnthColumn{
			      get{
        			return "VectorTermLegnth";
      			}
		    }
            
            public IColumn ImageAltText{
                get{
                    return this.GetColumn("ImageAltText");
                }
            }
				
   			public static string ImageAltTextColumn{
			      get{
        			return "ImageAltText";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CosineImageImageUnderSameHeading
        /// Primary Key: CosineImageImageUnderHeadingId
        /// </summary>

        public class CosineImageImageUnderSameHeadingTable: DatabaseTable {
            
            public CosineImageImageUnderSameHeadingTable(IDataProvider provider):base("CosineImageImageUnderSameHeading",provider){
                ClassName = "CosineImageImageUnderSameHeading";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CosineImageImageUnderHeadingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImageXId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImageYId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CosineValueImageImageWithHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WebpageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CosineImageImageUnderHeadingId{
                get{
                    return this.GetColumn("CosineImageImageUnderHeadingId");
                }
            }
				
   			public static string CosineImageImageUnderHeadingIdColumn{
			      get{
        			return "CosineImageImageUnderHeadingId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn ImageXId{
                get{
                    return this.GetColumn("ImageXId");
                }
            }
				
   			public static string ImageXIdColumn{
			      get{
        			return "ImageXId";
      			}
		    }
            
            public IColumn ImageYId{
                get{
                    return this.GetColumn("ImageYId");
                }
            }
				
   			public static string ImageYIdColumn{
			      get{
        			return "ImageYId";
      			}
		    }
            
            public IColumn CosineValueImageImageWithHeading{
                get{
                    return this.GetColumn("CosineValueImageImageWithHeading");
                }
            }
				
   			public static string CosineValueImageImageWithHeadingColumn{
			      get{
        			return "CosineValueImageImageWithHeading";
      			}
		    }
            
            public IColumn WebpageId{
                get{
                    return this.GetColumn("WebpageId");
                }
            }
				
   			public static string WebpageIdColumn{
			      get{
        			return "WebpageId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CosineImageImageWithoutHeading
        /// Primary Key: CosineImageImageWithoutHeadingId
        /// </summary>

        public class CosineImageImageWithoutHeadingTable: DatabaseTable {
            
            public CosineImageImageWithoutHeadingTable(IDataProvider provider):base("CosineImageImageWithoutHeading",provider){
                ClassName = "CosineImageImageWithoutHeading";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CosineImageImageWithoutHeadingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImageXId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImageYId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CosineValueImageImageWithoutHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CosineImageImageWithoutHeadingId{
                get{
                    return this.GetColumn("CosineImageImageWithoutHeadingId");
                }
            }
				
   			public static string CosineImageImageWithoutHeadingIdColumn{
			      get{
        			return "CosineImageImageWithoutHeadingId";
      			}
		    }
            
            public IColumn ImageXId{
                get{
                    return this.GetColumn("ImageXId");
                }
            }
				
   			public static string ImageXIdColumn{
			      get{
        			return "ImageXId";
      			}
		    }
            
            public IColumn ImageYId{
                get{
                    return this.GetColumn("ImageYId");
                }
            }
				
   			public static string ImageYIdColumn{
			      get{
        			return "ImageYId";
      			}
		    }
            
            public IColumn CosineValueImageImageWithoutHeading{
                get{
                    return this.GetColumn("CosineValueImageImageWithoutHeading");
                }
            }
				
   			public static string CosineValueImageImageWithoutHeadingColumn{
			      get{
        			return "CosineValueImageImageWithoutHeading";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CosineLinkLinkWithoutHeading
        /// Primary Key: CosineLinkLinkWithoutHeadingId
        /// </summary>

        public class CosineLinkLinkWithoutHeadingTable: DatabaseTable {
            
            public CosineLinkLinkWithoutHeadingTable(IDataProvider provider):base("CosineLinkLinkWithoutHeading",provider){
                ClassName = "CosineLinkLinkWithoutHeading";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CosineLinkLinkWithoutHeadingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkXId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkYId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CosineValueLinkLinkWithoutHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CosineLinkLinkWithoutHeadingId{
                get{
                    return this.GetColumn("CosineLinkLinkWithoutHeadingId");
                }
            }
				
   			public static string CosineLinkLinkWithoutHeadingIdColumn{
			      get{
        			return "CosineLinkLinkWithoutHeadingId";
      			}
		    }
            
            public IColumn LinkXId{
                get{
                    return this.GetColumn("LinkXId");
                }
            }
				
   			public static string LinkXIdColumn{
			      get{
        			return "LinkXId";
      			}
		    }
            
            public IColumn LinkYId{
                get{
                    return this.GetColumn("LinkYId");
                }
            }
				
   			public static string LinkYIdColumn{
			      get{
        			return "LinkYId";
      			}
		    }
            
            public IColumn CosineValueLinkLinkWithoutHeading{
                get{
                    return this.GetColumn("CosineValueLinkLinkWithoutHeading");
                }
            }
				
   			public static string CosineValueLinkLinkWithoutHeadingColumn{
			      get{
        			return "CosineValueLinkLinkWithoutHeading";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CosineLinkLinkWithHeading
        /// Primary Key: CosineLinkLinkWithHeadingId
        /// </summary>

        public class CosineLinkLinkWithHeadingTable: DatabaseTable {
            
            public CosineLinkLinkWithHeadingTable(IDataProvider provider):base("CosineLinkLinkWithHeading",provider){
                ClassName = "CosineLinkLinkWithHeading";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CosineLinkLinkWithHeadingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HeadingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkXId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkYId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CosineValueLinkLinkWithHeading", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WebpageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CosineLinkLinkWithHeadingId{
                get{
                    return this.GetColumn("CosineLinkLinkWithHeadingId");
                }
            }
				
   			public static string CosineLinkLinkWithHeadingIdColumn{
			      get{
        			return "CosineLinkLinkWithHeadingId";
      			}
		    }
            
            public IColumn HeadingId{
                get{
                    return this.GetColumn("HeadingId");
                }
            }
				
   			public static string HeadingIdColumn{
			      get{
        			return "HeadingId";
      			}
		    }
            
            public IColumn LinkXId{
                get{
                    return this.GetColumn("LinkXId");
                }
            }
				
   			public static string LinkXIdColumn{
			      get{
        			return "LinkXId";
      			}
		    }
            
            public IColumn LinkYId{
                get{
                    return this.GetColumn("LinkYId");
                }
            }
				
   			public static string LinkYIdColumn{
			      get{
        			return "LinkYId";
      			}
		    }
            
            public IColumn CosineValueLinkLinkWithHeading{
                get{
                    return this.GetColumn("CosineValueLinkLinkWithHeading");
                }
            }
				
   			public static string CosineValueLinkLinkWithHeadingColumn{
			      get{
        			return "CosineValueLinkLinkWithHeading";
      			}
		    }
            
            public IColumn WebpageId{
                get{
                    return this.GetColumn("WebpageId");
                }
            }
				
   			public static string WebpageIdColumn{
			      get{
        			return "WebpageId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: WebSite
        /// Primary Key: WebSiteId
        /// </summary>

        public class WebSiteTable: DatabaseTable {
            
            public WebSiteTable(IDataProvider provider):base("WebSite",provider){
                ClassName = "WebSite";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("WebSiteId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebSiteName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn WebSiteId{
                get{
                    return this.GetColumn("WebSiteId");
                }
            }
				
   			public static string WebSiteIdColumn{
			      get{
        			return "WebSiteId";
      			}
		    }
            
            public IColumn WebSiteName{
                get{
                    return this.GetColumn("WebSiteName");
                }
            }
				
   			public static string WebSiteNameColumn{
			      get{
        			return "WebSiteName";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Heading_Cosine
        /// Primary Key: headingCosineID
        /// </summary>

        public class Heading_CosineTable: DatabaseTable {
            
            public Heading_CosineTable(IDataProvider provider):base("Heading_Cosine",provider){
                ClassName = "Heading_Cosine";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("headingCosineID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("pageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("headingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("headingText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Cosine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("SelectedRow", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn headingCosineID{
                get{
                    return this.GetColumn("headingCosineID");
                }
            }
				
   			public static string headingCosineIDColumn{
			      get{
        			return "headingCosineID";
      			}
		    }
            
            public IColumn pageId{
                get{
                    return this.GetColumn("pageId");
                }
            }
				
   			public static string pageIdColumn{
			      get{
        			return "pageId";
      			}
		    }
            
            public IColumn headingId{
                get{
                    return this.GetColumn("headingId");
                }
            }
				
   			public static string headingIdColumn{
			      get{
        			return "headingId";
      			}
		    }
            
            public IColumn headingText{
                get{
                    return this.GetColumn("headingText");
                }
            }
				
   			public static string headingTextColumn{
			      get{
        			return "headingText";
      			}
		    }
            
            public IColumn Cosine{
                get{
                    return this.GetColumn("Cosine");
                }
            }
				
   			public static string CosineColumn{
			      get{
        			return "Cosine";
      			}
		    }
            
            public IColumn SelectedRow{
                get{
                    return this.GetColumn("SelectedRow");
                }
            }
				
   			public static string SelectedRowColumn{
			      get{
        			return "SelectedRow";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LinkWithoutHeading
        /// Primary Key: LinkId
        /// </summary>

        public class LinkWithoutHeadingTable: DatabaseTable {
            
            public LinkWithoutHeadingTable(IDataProvider provider):base("LinkWithoutHeading",provider){
                ClassName = "LinkWithoutHeading";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LinkId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LinkAnchorText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LinkUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ToPageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VectorTermLength", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn LinkId{
                get{
                    return this.GetColumn("LinkId");
                }
            }
				
   			public static string LinkIdColumn{
			      get{
        			return "LinkId";
      			}
		    }
            
            public IColumn WebPageId{
                get{
                    return this.GetColumn("WebPageId");
                }
            }
				
   			public static string WebPageIdColumn{
			      get{
        			return "WebPageId";
      			}
		    }
            
            public IColumn LinkAnchorText{
                get{
                    return this.GetColumn("LinkAnchorText");
                }
            }
				
   			public static string LinkAnchorTextColumn{
			      get{
        			return "LinkAnchorText";
      			}
		    }
            
            public IColumn LinkUrl{
                get{
                    return this.GetColumn("LinkUrl");
                }
            }
				
   			public static string LinkUrlColumn{
			      get{
        			return "LinkUrl";
      			}
		    }
            
            public IColumn ToPageId{
                get{
                    return this.GetColumn("ToPageId");
                }
            }
				
   			public static string ToPageIdColumn{
			      get{
        			return "ToPageId";
      			}
		    }
            
            public IColumn VectorTermLength{
                get{
                    return this.GetColumn("VectorTermLength");
                }
            }
				
   			public static string VectorTermLengthColumn{
			      get{
        			return "VectorTermLength";
      			}
		    }
            
                    
        }
        
}