﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cryptoUI
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bazadanych")]
	public partial class bazadanychDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCurrency(Currency instance);
    partial void UpdateCurrency(Currency instance);
    partial void DeleteCurrency(Currency instance);
    partial void InsertTable(Table instance);
    partial void UpdateTable(Table instance);
    partial void DeleteTable(Table instance);
    #endregion
		
		public bazadanychDataContext() : 
				base(global::cryptoUI.Properties.Settings.Default.bazadanychConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public bazadanychDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bazadanychDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bazadanychDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bazadanychDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Currency> Currencies
		{
			get
			{
				return this.GetTable<Currency>();
			}
		}
		
		public System.Data.Linq.Table<Table> Tables
		{
			get
			{
				return this.GetTable<Table>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Currencies")]
	public partial class Currency : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _API_Id;
		
		private string _Name;
		
		private string _ImageUrl;
		
		private EntitySet<Table> _Tables;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnAPI_IdChanging(int value);
    partial void OnAPI_IdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnImageUrlChanging(string value);
    partial void OnImageUrlChanged();
    #endregion
		
		public Currency()
		{
			this._Tables = new EntitySet<Table>(new Action<Table>(this.attach_Tables), new Action<Table>(this.detach_Tables));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_API_Id", DbType="Int NOT NULL")]
		public int API_Id
		{
			get
			{
				return this._API_Id;
			}
			set
			{
				if ((this._API_Id != value))
				{
					this.OnAPI_IdChanging(value);
					this.SendPropertyChanging();
					this._API_Id = value;
					this.SendPropertyChanged("API_Id");
					this.OnAPI_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageUrl", DbType="NVarChar(200)")]
		public string ImageUrl
		{
			get
			{
				return this._ImageUrl;
			}
			set
			{
				if ((this._ImageUrl != value))
				{
					this.OnImageUrlChanging(value);
					this.SendPropertyChanging();
					this._ImageUrl = value;
					this.SendPropertyChanged("ImageUrl");
					this.OnImageUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currency_Table", Storage="_Tables", ThisKey="Id", OtherKey="Id_Currency")]
		public EntitySet<Table> Tables
		{
			get
			{
				return this._Tables;
			}
			set
			{
				this._Tables.Assign(value);
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
		
		private void attach_Tables(Table entity)
		{
			this.SendPropertyChanging();
			entity.Currency = this;
		}
		
		private void detach_Tables(Table entity)
		{
			this.SendPropertyChanging();
			entity.Currency = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
	public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Id_Currency;
		
		private float _Price;
		
		private System.DateTime _DataTime;
		
		private EntityRef<Currency> _Currency;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnId_CurrencyChanging(int value);
    partial void OnId_CurrencyChanged();
    partial void OnPriceChanging(float value);
    partial void OnPriceChanged();
    partial void OnDataTimeChanging(System.DateTime value);
    partial void OnDataTimeChanged();
    #endregion
		
		public Table()
		{
			this._Currency = default(EntityRef<Currency>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Currency", DbType="Int NOT NULL")]
		public int Id_Currency
		{
			get
			{
				return this._Id_Currency;
			}
			set
			{
				if ((this._Id_Currency != value))
				{
					if (this._Currency.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_CurrencyChanging(value);
					this.SendPropertyChanging();
					this._Id_Currency = value;
					this.SendPropertyChanged("Id_Currency");
					this.OnId_CurrencyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Real NOT NULL")]
		public float Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataTime", DbType="DateTime NOT NULL")]
		public System.DateTime DataTime
		{
			get
			{
				return this._DataTime;
			}
			set
			{
				if ((this._DataTime != value))
				{
					this.OnDataTimeChanging(value);
					this.SendPropertyChanging();
					this._DataTime = value;
					this.SendPropertyChanged("DataTime");
					this.OnDataTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currency_Table", Storage="_Currency", ThisKey="Id_Currency", OtherKey="Id", IsForeignKey=true)]
		public Currency Currency
		{
			get
			{
				return this._Currency.Entity;
			}
			set
			{
				Currency previousValue = this._Currency.Entity;
				if (((previousValue != value) 
							|| (this._Currency.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Currency.Entity = null;
						previousValue.Tables.Remove(this);
					}
					this._Currency.Entity = value;
					if ((value != null))
					{
						value.Tables.Add(this);
						this._Id_Currency = value.Id;
					}
					else
					{
						this._Id_Currency = default(int);
					}
					this.SendPropertyChanged("Currency");
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
