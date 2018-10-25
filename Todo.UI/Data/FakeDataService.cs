using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.UI.Data
{
	public class FakeDataService : ITodoDataService
	{

		public IEnumerable<Model.Todo> GetAll()
		{
			return new List<Model.Todo>()
			{
				 new Model.Todo() {
					 Title ="Handla",
					 Description ="köpa mjölk"
				 },
				 new Model.Todo() {
					 Title ="Plugga",
					 Description ="jobba med PluralSight-kursen"
				 }
			};
		}
	}
}
