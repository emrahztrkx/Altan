using Altan.Application.Contract.Dtos;

namespace Altan.Application.Contract.Organizations.Dto
{
    public class ChangeStatusInput : BaseEntityDto
    {
        public bool IsActive { get; set; }
    }
}