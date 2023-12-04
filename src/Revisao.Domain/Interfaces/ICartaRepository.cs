using Revisao.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface ICartaRepository
    {
<<<<<<< HEAD
        public IEnumerable<DocumentosCarta> ObterTodos();

        Task Adicionar(DocumentosCarta documentosCarta);
=======
        IEnumerable<DocumentosCarta> ObterTodos();

        void Adicionar(DocumentosCarta documentosCarta);
>>>>>>> 3c4a218d8bf1dcfb436e4e12daa51730a8a0a0a0
    }
}
