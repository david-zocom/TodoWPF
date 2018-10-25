using System.Collections.Generic;
using Todo.Model;

namespace Todo.UI.Data
{
	public interface ITodoDataService
	{
		IEnumerable<Model.Todo> GetAll();
	}
}