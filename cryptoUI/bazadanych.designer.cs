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
    partial void InsertPrice(Price instance);
    partial void UpdatePrice(Price instance);
    partial void DeletePrice(Price instance);
    #endregion
		
		public bazadanychDataContext() : 
				base(global::cryptoUI.Properties.Settings.Default.bazadanychConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Price> Prices
		{
			get
			{
				return this.GetTable<Price>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Currency")]
	public partial class Currency : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Abbreviation;
		
		private EntitySet<Price> _Prices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAbbreviationChanging(string value);
    partial void OnAbbreviationChanged();
    #endregion
		
		public Currency()
		{
			this._Prices = new EntitySet<Price>(new Action<Price>(this.attach_Prices), new Action<Price>(this.detach_Prices));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abbreviation", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Abbreviation
		{
			get
			{
				return this._Abbreviation;
			}
			set
			{
				if ((this._Abbreviation != value))
				{
					this.OnAbbreviationChanging(value);
					this.SendPropertyChanging();
					this._Abbreviation = value;
					this.SendPropertyChanged("Abbreviation");
					this.OnAbbreviationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currency_Price", Storage="_Prices", ThisKey="Id", OtherKey="CurrencyId")]
		public EntitySet<Price> Prices
		{
			get
			{
				return this._Prices;
			}
			set
			{
				this._Prices.Assign(value);
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
		
		private void attach_Prices(Price entity)
		{
			this.SendPropertyChanging();
			entity.Currency = this;
		}
		
		private void detach_Prices(Price entity)
		{
			this.SendPropertyChanging();
			entity.Currency = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Prices")]
	public partial class Price : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _time;
		
		private float _price1;
		
		private int _CurrencyId;
		
		private EntityRef<Currency> _Currency;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OntimeChanging(System.DateTime value);
    partial void OntimeChanged();
    partial void Onprice1Changing(float value);
    partial void Onprice1Changed();
    partial void OnCurrencyIdChanging(int value);
    partial void OnCurrencyIdChanged();
    #endregion
		
		public Price()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime NOT NULL")]
		public System.DateTime time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="price", Storage="_price1", DbType="Real NOT NULL")]
		public float price1
		{
			get
			{
				return this._price1;
			}
			set
			{
				if ((this._price1 != value))
				{
					this.Onprice1Changing(value);
					this.SendPropertyChanging();
					this._price1 = value;
					this.SendPropertyChanged("price1");
					this.Onprice1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrencyId", DbType="Int NOT NULL")]
		public int CurrencyId
		{
			get
			{
				return this._CurrencyId;
			}
			set
			{
				if ((this._CurrencyId != value))
				{
					if (this._Currency.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCurrencyIdChanging(value);
					this.SendPropertyChanging();
					this._CurrencyId = value;
					this.SendPropertyChanged("CurrencyId");
					this.OnCurrencyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currency_Price", Storage="_Currency", ThisKey="CurrencyId", OtherKey="Id", IsForeignKey=true)]
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
						previousValue.Prices.Remove(this);
					}
					this._Currency.Entity = value;
					if ((value != null))
					{
						value.Prices.Add(this);
						this._CurrencyId = value.Id;
					}
					else
					{
						this._CurrencyId = default(int);
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