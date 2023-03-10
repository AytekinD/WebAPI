using StackExchange.Redis;

namespace Northwind_WebAPI.Models
{
	public class RedisManager
	{
		ConnectionMultiplexer connectionMultiplexer;
		public void Connect()
		{
			connectionMultiplexer = ConnectionMultiplexer.Connect("localhost:6379");
		}
		public IDatabase GetDb(int db)
		{
			return connectionMultiplexer.GetDatabase(db);
		}
	}
}
