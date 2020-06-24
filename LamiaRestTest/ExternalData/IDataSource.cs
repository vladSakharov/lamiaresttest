using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.Repositories;

namespace LamiaRestTest.ExternalData
{
	public interface IDataSource<T, T2> where T2: IDataRequest<T>
	{
		Task<T> Get(T2 request);
	}
}
