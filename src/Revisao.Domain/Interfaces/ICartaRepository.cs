using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface ICartaRepository
    {
        IEnumerable<DocumentosCarta> ObterTodos();

        Task Adicionar(DocumentosCarta documentosCarta);
    }
}
