using AutoMapper;
using ParseadorXML.Domain.src.Interfaces.Repositories;
using ParseadorXML.Domain.src.Interfaces.Services;
using ParseadorXML.Domain.src.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Service.src.Services
{
    public class ReceptorService : IReceptorService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IReceptorRepository _receptorRepository;

        /// <summary>
        /// 
        /// </summary>
        private readonly IMapper _mapper;


        public ReceptorService(IReceptorRepository receptorRepository, IMapper mapper)
        {
            _receptorRepository = receptorRepository;
            _mapper = mapper;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Task Insert(ReceptorDTo obj)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<ReceptorDTo>> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
