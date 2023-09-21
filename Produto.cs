using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCRUD
{
    public class Produto
    {
        private string _nome;

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		private int _id;

		public int Id
		{
			get { return _id; }
			set
			{
				if (value >= 0)
				{
					_id = value;
				}
				else { _id = 0; }
			}
		}

        



    }
}
