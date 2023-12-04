using AutoMapper;
using Revisao.Domain.ViewModels;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class CartaService : ICartaService
    {
        private readonly ICartaRepository _cartaRepository;
        private IMapper _mapper;

        public CartaService(ICartaRepository cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }

<<<<<<< HEAD
        public async Task Adicionar(NovaCartaViewModel novaCartaViewModel)
=======
        public void Adicionar(NovaCartaViewModel novaCartaViewModel)
>>>>>>> 3c4a218d8bf1dcfb436e4e12daa51730a8a0a0a0
        {
            var novaCarta = _mapper.Map<DocumentosCarta>(novaCartaViewModel);
            _cartaRepository.Adicionar(novaCarta);

        }

        public IEnumerable<CartaViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CartaViewModel>>(_cartaRepository.ObterTodos());
        }
    }
}
