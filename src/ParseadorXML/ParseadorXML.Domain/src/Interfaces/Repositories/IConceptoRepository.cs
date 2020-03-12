using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Interfaces.Repositories.Base.CRUD;

namespace ParseadorXML.Domain.src.Interfaces.Repositories.Base
{
    public interface IConceptoRepository : IInsertRepository<Concepto>,
                                           ISelectAllRepositoryAsync<Concepto>
    {
    }
}
