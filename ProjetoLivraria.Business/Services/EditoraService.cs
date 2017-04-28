using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Business.Interfaces.Repository;
using ProjetoLivraria.Business.Interfaces.Services;

namespace ProjetoLivraria.Business.Services
{
    public class EditoraService : ServiceBase<Editora>, IEditoraService
    {
        private readonly IEditoraRepository _editoraRepository;
        public EditoraService(IEditoraRepository editoraRepository) :
            base(editoraRepository)
        {
            _editoraRepository = editoraRepository;
        }
    }
}
