using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Model;
using Todo.UI.Data;

namespace Todo.UI.ViewModel
{
	public class MainViewModel:INotifyPropertyChanged
	{
		private ITodoDataService dataService;
		private IEnumerable<Model.Todo> todos;

		public MainViewModel(ITodoDataService dataService)
		{
			this.dataService = dataService;
		}

		public IEnumerable<Model.Todo> Todos { get { return todos; } }

		public Model.Todo SelectedTodo { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public void Load()
		{
			todos = dataService.GetAll();
		}

	}
}
