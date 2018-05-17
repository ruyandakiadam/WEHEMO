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

namespace WeHeMo.Business
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WEHEMO")]
	public partial class WeHeMoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCUSTOMER(CUSTOMER instance);
    partial void UpdateCUSTOMER(CUSTOMER instance);
    partial void DeleteCUSTOMER(CUSTOMER instance);
    partial void InsertSTATUS_CODE(STATUS_CODE instance);
    partial void UpdateSTATUS_CODE(STATUS_CODE instance);
    partial void DeleteSTATUS_CODE(STATUS_CODE instance);
    partial void InsertTEST(TEST instance);
    partial void UpdateTEST(TEST instance);
    partial void DeleteTEST(TEST instance);
    partial void InsertTEST_RESULT(TEST_RESULT instance);
    partial void UpdateTEST_RESULT(TEST_RESULT instance);
    partial void DeleteTEST_RESULT(TEST_RESULT instance);
    #endregion
		
		public WeHeMoDataContext() : 
				base(global::WeHeMo.Business.Properties.Settings.Default.WEHEMOConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WeHeMoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeHeMoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeHeMoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeHeMoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CUSTOMER> CUSTOMERs
		{
			get
			{
				return this.GetTable<CUSTOMER>();
			}
		}
		
		public System.Data.Linq.Table<STATUS_CODE> STATUS_CODEs
		{
			get
			{
				return this.GetTable<STATUS_CODE>();
			}
		}
		
		public System.Data.Linq.Table<TEST> TESTs
		{
			get
			{
				return this.GetTable<TEST>();
			}
		}
		
		public System.Data.Linq.Table<TEST_RESULT> TEST_RESULTs
		{
			get
			{
				return this.GetTable<TEST_RESULT>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CUSTOMER")]
	public partial class CUSTOMER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Name;
		
		private string _Email;
		
		private string _Password;
		
		private System.DateTime _CreateDate;
		
		private System.Nullable<System.DateTime> _UpdateDate;
		
		private EntitySet<TEST> _TESTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnUpdateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdateDateChanged();
    #endregion
		
		public CUSTOMER()
		{
			this._TESTs = new EntitySet<TEST>(new Action<TEST>(this.attach_TESTs), new Action<TEST>(this.detach_TESTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="SmallDateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateDate", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> UpdateDate
		{
			get
			{
				return this._UpdateDate;
			}
			set
			{
				if ((this._UpdateDate != value))
				{
					this.OnUpdateDateChanging(value);
					this.SendPropertyChanging();
					this._UpdateDate = value;
					this.SendPropertyChanged("UpdateDate");
					this.OnUpdateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_TEST", Storage="_TESTs", ThisKey="Id", OtherKey="CustomerId")]
		public EntitySet<TEST> TESTs
		{
			get
			{
				return this._TESTs;
			}
			set
			{
				this._TESTs.Assign(value);
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
		
		private void attach_TESTs(TEST entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = this;
		}
		
		private void detach_TESTs(TEST entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.STATUS_CODE")]
	public partial class STATUS_CODE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Description;
		
		private EntitySet<TEST> _TESTs;
		
		private EntitySet<TEST_RESULT> _TEST_RESULTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public STATUS_CODE()
		{
			this._TESTs = new EntitySet<TEST>(new Action<TEST>(this.attach_TESTs), new Action<TEST>(this.detach_TESTs));
			this._TEST_RESULTs = new EntitySet<TEST_RESULT>(new Action<TEST_RESULT>(this.attach_TEST_RESULTs), new Action<TEST_RESULT>(this.detach_TEST_RESULTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="STATUS_CODE_TEST", Storage="_TESTs", ThisKey="Code", OtherKey="StatusCode")]
		public EntitySet<TEST> TESTs
		{
			get
			{
				return this._TESTs;
			}
			set
			{
				this._TESTs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="STATUS_CODE_TEST_RESULT", Storage="_TEST_RESULTs", ThisKey="Code", OtherKey="StatusCode")]
		public EntitySet<TEST_RESULT> TEST_RESULTs
		{
			get
			{
				return this._TEST_RESULTs;
			}
			set
			{
				this._TEST_RESULTs.Assign(value);
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
		
		private void attach_TESTs(TEST entity)
		{
			this.SendPropertyChanging();
			entity.STATUS_CODE = this;
		}
		
		private void detach_TESTs(TEST entity)
		{
			this.SendPropertyChanging();
			entity.STATUS_CODE = null;
		}
		
		private void attach_TEST_RESULTs(TEST_RESULT entity)
		{
			this.SendPropertyChanging();
			entity.STATUS_CODE = this;
		}
		
		private void detach_TEST_RESULTs(TEST_RESULT entity)
		{
			this.SendPropertyChanging();
			entity.STATUS_CODE = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TEST")]
	public partial class TEST : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _CustomerId;
		
		private string _Url;
		
		private System.DateTime _CreateDate;
		
		private System.Nullable<int> _StatusCode;
		
		private System.Nullable<System.DateTime> _TestDate;
		
		private EntitySet<TEST_RESULT> _TEST_RESULTs;
		
		private EntityRef<CUSTOMER> _CUSTOMER;
		
		private EntityRef<STATUS_CODE> _STATUS_CODE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnCustomerIdChanging(System.Guid value);
    partial void OnCustomerIdChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnStatusCodeChanging(System.Nullable<int> value);
    partial void OnStatusCodeChanged();
    partial void OnTestDateChanging(System.Nullable<System.DateTime> value);
    partial void OnTestDateChanged();
    #endregion
		
		public TEST()
		{
			this._TEST_RESULTs = new EntitySet<TEST_RESULT>(new Action<TEST_RESULT>(this.attach_TEST_RESULTs), new Action<TEST_RESULT>(this.detach_TEST_RESULTs));
			this._CUSTOMER = default(EntityRef<CUSTOMER>);
			this._STATUS_CODE = default(EntityRef<STATUS_CODE>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._CUSTOMER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="VarChar(400) NOT NULL", CanBeNull=false)]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="SmallDateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusCode", DbType="Int")]
		public System.Nullable<int> StatusCode
		{
			get
			{
				return this._StatusCode;
			}
			set
			{
				if ((this._StatusCode != value))
				{
					if (this._STATUS_CODE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStatusCodeChanging(value);
					this.SendPropertyChanging();
					this._StatusCode = value;
					this.SendPropertyChanged("StatusCode");
					this.OnStatusCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TestDate", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> TestDate
		{
			get
			{
				return this._TestDate;
			}
			set
			{
				if ((this._TestDate != value))
				{
					this.OnTestDateChanging(value);
					this.SendPropertyChanging();
					this._TestDate = value;
					this.SendPropertyChanged("TestDate");
					this.OnTestDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TEST_TEST_RESULT", Storage="_TEST_RESULTs", ThisKey="Id", OtherKey="TestId")]
		public EntitySet<TEST_RESULT> TEST_RESULTs
		{
			get
			{
				return this._TEST_RESULTs;
			}
			set
			{
				this._TEST_RESULTs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_TEST", Storage="_CUSTOMER", ThisKey="CustomerId", OtherKey="Id", IsForeignKey=true)]
		public CUSTOMER CUSTOMER
		{
			get
			{
				return this._CUSTOMER.Entity;
			}
			set
			{
				CUSTOMER previousValue = this._CUSTOMER.Entity;
				if (((previousValue != value) 
							|| (this._CUSTOMER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CUSTOMER.Entity = null;
						previousValue.TESTs.Remove(this);
					}
					this._CUSTOMER.Entity = value;
					if ((value != null))
					{
						value.TESTs.Add(this);
						this._CustomerId = value.Id;
					}
					else
					{
						this._CustomerId = default(System.Guid);
					}
					this.SendPropertyChanged("CUSTOMER");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="STATUS_CODE_TEST", Storage="_STATUS_CODE", ThisKey="StatusCode", OtherKey="Code", IsForeignKey=true)]
		public STATUS_CODE STATUS_CODE
		{
			get
			{
				return this._STATUS_CODE.Entity;
			}
			set
			{
				STATUS_CODE previousValue = this._STATUS_CODE.Entity;
				if (((previousValue != value) 
							|| (this._STATUS_CODE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._STATUS_CODE.Entity = null;
						previousValue.TESTs.Remove(this);
					}
					this._STATUS_CODE.Entity = value;
					if ((value != null))
					{
						value.TESTs.Add(this);
						this._StatusCode = value.Code;
					}
					else
					{
						this._StatusCode = default(Nullable<int>);
					}
					this.SendPropertyChanged("STATUS_CODE");
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
		
		private void attach_TEST_RESULTs(TEST_RESULT entity)
		{
			this.SendPropertyChanging();
			entity.TEST = this;
		}
		
		private void detach_TEST_RESULTs(TEST_RESULT entity)
		{
			this.SendPropertyChanging();
			entity.TEST = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TEST_RESULT")]
	public partial class TEST_RESULT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _TestId;
		
		private int _StatusCode;
		
		private System.DateTime _CreateDate;
		
		private EntityRef<STATUS_CODE> _STATUS_CODE;
		
		private EntityRef<TEST> _TEST;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnTestIdChanging(System.Guid value);
    partial void OnTestIdChanged();
    partial void OnStatusCodeChanging(int value);
    partial void OnStatusCodeChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    #endregion
		
		public TEST_RESULT()
		{
			this._STATUS_CODE = default(EntityRef<STATUS_CODE>);
			this._TEST = default(EntityRef<TEST>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TestId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid TestId
		{
			get
			{
				return this._TestId;
			}
			set
			{
				if ((this._TestId != value))
				{
					if (this._TEST.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTestIdChanging(value);
					this.SendPropertyChanging();
					this._TestId = value;
					this.SendPropertyChanged("TestId");
					this.OnTestIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusCode", DbType="Int NOT NULL")]
		public int StatusCode
		{
			get
			{
				return this._StatusCode;
			}
			set
			{
				if ((this._StatusCode != value))
				{
					if (this._STATUS_CODE.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStatusCodeChanging(value);
					this.SendPropertyChanging();
					this._StatusCode = value;
					this.SendPropertyChanged("StatusCode");
					this.OnStatusCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="STATUS_CODE_TEST_RESULT", Storage="_STATUS_CODE", ThisKey="StatusCode", OtherKey="Code", IsForeignKey=true)]
		public STATUS_CODE STATUS_CODE
		{
			get
			{
				return this._STATUS_CODE.Entity;
			}
			set
			{
				STATUS_CODE previousValue = this._STATUS_CODE.Entity;
				if (((previousValue != value) 
							|| (this._STATUS_CODE.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._STATUS_CODE.Entity = null;
						previousValue.TEST_RESULTs.Remove(this);
					}
					this._STATUS_CODE.Entity = value;
					if ((value != null))
					{
						value.TEST_RESULTs.Add(this);
						this._StatusCode = value.Code;
					}
					else
					{
						this._StatusCode = default(int);
					}
					this.SendPropertyChanged("STATUS_CODE");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TEST_TEST_RESULT", Storage="_TEST", ThisKey="TestId", OtherKey="Id", IsForeignKey=true)]
		public TEST TEST
		{
			get
			{
				return this._TEST.Entity;
			}
			set
			{
				TEST previousValue = this._TEST.Entity;
				if (((previousValue != value) 
							|| (this._TEST.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TEST.Entity = null;
						previousValue.TEST_RESULTs.Remove(this);
					}
					this._TEST.Entity = value;
					if ((value != null))
					{
						value.TEST_RESULTs.Add(this);
						this._TestId = value.Id;
					}
					else
					{
						this._TestId = default(System.Guid);
					}
					this.SendPropertyChanged("TEST");
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