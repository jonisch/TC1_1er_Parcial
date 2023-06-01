using DAL.Contracts;
using Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{

	public sealed class Factory
	{
		private readonly static Factory _instance = new Factory();

		private string Backend;

		public static Factory Current
		{
			get
			{
				return _instance;
			}
		}

		private Factory()
		{
			//Implent here the initialization of your singleton
			Backend = ConfigurationManager.AppSettings["Backend"];
		}

		//public IGenericRepository<Sale> GetSaleRepository()
		//{
		//	if (Backend == "Memory")
		//	{
		//		return new Repositories.Memory.SaleRepository();
		//	}
		//	else
		//	{
		//		return new Repositories.SQL.SaleRepository();
		//	}
		//}
	}

}
