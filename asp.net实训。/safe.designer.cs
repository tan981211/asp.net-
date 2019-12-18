﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace asp.net实训_
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="safe")]
	public partial class safeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void InsertrepairAdmin(repairAdmin instance);
    partial void UpdaterepairAdmin(repairAdmin instance);
    partial void DeleterepairAdmin(repairAdmin instance);
    #endregion
		
		public safeDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["safeConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public safeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public safeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public safeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public safeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<user> user
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<repairAdmin> repairAdmin
		{
			get
			{
				return this.GetTable<repairAdmin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[user]")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userId;
		
		private string _userName;
		
		private string _userEmail;
		
		private string _userPhone;
		
		private string _userAddress;
		
		private string _userPassword;
		
		private EntitySet<repairAdmin> _repairAdmin;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIdChanging(int value);
    partial void OnuserIdChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void OnuserEmailChanging(string value);
    partial void OnuserEmailChanged();
    partial void OnuserPhoneChanging(string value);
    partial void OnuserPhoneChanged();
    partial void OnuserAddressChanging(string value);
    partial void OnuserAddressChanged();
    partial void OnuserPasswordChanging(string value);
    partial void OnuserPasswordChanged();
    #endregion
		
		public user()
		{
			this._repairAdmin = new EntitySet<repairAdmin>(new Action<repairAdmin>(this.attach_repairAdmin), new Action<repairAdmin>(this.detach_repairAdmin));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this.OnuserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("userName");
					this.OnuserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userEmail", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string userEmail
		{
			get
			{
				return this._userEmail;
			}
			set
			{
				if ((this._userEmail != value))
				{
					this.OnuserEmailChanging(value);
					this.SendPropertyChanging();
					this._userEmail = value;
					this.SendPropertyChanged("userEmail");
					this.OnuserEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userPhone", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string userPhone
		{
			get
			{
				return this._userPhone;
			}
			set
			{
				if ((this._userPhone != value))
				{
					this.OnuserPhoneChanging(value);
					this.SendPropertyChanging();
					this._userPhone = value;
					this.SendPropertyChanged("userPhone");
					this.OnuserPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userAddress", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string userAddress
		{
			get
			{
				return this._userAddress;
			}
			set
			{
				if ((this._userAddress != value))
				{
					this.OnuserAddressChanging(value);
					this.SendPropertyChanging();
					this._userAddress = value;
					this.SendPropertyChanged("userAddress");
					this.OnuserAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userPassword", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string userPassword
		{
			get
			{
				return this._userPassword;
			}
			set
			{
				if ((this._userPassword != value))
				{
					this.OnuserPasswordChanging(value);
					this.SendPropertyChanging();
					this._userPassword = value;
					this.SendPropertyChanged("userPassword");
					this.OnuserPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_repairAdmin", Storage="_repairAdmin", ThisKey="userId", OtherKey="userId")]
		public EntitySet<repairAdmin> repairAdmin
		{
			get
			{
				return this._repairAdmin;
			}
			set
			{
				this._repairAdmin.Assign(value);
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
		
		private void attach_repairAdmin(repairAdmin entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_repairAdmin(repairAdmin entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.repairAdmin")]
	public partial class repairAdmin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _repairId;
		
		private int _userId;
		
		private string _repperName;
		
		private string _repairType;
		
		private System.DateTime _repairedDate;
		
		private System.DateTime _repairingDate;
		
		private string _repperPhone;
		
		private bool _isAccept;
		
		private bool _isSolve;
		
		private string _evaluateText;
		
		private EntityRef<user> _user;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnrepairIdChanging(int value);
    partial void OnrepairIdChanged();
    partial void OnuserIdChanging(int value);
    partial void OnuserIdChanged();
    partial void OnrepperNameChanging(string value);
    partial void OnrepperNameChanged();
    partial void OnrepairTypeChanging(string value);
    partial void OnrepairTypeChanged();
    partial void OnrepairedDateChanging(System.DateTime value);
    partial void OnrepairedDateChanged();
    partial void OnrepairingDateChanging(System.DateTime value);
    partial void OnrepairingDateChanged();
    partial void OnrepperPhoneChanging(string value);
    partial void OnrepperPhoneChanged();
    partial void OnisAcceptChanging(bool value);
    partial void OnisAcceptChanged();
    partial void OnisSolveChanging(bool value);
    partial void OnisSolveChanged();
    partial void OnevaluateTextChanging(string value);
    partial void OnevaluateTextChanged();
    #endregion
		
		public repairAdmin()
		{
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_repairId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int repairId
		{
			get
			{
				return this._repairId;
			}
			set
			{
				if ((this._repairId != value))
				{
					this.OnrepairIdChanging(value);
					this.SendPropertyChanging();
					this._repairId = value;
					this.SendPropertyChanged("repairId");
					this.OnrepairIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="Int NOT NULL")]
		public int userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_repperName", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string repperName
		{
			get
			{
				return this._repperName;
			}
			set
			{
				if ((this._repperName != value))
				{
					this.OnrepperNameChanging(value);
					this.SendPropertyChanging();
					this._repperName = value;
					this.SendPropertyChanged("repperName");
					this.OnrepperNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_repairType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string repairType
		{
			get
			{
				return this._repairType;
			}
			set
			{
				if ((this._repairType != value))
				{
					this.OnrepairTypeChanging(value);
					this.SendPropertyChanging();
					this._repairType = value;
					this.SendPropertyChanged("repairType");
					this.OnrepairTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_repairedDate", DbType="DateTime NOT NULL")]
		public System.DateTime repairedDate
		{
			get
			{
				return this._repairedDate;
			}
			set
			{
				if ((this._repairedDate != value))
				{
					this.OnrepairedDateChanging(value);
					this.SendPropertyChanging();
					this._repairedDate = value;
					this.SendPropertyChanged("repairedDate");
					this.OnrepairedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_repairingDate", DbType="DateTime NOT NULL")]
		public System.DateTime repairingDate
		{
			get
			{
				return this._repairingDate;
			}
			set
			{
				if ((this._repairingDate != value))
				{
					this.OnrepairingDateChanging(value);
					this.SendPropertyChanging();
					this._repairingDate = value;
					this.SendPropertyChanged("repairingDate");
					this.OnrepairingDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_repperPhone", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string repperPhone
		{
			get
			{
				return this._repperPhone;
			}
			set
			{
				if ((this._repperPhone != value))
				{
					this.OnrepperPhoneChanging(value);
					this.SendPropertyChanging();
					this._repperPhone = value;
					this.SendPropertyChanged("repperPhone");
					this.OnrepperPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAccept", DbType="Bit NOT NULL")]
		public bool isAccept
		{
			get
			{
				return this._isAccept;
			}
			set
			{
				if ((this._isAccept != value))
				{
					this.OnisAcceptChanging(value);
					this.SendPropertyChanging();
					this._isAccept = value;
					this.SendPropertyChanged("isAccept");
					this.OnisAcceptChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isSolve", DbType="Bit NOT NULL")]
		public bool isSolve
		{
			get
			{
				return this._isSolve;
			}
			set
			{
				if ((this._isSolve != value))
				{
					this.OnisSolveChanging(value);
					this.SendPropertyChanging();
					this._isSolve = value;
					this.SendPropertyChanged("isSolve");
					this.OnisSolveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_evaluateText", DbType="VarChar(MAX)")]
		public string evaluateText
		{
			get
			{
				return this._evaluateText;
			}
			set
			{
				if ((this._evaluateText != value))
				{
					this.OnevaluateTextChanging(value);
					this.SendPropertyChanging();
					this._evaluateText = value;
					this.SendPropertyChanged("evaluateText");
					this.OnevaluateTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_repairAdmin", Storage="_user", ThisKey="userId", OtherKey="userId", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.repairAdmin.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.repairAdmin.Add(this);
						this._userId = value.userId;
					}
					else
					{
						this._userId = default(int);
					}
					this.SendPropertyChanged("user");
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
