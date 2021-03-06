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

namespace TesteLINQ.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FlowBox_Connect")]
	public partial class TesteLINQDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertProduto(Produto instance);
    partial void UpdateProduto(Produto instance);
    partial void DeleteProduto(Produto instance);
    #endregion
		
		public TesteLINQDataClassesDataContext() : 
				base(global::TesteLINQ.DataAccess.Properties.Settings.Default.FlowBox_ConnectConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TesteLINQDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TesteLINQDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TesteLINQDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TesteLINQDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categoria> Categorias
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Produto> Produtos
		{
			get
			{
				return this.GetTable<Produto>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categorias")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _id_categoria;
		
		private string _categoria1;
		
		private EntitySet<Produto> _Produtos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_categoriaChanging(byte value);
    partial void Onid_categoriaChanged();
    partial void Oncategoria1Changing(string value);
    partial void Oncategoria1Changed();
    #endregion
		
		public Categoria()
		{
			this._Produtos = new EntitySet<Produto>(new Action<Produto>(this.attach_Produtos), new Action<Produto>(this.detach_Produtos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_categoria", AutoSync=AutoSync.OnInsert, DbType="TinyInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public byte id_categoria
		{
			get
			{
				return this._id_categoria;
			}
			set
			{
				if ((this._id_categoria != value))
				{
					this.Onid_categoriaChanging(value);
					this.SendPropertyChanging();
					this._id_categoria = value;
					this.SendPropertyChanged("id_categoria");
					this.Onid_categoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="categoria", Storage="_categoria1", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string categoria1
		{
			get
			{
				return this._categoria1;
			}
			set
			{
				if ((this._categoria1 != value))
				{
					this.Oncategoria1Changing(value);
					this.SendPropertyChanging();
					this._categoria1 = value;
					this.SendPropertyChanged("categoria1");
					this.Oncategoria1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Produto", Storage="_Produtos", ThisKey="id_categoria", OtherKey="categoria")]
		public EntitySet<Produto> Produtos
		{
			get
			{
				return this._Produtos;
			}
			set
			{
				this._Produtos.Assign(value);
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
		
		private void attach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria1 = this;
		}
		
		private void detach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Produtos")]
	public partial class Produto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _codigoBarras;
		
		private string _nome;
		
		private string _fabricante;
		
		private byte _categoria;
		
		private decimal _valor;
		
		private decimal _peso;
		
		private int _quantidade;
		
		private EntityRef<Categoria> _Categoria1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodigoBarrasChanging(int value);
    partial void OncodigoBarrasChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnfabricanteChanging(string value);
    partial void OnfabricanteChanged();
    partial void OncategoriaChanging(byte value);
    partial void OncategoriaChanged();
    partial void OnvalorChanging(decimal value);
    partial void OnvalorChanged();
    partial void OnpesoChanging(decimal value);
    partial void OnpesoChanged();
    partial void OnquantidadeChanging(int value);
    partial void OnquantidadeChanged();
    #endregion
		
		public Produto()
		{
			this._Categoria1 = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigoBarras", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int codigoBarras
		{
			get
			{
				return this._codigoBarras;
			}
			set
			{
				if ((this._codigoBarras != value))
				{
					this.OncodigoBarrasChanging(value);
					this.SendPropertyChanging();
					this._codigoBarras = value;
					this.SendPropertyChanged("codigoBarras");
					this.OncodigoBarrasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(70) NOT NULL", CanBeNull=false)]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fabricante", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fabricante
		{
			get
			{
				return this._fabricante;
			}
			set
			{
				if ((this._fabricante != value))
				{
					this.OnfabricanteChanging(value);
					this.SendPropertyChanging();
					this._fabricante = value;
					this.SendPropertyChanged("fabricante");
					this.OnfabricanteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoria", DbType="TinyInt NOT NULL")]
		public byte categoria
		{
			get
			{
				return this._categoria;
			}
			set
			{
				if ((this._categoria != value))
				{
					if (this._Categoria1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncategoriaChanging(value);
					this.SendPropertyChanging();
					this._categoria = value;
					this.SendPropertyChanged("categoria");
					this.OncategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor", DbType="Decimal(16,2) NOT NULL")]
		public decimal valor
		{
			get
			{
				return this._valor;
			}
			set
			{
				if ((this._valor != value))
				{
					this.OnvalorChanging(value);
					this.SendPropertyChanging();
					this._valor = value;
					this.SendPropertyChanged("valor");
					this.OnvalorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_peso", DbType="Decimal(11,3) NOT NULL")]
		public decimal peso
		{
			get
			{
				return this._peso;
			}
			set
			{
				if ((this._peso != value))
				{
					this.OnpesoChanging(value);
					this.SendPropertyChanging();
					this._peso = value;
					this.SendPropertyChanged("peso");
					this.OnpesoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantidade", DbType="Int NOT NULL")]
		public int quantidade
		{
			get
			{
				return this._quantidade;
			}
			set
			{
				if ((this._quantidade != value))
				{
					this.OnquantidadeChanging(value);
					this.SendPropertyChanging();
					this._quantidade = value;
					this.SendPropertyChanged("quantidade");
					this.OnquantidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Produto", Storage="_Categoria1", ThisKey="categoria", OtherKey="id_categoria", IsForeignKey=true)]
		public Categoria Categoria1
		{
			get
			{
				return this._Categoria1.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria1.Entity;
				if (((previousValue != value) 
							|| (this._Categoria1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria1.Entity = null;
						previousValue.Produtos.Remove(this);
					}
					this._Categoria1.Entity = value;
					if ((value != null))
					{
						value.Produtos.Add(this);
						this._categoria = value.id_categoria;
					}
					else
					{
						this._categoria = default(byte);
					}
					this.SendPropertyChanged("Categoria1");
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
