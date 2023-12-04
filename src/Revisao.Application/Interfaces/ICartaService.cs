using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface ICartaService
    {
<<<<<<< HEAD
       public IEnumerable<CartaViewModel> ObterTodos();
       Task Adicionar(NovaCartaViewModel novaCartaViewModel);
=======
       IEnumerable<CartaViewModel> ObterTodos();
       public  void Adicionar(NovaCartaViewModel documentosCarta);
>>>>>>> 3c4a218d8bf1dcfb436e4e12daa51730a8a0a0a0

    }
}
