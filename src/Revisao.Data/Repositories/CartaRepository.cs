using Newtonsoft.Json;
using Revisao.Domain.ViewModels;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using Revisao.Data.Providers.MongoDB.Interfaces;
using AutoMapper;
using Revisao.Data.Providers.MongoDB.Collections;
=======
>>>>>>> 3c4a218d8bf1dcfb436e4e12daa51730a8a0a0a0

namespace Revisao.Data.Repositories
{
    public class CartaRepository : ICartaRepository
    {
<<<<<<< HEAD
        private readonly IMongoRepository<DocumentoCartaCollection> _cartaRepository;
        private readonly IMapper _mapper;

        public CartaRepository(IMongoRepository<DocumentoCartaCollection> cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }

        public async Task Adicionar(DocumentosCarta documentosCarta)
        {
            await _cartaRepository.InsertOneAsync(_mapper.Map<DocumentoCartaCollection>(documentosCarta));
=======
        private readonly string _CartaCaminhoArquivo;


        public CartaRepository()
        {
            _CartaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "carta.json");
        }

        public void Adicionar(DocumentosCarta documentosCarta)
        {
            var cartas = LerCartaDoArquivo();
            cartas.Add(documentosCarta);
            EscreverCartaNoArquivo(cartas);
>>>>>>> 3c4a218d8bf1dcfb436e4e12daa51730a8a0a0a0
        }


        public IEnumerable<DocumentosCarta> ObterTodos()
        {
<<<<<<< HEAD
            var categoriaList = _cartaRepository.FilterBy(filter => true);
            return _mapper.Map<IEnumerable<DocumentosCarta>>(categoriaList);
        }

        //private List<DocumentosCarta> LerCartaDoArquivo()
        //{
        //    if (!System.IO.File.Exists(_CartaCaminhoArquivo))
        //        return new List<DocumentosCarta>();
        //    string json = System.IO.File.ReadAllText(_CartaCaminhoArquivo);
        //    return JsonConvert.DeserializeObject<List<DocumentosCarta>>(json);
        //}

        //private void EscreverCartaNoArquivo(List<DocumentosCarta> documentosCarta)
        //{
        //    string json = JsonConvert.SerializeObject(documentosCarta);
        //    System.IO.File.WriteAllText(_CartaCaminhoArquivo, json);
        //}
=======
            return LerCartaDoArquivo();
        }

        private List<DocumentosCarta> LerCartaDoArquivo()
        {
            if (!System.IO.File.Exists(_CartaCaminhoArquivo))
                return new List<DocumentosCarta>();
            string json = System.IO.File.ReadAllText(_CartaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<DocumentosCarta>>(json);
        }

        private void EscreverCartaNoArquivo(List<DocumentosCarta> documentosCarta)
        {
            string json = JsonConvert.SerializeObject(documentosCarta);
            System.IO.File.WriteAllText(_CartaCaminhoArquivo, json);
        }
>>>>>>> 3c4a218d8bf1dcfb436e4e12daa51730a8a0a0a0
    }
}
