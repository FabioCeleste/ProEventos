using System.Threading.Tasks;
using ProEventos.Application.Dtos;

namespace ProEventos.Application.Contratos
{
    public interface IEventoServices
    {
         Task<EventoDto> AddEventos(EventoDto model);
         Task<EventoDto> UpdateEvento(int eventoId, EventoDto model);
         Task<bool> DeleteEventos(int eventoId);

         Task<EventoDto[]> GetAllEventosAsync(bool includePalestrantes = false);
         Task<EventoDto[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
         Task<EventoDto> GetEventoByIdAsync(int EventoId, bool includePalestrantes = false);
    }
}