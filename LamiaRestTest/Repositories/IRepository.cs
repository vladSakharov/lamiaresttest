using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.ExternalData;
using LamiaRestTest.Repositories;

namespace LamiaRestTest
{
	public interface IRepository<T, T2, T3> where T2 : IDataSource<T,T3> where T3 : IDataRequest<T>
	{
		Task<T> Get(T3 request);
	}
}
