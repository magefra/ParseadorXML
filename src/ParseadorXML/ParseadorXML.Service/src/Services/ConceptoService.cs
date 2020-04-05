using AutoMapper;
using ParseadorXML.Domain.src.Interfaces.Repositories.Base;
using ParseadorXML.Domain.src.Interfaces.Services;
using ParseadorXML.Domain.src.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Service.src.Services
{
    public class ConceptoService : IConceptoService
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly IConceptoRepository _conceptoRepository;


        /// <summary>
        /// 
        /// </summary>
        private readonly IMapper _mapper;

        public ConceptoService(IConceptoRepository conceptoRepository, IMapper mapper)
        {
            _conceptoRepository = conceptoRepository;
            _mapper = mapper;
        }

        public Task Insert(ConceptoDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ConceptoDTO>> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
