using AutoMapper;
using ParseadorXML.Domain.src.Interfaces.Repositories;
using ParseadorXML.Domain.src.Interfaces.Services.Base;
using ParseadorXML.Domain.src.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Service.src.Services
{
    public class EmisorService : IEmisorService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IEmisorRepository _emisorRepository;


        /// <summary>
        /// 
        /// </summary>
        private readonly IMapper _mapper;

        public EmisorService(IEmisorRepository  emisorRepository, IMapper mapper)
        {
            _emisorRepository = emisorRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Task Insert(EmisorDTO obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<EmisorDTO>> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
