using CI.Domain.Entity;
using CI.Domain.Interfaces.Repository;
using CI.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CI.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario Adicionar(Usuario entity)
        {
            //Regras específicas são colocadas aqui
            return _usuarioRepository.Adicionar(entity);
        }

        public void Atualizar(Usuario entity)
        {
            _usuarioRepository.Atualizar(entity);
        }

        public IEnumerable<Usuario> Buscar(Expression<Func<Usuario, bool>> predicado)
        {
            return _usuarioRepository.Buscar(predicado);
        }

        public Usuario ObterPorId(int id)
        {
            return _usuarioRepository.ObterPorId(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return _usuarioRepository.ObterTodos();
        }

        public void Remover(Usuario entity)
        {
            _usuarioRepository.Remover(entity);
        }
    }
}
