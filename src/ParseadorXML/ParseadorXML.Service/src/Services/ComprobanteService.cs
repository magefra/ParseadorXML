using ParseadorXML.Domain.src.Interfaces.Repositories;
using ParseadorXML.Domain.src.Interfaces.Services;
using ParseadorXML.Domain.src.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Service.src.Services
{
    public class ComprobanteService : IComprobanteService
    {

        public ComprobanteService()
        {

        }


        public Task Insert(ComprobanteDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ComprobanteDTO> Select(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ComprobanteDTO>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(ComprobanteDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
