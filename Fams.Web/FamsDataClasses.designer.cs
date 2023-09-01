﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fams.Web
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="Fams")]
	public partial class FamsDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertfls_COMPANY_INFO(fls_COMPANY_INFO instance);
    partial void Updatefls_COMPANY_INFO(fls_COMPANY_INFO instance);
    partial void Deletefls_COMPANY_INFO(fls_COMPANY_INFO instance);
    partial void Insertfls_LICENCE_INFO(fls_LICENCE_INFO instance);
    partial void Updatefls_LICENCE_INFO(fls_LICENCE_INFO instance);
    partial void Deletefls_LICENCE_INFO(fls_LICENCE_INFO instance);
    partial void InsertFams_Freq(Fams_Freq instance);
    partial void UpdateFams_Freq(Fams_Freq instance);
    partial void DeleteFams_Freq(Fams_Freq instance);
    partial void InsertCOMBO_Portable(COMBO_Portable instance);
    partial void UpdateCOMBO_Portable(COMBO_Portable instance);
    partial void DeleteCOMBO_Portable(COMBO_Portable instance);
    #endregion
		
		public FamsDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["FamsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public FamsDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FamsDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FamsDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FamsDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<fls_COMPANY_INFO> fls_COMPANY_INFOs
		{
			get
			{
				return this.GetTable<fls_COMPANY_INFO>();
			}
		}
		
		public System.Data.Linq.Table<fls_LICENCE_INFO> fls_LICENCE_INFOs
		{
			get
			{
				return this.GetTable<fls_LICENCE_INFO>();
			}
		}
		
		public System.Data.Linq.Table<Fams_Freq> Fams_Freqs
		{
			get
			{
				return this.GetTable<Fams_Freq>();
			}
		}
		
		public System.Data.Linq.Table<COMBO_Portable> COMBO_Portables
		{
			get
			{
				return this.GetTable<COMBO_Portable>();
			}
		}
	}
	
	[Table(Name="dbo.fls_COMPANY_INFO")]
	public partial class fls_COMPANY_INFO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _tax_id;
		
		private short _Comp_Account;
		
		private string _Comp_Name;
		
		private string _Comp_Address;
		
		private string _Comp_City;
		
		private string _Comp_Index;
		
		private string _Comp_Tel;
		
		private string _Comp_Fax;
		
		private string _Comp_Cont_Address;
		
		private string _Comp_Cont_city;
		
		private string _Comp_Cont_index;
		
		private string _Comp_Cont_tel;
		
		private string _Comp_Cont_fax;
		
		private string _Comp_URL;
		
		private string _Comp_Mail;
		
		private string _CONTACT_NAME;
		
		private string _Comp_Chief;
		
		private string _Chief_Position;
		
		private System.Nullable<System.DateTime> _SENT;
		
		private System.Nullable<System.DateTime> _gave;
		
		private bool _HAS_NO_FREQ;
		
		private bool _REC_Form1;
		
		private System.Nullable<System.DateTime> _Received;
		
		private string _remark;
		
		private EntitySet<fls_LICENCE_INFO> _fls_LICENCE_INFOs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Ontax_idChanging(string value);
    partial void Ontax_idChanged();
    partial void OnComp_AccountChanging(short value);
    partial void OnComp_AccountChanged();
    partial void OnComp_NameChanging(string value);
    partial void OnComp_NameChanged();
    partial void OnComp_AddressChanging(string value);
    partial void OnComp_AddressChanged();
    partial void OnComp_CityChanging(string value);
    partial void OnComp_CityChanged();
    partial void OnComp_IndexChanging(string value);
    partial void OnComp_IndexChanged();
    partial void OnComp_TelChanging(string value);
    partial void OnComp_TelChanged();
    partial void OnComp_FaxChanging(string value);
    partial void OnComp_FaxChanged();
    partial void OnComp_Cont_AddressChanging(string value);
    partial void OnComp_Cont_AddressChanged();
    partial void OnComp_Cont_cityChanging(string value);
    partial void OnComp_Cont_cityChanged();
    partial void OnComp_Cont_indexChanging(string value);
    partial void OnComp_Cont_indexChanged();
    partial void OnComp_Cont_telChanging(string value);
    partial void OnComp_Cont_telChanged();
    partial void OnComp_Cont_faxChanging(string value);
    partial void OnComp_Cont_faxChanged();
    partial void OnComp_URLChanging(string value);
    partial void OnComp_URLChanged();
    partial void OnComp_MailChanging(string value);
    partial void OnComp_MailChanged();
    partial void OnCONTACT_NAMEChanging(string value);
    partial void OnCONTACT_NAMEChanged();
    partial void OnComp_ChiefChanging(string value);
    partial void OnComp_ChiefChanged();
    partial void OnChief_PositionChanging(string value);
    partial void OnChief_PositionChanged();
    partial void OnSENTChanging(System.Nullable<System.DateTime> value);
    partial void OnSENTChanged();
    partial void OngaveChanging(System.Nullable<System.DateTime> value);
    partial void OngaveChanged();
    partial void OnHAS_NO_FREQChanging(bool value);
    partial void OnHAS_NO_FREQChanged();
    partial void OnREC_Form1Changing(bool value);
    partial void OnREC_Form1Changed();
    partial void OnReceivedChanging(System.Nullable<System.DateTime> value);
    partial void OnReceivedChanged();
    partial void OnremarkChanging(string value);
    partial void OnremarkChanged();
    #endregion
		
		public fls_COMPANY_INFO()
		{
			this._fls_LICENCE_INFOs = new EntitySet<fls_LICENCE_INFO>(new Action<fls_LICENCE_INFO>(this.attach_fls_LICENCE_INFOs), new Action<fls_LICENCE_INFO>(this.detach_fls_LICENCE_INFOs));
			OnCreated();
		}
		
		[Column(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[Column(Storage="_tax_id", DbType="NVarChar(30)")]
		public string tax_id
		{
			get
			{
				return this._tax_id;
			}
			set
			{
				if ((this._tax_id != value))
				{
					this.Ontax_idChanging(value);
					this.SendPropertyChanging();
					this._tax_id = value;
					this.SendPropertyChanged("tax_id");
					this.Ontax_idChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Account", DbType="SmallInt NOT NULL")]
		public short Comp_Account
		{
			get
			{
				return this._Comp_Account;
			}
			set
			{
				if ((this._Comp_Account != value))
				{
					this.OnComp_AccountChanging(value);
					this.SendPropertyChanging();
					this._Comp_Account = value;
					this.SendPropertyChanged("Comp_Account");
					this.OnComp_AccountChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Name", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string Comp_Name
		{
			get
			{
				return this._Comp_Name;
			}
			set
			{
				if ((this._Comp_Name != value))
				{
					this.OnComp_NameChanging(value);
					this.SendPropertyChanging();
					this._Comp_Name = value;
					this.SendPropertyChanged("Comp_Name");
					this.OnComp_NameChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Address", DbType="NVarChar(250)")]
		public string Comp_Address
		{
			get
			{
				return this._Comp_Address;
			}
			set
			{
				if ((this._Comp_Address != value))
				{
					this.OnComp_AddressChanging(value);
					this.SendPropertyChanging();
					this._Comp_Address = value;
					this.SendPropertyChanged("Comp_Address");
					this.OnComp_AddressChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_City", DbType="NVarChar(50)")]
		public string Comp_City
		{
			get
			{
				return this._Comp_City;
			}
			set
			{
				if ((this._Comp_City != value))
				{
					this.OnComp_CityChanging(value);
					this.SendPropertyChanging();
					this._Comp_City = value;
					this.SendPropertyChanged("Comp_City");
					this.OnComp_CityChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Index", DbType="VarChar(10)")]
		public string Comp_Index
		{
			get
			{
				return this._Comp_Index;
			}
			set
			{
				if ((this._Comp_Index != value))
				{
					this.OnComp_IndexChanging(value);
					this.SendPropertyChanging();
					this._Comp_Index = value;
					this.SendPropertyChanged("Comp_Index");
					this.OnComp_IndexChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Tel", DbType="VarChar(25)")]
		public string Comp_Tel
		{
			get
			{
				return this._Comp_Tel;
			}
			set
			{
				if ((this._Comp_Tel != value))
				{
					this.OnComp_TelChanging(value);
					this.SendPropertyChanging();
					this._Comp_Tel = value;
					this.SendPropertyChanged("Comp_Tel");
					this.OnComp_TelChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Fax", DbType="VarChar(25)")]
		public string Comp_Fax
		{
			get
			{
				return this._Comp_Fax;
			}
			set
			{
				if ((this._Comp_Fax != value))
				{
					this.OnComp_FaxChanging(value);
					this.SendPropertyChanging();
					this._Comp_Fax = value;
					this.SendPropertyChanged("Comp_Fax");
					this.OnComp_FaxChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Cont_Address", DbType="NVarChar(250)")]
		public string Comp_Cont_Address
		{
			get
			{
				return this._Comp_Cont_Address;
			}
			set
			{
				if ((this._Comp_Cont_Address != value))
				{
					this.OnComp_Cont_AddressChanging(value);
					this.SendPropertyChanging();
					this._Comp_Cont_Address = value;
					this.SendPropertyChanged("Comp_Cont_Address");
					this.OnComp_Cont_AddressChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Cont_city", DbType="NVarChar(75)")]
		public string Comp_Cont_city
		{
			get
			{
				return this._Comp_Cont_city;
			}
			set
			{
				if ((this._Comp_Cont_city != value))
				{
					this.OnComp_Cont_cityChanging(value);
					this.SendPropertyChanging();
					this._Comp_Cont_city = value;
					this.SendPropertyChanged("Comp_Cont_city");
					this.OnComp_Cont_cityChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Cont_index", DbType="VarChar(10)")]
		public string Comp_Cont_index
		{
			get
			{
				return this._Comp_Cont_index;
			}
			set
			{
				if ((this._Comp_Cont_index != value))
				{
					this.OnComp_Cont_indexChanging(value);
					this.SendPropertyChanging();
					this._Comp_Cont_index = value;
					this.SendPropertyChanged("Comp_Cont_index");
					this.OnComp_Cont_indexChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Cont_tel", DbType="VarChar(25)")]
		public string Comp_Cont_tel
		{
			get
			{
				return this._Comp_Cont_tel;
			}
			set
			{
				if ((this._Comp_Cont_tel != value))
				{
					this.OnComp_Cont_telChanging(value);
					this.SendPropertyChanging();
					this._Comp_Cont_tel = value;
					this.SendPropertyChanged("Comp_Cont_tel");
					this.OnComp_Cont_telChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Cont_fax", DbType="VarChar(25)")]
		public string Comp_Cont_fax
		{
			get
			{
				return this._Comp_Cont_fax;
			}
			set
			{
				if ((this._Comp_Cont_fax != value))
				{
					this.OnComp_Cont_faxChanging(value);
					this.SendPropertyChanging();
					this._Comp_Cont_fax = value;
					this.SendPropertyChanged("Comp_Cont_fax");
					this.OnComp_Cont_faxChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_URL", DbType="VarChar(250)")]
		public string Comp_URL
		{
			get
			{
				return this._Comp_URL;
			}
			set
			{
				if ((this._Comp_URL != value))
				{
					this.OnComp_URLChanging(value);
					this.SendPropertyChanging();
					this._Comp_URL = value;
					this.SendPropertyChanged("Comp_URL");
					this.OnComp_URLChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Mail", DbType="VarChar(250)")]
		public string Comp_Mail
		{
			get
			{
				return this._Comp_Mail;
			}
			set
			{
				if ((this._Comp_Mail != value))
				{
					this.OnComp_MailChanging(value);
					this.SendPropertyChanging();
					this._Comp_Mail = value;
					this.SendPropertyChanged("Comp_Mail");
					this.OnComp_MailChanged();
				}
			}
		}
		
		[Column(Storage="_CONTACT_NAME", DbType="NVarChar(250)")]
		public string CONTACT_NAME
		{
			get
			{
				return this._CONTACT_NAME;
			}
			set
			{
				if ((this._CONTACT_NAME != value))
				{
					this.OnCONTACT_NAMEChanging(value);
					this.SendPropertyChanging();
					this._CONTACT_NAME = value;
					this.SendPropertyChanged("CONTACT_NAME");
					this.OnCONTACT_NAMEChanged();
				}
			}
		}
		
		[Column(Storage="_Comp_Chief", DbType="NVarChar(250)")]
		public string Comp_Chief
		{
			get
			{
				return this._Comp_Chief;
			}
			set
			{
				if ((this._Comp_Chief != value))
				{
					this.OnComp_ChiefChanging(value);
					this.SendPropertyChanging();
					this._Comp_Chief = value;
					this.SendPropertyChanged("Comp_Chief");
					this.OnComp_ChiefChanged();
				}
			}
		}
		
		[Column(Storage="_Chief_Position", DbType="NVarChar(250)")]
		public string Chief_Position
		{
			get
			{
				return this._Chief_Position;
			}
			set
			{
				if ((this._Chief_Position != value))
				{
					this.OnChief_PositionChanging(value);
					this.SendPropertyChanging();
					this._Chief_Position = value;
					this.SendPropertyChanged("Chief_Position");
					this.OnChief_PositionChanged();
				}
			}
		}
		
		[Column(Storage="_SENT", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> SENT
		{
			get
			{
				return this._SENT;
			}
			set
			{
				if ((this._SENT != value))
				{
					this.OnSENTChanging(value);
					this.SendPropertyChanging();
					this._SENT = value;
					this.SendPropertyChanged("SENT");
					this.OnSENTChanged();
				}
			}
		}
		
		[Column(Storage="_gave", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> gave
		{
			get
			{
				return this._gave;
			}
			set
			{
				if ((this._gave != value))
				{
					this.OngaveChanging(value);
					this.SendPropertyChanging();
					this._gave = value;
					this.SendPropertyChanged("gave");
					this.OngaveChanged();
				}
			}
		}
		
		[Column(Storage="_HAS_NO_FREQ", DbType="Bit NOT NULL")]
		public bool HAS_NO_FREQ
		{
			get
			{
				return this._HAS_NO_FREQ;
			}
			set
			{
				if ((this._HAS_NO_FREQ != value))
				{
					this.OnHAS_NO_FREQChanging(value);
					this.SendPropertyChanging();
					this._HAS_NO_FREQ = value;
					this.SendPropertyChanged("HAS_NO_FREQ");
					this.OnHAS_NO_FREQChanged();
				}
			}
		}
		
		[Column(Storage="_REC_Form1", DbType="Bit NOT NULL")]
		public bool REC_Form1
		{
			get
			{
				return this._REC_Form1;
			}
			set
			{
				if ((this._REC_Form1 != value))
				{
					this.OnREC_Form1Changing(value);
					this.SendPropertyChanging();
					this._REC_Form1 = value;
					this.SendPropertyChanged("REC_Form1");
					this.OnREC_Form1Changed();
				}
			}
		}
		
		[Column(Storage="_Received", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Received
		{
			get
			{
				return this._Received;
			}
			set
			{
				if ((this._Received != value))
				{
					this.OnReceivedChanging(value);
					this.SendPropertyChanging();
					this._Received = value;
					this.SendPropertyChanged("Received");
					this.OnReceivedChanged();
				}
			}
		}
		
		[Column(Storage="_remark", DbType="NVarChar(4000)")]
		public string remark
		{
			get
			{
				return this._remark;
			}
			set
			{
				if ((this._remark != value))
				{
					this.OnremarkChanging(value);
					this.SendPropertyChanging();
					this._remark = value;
					this.SendPropertyChanged("remark");
					this.OnremarkChanged();
				}
			}
		}
		
		[Association(Name="fls_COMPANY_INFO_fls_LICENCE_INFO", Storage="_fls_LICENCE_INFOs", ThisKey="id", OtherKey="comp_id")]
		public EntitySet<fls_LICENCE_INFO> fls_LICENCE_INFOs
		{
			get
			{
				return this._fls_LICENCE_INFOs;
			}
			set
			{
				this._fls_LICENCE_INFOs.Assign(value);
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
		
		private void attach_fls_LICENCE_INFOs(fls_LICENCE_INFO entity)
		{
			this.SendPropertyChanging();
			entity.fls_COMPANY_INFO = this;
		}
		
		private void detach_fls_LICENCE_INFOs(fls_LICENCE_INFO entity)
		{
			this.SendPropertyChanging();
			entity.fls_COMPANY_INFO = null;
		}
	}
	
	[Table(Name="dbo.fls_LICENCE_INFO")]
	public partial class fls_LICENCE_INFO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _LICENCE;
		
		private System.Nullable<System.DateTime> _LIC_ISSU_DATE;
		
		private System.Nullable<System.DateTime> _LIC_EXPIRY_DATE;
		
		private string _COMMENTS;
		
		private int _comp_id;
		
		private EntitySet<Fams_Freq> _Fams_Freqs;
		
		private EntityRef<fls_COMPANY_INFO> _fls_COMPANY_INFO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnLICENCEChanging(string value);
    partial void OnLICENCEChanged();
    partial void OnLIC_ISSU_DATEChanging(System.Nullable<System.DateTime> value);
    partial void OnLIC_ISSU_DATEChanged();
    partial void OnLIC_EXPIRY_DATEChanging(System.Nullable<System.DateTime> value);
    partial void OnLIC_EXPIRY_DATEChanged();
    partial void OnCOMMENTSChanging(string value);
    partial void OnCOMMENTSChanged();
    partial void Oncomp_idChanging(int value);
    partial void Oncomp_idChanged();
    #endregion
		
		public fls_LICENCE_INFO()
		{
			this._Fams_Freqs = new EntitySet<Fams_Freq>(new Action<Fams_Freq>(this.attach_Fams_Freqs), new Action<Fams_Freq>(this.detach_Fams_Freqs));
			this._fls_COMPANY_INFO = default(EntityRef<fls_COMPANY_INFO>);
			OnCreated();
		}
		
		[Column(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[Column(Storage="_LICENCE", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string LICENCE
		{
			get
			{
				return this._LICENCE;
			}
			set
			{
				if ((this._LICENCE != value))
				{
					this.OnLICENCEChanging(value);
					this.SendPropertyChanging();
					this._LICENCE = value;
					this.SendPropertyChanged("LICENCE");
					this.OnLICENCEChanged();
				}
			}
		}
		
		[Column(Storage="_LIC_ISSU_DATE", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> LIC_ISSU_DATE
		{
			get
			{
				return this._LIC_ISSU_DATE;
			}
			set
			{
				if ((this._LIC_ISSU_DATE != value))
				{
					this.OnLIC_ISSU_DATEChanging(value);
					this.SendPropertyChanging();
					this._LIC_ISSU_DATE = value;
					this.SendPropertyChanged("LIC_ISSU_DATE");
					this.OnLIC_ISSU_DATEChanged();
				}
			}
		}
		
		[Column(Storage="_LIC_EXPIRY_DATE", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> LIC_EXPIRY_DATE
		{
			get
			{
				return this._LIC_EXPIRY_DATE;
			}
			set
			{
				if ((this._LIC_EXPIRY_DATE != value))
				{
					this.OnLIC_EXPIRY_DATEChanging(value);
					this.SendPropertyChanging();
					this._LIC_EXPIRY_DATE = value;
					this.SendPropertyChanged("LIC_EXPIRY_DATE");
					this.OnLIC_EXPIRY_DATEChanged();
				}
			}
		}
		
		[Column(Storage="_COMMENTS", DbType="NVarChar(500)")]
		public string COMMENTS
		{
			get
			{
				return this._COMMENTS;
			}
			set
			{
				if ((this._COMMENTS != value))
				{
					this.OnCOMMENTSChanging(value);
					this.SendPropertyChanging();
					this._COMMENTS = value;
					this.SendPropertyChanged("COMMENTS");
					this.OnCOMMENTSChanged();
				}
			}
		}
		
		[Column(Storage="_comp_id", DbType="Int NOT NULL")]
		public int comp_id
		{
			get
			{
				return this._comp_id;
			}
			set
			{
				if ((this._comp_id != value))
				{
					if (this._fls_COMPANY_INFO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncomp_idChanging(value);
					this.SendPropertyChanging();
					this._comp_id = value;
					this.SendPropertyChanged("comp_id");
					this.Oncomp_idChanged();
				}
			}
		}
		
		[Association(Name="fls_LICENCE_INFO_Fams_Freq", Storage="_Fams_Freqs", ThisKey="id", OtherKey="licence_id")]
		public EntitySet<Fams_Freq> Fams_Freqs
		{
			get
			{
				return this._Fams_Freqs;
			}
			set
			{
				this._Fams_Freqs.Assign(value);
			}
		}
		
		[Association(Name="fls_COMPANY_INFO_fls_LICENCE_INFO", Storage="_fls_COMPANY_INFO", ThisKey="comp_id", OtherKey="id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public fls_COMPANY_INFO fls_COMPANY_INFO
		{
			get
			{
				return this._fls_COMPANY_INFO.Entity;
			}
			set
			{
				fls_COMPANY_INFO previousValue = this._fls_COMPANY_INFO.Entity;
				if (((previousValue != value) 
							|| (this._fls_COMPANY_INFO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._fls_COMPANY_INFO.Entity = null;
						previousValue.fls_LICENCE_INFOs.Remove(this);
					}
					this._fls_COMPANY_INFO.Entity = value;
					if ((value != null))
					{
						value.fls_LICENCE_INFOs.Add(this);
						this._comp_id = value.id;
					}
					else
					{
						this._comp_id = default(int);
					}
					this.SendPropertyChanged("fls_COMPANY_INFO");
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
		
		private void attach_Fams_Freqs(Fams_Freq entity)
		{
			this.SendPropertyChanging();
			entity.fls_LICENCE_INFO = this;
		}
		
		private void detach_Fams_Freqs(Fams_Freq entity)
		{
			this.SendPropertyChanging();
			entity.fls_LICENCE_INFO = null;
		}
	}
	
	[Table(Name="dbo.Fams_Freq")]
	public partial class Fams_Freq : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private long _freq;
		
		private int _BandWidth;
		
		private System.Nullable<int> _zone_city_id;
		
		private string _remark;
		
		private bool _reestrit;
		
		private int _licence_id;
		
		private EntityRef<fls_LICENCE_INFO> _fls_LICENCE_INFO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnfreqChanging(long value);
    partial void OnfreqChanged();
    partial void OnBandWidthChanging(int value);
    partial void OnBandWidthChanged();
    partial void Onzone_city_idChanging(System.Nullable<int> value);
    partial void Onzone_city_idChanged();
    partial void OnremarkChanging(string value);
    partial void OnremarkChanged();
    partial void OnreestritChanging(bool value);
    partial void OnreestritChanged();
    partial void Onlicence_idChanging(int value);
    partial void Onlicence_idChanged();
    #endregion
		
		public Fams_Freq()
		{
			this._fls_LICENCE_INFO = default(EntityRef<fls_LICENCE_INFO>);
			OnCreated();
		}
		
		[Column(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[Column(Storage="_freq", DbType="BigInt NOT NULL")]
		public long freq
		{
			get
			{
				return this._freq;
			}
			set
			{
				if ((this._freq != value))
				{
					this.OnfreqChanging(value);
					this.SendPropertyChanging();
					this._freq = value;
					this.SendPropertyChanged("freq");
					this.OnfreqChanged();
				}
			}
		}
		
		[Column(Storage="_BandWidth", DbType="Int NOT NULL")]
		public int BandWidth
		{
			get
			{
				return this._BandWidth;
			}
			set
			{
				if ((this._BandWidth != value))
				{
					this.OnBandWidthChanging(value);
					this.SendPropertyChanging();
					this._BandWidth = value;
					this.SendPropertyChanged("BandWidth");
					this.OnBandWidthChanged();
				}
			}
		}
		
		[Column(Storage="_zone_city_id", DbType="Int")]
		public System.Nullable<int> zone_city_id
		{
			get
			{
				return this._zone_city_id;
			}
			set
			{
				if ((this._zone_city_id != value))
				{
					this.Onzone_city_idChanging(value);
					this.SendPropertyChanging();
					this._zone_city_id = value;
					this.SendPropertyChanged("zone_city_id");
					this.Onzone_city_idChanged();
				}
			}
		}
		
		[Column(Storage="_remark", DbType="NVarChar(100)")]
		public string remark
		{
			get
			{
				return this._remark;
			}
			set
			{
				if ((this._remark != value))
				{
					this.OnremarkChanging(value);
					this.SendPropertyChanging();
					this._remark = value;
					this.SendPropertyChanged("remark");
					this.OnremarkChanged();
				}
			}
		}
		
		[Column(Storage="_reestrit", DbType="Bit NOT NULL")]
		public bool reestrit
		{
			get
			{
				return this._reestrit;
			}
			set
			{
				if ((this._reestrit != value))
				{
					this.OnreestritChanging(value);
					this.SendPropertyChanging();
					this._reestrit = value;
					this.SendPropertyChanged("reestrit");
					this.OnreestritChanged();
				}
			}
		}
		
		[Column(Storage="_licence_id", DbType="Int NOT NULL")]
		public int licence_id
		{
			get
			{
				return this._licence_id;
			}
			set
			{
				if ((this._licence_id != value))
				{
					if (this._fls_LICENCE_INFO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onlicence_idChanging(value);
					this.SendPropertyChanging();
					this._licence_id = value;
					this.SendPropertyChanged("licence_id");
					this.Onlicence_idChanged();
				}
			}
		}
		
		[Association(Name="fls_LICENCE_INFO_Fams_Freq", Storage="_fls_LICENCE_INFO", ThisKey="licence_id", OtherKey="id", IsForeignKey=true)]
		public fls_LICENCE_INFO fls_LICENCE_INFO
		{
			get
			{
				return this._fls_LICENCE_INFO.Entity;
			}
			set
			{
				fls_LICENCE_INFO previousValue = this._fls_LICENCE_INFO.Entity;
				if (((previousValue != value) 
							|| (this._fls_LICENCE_INFO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._fls_LICENCE_INFO.Entity = null;
						previousValue.Fams_Freqs.Remove(this);
					}
					this._fls_LICENCE_INFO.Entity = value;
					if ((value != null))
					{
						value.Fams_Freqs.Add(this);
						this._licence_id = value.id;
					}
					else
					{
						this._licence_id = default(int);
					}
					this.SendPropertyChanged("fls_LICENCE_INFO");
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
	
	[Table(Name="dbo.COMBO_Portable")]
	public partial class COMBO_Portable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Manufacturer;
		
		private string _Model;
		
		private System.Nullable<decimal> _PowerVHF;
		
		private System.Nullable<decimal> _PowerUHF;
		
		private System.Data.Linq.Binary _Image;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnManufacturerChanging(string value);
    partial void OnManufacturerChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnPowerVHFChanging(System.Nullable<decimal> value);
    partial void OnPowerVHFChanged();
    partial void OnPowerUHFChanging(System.Nullable<decimal> value);
    partial void OnPowerUHFChanged();
    partial void OnImageChanging(System.Data.Linq.Binary value);
    partial void OnImageChanged();
    #endregion
		
		public COMBO_Portable()
		{
			OnCreated();
		}
		
		[Column(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[Column(Storage="_Manufacturer", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Manufacturer
		{
			get
			{
				return this._Manufacturer;
			}
			set
			{
				if ((this._Manufacturer != value))
				{
					this.OnManufacturerChanging(value);
					this.SendPropertyChanging();
					this._Manufacturer = value;
					this.SendPropertyChanged("Manufacturer");
					this.OnManufacturerChanged();
				}
			}
		}
		
		[Column(Storage="_Model", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[Column(Storage="_PowerVHF", DbType="Decimal(5,1)")]
		public System.Nullable<decimal> PowerVHF
		{
			get
			{
				return this._PowerVHF;
			}
			set
			{
				if ((this._PowerVHF != value))
				{
					this.OnPowerVHFChanging(value);
					this.SendPropertyChanging();
					this._PowerVHF = value;
					this.SendPropertyChanged("PowerVHF");
					this.OnPowerVHFChanged();
				}
			}
		}
		
		[Column(Storage="_PowerUHF", DbType="Decimal(5,1)")]
		public System.Nullable<decimal> PowerUHF
		{
			get
			{
				return this._PowerUHF;
			}
			set
			{
				if ((this._PowerUHF != value))
				{
					this.OnPowerUHFChanging(value);
					this.SendPropertyChanging();
					this._PowerUHF = value;
					this.SendPropertyChanged("PowerUHF");
					this.OnPowerUHFChanged();
				}
			}
		}
		
		[Column(Storage="_Image", DbType="Image", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
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
