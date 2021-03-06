﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cadastro.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BANCODAMINHAAPLICACAO")]
	public partial class CadastroDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    #endregion
		
		public CadastroDataClassesDataContext() : 
				base(global::Cadastro.DataAccess.Properties.Settings.Default.BANCODAMINHAAPLICACAOConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CadastroDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CadastroDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CadastroDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CadastroDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cliente> Clientes
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _CPF;
		
		private System.DateTime _Nascimento;
		
		private bool _Ativo;
		
		private string _Nome;
		
		private string _Logradouro;
		
		private string _Bairro;
		
		private string _Cidade;
		
		private string _UF;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnCPFChanging(string value);
    partial void OnCPFChanged();
    partial void OnNascimentoChanging(System.DateTime value);
    partial void OnNascimentoChanged();
    partial void OnAtivoChanging(bool value);
    partial void OnAtivoChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnLogradouroChanging(string value);
    partial void OnLogradouroChanged();
    partial void OnBairroChanging(string value);
    partial void OnBairroChanged();
    partial void OnCidadeChanging(string value);
    partial void OnCidadeChanged();
    partial void OnUFChanging(string value);
    partial void OnUFChanged();
    #endregion
		
		public Cliente()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPF", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string CPF
		{
			get
			{
				return this._CPF;
			}
			set
			{
				if ((this._CPF != value))
				{
					this.OnCPFChanging(value);
					this.SendPropertyChanging();
					this._CPF = value;
					this.SendPropertyChanged("CPF");
					this.OnCPFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nascimento", DbType="DateTime NOT NULL")]
		public System.DateTime Nascimento
		{
			get
			{
				return this._Nascimento;
			}
			set
			{
				if ((this._Nascimento != value))
				{
					this.OnNascimentoChanging(value);
					this.SendPropertyChanging();
					this._Nascimento = value;
					this.SendPropertyChanged("Nascimento");
					this.OnNascimentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ativo", DbType="Bit NOT NULL")]
		public bool Ativo
		{
			get
			{
				return this._Ativo;
			}
			set
			{
				if ((this._Ativo != value))
				{
					this.OnAtivoChanging(value);
					this.SendPropertyChanging();
					this._Ativo = value;
					this.SendPropertyChanged("Ativo");
					this.OnAtivoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logradouro", DbType="VarChar(100)")]
		public string Logradouro
		{
			get
			{
				return this._Logradouro;
			}
			set
			{
				if ((this._Logradouro != value))
				{
					this.OnLogradouroChanging(value);
					this.SendPropertyChanging();
					this._Logradouro = value;
					this.SendPropertyChanged("Logradouro");
					this.OnLogradouroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bairro", DbType="VarChar(50)")]
		public string Bairro
		{
			get
			{
				return this._Bairro;
			}
			set
			{
				if ((this._Bairro != value))
				{
					this.OnBairroChanging(value);
					this.SendPropertyChanging();
					this._Bairro = value;
					this.SendPropertyChanged("Bairro");
					this.OnBairroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cidade", DbType="VarChar(50)")]
		public string Cidade
		{
			get
			{
				return this._Cidade;
			}
			set
			{
				if ((this._Cidade != value))
				{
					this.OnCidadeChanging(value);
					this.SendPropertyChanging();
					this._Cidade = value;
					this.SendPropertyChanged("Cidade");
					this.OnCidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UF", DbType="VarChar(2)")]
		public string UF
		{
			get
			{
				return this._UF;
			}
			set
			{
				if ((this._UF != value))
				{
					this.OnUFChanging(value);
					this.SendPropertyChanging();
					this._UF = value;
					this.SendPropertyChanged("UF");
					this.OnUFChanged();
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
