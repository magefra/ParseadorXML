using FluentValidation;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Service.src.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ParseadorXML.Service.src.Validators
{
    public class ComprobanteValidator : AbstractValidator<ComprobanteDTO>
    {
        public ComprobanteValidator()
        {
            RuleFor(c => c.UUID).NotEmpty().WithMessage("El UUID no debé estar vació").MinimumLength(36).MaximumLength(36).WithMessage("El UUID no deberá ser mayor a 36");
            RuleFor(c => c.Version).NotEmpty().WithMessage("La versión no debé estar vació");


        }
    }
}
