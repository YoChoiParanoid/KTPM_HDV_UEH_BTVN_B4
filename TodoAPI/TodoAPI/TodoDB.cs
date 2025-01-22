namespace TodoAPI
{
	using Microsoft.EntityFrameworkCore;
	using TodoAPI.model;

	class TodoDB : DbContext
	{
		public TodoDB(DbContextOptions<TodoDB> options)
			: base(options) { }

		public DbSet<Todo> Todos => Set<Todo>();
	}
}
