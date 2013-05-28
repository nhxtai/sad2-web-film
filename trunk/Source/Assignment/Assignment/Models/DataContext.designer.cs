﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Assignment")]
	public partial class DataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblAccount(tblAccount instance);
    partial void UpdatetblAccount(tblAccount instance);
    partial void DeletetblAccount(tblAccount instance);
    partial void InserttblCategory(tblCategory instance);
    partial void UpdatetblCategory(tblCategory instance);
    partial void DeletetblCategory(tblCategory instance);
    partial void InserttblComment(tblComment instance);
    partial void UpdatetblComment(tblComment instance);
    partial void DeletetblComment(tblComment instance);
    partial void InserttblFilm(tblFilm instance);
    partial void UpdatetblFilm(tblFilm instance);
    partial void DeletetblFilm(tblFilm instance);
    #endregion
		
		public DataContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AssignmentConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblAccount> tblAccounts
		{
			get
			{
				return this.GetTable<tblAccount>();
			}
		}
		
		public System.Data.Linq.Table<tblCategory> tblCategories
		{
			get
			{
				return this.GetTable<tblCategory>();
			}
		}
		
		public System.Data.Linq.Table<tblComment> tblComments
		{
			get
			{
				return this.GetTable<tblComment>();
			}
		}
		
		public System.Data.Linq.Table<tblFilm> tblFilms
		{
			get
			{
				return this.GetTable<tblFilm>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblAccount")]
	public partial class tblAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
		private bool _IsActive;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public tblAccount()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCategory")]
	public partial class tblCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _CategoryID;
		
		private string _Name;
		
		private bool _IsActive;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(long value);
    partial void OnCategoryIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public tblCategory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblComment")]
	public partial class tblComment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _FilmID;
		
		private long _CommentID;
		
		private string _Username;
		
		private string _CommentContent;
		
		private bool _IsActive;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFilmIDChanging(long value);
    partial void OnFilmIDChanged();
    partial void OnCommentIDChanging(long value);
    partial void OnCommentIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnCommentContentChanging(string value);
    partial void OnCommentContentChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public tblComment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmID", DbType="BigInt NOT NULL")]
		public long FilmID
		{
			get
			{
				return this._FilmID;
			}
			set
			{
				if ((this._FilmID != value))
				{
					this.OnFilmIDChanging(value);
					this.SendPropertyChanging();
					this._FilmID = value;
					this.SendPropertyChanged("FilmID");
					this.OnFilmIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long CommentID
		{
			get
			{
				return this._CommentID;
			}
			set
			{
				if ((this._CommentID != value))
				{
					this.OnCommentIDChanging(value);
					this.SendPropertyChanging();
					this._CommentID = value;
					this.SendPropertyChanged("CommentID");
					this.OnCommentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentContent", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CommentContent
		{
			get
			{
				return this._CommentContent;
			}
			set
			{
				if ((this._CommentContent != value))
				{
					this.OnCommentContentChanging(value);
					this.SendPropertyChanging();
					this._CommentContent = value;
					this.SendPropertyChanged("CommentContent");
					this.OnCommentContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblFilm")]
	public partial class tblFilm : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _FilmID;
		
		private long _CategoryID;
		
		private string _ShortTitle;
		
		private string _FullTitle;
		
		private string _Description;
		
		private string _Poster;
		
		private string _LinkFilm;
		
		private bool _IsActive;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFilmIDChanging(long value);
    partial void OnFilmIDChanged();
    partial void OnCategoryIDChanging(long value);
    partial void OnCategoryIDChanged();
    partial void OnShortTitleChanging(string value);
    partial void OnShortTitleChanged();
    partial void OnFullTitleChanging(string value);
    partial void OnFullTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPosterChanging(string value);
    partial void OnPosterChanged();
    partial void OnLinkFilmChanging(string value);
    partial void OnLinkFilmChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public tblFilm()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long FilmID
		{
			get
			{
				return this._FilmID;
			}
			set
			{
				if ((this._FilmID != value))
				{
					this.OnFilmIDChanging(value);
					this.SendPropertyChanging();
					this._FilmID = value;
					this.SendPropertyChanged("FilmID");
					this.OnFilmIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="BigInt NOT NULL")]
		public long CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortTitle", DbType="NVarChar(MAX)")]
		public string ShortTitle
		{
			get
			{
				return this._ShortTitle;
			}
			set
			{
				if ((this._ShortTitle != value))
				{
					this.OnShortTitleChanging(value);
					this.SendPropertyChanging();
					this._ShortTitle = value;
					this.SendPropertyChanged("ShortTitle");
					this.OnShortTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullTitle", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FullTitle
		{
			get
			{
				return this._FullTitle;
			}
			set
			{
				if ((this._FullTitle != value))
				{
					this.OnFullTitleChanging(value);
					this.SendPropertyChanging();
					this._FullTitle = value;
					this.SendPropertyChanged("FullTitle");
					this.OnFullTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Poster", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Poster
		{
			get
			{
				return this._Poster;
			}
			set
			{
				if ((this._Poster != value))
				{
					this.OnPosterChanging(value);
					this.SendPropertyChanging();
					this._Poster = value;
					this.SendPropertyChanged("Poster");
					this.OnPosterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkFilm", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string LinkFilm
		{
			get
			{
				return this._LinkFilm;
			}
			set
			{
				if ((this._LinkFilm != value))
				{
					this.OnLinkFilmChanging(value);
					this.SendPropertyChanging();
					this._LinkFilm = value;
					this.SendPropertyChanged("LinkFilm");
					this.OnLinkFilmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591