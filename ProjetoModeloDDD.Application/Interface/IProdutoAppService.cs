using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IProdutoAppService : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
